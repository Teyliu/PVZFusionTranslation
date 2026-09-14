using System;
using Cpp2IlInjected;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020008AC RID: 2220
[Token(Token = "0x20008AC")]
public class ScrollModify : ScrollRect
{
	// Token: 0x06002D57 RID: 11607 RVA: 0x000F7408 File Offset: 0x000F5608
	[Token(Token = "0x6002D57")]
	[Address(RVA = "0x6D8540", Offset = "0x6D6B40", VA = "0x1806D8540", Slot = "42")]
	public override void OnScroll(PointerEventData data)
	{
		base.OnScroll(data);
	}

	// Token: 0x06002D58 RID: 11608 RVA: 0x000F741C File Offset: 0x000F561C
	[Token(Token = "0x6002D58")]
	[Address(RVA = "0x6D8550", Offset = "0x6D6B50", VA = "0x1806D8550")]
	public ScrollModify()
	{
	}
}
