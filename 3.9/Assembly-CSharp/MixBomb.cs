using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000400 RID: 1024
[Token(Token = "0x2000400")]
public class MixBomb : Plant
{
	// Token: 0x060012E4 RID: 4836 RVA: 0x00069B20 File Offset: 0x00067D20
	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x4A9B10", Offset = "0x4A8110", VA = "0x1804A9B10", Slot = "10")]
	protected override void Awake()
	{
		int num = 0;
		base.Awake();
		base.AttributeCountdown = (float)num;
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x00069B3C File Offset: 0x00067D3C
	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x4A8F40", Offset = "0x4A7540", VA = "0x1804A8F40", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			base.Die((Plant.DieReason)((uint)2));
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			Board board = this.board;
			bool flag;
			if (flag)
			{
				MixBomb.<>c__DisplayClass1_0 CS$<>8__locals1;
				CS$<>8__locals1.plant = num;
				int theLevel = CS$<>8__locals1.plant.theLevel;
				if (theLevel - 1 > 1)
				{
					continue;
				}
				int thePlantColumn = this.thePlantColumn;
				int thePlantRow2 = this.thePlantRow;
				List<Plant> list2 = global::Lawnf.Get1x1Plants(thePlantColumn, thePlantRow2);
				int num3 = this.thePlantColumn;
				num3++;
				int thePlantRow3 = this.thePlantRow;
				List<Plant> list3 = global::Lawnf.Get1x1Plants(num3, thePlantRow3);
				Func<Plant, bool> func = delegate(Plant p)
				{
					PlantType thePlantType = CS$<>8__locals1.plant.thePlantType;
					if (p.thePlantType != thePlantType)
					{
					}
					int theLevel2 = CS$<>8__locals1.plant.theLevel;
					return p.theLevel == theLevel2;
				};
				Plant plant = Enumerable.FirstOrDefault<Plant>(list2, func);
				Func<Plant, bool> func2 = delegate(Plant p)
				{
					PlantType thePlantType2 = CS$<>8__locals1.plant.thePlantType;
					if (p.thePlantType != thePlantType2)
					{
					}
					int theLevel3 = CS$<>8__locals1.plant.theLevel;
					return p.theLevel == theLevel3;
				};
				Plant plant2 = Enumerable.FirstOrDefault<Plant>(list3, func2);
				int num4 = 0;
				if (plant != num4)
				{
					int num5 = 0;
					if (plant2 != num5)
					{
						CS$<>8__locals1.plant.Die((Plant.DieReason)((uint)4));
						plant.Die((Plant.DieReason)((uint)4));
						plant2.Die((Plant.DieReason)((uint)4));
						CreatePlant instance = CreatePlant.Instance;
						Plant plant3 = CS$<>8__locals1.plant;
						int num6 = 0;
						Plant plant4;
						if (!(plant4 != num6))
						{
							continue;
						}
						int num7 = theLevel + 1;
						int num8 = 0;
						bool flag2 = plant4.Upgrade(num7, true, num8 != 0);
						plant4.imitatless = true;
					}
				}
				InGameText instance2 = InGameText.Instance;
			}
			if (num2 != 0)
			{
				goto IL_027C;
			}
			bool flag3;
			if (flag3)
			{
				Dictionary<PlantType, List<PlantType>> recipe = MixBomb.Recipe;
				bool flag4;
				while (!flag4)
				{
				}
				int num9 = 0;
				Plant plant5;
				if (plant5 != num9)
				{
					int num10 = 0;
					Plant plant6;
					if (plant6 != num10)
					{
						int num11 = 0;
						plant5.Die((Plant.DieReason)num11);
						int num12 = 0;
						plant6.Die((Plant.DieReason)num12);
						GameAPP.PlaySound(125, 0.5f, 1f);
					}
				}
				InGameText instance3 = InGameText.Instance;
				string text2;
				string text3;
				string text4;
				string text = string.Concat(new string[] { "请按左中右的顺序放置以下植物\n", text2, "，", text3, "，", text4 });
			}
		}
		while (num2 != 0);
		ulong num13;
		if (num13 == (ulong)0L)
		{
		}
		return;
		IL_027C:
		throw new NullReferenceException();
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x00069E34 File Offset: 0x00068034
	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public MixBomb()
	{
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x00069E48 File Offset: 0x00068048
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x4A9B40", Offset = "0x4A8140", VA = "0x1804A9B40")]
	static MixBomb()
	{
		Dictionary<PlantType, List<PlantType>> dictionary = new Dictionary();
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		dictionary.Add((uint)14, list);
		List<PlantType> list2 = new List();
		int size4 = list2._size;
		int size5 = list2._size;
		int size6 = list2._size;
		dictionary.Add((uint)25, list2);
		List<PlantType> list3 = new List();
		int size7 = list3._size;
		int size8 = list3._size;
		int size9 = list3._size;
		dictionary.Add((uint)5, list3);
		List<PlantType> list4 = new List();
		int size10 = list4._size;
		int size11 = list4._size;
		int size12 = list4._size;
		dictionary.Add((uint)19, list4);
		List<PlantType> list5 = new List();
		int size13 = list5._size;
		int size14 = list5._size;
		int size15 = list5._size;
		dictionary.Add((uint)28, list5);
		List<PlantType> list6 = new List();
		int size16 = list6._size;
		int size17 = list6._size;
		int size18 = list6._size;
		dictionary.Add((uint)1027, list6);
		List<PlantType> list7 = new List();
		int size19 = list7._size;
		int size20 = list7._size;
		int size21 = list7._size;
		dictionary.Add((uint)1070, list7);
		List<PlantType> list8 = new List();
		int size22 = list8._size;
		int size23 = list8._size;
		int size24 = list8._size;
		dictionary.Add((uint)26, list8);
		List<PlantType> list9 = new List();
		int size25 = list9._size;
		int size26 = list9._size;
		int size27 = list9._size;
		dictionary.Add((uint)990, list9);
		MixBomb.Recipe = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x04000C8F RID: 3215
	[Token(Token = "0x4000C8F")]
	public static readonly Dictionary<PlantType, List<PlantType>> Recipe;
}
