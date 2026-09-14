using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000182 RID: 386
[Token(Token = "0x2000182")]
public class Bullet_pickaxeStar : Bullet_star
{
	// Token: 0x060006CE RID: 1742 RVA: 0x00023958 File Offset: 0x00021B58
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x7DB8B0", Offset = "0x7D9EB0", VA = "0x1807DB8B0", Slot = "25")]
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

	// Token: 0x060006CF RID: 1743 RVA: 0x000239A8 File Offset: 0x00021BA8
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x7DB7D0", Offset = "0x7D9DD0", VA = "0x1807DB7D0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x000239D4 File Offset: 0x00021BD4
	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x7DB980", Offset = "0x7D9F80", VA = "0x1807DB980")]
	public Bullet_pickaxeStar()
	{
		this.movingToCircle = true;
		base..ctor();
	}
}
