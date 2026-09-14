using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000378 RID: 888
[Token(Token = "0x2000378")]
public class CherryUltimatePumpkin : UltimatePumpkin
{
	// Token: 0x06001043 RID: 4163 RVA: 0x0005D360 File Offset: 0x0005B560
	[Token(Token = "0x6001043")]
	[Address(RVA = "0x47BE60", Offset = "0x47A460", VA = "0x18047BE60", Slot = "70")]
	protected override GameObject GetFly()
	{
		return Resources.Load<GameObject>("Plants/Pumpkin/CherryUltimatePumpkin/CherryFly");
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x0005D378 File Offset: 0x0005B578
	[Token(Token = "0x6001044")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "39")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x0005D388 File Offset: 0x0005B588
	[Token(Token = "0x6001045")]
	[Address(RVA = "0x47BEB0", Offset = "0x47A4B0", VA = "0x18047BEB0")]
	public CherryUltimatePumpkin()
	{
	}
}
