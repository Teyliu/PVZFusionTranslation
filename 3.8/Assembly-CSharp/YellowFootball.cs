using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000714 RID: 1812
[Token(Token = "0x2000714")]
public class YellowFootball : Zombie
{
	// Token: 0x0600246A RID: 9322 RVA: 0x000BDAC8 File Offset: 0x000BBCC8
	[Token(Token = "0x600246A")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x0600246B RID: 9323 RVA: 0x000BDAD8 File Offset: 0x000BBCD8
	[Token(Token = "0x600246B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x0600246C RID: 9324 RVA: 0x000BDAE8 File Offset: 0x000BBCE8
	[Token(Token = "0x600246C")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600246D RID: 9325 RVA: 0x000BDAF8 File Offset: 0x000BBCF8
	[Token(Token = "0x600246D")]
	[Address(RVA = "0x592060", Offset = "0x590660", VA = "0x180592060")]
	public YellowFootball()
	{
	}
}
