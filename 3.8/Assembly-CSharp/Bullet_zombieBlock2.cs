using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D4 RID: 468
[Token(Token = "0x20001D4")]
public class Bullet_zombieBlock2 : Bullet_zombieBlock
{
	// Token: 0x06000802 RID: 2050 RVA: 0x00029400 File Offset: 0x00027600
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x8543F0", Offset = "0x8529F0", VA = "0x1808543F0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		zombie.KnockBack(0.25f, (Zombie.KnockBackReason)((uint)1));
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00029454 File Offset: 0x00027654
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_zombieBlock2()
	{
	}
}
