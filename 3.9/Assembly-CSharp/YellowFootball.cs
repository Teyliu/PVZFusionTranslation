using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200074D RID: 1869
[Token(Token = "0x200074D")]
public class YellowFootball : Zombie
{
	// Token: 0x0600258A RID: 9610 RVA: 0x000C28B4 File Offset: 0x000C0AB4
	[Token(Token = "0x600258A")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x000C28C4 File Offset: 0x000C0AC4
	[Token(Token = "0x600258B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x000C28D4 File Offset: 0x000C0AD4
	[Token(Token = "0x600258C")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x000C28E4 File Offset: 0x000C0AE4
	[Token(Token = "0x600258D")]
	[Address(RVA = "0x60C180", Offset = "0x60A780", VA = "0x18060C180")]
	public YellowFootball()
	{
	}
}
