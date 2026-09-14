using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A2 RID: 418
[Token(Token = "0x20001A2")]
public class Bullet_smallButter : Bullet_butter
{
	// Token: 0x0600073E RID: 1854 RVA: 0x00024B80 File Offset: 0x00022D80
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x80D940", Offset = "0x80BF40", VA = "0x18080D940", Slot = "22")]
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

	// Token: 0x0600073F RID: 1855 RVA: 0x00024BF8 File Offset: 0x00022DF8
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_smallButter()
	{
	}
}
