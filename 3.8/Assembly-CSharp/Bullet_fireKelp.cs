using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200013B RID: 315
[Token(Token = "0x200013B")]
public class Bullet_fireKelp : Bullet
{
	// Token: 0x060005EA RID: 1514 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x6C28A0", Offset = "0x6C0EA0", VA = "0x1806C28A0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		if (zombie.inWater)
		{
			int num3 = 0;
			zombie.SetKelped((float)damage, num3 != 0);
		}
		zombie.Warm();
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		if (theSecondArmorType != Zombie.SecondArmorType.Door && theSecondArmorType > Zombie.SecondArmorType.Ladder && zombie.theZombieType != ZombieType.SubmarineZombie)
		{
			uint num4;
			uint num5;
			GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num4, (int)num5), 0.5f, 1f);
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			this.AttackOtherZombie(zombie);
		}
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0001FD48 File Offset: 0x0001DF48
	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x6C27C0", Offset = "0x6C0DC0", VA = "0x1806C27C0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x0001FD74 File Offset: 0x0001DF74
	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x6C23A0", Offset = "0x6C09A0", VA = "0x1806C23A0")]
	private void AttackOtherZombie(Zombie targetZombie)
	{
		ulong num5;
		do
		{
			List<Zombie> list = new List();
			int damage = this._damage;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			int num = this.zombieLayer;
			int num2 = 0;
			int num3 = 0;
			Collider2D[] array;
			if (num3 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && !flag2)
				{
					int num4 = this.theBulletRow;
					if (num4 != 1)
					{
						num4 += -3;
						if (num4 > 3)
						{
						}
					}
				}
				num2++;
			}
			if (list._size == 0)
			{
				break;
			}
			bool flag3;
			if (flag3)
			{
				PlantType fromType = this.fromType;
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x0001FE1C File Offset: 0x0001E01C
	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x6C2360", Offset = "0x6C0960", VA = "0x1806C2360")]
	private bool AllowSputter(Zombie zombie)
	{
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		if (theSecondArmorType == Zombie.SecondArmorType.Door || theSecondArmorType <= Zombie.SecondArmorType.Ladder || zombie.theZombieType != ZombieType.SubmarineZombie)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x0001FE4C File Offset: 0x0001E04C
	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_fireKelp()
	{
	}
}
