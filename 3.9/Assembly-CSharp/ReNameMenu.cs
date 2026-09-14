using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000836 RID: 2102
[Token(Token = "0x2000836")]
public class ReNameMenu : BaseMenu
{
	// Token: 0x06002AEF RID: 10991 RVA: 0x000E90A4 File Offset: 0x000E72A4
	[Token(Token = "0x6002AEF")]
	[Address(RVA = "0x6A91B0", Offset = "0x6A77B0", VA = "0x1806A91B0")]
	public void SetTitle(string text)
	{
		TextMeshProUGUI textMeshProUGUI = this.title;
		throw new NullReferenceException();
	}

	// Token: 0x06002AF0 RID: 10992 RVA: 0x000E90C0 File Offset: 0x000E72C0
	[Token(Token = "0x6002AF0")]
	[Address(RVA = "0x6A9120", Offset = "0x6A7720", VA = "0x1806A9120")]
	public void SetInputText(string text)
	{
		TMP_InputField tmp_InputField = this.input;
		int num = 0;
		if (tmp_InputField != num)
		{
			this.input.text = text;
		}
	}

	// Token: 0x06002AF1 RID: 10993 RVA: 0x000E90F4 File Offset: 0x000E72F4
	[Token(Token = "0x6002AF1")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public ReNameMenu()
	{
	}

	// Token: 0x040018E5 RID: 6373
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018E5")]
	public TextMeshProUGUI title;

	// Token: 0x040018E6 RID: 6374
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018E6")]
	public UIButton activeButton;

	// Token: 0x040018E7 RID: 6375
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018E7")]
	public TMP_InputField input;
}
