using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200051E RID: 1310
[Token(Token = "0x200051E")]
public class FumeShroom : Shooter
{
	// Token: 0x06001885 RID: 6277 RVA: 0x000850C4 File Offset: 0x000832C4
	[Token(Token = "0x6001885")]
	[Address(RVA = "0x524B50", Offset = "0x523150", VA = "0x180524B50", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num4;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					int thePlantRow = this.thePlantRow;
					float vision = this.vision;
					Transform axis = this.axis;
					Transform axis2 = this.axis;
					float num3 = this.range;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num4 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x0008515C File Offset: 0x0008335C
	[Token(Token = "0x6001886")]
	[Address(RVA = "0x524890", Offset = "0x522E90", VA = "0x180524890", Slot = "72")]
	protected virtual void AttackZombie()
	{
		int num2;
		ulong num5;
		do
		{
			int num = 0;
			num2 = 0;
			int num3 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(this.thePlantRow, num3 != 0);
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
				float num4 = this.range;
				Transform axis2 = this.axis;
				if (!base.SearchUniqueZombie(num))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				this.Attack(num);
			}
		}
		while (num5 != (ulong)0L);
		if (num2 != 0)
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		}
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x000851FC File Offset: 0x000833FC
	[Token(Token = "0x6001887")]
	[Address(RVA = "0x50BB80", Offset = "0x50A180", VA = "0x18050BB80", Slot = "73")]
	protected virtual void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)1), thePlantType, num != 0UL);
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x0008522C File Offset: 0x0008342C
	[Token(Token = "0x6001888")]
	[Address(RVA = "0x524E00", Offset = "0x523400", VA = "0x180524E00", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform = gameObject.transform;
		GameAPP.PlaySound(58, 0.5f, 1f);
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x00085274 File Offset: 0x00083474
	[Token(Token = "0x6001889")]
	[Address(RVA = "0x523270", Offset = "0x521870", VA = "0x180523270")]
	public FumeShroom()
	{
	}

	// Token: 0x04000E7A RID: 3706
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E7A")]
	protected float range = 7f;
}
