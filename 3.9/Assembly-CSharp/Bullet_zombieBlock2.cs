using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001DE RID: 478
[Token(Token = "0x20001DE")]
public class Bullet_zombieBlock2 : Bullet_zombieBlock
{
	// Token: 0x06000818 RID: 2072 RVA: 0x00028FC0 File Offset: 0x000271C0
	[Token(Token = "0x6000818")]
	[Address(RVA = "0x8E30D0", Offset = "0x8E16D0", VA = "0x1808E30D0", Slot = "22")]
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

	// Token: 0x06000819 RID: 2073 RVA: 0x00029014 File Offset: 0x00027214
	[Token(Token = "0x6000819")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_zombieBlock2()
	{
	}
}
