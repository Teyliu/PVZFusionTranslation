using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200080B RID: 2059
[Token(Token = "0x200080B")]
public class AlmanacSecondMenu : BaseMenu
{
	// Token: 0x060029E6 RID: 10726 RVA: 0x000E2434 File Offset: 0x000E0634
	[Token(Token = "0x60029E6")]
	[Address(RVA = "0x68C9D0", Offset = "0x68AFD0", VA = "0x18068C9D0")]
	public AlmanacSecondMenu()
	{
		List<AlmanacCardUI> list = new List();
		this.cards = list;
		base..ctor();
	}

	// Token: 0x040017E2 RID: 6114
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017E2")]
	[Header("卡牌设置")]
	public RectTransform basicCardContent;

	// Token: 0x040017E3 RID: 6115
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017E3")]
	public RectTransform basicCardHead;

	// Token: 0x040017E4 RID: 6116
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017E4")]
	public Scrollbar cardScrollbar;

	// Token: 0x040017E5 RID: 6117
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017E5")]
	[Header("生成以后的卡牌设置")]
	public List<AlmanacCardUI> cards;
}
