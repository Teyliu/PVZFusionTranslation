using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000483 RID: 1155
[Token(Token = "0x2000483")]
public class UltimateCabbageCannon : CabbageCannon
{
	// Token: 0x06001549 RID: 5449 RVA: 0x00075818 File Offset: 0x00073A18
	[Token(Token = "0x6001549")]
	[Address(RVA = "0x4D5510", Offset = "0x4D3B10", VA = "0x1804D5510", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_explode;
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x0007582C File Offset: 0x00073A2C
	[Token(Token = "0x600154A")]
	[Address(RVA = "0x4D6940", Offset = "0x4D4F40", VA = "0x1804D6940", Slot = "74")]
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

	// Token: 0x0600154B RID: 5451 RVA: 0x00075898 File Offset: 0x00073A98
	[Token(Token = "0x600154B")]
	[Address(RVA = "0x4D5520", Offset = "0x4D3B20", VA = "0x1804D5520", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num;
		int attackDamage;
		bool flag2;
		List<Zombie> list;
		int num2;
		int num3;
		do
		{
			num = 0;
			attackDamage = this.attackDamage;
			bool flag;
			if (flag)
			{
			}
			if (flag2)
			{
				this.flightTime = 0.75f;
			}
			list = new List();
			List<Zombie> zombieArray = this.board.zombieArray;
			num2 = 0;
			bool flag3;
			if (!flag3)
			{
				goto IL_0060;
			}
			num3 = 0;
		}
		while (!(num != num3) || !Thrower.ThrowSearchZombie(num));
		Transform axis = this.axis;
		IL_0060:
		if (num2 == 0)
		{
			int num4 = 0;
			bool flag4;
			if (!flag4)
			{
			}
			uint num5;
			if (global::UnityEngine.Random.Range(0, (int)num5) == 0)
			{
				int num6 = 0;
				Vector3 vector;
				float num7 = vector.z;
				num7 += num7;
				num6 += num6;
			}
			Dictionary<Zombie, int> dictionary = new Dictionary();
			int num10;
			int num12;
			if (flag2)
			{
				int size = list._size;
				if (size != 0)
				{
					bool flag5;
					int num9;
					if (size > dictionary)
					{
						if (flag5)
						{
							uint num8;
							dictionary[num] = num8;
						}
						if (num4 != 0)
						{
							throw new NullReferenceException();
						}
						num9 = 0;
					}
					bool flag6;
					if (flag6)
					{
						dictionary[num] = flag5;
					}
					if (num9 != 0)
					{
						throw new NullReferenceException();
					}
					num10 = 0;
					Func<Zombie, float> func;
					if (UltimateCabbageCannon.<>c.<>9__2_0 == 0)
					{
						UltimateCabbageCannon.<>c.<>9__2_0 = func;
					}
					Zombie zombie = Enumerable.ToList<Zombie>(Enumerable.OrderBy<Zombie, float>(list, func))[num10];
					int num11 = dictionary[zombie] + 1;
					dictionary[zombie] = num11;
					num10++;
					bool flag7;
					if (flag7)
					{
						goto IL_0219;
					}
					bool flag8;
					if (!flag8)
					{
						goto IL_0240;
					}
					Func<KeyValuePair<Zombie, int>, int> func2;
					if (UltimateCabbageCannon.<>c.<>9__2_3 == 0)
					{
						UltimateCabbageCannon.<>c.<>9__2_3 = func2;
					}
					num12 = Enumerable.Sum<KeyValuePair<Zombie, int>>(dictionary, func2);
					uint num13;
					num13 -= (uint)num12;
					uint num14;
					num12 = Mathf.Max((int)num13, (int)num14);
					int num15;
					if (num15 <= 50000)
					{
						goto IL_0240;
					}
					List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
					TravelMgr instance = TravelMgr.Instance;
					InGameText instance2 = InGameText.Instance;
				}
				float num16 = global::UnityEngine.Random.Range(0.9f, 1.2f);
				uint num17;
				GameAPP.PlaySound((int)num17, 0.5f, num16);
			}
			int num19;
			if (num12 == 0)
			{
				if (UltimateCabbageCannon.<>c.<>9__2_1 == 0)
				{
					Func<Zombie, float> func3;
					UltimateCabbageCannon.<>c.<>9__2_1 = func3;
				}
				IEnumerable<Zombie> enumerable;
				List<Zombie> list2 = Enumerable.ToList<Zombie>(enumerable);
				bool flag9;
				if (flag9)
				{
					uint num18;
					dictionary[num] = num18;
				}
				if (num10 != 0)
				{
					throw new NullReferenceException();
				}
				num19 = 0;
			}
			bool flag10;
			if (flag10)
			{
				uint num20;
				dictionary[num] = num20;
			}
			if (num19 != 0)
			{
				throw new NullReferenceException();
			}
			int num21 = 0;
			IL_0219:
			Func<KeyValuePair<Zombie, int>, int> func4;
			if (UltimateCabbageCannon.<>c.<>9__2_2 == 0)
			{
				UltimateCabbageCannon.<>c.<>9__2_2 = func4;
			}
			int num22 = Enumerable.Sum<KeyValuePair<Zombie, int>>(dictionary, func4);
			int num23 = attackDamage.MultiplyPercent(0.5f);
			IL_0240:
			Vector3 vector2;
			float z = vector2.z;
			Vector3 vector3;
			float z2 = vector3.z;
			bool flag11;
			if (flag11)
			{
				int num24 = 0;
				Plant plant;
				if (plant != num24)
				{
					Transform axis2 = plant.axis;
					CreateBullet instance3 = CreateBullet.Instance;
					Bullet bullet;
					bullet.Damage = num23;
				}
				CreateBullet instance4 = CreateBullet.Instance;
				int num25 = 0;
				Bullet bullet2;
				bullet2.Damage = num23;
				bullet2.fromType = (PlantType)num25;
				num21++;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00075B94 File Offset: 0x00073D94
	[Token(Token = "0x600154C")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public UltimateCabbageCannon()
	{
	}
}
