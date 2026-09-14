using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200019B RID: 411
[Token(Token = "0x200019B")]
public class Bullet_smallButter : Bullet_butter
{
	// Token: 0x06000731 RID: 1841 RVA: 0x00025248 File Offset: 0x00023448
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x7E0200", Offset = "0x7DE800", VA = "0x1807E0200", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		if (!zombie.isSmall)
		{
			zombie.BeSmall(0.7f);
		}
		zombie.Buttered(1.5f, true);
		base.Die();
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x000252C0 File Offset: 0x000234C0
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_smallButter()
	{
	}
}
