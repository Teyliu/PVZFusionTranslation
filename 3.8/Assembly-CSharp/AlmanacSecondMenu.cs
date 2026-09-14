using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020007D2 RID: 2002
[Token(Token = "0x20007D2")]
public class AlmanacSecondMenu : BaseMenu
{
	// Token: 0x060028B7 RID: 10423 RVA: 0x000DD444 File Offset: 0x000DB644
	[Token(Token = "0x60028B7")]
	[Address(RVA = "0x6290D0", Offset = "0x6276D0", VA = "0x1806290D0")]
	public AlmanacSecondMenu()
	{
		List<AlmanacCardUI> list = new List();
		this.cards = list;
		base..ctor();
	}

	// Token: 0x04001706 RID: 5894
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001706")]
	[Header("卡牌设置")]
	public RectTransform basicCardContent;

	// Token: 0x04001707 RID: 5895
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001707")]
	public RectTransform basicCardHead;

	// Token: 0x04001708 RID: 5896
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001708")]
	public Scrollbar cardScrollbar;

	// Token: 0x04001709 RID: 5897
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001709")]
	[Header("生成以后的卡牌设置")]
	public List<AlmanacCardUI> cards;
}
