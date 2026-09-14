using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020007FB RID: 2043
[Token(Token = "0x20007FB")]
public class ReNameMenu : BaseMenu
{
	// Token: 0x060029B9 RID: 10681 RVA: 0x000E3FD8 File Offset: 0x000E21D8
	[Token(Token = "0x60029B9")]
	[Address(RVA = "0x644A50", Offset = "0x643050", VA = "0x180644A50")]
	public void SetTitle(string text)
	{
		TextMeshProUGUI textMeshProUGUI = this.title;
		throw new NullReferenceException();
	}

	// Token: 0x060029BA RID: 10682 RVA: 0x000E3FF4 File Offset: 0x000E21F4
	[Token(Token = "0x60029BA")]
	[Address(RVA = "0x6449C0", Offset = "0x642FC0", VA = "0x1806449C0")]
	public void SetInputText(string text)
	{
		TMP_InputField tmp_InputField = this.input;
		int num = 0;
		if (tmp_InputField != num)
		{
			this.input.text = text;
		}
	}

	// Token: 0x060029BB RID: 10683 RVA: 0x000E4028 File Offset: 0x000E2228
	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public ReNameMenu()
	{
	}

	// Token: 0x040017FA RID: 6138
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017FA")]
	public TextMeshProUGUI title;

	// Token: 0x040017FB RID: 6139
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017FB")]
	public UIButton activeButton;

	// Token: 0x040017FC RID: 6140
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017FC")]
	public TMP_InputField input;
}
