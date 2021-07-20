# vmcrack wu leak by ret, sry stackhound. <3 (I flagged myself but it's so fucking long to re-write everything, also I blur the flag, but you have the all steps to reproduce it, so here is the wu of the owner:)

-----------------

- We start off by executing the application to inspect the intended application input/output.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866691950353317908/pasted_image_0.png">

- It would seem that the application is a “find the correct credential” challenge, in which we have to somehow figure out the correct input. Let’s try opening it in OllyDbg to take a closer look.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866692170828218418/pasted_image_1.png">

- Interestingly, we receive this error message before OllyDbg is even able to assume control of the debuggee. This seems like it should not be possible, as OllyDbg breaks at the entry point, which should be the first point of execution in an application. However, on Windows, when using the Microsoft Visual C standard library with a non-statically built binary, we can register what is known as a “TLS callback” (short for Thread Local Storage callback). 

- Any registered TLS callback will be executed before the entry point, allowing us to perform anti-debugging checks before the debugger assumes control of our application. However, the application will have to export both the entry point and these TLS callbacks, with a specific naming convention, namely TlsCallback_x, where x denotes the callback index. This effectively means that when reading through the exports of the application in e.g. IDA, one should quickly realize that TLS callbacks are in use and start analyzing them.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866692334628241448/pasted_image_2.png">

- As we can see, they are all listed under the Export tab in IDA. Let’s take a look at index 0.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866692556480577556/pasted_image_3.png">

- By reading through the first TLS callback, we realize that:

   - The application must execute as a 32-bit application (the binary is 32-bit afterall)
   - The application must execute under SysWOW64 (the host OS must be 64-bit)

- These are clues we can use for later, but are not the cause of our pre-entrypoint termination. Let’s progress and check out the next index in the TLS chain.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866692826536476692/pasted_image_4.png">

- In this TLS callback we notice something interesting, namely that a function is called to return a function pointer, after which the function pointer is called and the return value is evaluated. Upon returning true, some functions are called with distinct buffers. Since we cannot debug the application at this point, we can only perform static analysis here, but it is not strictly necessary to understand what the code does, as one could simply patch out the conditional jump based on the return value, replacing it with an unconditional jump effectively forcing the function to skip the termination. We simply have to verify that this is actually the point of interest.

- For the sake of completion, I can state here that the first function invoked is very similar to the Windows API `GetProcAddress`, as it iterates a module’s exports to find a specific function. The module in question is effectively chosen based on the InLoadOrderModules list in the windows internal ProcessEnvironmentBlock (PEB) structure. Since the Windows loader will `always` load `ntdll.dll` followed by `kernel32.dll` as the first libraries in a newly allocated process space, we can use the first parameter (`1 or 2`) to choose between fetching an exported API in `ntdll` or `kernel32`.

- The target function is denoted by the second parameter, which is a XOR-encoded string using the third parameter as `key`. If you xor’ed the string with the key presented in the decompilation view, you would obtain the string `CheckRemoteDebuggerPresent`, which is a Windows API for detecting debuggers in an arbitrary process. The `0xffffffff` parameter passed to the function, is a pseudo-handle in Windows that is interpreted as `‘this process’`, effectively making the call verify if there is a debugger attached to our own process.

- We should now patch this callback by simply replacing either one of the conditional jumps with an unconditional jump, e.g. the line shown in the illustration below.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866693390950989894/pasted_image_5.png">

- After patching the application, the line should look as such:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866693643431968818/pasted_image_6.png">

- We can now try to run the application, and we should no longer see the same message.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866693811598131208/pasted_image_7.png">

- We are however still experiencing pre-entrypoint termination, so we should check the next TLS callback in the TLS callback chain.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866694001607573514/pasted_image_8.png">

- As we can see, this callback is very similar to the previous callback, but in this case, the API called is different. If we decrypt the API string, we come up with `“NtQueryInformationProcess”`, which is a native Windows API for querying information about a process. We are querying it with information type 0x1e, which is the ID for querying the process debug object handle. Thus, if the process is being debugged, we should receive a non-null handle, otherwise we should receive a null handle.

- Just like with the previous TLS callback, we simply patch either of the conditional jumps, such as e.g. the one highlighted in the illustration below.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866694183841431572/pasted_image_9.png">

