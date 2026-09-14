using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000140 RID: 320
[Token(Token = "0x2000140")]
public class Bullet_fireKelp : Bullet
{
	// Token: 0x060005F1 RID: 1521 RVA: 0x0001F48C File Offset: 0x0001D68C
	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x6ED680", Offset = "0x6EBC80", VA = "0x1806ED680", Slot = "22")]
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

	// Token: 0x060005F2 RID: 1522 RVA: 0x0001F530 File Offset: 0x0001D730
	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x6ED5A0", Offset = "0x6EBBA0", VA = "0x1806ED5A0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0001F55C File Offset: 0x0001D75C
	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x6ED180", Offset = "0x6EB780", VA = "0x1806ED180")]
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

	// Token: 0x060005F4 RID: 1524 RVA: 0x0001F604 File Offset: 0x0001D804
	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x6ED140", Offset = "0x6EB740", VA = "0x1806ED140")]
	private bool AllowSputter(Zombie zombie)
	{
		Zombie.SecondArmorType theSecondArmorType = zombie.theSecondArmorType;
		if (theSecondArmorType == Zombie.SecondArmorType.Door || theSecondArmorType <= Zombie.SecondArmorType.Ladder || zombie.theZombieType != ZombieType.SubmarineZombie)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0001F634 File Offset: 0x0001D834
	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_fireKelp()
	{
	}
}
