using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000112 RID: 274
[Token(Token = "0x2000112")]
public class Bullet_blackPuff : Bullet
{
	// Token: 0x06000557 RID: 1367 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
	[Token(Token = "0x6000557")]
	[Address(RVA = "0x6E2400", Offset = "0x6E0A00", VA = "0x1806E2400", Slot = "22")]
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

	// Token: 0x06000558 RID: 1368 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
	[Token(Token = "0x6000558")]
	[Address(RVA = "0x6E2320", Offset = "0x6E0920", VA = "0x1806E2320", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0001C61C File Offset: 0x0001A81C
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_blackPuff()
	{
	}
}
