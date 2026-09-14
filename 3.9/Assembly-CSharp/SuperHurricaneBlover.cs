using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000464 RID: 1124
[Token(Token = "0x2000464")]
public class SuperHurricaneBlover : HurricaneBlover
{
	// Token: 0x060014B1 RID: 5297 RVA: 0x00072B08 File Offset: 0x00070D08
	[Token(Token = "0x60014B1")]
	[Address(RVA = "0x4CA620", Offset = "0x4C8C20", VA = "0x1804CA620", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 10f;
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x00072B28 File Offset: 0x00070D28
	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x4CA500", Offset = "0x4C8B00", VA = "0x1804CA500", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.attributeCountdown = 10f;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)43)))
		{
			this.attributeCountdown = 3f;
		}
		CreatePlant instance = CreatePlant.Instance;
		int num = this.thePlantColumn;
		num++;
		int num2 = 0;
		Plant plant;
		if (plant == num2)
		{
			base.Blow();
			return;
		}
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00072B88 File Offset: 0x00070D88
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x4C9E70", Offset = "0x4C8470", VA = "0x1804C9E70", Slot = "72")]
	protected override void AnimStartBlow()
	{
		int num;
		do
		{
			num = 0;
			base.AnimStartBlow();
			HashSet<int> hashSet = new HashSet();
			int thePlantRow = this.thePlantRow;
			bool flag = hashSet.Add(thePlantRow);
			int thePlantRow2 = this.thePlantRow;
			bool flag2 = hashSet.Add(thePlantRow2);
			int num2 = this.thePlantRow;
			num2++;
			bool flag3 = hashSet.Add(num2);
			int num3 = 0;
			List<Zombie> zombiesByRows = Lawnf.GetZombiesByRows(hashSet, num3 != 0);
			Func<Zombie, bool> func = delegate(Zombie z)
			{
				int column = z.Column;
				return z.theStatus != ZombieStatus.Miner_digging;
			};
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombiesByRows, func);
			Func<Zombie, bool> <>9__2_ = SuperHurricaneBlover.<>c.<>9__2_1;
			if (<>9__2_ == 0)
			{
				SuperHurricaneBlover.<>c.<>9__2_1 = (Zombie z) => z.theStatus == ZombieStatus.Flying || z.HasBuff((EffectType)((uint)12));
			}
			IOrderedEnumerable<Zombie> orderedEnumerable = Enumerable.OrderByDescending<Zombie, bool>(enumerable, <>9__2_);
			Func<Zombie, float> func2;
			if (SuperHurricaneBlover.<>c.<>9__2_2 == 0)
			{
				SuperHurricaneBlover.<>c.<>9__2_2 = func2;
			}
			uint num4;
			IEnumerable<Zombie> enumerable2 = Enumerable.Take<Zombie>(Enumerable.ThenBy<Zombie, float>(orderedEnumerable, func2), (int)num4);
			int num5 = 0;
			if (enumerable2 != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_00DA;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_00DA;
				}
				IL_010B:
				uint num6;
				num6 += num6;
				goto IL_0112;
				IL_00DA:
				bool flag4;
				if (flag4)
				{
				}
				bool flag5;
				Vector2 vector;
				if (flag5)
				{
					float fixedDeltaTime = Time.fixedDeltaTime;
					vector = Vector3Extensions.Add(num, num, num);
					if (!flag4 || num5 > (int)fixedDeltaTime)
					{
					}
				}
				while (vector == 0)
				{
				}
				goto IL_010B;
			}
			IL_0112:
			if ("{il2cpp array field local32->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x00072CD4 File Offset: 0x00070ED4
	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x4CA640", Offset = "0x4C8C40", VA = "0x1804CA640", Slot = "73")]
	protected override void BlowUpdate()
	{
		int num;
		do
		{
			num = 0;
			HashSet<int> hashSet = new HashSet();
			int thePlantRow = this.thePlantRow;
			bool flag = hashSet.Add(thePlantRow);
			int thePlantRow2 = this.thePlantRow;
			bool flag2 = hashSet.Add(thePlantRow2);
			int num2 = this.thePlantRow;
			num2++;
			bool flag3 = hashSet.Add(num2);
			int num3 = 0;
			List<Zombie> zombiesByRows = Lawnf.GetZombiesByRows(hashSet, num3 != 0);
			Func<Zombie, bool> func = delegate(Zombie z)
			{
				int column = z.Column;
				return z.theStatus != ZombieStatus.Miner_digging;
			};
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombiesByRows, func);
			Func<Zombie, bool> <>9__3_ = SuperHurricaneBlover.<>c.<>9__3_1;
			if (<>9__3_ == 0)
			{
				SuperHurricaneBlover.<>c.<>9__3_1 = (Zombie z) => z.theStatus == ZombieStatus.Flying || z.HasBuff((EffectType)((uint)12));
			}
			IOrderedEnumerable<Zombie> orderedEnumerable = Enumerable.OrderByDescending<Zombie, bool>(enumerable, <>9__3_);
			Func<Zombie, float> func2;
			if (SuperHurricaneBlover.<>c.<>9__3_2 == 0)
			{
				SuperHurricaneBlover.<>c.<>9__3_2 = func2;
			}
			uint num4;
			if (Enumerable.Take<Zombie>(Enumerable.ThenBy<Zombie, float>(orderedEnumerable, func2), (int)num4) != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_00CD;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_00CD;
				}
				IL_00EE:
				int num5;
				num5 += 312;
				goto IL_00F8;
				IL_00CD:
				bool flag4;
				if (flag4)
				{
				}
				bool flag5;
				bool flag6;
				if (!flag5 && !flag6)
				{
					num5 = 0;
					bool flag7;
					if (flag7)
					{
					}
				}
				float fixedDeltaTime = Time.fixedDeltaTime;
				goto IL_00EE;
			}
			IL_00F8:
			if ("{il2cpp array field local28->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x00072E00 File Offset: 0x00071000
	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public SuperHurricaneBlover()
	{
	}
}
