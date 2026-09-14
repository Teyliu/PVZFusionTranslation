using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000168 RID: 360
[Token(Token = "0x2000168")]
public class Bullet_magnetCactus : Bullet
{
	// Token: 0x06000677 RID: 1655 RVA: 0x00022004 File Offset: 0x00020204
	[Token(Token = "0x6000677")]
	[Address(RVA = "0x6C98B0", Offset = "0x6C7EB0", VA = "0x1806C98B0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (typeof(IAirCrashable).TypeHandle != 0)
		{
			int num = 0;
			if (num < typeof(IAirCrashable).TypeHandle)
			{
				num += num;
				if ("{il2cpp array field il2cppMethodInfo->}" == typeof(IAirCrashable).TypeHandle)
				{
					goto IL_0036;
				}
				num++;
			}
		}
		int num2 = this._damage;
		if (zombie.theFirstArmorType > Zombie.FirstArmorType.BucketNut)
		{
			goto IL_003A;
		}
		IL_0036:
		num2 += num2;
		IL_003A:
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		uint num3;
		if (theSecondArmorType == Zombie.SecondArmorType.Door || theSecondArmorType == Zombie.SecondArmorType.Ladder || theSecondArmorType == Zombie.SecondArmorType.RedLadder)
		{
			num3 += num3;
		}
		int num4 = 0;
		PlantType fromType = this.fromType;
		ulong num5;
		zombie.TakeDamage((int)num3, this, (DamageType)num4, fromType, num5 != 0UL);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00022090 File Offset: 0x00020290
	[Token(Token = "0x6000678")]
	[Address(RVA = "0x6C9830", Offset = "0x6C7E30", VA = "0x1806C9830", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x000220BC File Offset: 0x000202BC
	[Token(Token = "0x6000679")]
	[Address(RVA = "0x6C97A0", Offset = "0x6C7DA0", VA = "0x1806C97A0")]
	private int AttackIronArmor(Zombie zombie, int damage)
	{
		Zombie.FirstArmorType firstArmorType = zombie.theFirstArmorType;
		if (firstArmorType <= Zombie.FirstArmorType.BucketNut)
		{
			firstArmorType += (int)firstArmorType;
		}
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		if (theSecondArmorType != Zombie.SecondArmorType.Door && theSecondArmorType != Zombie.SecondArmorType.Ladder)
		{
			return damage;
		}
		return damage;
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x000220F4 File Offset: 0x000202F4
	[Token(Token = "0x600067A")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_magnetCactus()
	{
	}
}
