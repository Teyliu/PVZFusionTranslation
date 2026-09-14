using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000463 RID: 1123
[Token(Token = "0x2000463")]
public class UltimateCabbageCannon : CabbageCannon
{
	// Token: 0x060014B9 RID: 5305 RVA: 0x000734E8 File Offset: 0x000716E8
	[Token(Token = "0x60014B9")]
	[Address(RVA = "0x47DB90", Offset = "0x47C190", VA = "0x18047DB90", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_explode;
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x000734FC File Offset: 0x000716FC
	[Token(Token = "0x60014BA")]
	[Address(RVA = "0x47E7C0", Offset = "0x47CDC0", VA = "0x18047E7C0", Slot = "75")]
	protected override Zombie ThrowerSearchZombie()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				float vision = this.vision;
				if (!base.CheckRange(num) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x00073568 File Offset: 0x00071768
	[Token(Token = "0x60014BB")]
	[Address(RVA = "0x47DBA0", Offset = "0x47C1A0", VA = "0x18047DBA0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num10;
		do
		{
			int num = 0;
			int attackDamage = this.attackDamage;
			bool flag;
			if (flag)
			{
			}
			List<Zombie> list = new List();
			List<Zombie> zombieArray = this.board.zombieArray;
			int num2 = 0;
			bool flag2;
			if (flag2)
			{
				int num3 = 0;
				if (!(num != num3) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
			if (num2 != 0)
			{
				goto IL_015D;
			}
			int num4 = 0;
			bool flag3;
			uint num5;
			if (flag3 && global::UnityEngine.Random.Range(0, (int)num5) == 0)
			{
				int num6 = 0;
				Vector3 vector;
				float num7 = vector.z;
				num7 += num7;
				num6 += num6;
			}
			Func<Zombie, float> func;
			if (UltimateCabbageCannon.<>c.<>9__2_0 == 0)
			{
				UltimateCabbageCannon.<>c.<>9__2_0 = func;
			}
			IOrderedEnumerable<Zombie> orderedEnumerable = Enumerable.OrderBy<Zombie, float>(list, func);
			IEnumerable<Zombie> enumerable;
			List<Zombie> list2 = Enumerable.ToList<Zombie>(enumerable);
			int num8 = 0;
			Plant plant;
			if (plant != num8)
			{
				Transform axis2 = plant.axis;
				Vector3 vector2;
				float z = vector2.z;
				bool flag4;
				if (flag4)
				{
					CreateBullet instance = CreateBullet.Instance;
					int num9 = 0;
					Bullet bullet;
					bullet.Damage = attackDamage;
					bullet.fromType = (PlantType)num9;
				}
				if (num4 != 0)
				{
					goto IL_0181;
				}
				num10 = 0;
			}
			bool flag5;
			if (flag5)
			{
				CreateBullet instance2 = CreateBullet.Instance;
				int num11 = 0;
				Bullet bullet2;
				bullet2.Damage = attackDamage;
				bullet2.fromType = (PlantType)num11;
			}
		}
		while (num10 != 0);
		float num12 = global::UnityEngine.Random.Range(0.9f, 1.2f);
		uint num13;
		GameAPP.PlaySound((int)num13, 0.5f, num12);
		throw new NullReferenceException();
		IL_015D:
		throw new NullReferenceException();
		IL_0181:
		throw new NullReferenceException();
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x0007370C File Offset: 0x0007190C
	[Token(Token = "0x60014BC")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public UltimateCabbageCannon()
	{
	}
}