- We can now try to run the application again.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866694330353188904/pasted_image_10.png">

- Now is when something really mind-boggling happens. The terminal shows for a split second, after which it disappears again and OllyDbg loses complete control of the debuggee. This time, we look into the last TLS callback, which looks as shown in the illustration below:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866694440616460298/pasted_image_11.png">

- Once again, this function is very similar to the previous TLS callbacks, but if we decrypt the API string, we receive the string `“NtSetInformationThread”`. We call this API with the information type `0x11`, which is the ID for `ThreadHideFromDebugger`. This is a powerful flag, that allows a thread to hide from any processes attempting to debug it at a native level. In order to bypass this, we do not depend on skipping an error-message, as none occurred – instead, we have to patch out the invocation of the API.

- We could simply fill the push- and call-space with `nop` instructions, but then we have no guarantee the flow will trace along the conditional jump. Instead I patched the following:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866694791030243448/pasted_image_12.png">

- By changing it into the following:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866694907505410078/pasted_image_13.png">

- We have now effectively cleaned up after 2 leading pushes and ensured the condition. We can now run the application again, to see if our countermeasures were effective.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866695008014303252/pasted_image_14.png">

- As seen in the illustration above, we are finally able to reach the entrypoint with the debuggee running under OllyDbg. We should now trace to the main function to examine what the program is actually doing.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866695253788327986/pasted_image_15.png">

- Upon landing in the main function, we should see the above illustrated code flow. A lot of distinct variables or memory entries are populated and then a function is executed. Let’s look into the invoked function.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866695379579437066/pasted_image_16.png">

- This function is actually decompiled wrongly by IDA, as it contains an anti-debug try-catch which modifies a value, followed by a conditional jump based on the value that should have been modified. Due to the exception-greedy nature of debuggers, it will consume all exceptions and the variable will never be modified, so we can detect that a debugger is attached by means of the above described technique.

- However, this function will only break our debug flow, if we trace over it directly via. single stepping – however, we can simply set a breakpoint at a later point and ignore this function.

- Let’s look at the function it invokes at the end.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866695541738700832/pasted_image_17.png">

- Once again, IDA fails to decompile this correctly. This function utilizes a somewhat similar method, but instead of raising a direct exception, it tries to set the TRAP flag of the EFLAGS register, which should confuse the debugger into skipping the exception type, again letting us detect the debugger and react upon it.

- Once this has happened, the function invokes another function (sub_401FC0), and performs a switch based on the returned value. If we look into the function, IDA once again fails to properly decode it, as this is what we see:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866695684756733952/pasted_image_18.png">

- However, if we look at the assembly we notice something interesting.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866695793393270834/pasted_image_19.png">

- The function injects another function into the SEH (Safe Exception Handler) chain, and then triggers an intentional exception by calling the software-breakpoint instruction, `int 3`. The function sets ‘eax’ (the return value) to 0 at first, so unless the registered exception handler is executed, the return value will `always` be 0. Again, due to the greedy nature of debuggers, this function will never be executed under a debugger, so the return value will always be 0 if a debugger is used. If we try to run the application under a debugger, we should see the following message:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866696046192623647/pasted_image_20.png">

- This must indicate that upon returning 0, this happens. We need to find out what happens that could make the program return ‘1’ or ‘2’. Let us check out the exception injected function.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866696171736268820/pasted_image_21.png">

- As we can see, the exception handler performs some interesting actions. First it fills some structure with zeroes, initializes some values in various buffers and invokes a function, storing the return value in `a3+0xb0`. Interestingly, for exception handlers, their third parameter is a pointer to a `CONTEXT` structure, from which the exception handler can modify registers before returning from the exception context. In other words, the above exception handler sets the return value, `eax`, based on the value returned from the invoked function and increments the instruction pointer, `eip`, in order to skip over the debug instruction.

- Let us take a look at the invoked function.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866696460224561152/pasted_image_22.png">

- As can be seen above, the function stores all registers in some structure, and then jumps to the function located adjacently above.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866696573961109514/pasted_image_23.png">

- This function then reads a byte from the pointer located in esi and jumps to an address stored in a table located in `edi`, based on the value read out of the `esi` buffer.

