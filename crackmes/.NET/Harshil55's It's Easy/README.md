# Harshil55's It's Easy .NET 1.5 

## Link: https://crackmes.one/crackme/5ebebde133c5d449d91ae4ec

```Description

It is very easy to crack.
Just need to find somethings inside.
If you can't solve,
Go back to learning .net```

- Open it into dnSpy and here we have two choices, read or put breakpoints for get the final result

- If you don't want to understand the code and want be fast, just put BP at theses lines:

<img src="https://cdn.discordapp.com/attachments/865706489951944717/886650741727559680/unknown.png">

- But if you wanna try to understand the code let me explain,

- So the correct string value is the text3 + text + text4 + text5.

- If we scroll up we can see this:

```csharp
			string text = this.txtName.Text.Substring(0, 4).ToUpper();
			string text2 = this.txtSerialKey.Text;
			string text3 = this.productId1.Text;
			string text4 = this.productId2.Text;
			string text5 = this.productId3.Text;
			if (text.Length < 4)
```

- So text3 correspond to X398

- The text is the 4 letters in the input name but in uppercase like if you put `hell` in name it will be `HELL`

- text4 is the id2 so it's correspond to 33CE

- And text5 is the id3 so it's correspond to A639

- So our serial key will look like this: `X398HELL33CEA639`

- (yes 34FE are useless)
