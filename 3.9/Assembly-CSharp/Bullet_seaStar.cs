using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000196 RID: 406
[Token(Token = "0x2000196")]
public class Bullet_seaStar : Bullet_star
{
	// Token: 0x0600070E RID: 1806 RVA: 0x00023F18 File Offset: 0x00022118
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x80BAC0", Offset = "0x80A0C0", VA = "0x18080BAC0", Slot = "22")]
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

	// Token: 0x0600070F RID: 1807 RVA: 0x00023F68 File Offset: 0x00022168
	[Token(Token = "0x600070F")]
	[Address(RVA = "0x80B9E0", Offset = "0x809FE0", VA = "0x18080B9E0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00023F94 File Offset: 0x00022194
	[Token(Token = "0x6000710")]
	[Address(RVA = "0x809340", Offset = "0x807940", VA = "0x180809340")]
	public Bullet_seaStar()
	{
		this.movingToCircle = true;
		base..ctor();
	}
}
