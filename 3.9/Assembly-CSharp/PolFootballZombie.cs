using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006EE RID: 1774
[Token(Token = "0x20006EE")]
public class PolFootballZombie : PolevaulterZombie
{
	// Token: 0x060022BA RID: 8890 RVA: 0x000B5F8C File Offset: 0x000B418C
	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x5CAEB0", Offset = "0x5C94B0", VA = "0x1805CAEB0", Slot = "37")]
	protected override void FindAndReplaceArmUpperSprite(GameObject obj)
	{
		base.FindAndReplaceArmUpperSprite(obj);
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x000B5FA4 File Offset: 0x000B41A4
	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x000B5FB4 File Offset: 0x000B41B4
	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x5CAEC0", Offset = "0x5C94C0", VA = "0x1805CAEC0")]
	public PolFootballZombie()
	{
		this.range = (ulong)1060320051L;
		this.range.y = 2f;
		base..ctor();
	}
}
