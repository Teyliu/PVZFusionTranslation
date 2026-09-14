using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003E8 RID: 1000
[Token(Token = "0x20003E8")]
public class MixBomb : Plant
{
	// Token: 0x06001277 RID: 4727 RVA: 0x00067EE4 File Offset: 0x000660E4
	[Token(Token = "0x6001277")]
	[Address(RVA = "0x454BA0", Offset = "0x4531A0", VA = "0x180454BA0", Slot = "10")]
	protected override void Awake()
	{
		int num = 0;
		base.Awake();
		base.AttributeCountdown = (float)num;
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x00067F00 File Offset: 0x00066100
	[Token(Token = "0x6001278")]
	[Address(RVA = "0x454000", Offset = "0x452600", VA = "0x180454000", Slot = "40")]
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
				Func<Plant, bool> func;
				Plant plant = Enumerable.FirstOrDefault<Plant>(list2, func);
				Func<Plant, bool> func2;
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
				int num9 = 0;
				instance2.ShowText("左右两边必须有同等级的相同植物才能升级", 3f, num9 != 0);
			}
			if (num2 != 0)
			{
				goto IL_0287;
			}
			bool flag3;
			if (flag3)
			{
				Dictionary<PlantType, List<PlantType>> recipe = MixBomb.Recipe;
				bool flag4;
				while (!flag4)
				{
				}
				int num10 = 0;
				Plant plant5;
				if (plant5 != num10)
				{
					int num11 = 0;
					Plant plant6;
					if (plant6 != num11)
					{
						int num12 = 0;
						plant5.Die((Plant.DieReason)num12);
						int num13 = 0;
						plant6.Die((Plant.DieReason)num13);
						GameAPP.PlaySound(125, 0.5f, 1f);
					}
				}
				InGameText instance3 = InGameText.Instance;
				string text2;
				string text3;
				string text4;
				string text = string.Concat(new string[] { "请按左中右的顺序放置以下植物\n", text2, "，", text3, "，", text4 });
				int num14 = 0;
				instance3.ShowText(text, 5f, num14 != 0);
			}
		}
		while (num2 != 0);
		ulong num15;
		if (num15 == (ulong)0L)
		{
		}
		return;
		IL_0287:
		throw new NullReferenceException();
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x00068200 File Offset: 0x00066400
	[Token(Token = "0x6001279")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public MixBomb()
	{
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x00068214 File Offset: 0x00066414
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600127A")]
	[Address(RVA = "0x454BD0", Offset = "0x4531D0", VA = "0x180454BD0")]
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

	// Token: 0x04000C1A RID: 3098
	[Token(Token = "0x4000C1A")]
	public static readonly Dictionary<PlantType, List<PlantType>> Recipe;
}
