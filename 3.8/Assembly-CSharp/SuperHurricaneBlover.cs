using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000444 RID: 1092
[Token(Token = "0x2000444")]
public class SuperHurricaneBlover : HurricaneBlover
{
	// Token: 0x06001421 RID: 5153 RVA: 0x0007081C File Offset: 0x0006EA1C
	[Token(Token = "0x6001421")]
	[Address(RVA = "0x472D70", Offset = "0x471370", VA = "0x180472D70", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 10f;
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0007083C File Offset: 0x0006EA3C
	[Token(Token = "0x6001422")]
	[Address(RVA = "0x472C50", Offset = "0x471250", VA = "0x180472C50", Slot = "40")]
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

	// Token: 0x06001423 RID: 5155 RVA: 0x0007089C File Offset: 0x0006EA9C
	[Token(Token = "0x6001423")]
	[Address(RVA = "0x4725C0", Offset = "0x470BC0", VA = "0x1804725C0", Slot = "73")]
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
			Func<Zombie, bool> func;
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(Lawnf.GetZombiesByRows(hashSet, num3 != 0), func);
			Func<Zombie, bool> <>9__2_ = SuperHurricaneBlover.<>c.<>9__2_1;
			if (<>9__2_ == 0)
			{
				Func<Zombie, bool> func2;
				SuperHurricaneBlover.<>c.<>9__2_1 = func2;
			}
			IOrderedEnumerable<Zombie> orderedEnumerable = Enumerable.OrderBy<Zombie, bool>(enumerable, <>9__2_);
			Func<Zombie, float> func3;
			if (SuperHurricaneBlover.<>c.<>9__2_2 == 0)
			{
				SuperHurricaneBlover.<>c.<>9__2_2 = func3;
			}
			uint num4;
			IEnumerable<Zombie> enumerable2 = Enumerable.Take<Zombie>(Enumerable.ThenBy<Zombie, float>(orderedEnumerable, func3), (int)num4);
			int num5 = 0;
			if (enumerable2 != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_00BA;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_00BA;
				}
				IL_00EB:
				uint num6;
				num6 += num6;
				goto IL_00F2;
				IL_00BA:
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
				goto IL_00EB;
			}
			IL_00F2:
			if ("{il2cpp array field local32->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x000709C8 File Offset: 0x0006EBC8
	[Token(Token = "0x6001424")]
	[Address(RVA = "0x472D90", Offset = "0x471390", VA = "0x180472D90", Slot = "74")]
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
			Func<Zombie, bool> func;
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(Lawnf.GetZombiesByRows(hashSet, num3 != 0), func);
			Func<Zombie, bool> <>9__3_ = SuperHurricaneBlover.<>c.<>9__3_1;
			if (<>9__3_ == 0)
			{
				Func<Zombie, bool> func2;
				SuperHurricaneBlover.<>c.<>9__3_1 = func2;
			}
			IOrderedEnumerable<Zombie> orderedEnumerable = Enumerable.OrderBy<Zombie, bool>(enumerable, <>9__3_);
			Func<Zombie, float> func3;
			if (SuperHurricaneBlover.<>c.<>9__3_2 == 0)
			{
				SuperHurricaneBlover.<>c.<>9__3_2 = func3;
			}
			uint num4;
			if (Enumerable.Take<Zombie>(Enumerable.ThenBy<Zombie, float>(orderedEnumerable, func3), (int)num4) != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_00AD;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_00AD;
				}
				IL_00CE:
				int num5;
				num5 += 312;
				goto IL_00D8;
				IL_00AD:
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
				goto IL_00CE;
			}
			IL_00D8:
			if ("{il2cpp array field local28->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x00070AD4 File Offset: 0x0006ECD4
	[Token(Token = "0x6001425")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public SuperHurricaneBlover()
	{
	}
}
