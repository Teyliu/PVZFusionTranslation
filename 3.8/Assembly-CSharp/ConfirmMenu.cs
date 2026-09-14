using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000814 RID: 2068
[Token(Token = "0x2000814")]
public class ConfirmMenu : BaseMenu
{
	// Token: 0x06002A0F RID: 10767 RVA: 0x000E5DC8 File Offset: 0x000E3FC8
	[Token(Token = "0x6002A0F")]
	[Address(RVA = "0x635600", Offset = "0x633C00", VA = "0x180635600")]
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

	// Token: 0x06002A10 RID: 10768 RVA: 0x000E5DF4 File Offset: 0x000E3FF4
	[Token(Token = "0x6002A10")]
	[Address(RVA = "0x635730", Offset = "0x633D30", VA = "0x180635730")]
	public ConfirmMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.title = list;
		base..ctor();
	}

	// Token: 0x04001854 RID: 6228
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001854")]
	public List<TextMeshProUGUI> title;

	// Token: 0x04001855 RID: 6229
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001855")]
	public UIButton activeButton;
}
