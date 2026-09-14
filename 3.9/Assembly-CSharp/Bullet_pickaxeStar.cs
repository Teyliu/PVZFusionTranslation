using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000189 RID: 393
[Token(Token = "0x2000189")]
public class Bullet_pickaxeStar : Bullet_star
{
	// Token: 0x060006DD RID: 1757 RVA: 0x00023350 File Offset: 0x00021550
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x809270", Offset = "0x807870", VA = "0x180809270", Slot = "22")]
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

	// Token: 0x060006DE RID: 1758 RVA: 0x000233A0 File Offset: 0x000215A0
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x809190", Offset = "0x807790", VA = "0x180809190", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x000233CC File Offset: 0x000215CC
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x809340", Offset = "0x807940", VA = "0x180809340")]
	public Bullet_pickaxeStar()
	{
		this.movingToCircle = true;
		base..ctor();
	}
}