- This should be familiar to a seasoned reverse engineer – it is known as `virtualization protection`. 

- Basically, a small embedded “virtual machine” (or so they are called) will interpret a customly defined byte-code and act upon it. This is a technique often utilized by software for which the developer wants to protect the confidentiality of his underlying code – i.e. he does not want people to be able to read what his code does.

- There are some renown commercial products that employ this technique – VMProtect, Themida, Obsidian, etc., and they are all very widely used softwares that features both virtualization and `heavy` obfuscation. The virtual machine embedded in this software was devised and developed by myself, so I did not employ any type of obfuscation, and simply developed a small assembly interpreter `in assembly itself`, so that it is not too complex or hard to figure out.

- At this point we can either decide to continue with static analysis, or find a way to force OllyDbg to execute the code in the unreachable exception handler. I personally decided to go with static analysis for this write-up, and will be following that path throughout the write-up.

- The first function we landed in, was the `setup` function, which jumped into the `dispatcher` function. The `dispatcher` function is responsible for picking the next handler in the emulation chain from the handler table (in this case, `edi`) based on the input supplied in the `P-code buffer` (in this case, `esi`).

- Let us take a look at how we can figure out what instructions the embedded `virtual machine` supports, by checking the handlers located in `edi`, the handler table.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866697301748482068/pasted_image_24.png">

- Let us start by checking out the first entry.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866697435655700531/pasted_image_25.png">

- This entry simply jumps back to the dispatcher – it can therefore be considered to emulate a flow equivalent to that of a nop instruction. In other words, `opcode 0` does nothing.

- Let us check out what happens in `opcode 1`:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866697613729202236/pasted_image_26.png">

- As can be seen above, the function jumps back into somewhere, after pushing a `return` address to the part below it. Without going into further detail, the called function fetches the first operand based on the next few bytes in the `P-code buffer`, and then returns to this place, in which the handler performs an `inc` operation on the returned operand.

- The entire inner workings of the `virtual machine` might be a bit hard to understand for a person new to reverse engineering, but there are multiple concepts to consider in this context.

  -  The program must maintain a context (ebx in this case)
  -  The context must contain the values of the various x86 registers
  -  The context must emulate a stack, since the real stack is used for calls, etc.

- So with this in mind, we should consider that many of the function calls we’ll see internally when analyzing the `vm` are actually internal helpers for maintaining local parameters and stack values.

- The way progress at this point, is to enumerate through all of the handlers and construct a map of what the handlers do. The constructed table should be similar to this:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866698597394153482/unknown.png">

- Most of the handlers will be very similar, especially the arithmetic ones – however, some of them may also be hard or complex to pin-point exactly, as for example, for the `add esp` and `sub esp`, you need to understand the layout of the context, by knowing where `esp` is located, to figure out that it is the internal representation of `esp` that they are modifying. Also, for `mov gs`, you must be familiar with the `Heaven’s Gate` concept on Windows subsystems.

- On Windows, when running an application, the `code segment` (register CS) is set according to which entry in the `GDT` you are executing code from. This traces back to when CPUs were 16-bit and segmentation was necessary to produce functional applications – however, this is way out of scope a full in-depth discussion in this write-up, so I suggest people read up on how Windows handles segmentation, and what distinguished 32-bit execution mode from 64-bit.

- Returning to the subject, one can jump between execution modes by modifying the `CS` register using “far” flow-control instructions, such as `far jump, far call or far return`. A binary on Windows running under the SysWOW64 subsystem (in 32-bit execution mode) will have `CS` set to 0x23, while a 64-bit application will have `CS` set to 0x33. By setting `CS` to 0x33 in a 32-bit application, you can force the CPU to interpret instructions as 64-bit, as well as force Windows to populate some specific 64-bit registers (R8-R15) with interesting information, such as the 64-bit Thread Environment Block (TEB).

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866699508717191178/pasted_image_27.png">

- The `mov gs` instruction utilizes this in the sub-function shown in the illustration above, by setting execution mode to 64-bit, then executing `dec ecx, push esp, dec eax, pop eax`, which is actually a misleading 32-bit representation of the 64-bit code, which is actually `push r12, pop rax`.

