using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016E RID: 366
[Token(Token = "0x200016E")]
public class Bullet_magnetCactus : Bullet
{
	// Token: 0x06000682 RID: 1666 RVA: 0x000219AC File Offset: 0x0001FBAC
	[Token(Token = "0x6000682")]
	[Address(RVA = "0x6F51B0", Offset = "0x6F37B0", VA = "0x1806F51B0", Slot = "22")]
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

	// Token: 0x06000683 RID: 1667 RVA: 0x00021A38 File Offset: 0x0001FC38
	[Token(Token = "0x6000683")]
	[Address(RVA = "0x6F5130", Offset = "0x6F3730", VA = "0x1806F5130", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00021A64 File Offset: 0x0001FC64
	[Token(Token = "0x6000684")]
	[Address(RVA = "0x6F50A0", Offset = "0x6F36A0", VA = "0x1806F50A0")]
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

	// Token: 0x06000685 RID: 1669 RVA: 0x00021A9C File Offset: 0x0001FC9C
	[Token(Token = "0x6000685")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_magnetCactus()
	{
	}
}
