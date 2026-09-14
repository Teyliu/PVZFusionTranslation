using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000368 RID: 872
[Token(Token = "0x2000368")]
public class CherryUltimatePumpkin : UltimatePumpkin
{
	// Token: 0x06000FF7 RID: 4087 RVA: 0x0005C3A0 File Offset: 0x0005A5A0
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x425180", Offset = "0x423780", VA = "0x180425180", Slot = "71")]
	protected override GameObject GetFly()
	{
		return Resources.Load<GameObject>("Plants/Pumpkin/CherryUltimatePumpkin/CherryFly");
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x0005C3B8 File Offset: 0x0005A5B8
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "40")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x4251D0", Offset = "0x4237D0", VA = "0x1804251D0")]
	public CherryUltimatePumpkin()
	{
	}
}