When returning to 32-bit execution mode from this 64-bit executed chunk, the `eax` register will be populated with the data that resides in `r12`, which is a pointer to the `64-bit` TEB.

Aside from the 3 mentioned `special` operations, the rest of the opcodes present in the virtual machine should be fairly straightforward to interpret, although we still do not know what inputs they expect or how they retrieve their operands.

- This should be the next step – to analyze how the VM fetches operands and utilizes them. Let us analyze how the `inc` instruction fetches its one operand. We trace the fetch-operation into this piece of code:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866700206347386910/pasted_image_28.png">

- Basically, the function reads a byte from the `P-code` and performs specific actions based on the value of the byte. For the three possible options, one of the following actions will occur:

  -  Call another function
  -  Call another function
  -  Read a dword from the `P-code` and use this as the operand

- Judging by the above, we can more or less deduce that 1 and 2 signifies a register operand or a memory operand, although the exact order of which does what is unknown to us. We can further deduce that 3 signifies an immediate value (a constant), which is always 4 bytes.

- Let us take a look at the sub function invoked for value `1`:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866700466485329960/pasted_image_29.png">

- As we can see, it reads another byte from the `P-code` buffer, and invokes a function to store this value on the emulated context stack. Another function is then being accessed.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866700611176497212/pasted_image_30.png">

- Inside this function, the value is freed from the context stack, and stored in `eax`. The function then devises a pointer to the context based on `eax`, which is returned from the flow. Since this function allows only fetching of pointers pointing to direct indices of the context, we can assume that this is responsible for fetching register parameters, pointing to the respective register inside the emulated context.

- Let us take a look the sub function invoked for value `2`:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866700821873950770/pasted_image_31.png">

- As we can see, it reads multiple bytes from the `P-code` buffer, and invokes functions to store these on the emulated context stack. Another function is then being accessed.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866701027579265065/pasted_image_32.png">

- Firstly, it uses the function accessed for the register fetching, presumably to fetch the `base` register for the `memory` operand.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866701276853829632/pasted_image_33.png">

- Secondly, it uses the function again, presumably to fetch the `index` register for the `memory` operand.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866701441404895282/pasted_image_34.png">

- Thirdly, it performs right-shifts by 1 bit, presumably to validate the `scale` param of the `memory` operand, to deduce what scale the memory operand should use for the `index` register.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866701602127085589/pasted_image_35.png">

- Fourthly, depending on the scale, the function devises different types of pointers to the `memory` operand.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866701721241387068/pasted_image_36.png">

- Lastly, the pointer is incremented by the amount designated by the `displacement` parameter of the `memory` operand, before returning the `memory` operand pointer.

- We have now deduced the different types of possible operands and what parameters they take as well as their size. If we trace from the start to the end of the flows for the distinct operand types, we should come up with the following consumption information:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866702175617679370/unknown.png">

- Register operands therefore consume a total of 3 bytes.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866702296314281984/unknown.png">

- Memory operands therefore consume a total of 9 bytes.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866702410125803570/unknown.png">

- Immediate operands therefore consume a total of 5 bytes.

- Now that we know the different instructions present in the `P-code` as well as their IDs, and the parameters taken by various operands, we can actually start to interpret the P-code used in the program.

- However, even if we constructed some pseudo-code from the `P-code` buffer, we still do not know which values represent which registers, nor if any of the instructions consume atypical parameters from the `P-code` buffer.

- Let us start by defining which values correlate to which registers in the context.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866702634714005504/pasted_image_37.png">

- By looking back at the `setup` function, which is initially called before the first invocation of the `dispatcher`, we can see that the current registers are placed into the context at specific offsets.

- Judging by this, and the fact that the context was accessed directly offset by the value read from the `P-code` in the register-fetching internal function, we can assume that these are the values that correlate to their respective registers.

- We should now have constructed a table similar to the below:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866703002098204722/unknown.png">

- Now let us look into which functions consume what, and if there is any atypical consumption. This is done similar to detecting what each handler does – by enumerating each of the functions to see if they call the same internal fetching functions, or if they read parameters explicitly.

- This should allow us to construct a table similar to the following:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866703140786667580/unknown.png">

- Now that we have all the information necessary, we can rip the `P-code` buffer from the program, and analyze it manually to reconstruct the emulated code-flow.

