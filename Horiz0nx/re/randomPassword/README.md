### [Cutter](https://cutter.re/)

- So for this challenge we will need cutter.

- If we go on the decompiler and we double click on main we can see this:

```c
undefined8 main(undefined8 argc, char **argv)
{
    undefined4 uVar1;
    int32_t iVar2;
    uint64_t uVar3;
    uint64_t uVar4;
    char **var_120h;
    int64_t var_114h;
    char *s1;
    undefined var_81h;
    char *s;
    int64_t var_78h;
    int64_t var_70h;
    int64_t var_68h;
    int64_t var_60h;
    int64_t var_58h;
    int64_t var_50h;
    int64_t var_48h;
    char *var_40h;
    int64_t var_38h;
    int64_t var_30h;
    int64_t var_28h;
    int32_t var_18h;
    int64_t var_14h;
    int64_t var_8h;
    
    var_114h._0_4_ = (undefined4)argc;
    uVar1 = time(0);
    srand(uVar1);
    var_40h = (char *)0x0;
    var_38h = 0;
    var_30h = 0;
    var_28h._0_1_ = 0;
    var_60h = 0x59271b4b275d3905;
    var_58h = 0x2755531f44687c13;
    var_50h = 0x2b776321653a571a;
    var_48h._0_1_ = 0xf;
    s = (char *)0x21492b314e2f566d;
    var_78h = 0x4271217a322d2e68;
    var_70h = 0x674753423a496645;
    var_68h._0_1_ = 0x72;
    var_14h._0_4_ = 0;
    while( true ) {
        uVar4 = SEXT48((int32_t)var_14h);
        uVar3 = strlen(&s);
        if (uVar3 <= uVar4) break;
        *(uint8_t *)((int64_t)&var_40h + (int64_t)(int32_t)var_14h) =
             *(uint8_t *)((int64_t)&s + (int64_t)(int32_t)var_14h) ^
             *(uint8_t *)((int64_t)&var_60h + (int64_t)(int32_t)var_14h);
        var_14h._0_4_ = (int32_t)var_14h + 1;
    }
    var_28h._1_1_ = 0;
    var_18h = 0;
    while (var_18h < 0x1e) {
        iVar2 = rand();
        *(char *)((int64_t)&s1 + (int64_t)var_18h) = (char)iVar2 + (char)(iVar2 / 100) * -100;
        var_18h = var_18h + 1;
    }
    var_81h = 0;
    printf("Please enter password: ");
    __isoc99_scanf(0x2020, (int64_t)&var_114h + 4);
    iVar2 = strcmp(&s1, (int64_t)&var_114h + 4, (int64_t)&var_114h + 4);
    if (iVar2 == 0) {
        printf("Good job here is your flag: %s\n", &var_40h);
    } else {
        puts("Incorrect password");
    }
    return 0;
}
```

- When we read it we can see this important line:


```c
    if (iVar2 == 0) {
        printf("Good job here is your flag: %s\n", &var_40h);
    } else {
        puts("Incorrect password");
    }
```

- So we gonna do a reverse jump for make it look like this:

```c
    if (iVar2 == 0) {
        puts("Incorrect password");
    } else {
        printf("Good job here is your flag: %s\n", &var_40h);
    }
```

- Then go on the disassembly section and search this `0x0000131f      jne     0x133b`.

- Right click on it, go on `Edit`, and click on `Reverse Jump`.

- Save the file and exec it, you will get the flag.

- `Good job here is your flag: horiz0nx{REver$e_XXXXXXXX}`
