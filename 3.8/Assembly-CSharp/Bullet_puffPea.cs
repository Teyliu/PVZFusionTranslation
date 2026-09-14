using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018A RID: 394
[Token(Token = "0x200018A")]
public class Bullet_puffPea : Bullet
{
	// Token: 0x060006EE RID: 1774 RVA: 0x000240C4 File Offset: 0x000222C4
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x7DCF80", Offset = "0x7DB580", VA = "0x1807DCF80", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num != 0);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00024114 File Offset: 0x00022314
	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x7DCEA0", Offset = "0x7DB4A0", VA = "0x1807DCEA0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00024144 File Offset: 0x00022344
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_puffPea()
	{
	}
}
