using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000852 RID: 2130
[Token(Token = "0x2000852")]
public class ConfirmMenu : BaseMenu
{
	// Token: 0x06002B4D RID: 11085 RVA: 0x000EB108 File Offset: 0x000E9308
	[Token(Token = "0x6002B4D")]
	[Address(RVA = "0x699B70", Offset = "0x698170", VA = "0x180699B70")]
	public void SetTitle(string title)
	{
		ulong num;
		do
		{
			List<TextMeshProUGUI> list = this.title;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x000EB134 File Offset: 0x000E9334
	[Token(Token = "0x6002B4E")]
	[Address(RVA = "0x699CA0", Offset = "0x6982A0", VA = "0x180699CA0")]
	public ConfirmMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.title = list;
		base..ctor();
	}

	// Token: 0x04001950 RID: 6480
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001950")]
	public List<TextMeshProUGUI> title;

	// Token: 0x04001951 RID: 6481
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001951")]
	public UIButton activeButton;
}
