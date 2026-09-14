using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017E RID: 382
[Token(Token = "0x200017E")]
public class Bullet_nut : Bullet_pierce
{
	// Token: 0x060006B6 RID: 1718 RVA: 0x000228B4 File Offset: 0x00020AB4
	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x807090", Offset = "0x805690", VA = "0x180807090", Slot = "22")]
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
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x000228FC File Offset: 0x00020AFC
	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x807150", Offset = "0x805750", VA = "0x180807150", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x0002291C File Offset: 0x00020B1C
	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x806FB0", Offset = "0x8055B0", VA = "0x180806FB0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00022948 File Offset: 0x00020B48
	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_nut()
	{
	}
}
