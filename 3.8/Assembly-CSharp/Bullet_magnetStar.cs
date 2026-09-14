using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000169 RID: 361
[Token(Token = "0x2000169")]
public class Bullet_magnetStar : Bullet_star
{
	// Token: 0x0600067B RID: 1659 RVA: 0x00022108 File Offset: 0x00020308
	[Token(Token = "0x600067B")]
	[Address(RVA = "0x6C9BB0", Offset = "0x6C81B0", VA = "0x1806C9BB0", Slot = "25")]
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

	// Token: 0x0600067C RID: 1660 RVA: 0x00022178 File Offset: 0x00020378
	[Token(Token = "0x600067C")]
	[Address(RVA = "0x6C9AD0", Offset = "0x6C80D0", VA = "0x1806C9AD0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x000221A4 File Offset: 0x000203A4
	[Token(Token = "0x600067D")]
	[Address(RVA = "0x6C9A50", Offset = "0x6C8050", VA = "0x1806C9A50")]
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

	// Token: 0x0600067E RID: 1662 RVA: 0x000221D4 File Offset: 0x000203D4
	[Token(Token = "0x600067E")]
	[Address(RVA = "0x6BC210", Offset = "0x6BA810", VA = "0x1806BC210")]
	public Bullet_magnetStar()
	{
	}
}