- This is done by simply reading the first byte to determine the opcode, then looking at the table above to determine what kind of parameters the opcode takes. Then for each of those params, read the data respective to them, and repeat the process until the entire buffer has been run through and processed.

- The sanitized P-code constructed from this process, should match what is shown below.

```asm
jmp, imm, 0x0a, 0x00, 0x00, 0x00,
xor, reg, dword, eax, reg, dword, eax,
ret, 0x00, 0x00,
mov_fs, reg, dword, ecx, imm, 0x30, 0x00, 0x00, 0x00,
mov, reg, dword, eax, mem, byte, ecx, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
test, reg, dword, eax, reg, dword, eax,
jnz, imm, 0xd3, 0xff, 0xff, 0xff,
mov, reg, dword, eax, mem, dword, ecx, 0x00, 0x00, 0x68, 0x00, 0x00, 0x00,
and, reg, dword, eax, imm, 0x70, 0x00, 0x00, 0x00,
cmp, reg, dword, eax, imm, 0x70, 0x00, 0x00, 0x00,
jz, imm, 0xae, 0xff, 0xff, 0xff,
mov, reg, dword, edx, mem, dword, ecx, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00,
mov, reg, dword, eax, mem, dword, edx, 0x00, 0x00, 0x40, 0x00, 0x00, 0x00,
test, reg, dword, eax, imm, 0x02, 0x00, 0x00, 0x00,
jz, imm, 0x85, 0xff, 0xff, 0xff,
mov, reg, dword, eax, mem, dword, edx, 0x00, 0x00, 0x44, 0x00, 0x00, 0x00,
test, reg, dword, eax, reg, dword, eax,
jnz, imm, 0x6b, 0xff, 0xff, 0xff,
mov_gs, reg, dword, ecx, imm, 0x60, 0x00, 0x00, 0x00,
mov, reg, dword, eax, mem, byte, ecx, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
test, reg, dword, eax, reg, dword, eax,
jnz, imm, 0x48, 0xff, 0xff, 0xff,
mov, reg, dword, eax, mem, dword, ecx, 0x00, 0x00, 0xbc, 0x00, 0x00, 0x00,
and, reg, dword, eax, imm, 0x70, 0x00, 0x00, 0x00,
cmp, reg, dword, eax, imm, 0x70, 0x00, 0x00, 0x00,
jz, imm, 0x23, 0xff, 0xff, 0xff,
mov, reg, dword, edx, mem, dword, ecx, 0x00, 0x00, 0x30, 0x00, 0x00, 0x00,
mov, reg, dword, eax, mem, dword, edx, 0x00, 0x00, 0x70, 0x00, 0x00, 0x00,
test, reg, dword, eax, imm, 0x02, 0x00, 0x00, 0x00,
jz, imm, 0xfa, 0xfe, 0xff, 0xff,
mov, reg, dword, eax, mem, dword, edx, 0x00, 0x00, 0x74, 0x00, 0x00, 0x00,
test, reg, dword, eax, reg, dword, eax,
jnz, imm, 0xe0, 0xfe, 0xff, 0xff,
push, reg, dword, esi,
push, reg, dword, edi,
push, imm, 0x00, 0x00, 0x00, 0x00,
mov, reg, dword, eax, reg, dword, esp,
push, imm, 0x3d, 0x2b, 0x75, 0x6f,
push, imm, 0x3c, 0x3c, 0x38, 0x20,
push, imm, 0x3d, 0x6f, 0x1f, 0x2e,
push, imm, 0x0a, 0x21, 0x3b, 0x2a,
mov, reg, dword, ecx, reg, dword, eax,
sub, reg, dword, ecx, reg, dword, esp,
xor, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff, imm, 0x4f, 0x00, 0x00, 0x00,
dec, reg, dword, ecx,
jnz, imm, 0xe7, 0xff, 0xff, 0xff,
mov, reg, dword, eax, reg, dword, esp,
push, imm, 0x00, 0x00, 0x00, 0x00,
push, reg, dword, eax,
call, imm, 0x00, 0x00, 0x00, 0x00,
esp_add, 0x1c, 0x00,
esp_sub, 0x00, 0x01,
mov, reg, dword, eax, reg, dword, esp,
push, imm, 0x00, 0x00, 0x00, 0x00,
push, imm, 0x00, 0x01, 0x00, 0x00,
push, reg, dword, eax,
call, imm, 0x00, 0x00, 0x00, 0x00,
esp_add, 0x0c, 0x00,
xor, reg, dword, eax, reg, dword, eax,
mov, reg, dword, ecx, imm, 0xff, 0xff, 0x00, 0x00,
mov, reg, dword, edi, reg, dword, esp,
scas_repnz, byte,
sub, reg, dword, ecx, imm, 0xff, 0xff, 0x00, 0x00,
not, reg, dword, ecx,
dec, reg, dword, ecx,
mov, mem, byte, esp, ecx, 0x01, 0x00, 0x00, 0x00, 0x00, imm, 0x00, 0x00, 0x00, 0x00,
mov, reg, dword, edx, reg, dword, ecx,
jmp, imm, 0x17, 0x00, 0x00, 0x00,
mov, reg, dword, eax, imm, 0x01, 0x00, 0x00, 0x00,
esp_add, 0x00, 0x01,
pop, reg, dword, edi,
pop, reg, dword, esi,
ret, 0x00, 0x00,
cmp, reg, dword, edx, imm, 0x3b, 0x00, 0x00, 0x00,
jnz, imm, 0xda, 0xff, 0xff, 0xff,
mov, reg, dword, eax, mem, byte, esp, ecx, 0x01, 0x00, 0x00, 0x00, 0x00,
inc, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff,
rol, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff, imm, 0x9f, 0x00, 0x00, 0x00,
sub, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff, imm, 0x0e, 0x00, 0x00, 0x00,
not, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff,
xor, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff, imm, 0xc3, 0x00, 0x00, 0x00,
neg, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff,
add, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff, imm, 0x3e, 0x00, 0x00, 0x00,
ror, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff, imm, 0x1d, 0x00, 0x00, 0x00,
dec, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff,
xor, mem, byte, esp, ecx, 0x01, 0xff, 0xff, 0xff, 0xff, reg, byte, eax,
dec, reg, dword, ecx,
jnz, imm, 0x69, 0xff, 0xff, 0xff,
mov, reg, dword, edi, reg, dword, esp,
push, imm, 0xf5, 0xed, 0x17, 0x00,
push, imm, 0xf5, 0xed, 0xf5, 0xed,
push, imm, 0xfe, 0xd6, 0xd5, 0xa5,
push, imm, 0xfe, 0xd6, 0xfe, 0xd6,
push, imm, 0x66, 0x91, 0xc1, 0xc2,
push, imm, 0x6e, 0x06, 0x32, 0x5a,
push, imm, 0x2d, 0x69, 0x29, 0x6d,
push, imm, 0x36, 0x72, 0x6a, 0x2e,
push, imm, 0x65, 0x35, 0x09, 0x35,
push, imm, 0x7b, 0x53, 0x70, 0x8a,
push, imm, 0xdc, 0xac, 0xf8, 0x0f,
push, imm, 0xa8, 0x5b, 0x67, 0x90,
push, imm, 0x1f, 0xa0, 0xa8, 0xf3,
push, imm, 0xa7, 0x8f, 0xc3, 0x88,
push, imm, 0x8c, 0x9c, 0xeb, 0xbf,
mov, reg, dword, esi, reg, dword, esp,
mov, reg, dword, ecx, reg, dword, edx,
cmps_repz, byte,
esp_add, 0x3c, 0x00,
jnz, imm, 0xc9, 0xfe, 0xff, 0xff,
mov, reg, dword, eax, imm, 0x02, 0x00, 0x00, 0x00,
jmp, imm, 0xc3, 0xfe, 0xff, 0xff,
```

