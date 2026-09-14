using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016F RID: 367
[Token(Token = "0x200016F")]
public class Bullet_magnetStar : Bullet_star
{
	// Token: 0x06000686 RID: 1670 RVA: 0x00021AB0 File Offset: 0x0001FCB0
	[Token(Token = "0x6000686")]
	[Address(RVA = "0x6F54B0", Offset = "0x6F3AB0", VA = "0x1806F54B0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = this._damage;
		if (zombie.theFirstArmorType <= Zombie.FirstArmorType.TallNut)
		{
		}
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		if (theSecondArmorType == Zombie.SecondArmorType.Door || theSecondArmorType == Zombie.SecondArmorType.Ladder || theSecondArmorType == Zombie.SecondArmorType.RedLadder)
		{
			num += num;
		}
		int num2 = 0;
		PlantType fromType = this.fromType;
		ulong num3;
		zombie.TakeDamage(num, this, (DamageType)num2, fromType, num3 != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00021B20 File Offset: 0x0001FD20
	[Token(Token = "0x6000687")]
	[Address(RVA = "0x6F53D0", Offset = "0x6F39D0", VA = "0x1806F53D0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00021B4C File Offset: 0x0001FD4C
	[Token(Token = "0x6000688")]
	[Address(RVA = "0x6F5350", Offset = "0x6F3950", VA = "0x1806F5350")]
	private int AttackIronArmor(Zombie zombie, int damage)
	{
		if (zombie.theFirstArmorType <= Zombie.FirstArmorType.TallNut)
		{
		}
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		if (theSecondArmorType != Zombie.SecondArmorType.Door && theSecondArmorType != Zombie.SecondArmorType.Ladder)
		{
			return damage;
		}
		return damage;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00021B7C File Offset: 0x0001FD7C
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x6E70E0", Offset = "0x6E56E0", VA = "0x1806E70E0")]
	public Bullet_magnetStar()
	{
	}
}
