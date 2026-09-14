using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000187 RID: 391
[Token(Token = "0x2000187")]
public class Bullet_puff : Bullet
{
	// Token: 0x060006E2 RID: 1762 RVA: 0x00023E24 File Offset: 0x00022024
	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x7DDD20", Offset = "0x7DC320", VA = "0x1807DDD20", Slot = "25")]
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

	// Token: 0x060006E3 RID: 1763 RVA: 0x00023E74 File Offset: 0x00022074
	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x7DDC40", Offset = "0x7DC240", VA = "0x1807DDC40", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00023EA0 File Offset: 0x000220A0
	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_puff()
	{
	}
}