- Now that we have the sanitized P-code, we should attempt to produce sensible x86 assembly code from it. 

- This process is similar to before, but this time we connect the data to attempt to restore x86 instructions from it – as closely as possible. Sometimes this might not be directly translatable, as the virtual machine, for example, allows operations such as `‘mov eax,cl’`, which is not possible in x86 assembly, where the code should instead be `‘movzx eax,cl’`.

- Once this process is finished, and we have restored the original code, it should be equivalent to that shown below.

```asm
    jmp $+10 (skip _debug_return)

_debug_return:
    xor eax,eax
    ret

    mov ecx,dword ptr fs:[0x30]        // TEB.ProcessEnvironmentBlock
    mov eax,byte ptr [ecx+0x02]        // PEB.BeingDebugged
    test eax,eax
    jnz $-45 (_debug_return)

    mov eax,dword ptr [ecx+0x68]        // PEB.NtGlobalFlag
    and eax,0x70
    cmp eax,0x70
    jz $-82 (_debug_return)

    mov edx,dword ptr [ecx+0x18]        // PEB.ProcessHeap
    mov eax,dword ptr [edx+0x40]        // Heap.Flags
    test eax,0x02
    jz $-123 (_debug_return)

    mov eax,dword ptr [edx+0x44]        // Heap.ForceFlags
    test eax,eax
    jnz $-149 (_debug_return)

    mov ecx,dword ptr gs:[0x60]        // TEB64.ProcessEnvironmentBlock
    mov eax,byte ptr [ecx+0x02]        // PEB64.BeingDebugged
    test eax,eax
    jnz $-184 (_debug_return)

    mov eax,dword ptr [ecx+0xbc]        // PEB64.NtGlobalFlag
    and eax,0x70
    cmp eax,0x70
    jz $-221 (_debug_return)

    mov edx,dword ptr [ecx+0x30]        // PEB64.ProcessHeap
    mov eax,dword ptr [edx+0x70]        // Heap64.Flags
    test eax,0x02
    jz $-262 (_debug_return)

    mov eax,dword ptr [edx+0x74]        // Heap64.ForceFlags
    test eax,eax
    jnz $-288 (_debug_return)

    push esi
    push edi

    push 0x00
    mov eax,esp
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "
    push string "[Human.IO]::Translate("Credentials por favor"): "

    mov ecx,eax
    sub ecx,esp

_decode_output:
    xor byte ptr [esp+ecx-1],0x4f
    dec ecx
    jnz $-25 (_decode_output)

_print_output:
    mov eax,esp
    push stdout
    push eax
    call fputs
    add esp,0x3c

_read_input:
    sub esp,0x100
    mov eax,esp
    push stdin
    push 0x100
    push eax
    call fgets
    add esp,0x0c

_calculate_length:
    xor eax,eax
    mov ecx,0xffff
    mov edi,esp
    repnz scasb
    sub ecx,0xffff
    not ecx
    dec ecx [ignore trailing '\n' in the size]
    mov byte ptr [esp+ecx],0x00
    mov edx,ecx

_store_password:
    mov esi,esp
    mov edi,0x00000000 [insert password]
    rep movsb

    mov ecx,edx
    jmp $+23 (_compare_length)

_password_return_false:
    mov eax,0x01
_password_return:
    add esp,0x100
    pop edi
    pop esi
    ret

_compare_length:
    cmp edx,0x3b
    jnz $-38 (_password_return_false)

_encode_input:
    mov eax,byte ptr [esp+ecx]
    inc byte ptr [esp+ecx-1]
    rol byte ptr [esp+ecx-1],0x9f
    sub byte ptr [esp+ecx-1],0x0e
    not byte ptr [esp+ecx-1]
    xor byte ptr [esp+ecx-1],0xc3
    neg byte ptr [esp+ecx-1]
    add byte ptr [esp+ecx-1],0x3e
    ror byte ptr [esp+ecx-1],0x1d
    dec byte ptr [esp+ecx-1]
    xor byte ptr [esp+ecx-1],al
    dec ecx
    jnz $-151 (_encode_input)
        
_compare_input:
    mov edi,esp
    push 0x0017edf5
    push 0xedf5edf5
    push 0xa5d5d6fe
    push 0xd6fed6fe
    push 0xc2c19166
    push 0x5a32066e
    push 0x6d29692d
    push 0x2e6a7236
    push 0x35093565
    push 0x8a70537b
    push 0x0ff8acdc
    push 0x90675ba8
    push 0xf3a8a01f
    push 0x88c38fa7
    push 0xbfeb9c8c
    mov esi,esp
    mov ecx,edx
    repz cmpsb
    add esp,0x3c
    jnz $-311 (_password_return_false)
    mov eax,0x02
    jmp $-317 (_password_return)
```

