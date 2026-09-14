using System;
using Cpp2IlInjected;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000870 RID: 2160
[Token(Token = "0x2000870")]
public class ScrollModify : ScrollRect
{
	// Token: 0x06002C25 RID: 11301 RVA: 0x000F27F0 File Offset: 0x000F09F0
	[Token(Token = "0x6002C25")]
	[Address(RVA = "0x6738F0", Offset = "0x671EF0", VA = "0x1806738F0", Slot = "42")]
	public override void OnScroll(PointerEventData data)
	{
		base.OnScroll(data);
	}

	// Token: 0x06002C26 RID: 11302 RVA: 0x000F2804 File Offset: 0x000F0A04
	[Token(Token = "0x6002C26")]
	[Address(RVA = "0x673900", Offset = "0x671F00", VA = "0x180673900")]
	public ScrollModify()
	{
	}
}
