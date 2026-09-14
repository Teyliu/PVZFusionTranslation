using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200010C RID: 268
[Token(Token = "0x200010C")]
public class Bullet_blackPuff : Bullet
{
	// Token: 0x06000546 RID: 1350 RVA: 0x0001CC1C File Offset: 0x0001AE1C
	[Token(Token = "0x6000546")]
	[Address(RVA = "0x6B7510", Offset = "0x6B5B10", VA = "0x1806B7510", Slot = "25")]
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

	// Token: 0x06000547 RID: 1351 RVA: 0x0001CC6C File Offset: 0x0001AE6C
	[Token(Token = "0x6000547")]
	[Address(RVA = "0x6B7430", Offset = "0x6B5A30", VA = "0x1806B7430", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0001CC98 File Offset: 0x0001AE98
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_blackPuff()
	{
	}
}