- If we read through the buffer, we will notice that the first part of the buffer is actually just more anti-debug techniques, such as reading some flags from the 32-bit and the 64-bit PEB structures.

- The function then prints out “[Human.IO]::Translate(“Credentials por favor”): “ and reads an input from the terminal. The length of this input is then compared to 0x3b, and if not equal to that, the function returns ‘1’.

- We now know the input must be 0x3b (59) bytes long. Let us take a look at the rest of the validation function. First of all, the function “encodes” our password, as seen in the snippet below:

```asm
_encode_input:
    mov eax,byte ptr [esp+ecx]
    inc byte ptr [esp+ecx-1]
    rol byte ptr [esp+ecx-1],0x9f
    sub byte ptr [esp+ecx-1],0x0e
    not byte ptr [esp+ecx-1]
    xor byte ptr [esp+ecx-1],0xc3
    neg byte ptr [esp+ecx-1]
    add byte ptr [esp+ecx-1],0x3e
    ror byte ptr [esp+ecx-1],0x1d
    dec byte ptr [esp+ecx-1]
    xor byte ptr [esp+ecx-1],al
    dec ecx
    jnz $-151 (_encode_input)
```

- The encoding-scheme seems to perform a bunch of arithmetic operations on the character, but interestingly all of them are reversible without any binary loss. Now that we know the encoding schema used for the password, we can analyze the final part:


