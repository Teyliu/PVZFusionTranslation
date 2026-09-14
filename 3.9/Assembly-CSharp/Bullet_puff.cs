using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018E RID: 398
[Token(Token = "0x200018E")]
public class Bullet_puff : Bullet
{
	// Token: 0x060006EF RID: 1775 RVA: 0x00023744 File Offset: 0x00021944
	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x80B490", Offset = "0x809A90", VA = "0x18080B490", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00023794 File Offset: 0x00021994
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x80B3B0", Offset = "0x8099B0", VA = "0x18080B3B0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x000237C0 File Offset: 0x000219C0
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_puff()
	{
	}
}