```asm
mov edi,esp
push 0x0017edf5
push 0xedf5edf5
push 0xa5d5d6fe
push 0xd6fed6fe
push 0xc2c19166
push 0x5a32066e
push 0x6d29692d
push 0x2e6a7236
push 0x35093565
push 0x8a70537b
push 0x0ff8acdc
push 0x90675ba8
push 0xf3a8a01f
push 0x88c38fa7
push 0xbfeb9c8c
mov esi,esp
mov ecx,edx
repz cmpsb
add esp,0x3c
jnz $-311 (_password_return_false)
mov eax,0x02
jmp $-317 (_password_return)
```

- In the above, the function pushes an encoded string onto the stack, and compares the encoded input buffer against this one, so this is what the program expects our encoded password to be.

- If the password matches, the function returns 2, effectively bypassing both of the terminating conditions in the `main` function, and progressing onto the real password function, prompting for a second `password`, which we assume is the same.

- Let us construct a small sample program to recover the password. First, let us construct the function that will decode a character:

```asm
__declspec(naked) uint8_t decode_char(uint8_t a, uint8_t b)
{
    __asm
    {
        movzx eax,byte ptr [esp+0x04]

        xor al,byte ptr [esp+0x08]
        inc al
        rol al,0x1d
        sub al,0x3e
        neg al
        xor al,0xc3
        not al
        add al,0x0e
        ror al,0x9f
        dec al

        ret
    }
}
```

The function takes two parameters, `a` and `b` and returns the decoded character. The above function is simply a reverse of the operations performed in the virtualized code, and will need to be fed two parameters, `a` and `b`, which are the byte to be decoded (`a`) and the next byte in the sequence (`b`). We can utilize this function to decode the buffer sequence by using the following code:


```c
int main(int argc, char* argv[])
{
    uint32_t buffer[] = 
    {
        0xbfeb9c8c, 0x88c38fa7, 0xf3a8a01f, 0x90675ba8, 0x0ff8acdc,
        0x8a70537b, 0x35093565, 0x2e6a7236, 0x6d29692d, 0x5a32066e,
        0xc2c19166, 0xd6fed6fe, 0xa5d5d6fe, 0xedf5edf5, 0x0017edf5
    };

    uint8_t* buf = (uint8_t*)buffer;

    for (uint32_t i = 0; i < sizeof(buffer) - 1; i++)
        putc(decode_char(buf[i], buf[i + 1]), stdout);

    getchar();
    return 0;
}
```

- This will output the password to the terminal as shown in the illustration below:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866705061652201502/unknown.png">

Now that we finally have the password, we should be able to enter it into the program without debugging, and hopefully retrieve the flag.

<img src="https://cdn.discordapp.com/attachments/862667483709440010/866705251003662366/unknown.png">
