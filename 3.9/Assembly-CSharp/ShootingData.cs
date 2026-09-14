using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A00 RID: 2560
[Token(Token = "0x2000A00")]
public static class ShootingData
{
	// Token: 0x0600349F RID: 13471 RVA: 0x001153D4 File Offset: 0x001135D4
	[Token(Token = "0x600349F")]
	[Address(RVA = "0x7767F0", Offset = "0x774DF0", VA = "0x1807767F0")]
	public static List<PlantType> GetPlants(ChallengeLevel level)
	{
		List<PlantType> list = new List();
		if (level == ChallengeLevel.Shooting6)
		{
			List<PlantType> list2 = new List();
			int size = list2._size;
			list2._size = list2;
			int size2 = list2._size;
			list2._size = list2;
			int size3 = list2._size;
			list2._size = list2;
			int size4 = list2._size;
			list2._size = list2;
			int size5 = list2._size;
			return list2;
		}
		if (level == ChallengeLevel.Shooting7)
		{
			List<PlantType> list3 = new List();
			int size6 = list3._size;
			list3._size = list3;
			int size7 = list3._size;
			list3._size = list3;
			int size8 = list3._size;
			list3._size = list3;
		}
		while (level != ChallengeLevel.Shooting8)
		{
		}
		return new List();
	}

	// Token: 0x060034A0 RID: 13472 RVA: 0x001154A4 File Offset: 0x001136A4
	[Token(Token = "0x60034A0")]
	[Address(RVA = "0x776100", Offset = "0x774700", VA = "0x180776100")]
	public static bool Chess(CardUI card)
	{
		int i;
		do
		{
			int num = 0;
			PlantType thePlantType = card.thePlantType;
			List<List<PlantType>> upgradeRoute_Chess = ShootingData.UpgradeRoute_Chess;
			i = 0;
			bool flag;
			if (flag)
			{
				PlantType plantType;
				if (card.thePlantType == plantType)
				{
					continue;
				}
				while (i >= (int)plantType)
				{
				}
				PlantType plantType2;
				if (plantType2 != thePlantType)
				{
				}
				if (PlantType.SunFlower != plantType2)
				{
				}
				int num2 = 0;
				List<Plant> list;
				PlantType thePlantType2 = list[num2].thePlantType;
				if (thePlantType2 <= PlantType.ThreeSquash)
				{
					goto IL_009C;
				}
				int num3;
				if (thePlantType2 == PlantType.SilverCabbage)
				{
					bool flag2;
					if (flag2)
					{
					}
					if (i != 0)
					{
						goto IL_00D7;
					}
					num3 = 0;
				}
				int num4;
				if (num == 1135)
				{
					bool flag3;
					if (flag3)
					{
					}
					if (num3 != 0)
					{
						goto IL_00DD;
					}
					num4 = 0;
				}
				if (num == 1189)
				{
					bool flag4;
					if (flag4)
					{
					}
					if (num4 == 0)
					{
						int num5 = 0;
						goto IL_009C;
					}
					goto IL_00E3;
				}
				IL_00BE:
				int num6;
				if (num6 == 0)
				{
					goto IL_00C3;
				}
				goto IL_00F5;
				IL_009C:
				if (num == 1039)
				{
					bool flag5;
					if (flag5)
					{
					}
					int num5;
					if (num5 != 0)
					{
						goto IL_00E9;
					}
					num6 = 0;
				}
				bool flag6;
				if (num != 1047 || flag6)
				{
					goto IL_00BE;
				}
				goto IL_00BE;
			}
			IL_00C3:;
		}
		while (i != 0);
		throw new NullReferenceException();
		IL_00D7:
		throw new NullReferenceException();
		IL_00DD:
		throw new NullReferenceException();
		IL_00E3:
		throw new NullReferenceException();
		IL_00E9:
		throw new NullReferenceException();
		IL_00F5:
		throw new NullReferenceException();
	}

	// Token: 0x060034A1 RID: 13473 RVA: 0x001155B4 File Offset: 0x001137B4
	[Token(Token = "0x60034A1")]
	[Address(RVA = "0x7772A0", Offset = "0x7758A0", VA = "0x1807772A0")]
	public static bool Shooting6(CardUI card)
	{
		int i;
		do
		{
			int num = 0;
			List<Plant> list = new List();
			PlantType thePlantType = card.thePlantType;
			ShootingData.<>c__DisplayClass10_0 CS$<>8__locals1;
			CS$<>8__locals1.thePlantType = thePlantType;
			List<List<PlantType>> upgradeRoute_ = ShootingData.UpgradeRoute_6;
			i = 0;
			bool flag;
			if (flag)
			{
				PlantType plantType;
				if (card.thePlantType != plantType)
				{
					while (i >= (int)plantType)
					{
					}
					PlantType plantType2;
					if (plantType2 != CS$<>8__locals1.thePlantType)
					{
					}
					if (PlantType.SunFlower != plantType2)
					{
					}
					int num2 = 0;
					List<Plant> list2;
					PlantType thePlantType2 = list2[num2].thePlantType;
					if (thePlantType2 <= PlantType.SplitPea)
					{
						goto IL_00C1;
					}
					int num3;
					if (thePlantType2 > PlantType.IronStar)
					{
						if (thePlantType2 == PlantType.SniperPea)
						{
							goto IL_0103;
						}
						if (thePlantType2 == PlantType.MelonFume)
						{
							goto IL_0113;
						}
						if (thePlantType2 != PlantType.PortalNut)
						{
							goto IL_00C1;
						}
						bool flag2;
						if (flag2)
						{
						}
						if (i != 0)
						{
							goto IL_019B;
						}
						num3 = 0;
					}
					if (num != 1093 && num != 1096)
					{
						goto IL_00C1;
					}
					IL_0133:
					bool flag3;
					if (flag3)
					{
					}
					int num4;
					if (num4 == 0)
					{
						goto IL_0140;
					}
					goto IL_01BF;
					IL_0123:
					bool flag4;
					if (flag4)
					{
					}
					int num5;
					if (num5 == 0)
					{
						num4 = 0;
						goto IL_0133;
					}
					goto IL_01B9;
					IL_0113:
					bool flag5;
					if (flag5)
					{
					}
					int num6;
					if (num6 == 0)
					{
						num5 = 0;
						goto IL_0123;
					}
					goto IL_01B3;
					IL_0103:
					bool flag6;
					if (flag6)
					{
					}
					int num7;
					if (num7 == 0)
					{
						num6 = 0;
						goto IL_0113;
					}
					goto IL_01AD;
					IL_00C1:
					if (num <= 1030 || (num != 1032 && num != 1090))
					{
						if (num == 946)
						{
							goto IL_0123;
						}
						while (num != 1030)
						{
						}
					}
					bool flag7;
					if (flag7)
					{
						float num8 = (float)(i * (int)1.5f);
					}
					if (num3 == 0)
					{
						num7 = 0;
						goto IL_0103;
					}
					goto IL_01A7;
				}
				IL_0140:
				List<Plant> plantHead = Board.Instance.boardEntity.plantHead;
				Func<Plant, bool> func;
				if (CS$<>8__locals1.<>9__0 == 0)
				{
					func = delegate(Plant p)
					{
						PlantType thePlantType3 = CS$<>8__locals1.thePlantType;
						return p.thePlantType == thePlantType3;
					};
					CS$<>8__locals1.<>9__0 = func;
				}
				if (!Enumerable.FirstOrDefault<Plant>(plantHead, func))
				{
					ShootingData.ResurrectionPlant(card);
				}
			}
		}
		while (i != 0);
		throw new NullReferenceException();
		IL_019B:
		throw new NullReferenceException();
		IL_01A7:
		throw new NullReferenceException();
		IL_01AD:
		throw new NullReferenceException();
		IL_01B3:
		throw new NullReferenceException();
		IL_01B9:
		throw new NullReferenceException();
		IL_01BF:
		throw new NullReferenceException();
	}

	// Token: 0x060034A2 RID: 13474 RVA: 0x0011579C File Offset: 0x0011399C
	[Token(Token = "0x60034A2")]
	[Address(RVA = "0x7786C0", Offset = "0x776CC0", VA = "0x1807786C0")]
	public static bool Shooting8(CardUI card)
	{
		int i;
		do
		{
			List<Plant> list = new List();
			PlantType thePlantType = card.thePlantType;
			ShootingData.<>c__DisplayClass11_0 CS$<>8__locals1;
			CS$<>8__locals1.thePlantType = thePlantType;
			List<List<PlantType>> upgradeRoute_ = ShootingData.UpgradeRoute_8;
			i = 0;
			bool flag;
			if (flag)
			{
				PlantType plantType;
				if (card.thePlantType != plantType)
				{
					while (i >= (int)plantType)
					{
					}
					PlantType plantType2;
					if (plantType2 != CS$<>8__locals1.thePlantType)
					{
					}
					if (PlantType.SunFlower != plantType2)
					{
					}
					bool flag2;
					if (flag2)
					{
					}
					if (i != 0)
					{
						goto IL_018C;
					}
					int num = 0;
					int num2 = 0;
					List<Plant> list2;
					Plant plant = list2[num2];
					PlantType thePlantType2 = plant.thePlantType;
					if (thePlantType2 <= PlantType.CobCannon)
					{
						goto IL_00A3;
					}
					if (thePlantType2 != PlantType.MelonCannon)
					{
						if (thePlantType2 == PlantType.FireNut)
						{
							goto IL_00BA;
						}
						if (thePlantType2 != PlantType.CabbageCannon)
						{
							goto IL_00A3;
						}
						goto IL_00F4;
					}
					IL_0114:
					bool flag3;
					if (flag3)
					{
					}
					int num3;
					if (num3 != 0)
					{
						goto IL_01BC;
					}
					int num4 = 0;
					bool flag4;
					if (flag4)
					{
					}
					if (num4 == 0)
					{
						goto IL_0131;
					}
					goto IL_01C2;
					IL_00F4:
					bool flag5;
					if (flag5)
					{
					}
					int num5;
					if (num5 != 0)
					{
						goto IL_01B0;
					}
					int num6 = 0;
					bool flag6;
					if (flag6)
					{
					}
					if (num6 == 0)
					{
						num3 = 0;
						goto IL_0114;
					}
					goto IL_01B6;
					IL_00DD:
					bool flag7;
					if (flag7)
					{
						flag7 += flag7;
					}
					int num7;
					if (num7 == 0)
					{
						num5 = 0;
						goto IL_00F4;
					}
					goto IL_01AA;
					IL_00BA:
					bool flag8;
					if (flag8)
					{
					}
					int num8;
					if (num8 != 0)
					{
						goto IL_019E;
					}
					int num9 = 0;
					bool flag9;
					if (flag9)
					{
					}
					if (num9 == 0)
					{
						num7 = 0;
						goto IL_00DD;
					}
					goto IL_01A4;
					IL_00A3:
					if (plant > (ulong)6L)
					{
						goto IL_00DD;
					}
					bool flag10;
					if (flag10)
					{
					}
					if (num == 0)
					{
						num8 = 0;
						goto IL_00BA;
					}
					goto IL_0198;
				}
				IL_0131:
				List<Plant> plantHead = Board.Instance.boardEntity.plantHead;
				Func<Plant, bool> func;
				if (CS$<>8__locals1.<>9__0 == 0)
				{
					func = delegate(Plant p)
					{
						PlantType thePlantType3 = CS$<>8__locals1.thePlantType;
						return p.thePlantType == thePlantType3;
					};
					CS$<>8__locals1.<>9__0 = func;
				}
				if (!Enumerable.FirstOrDefault<Plant>(plantHead, func))
				{
					ShootingData.ResurrectionPlant(card);
				}
			}
		}
		while (i != 0);
		throw new NullReferenceException();
		IL_018C:
		throw new NullReferenceException();
		IL_0198:
		throw new NullReferenceException();
		IL_019E:
		throw new NullReferenceException();
		IL_01A4:
		throw new NullReferenceException();
		IL_01AA:
		throw new NullReferenceException();
		IL_01B0:
		throw new NullReferenceException();
		IL_01B6:
		throw new NullReferenceException();
		IL_01BC:
		throw new NullReferenceException();
		IL_01C2:
		throw new NullReferenceException();
	}

	// Token: 0x060034A3 RID: 13475 RVA: 0x00115984 File Offset: 0x00113B84
	[Token(Token = "0x60034A3")]
	[Address(RVA = "0x777C50", Offset = "0x776250", VA = "0x180777C50")]
	public static bool Shooting7(CardUI card)
	{
		int i;
		do
		{
			List<Plant> list = new List();
			PlantType thePlantType = card.thePlantType;
			ShootingData.<>c__DisplayClass12_0 CS$<>8__locals1;
			CS$<>8__locals1.thePlantType = thePlantType;
			List<List<PlantType>> upgradeRoute_ = ShootingData.UpgradeRoute_7;
			i = 0;
			bool flag;
			if (flag)
			{
				PlantType plantType;
				if (card.thePlantType != plantType)
				{
					while (i >= (int)plantType)
					{
					}
					PlantType plantType2;
					if (plantType2 != CS$<>8__locals1.thePlantType)
					{
					}
					if (PlantType.SunFlower != plantType2)
					{
					}
					int num = 0;
					List<Plant> list2;
					PlantType thePlantType2 = list2[num].thePlantType;
					if (thePlantType2 <= PlantType.CobCannon)
					{
						goto IL_00AD;
					}
					if (thePlantType2 > PlantType.SuperGatling)
					{
						if (thePlantType2 == PlantType.BigChomper)
						{
							goto IL_00F5;
						}
						if (thePlantType2 == PlantType.SuperThreeGatling)
						{
							goto IL_0115;
						}
						if (thePlantType2 == PlantType.TorchSunflower)
						{
							goto IL_00C4;
						}
					}
					if (thePlantType2 == PlantType.FireCannon)
					{
						goto IL_00D4;
					}
					if (thePlantType2 != PlantType.SuperGatling)
					{
						goto IL_00AD;
					}
					goto IL_0105;
					IL_0115:
					bool flag2;
					if (flag2)
					{
					}
					int num2;
					if (num2 == 0)
					{
						goto IL_0122;
					}
					goto IL_01A7;
					IL_0105:
					bool flag3;
					if (flag3)
					{
					}
					int num3;
					if (num3 == 0)
					{
						num2 = 0;
						goto IL_0115;
					}
					goto IL_019B;
					IL_00F5:
					bool flag4;
					if (flag4)
					{
					}
					int num4;
					if (num4 == 0)
					{
						num3 = 0;
						goto IL_0105;
					}
					goto IL_0195;
					IL_00D4:
					bool flag5;
					int num6;
					if (flag5)
					{
						float num5 = (float)(num6 * (int)6f);
						flag5 += flag5;
					}
					int num7;
					if (num7 == 0)
					{
						num4 = 0;
						goto IL_00F5;
					}
					goto IL_018F;
					IL_00C4:
					bool flag6;
					if (flag6)
					{
					}
					if (num6 == 0)
					{
						num7 = 0;
						goto IL_00D4;
					}
					goto IL_0189;
					IL_00AD:
					bool flag7;
					if (flag7)
					{
						flag7 += flag7;
					}
					if (i == 0)
					{
						num6 = 0;
						goto IL_00C4;
					}
					goto IL_0183;
				}
				IL_0122:
				List<Plant> plantHead = Board.Instance.boardEntity.plantHead;
				Func<Plant, bool> func;
				if (CS$<>8__locals1.<>9__0 == 0)
				{
					func = delegate(Plant p)
					{
						PlantType thePlantType3 = CS$<>8__locals1.thePlantType;
						return p.thePlantType == thePlantType3;
					};
					CS$<>8__locals1.<>9__0 = func;
				}
				if (!Enumerable.FirstOrDefault<Plant>(plantHead, func))
				{
					ShootingData.ResurrectionPlant(card);
				}
			}
		}
		while (i != 0);
		throw new NullReferenceException();
		IL_0183:
		throw new NullReferenceException();
		IL_0189:
		throw new NullReferenceException();
		IL_018F:
		throw new NullReferenceException();
		IL_0195:
		throw new NullReferenceException();
		IL_019B:
		throw new NullReferenceException();
		IL_01A7:
		throw new NullReferenceException();
	}

	// Token: 0x060034A4 RID: 13476 RVA: 0x00115B54 File Offset: 0x00113D54
	[Token(Token = "0x60034A4")]
	[Address(RVA = "0x7792F0", Offset = "0x7778F0", VA = "0x1807792F0")]
	private static List<Plant> TurnPlantsToNewPlants(CardUI card, PlantType newType, PlantType nextType)
	{
		int num = 0;
		int num2 = 0;
		List<Plant> list = new List();
		List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
		bool flag;
		if (flag)
		{
			int num3 = 0;
			bool flag2 = num != num3;
			while (!flag2)
			{
			}
			while ((flag2 ? PlantType.SunFlower : PlantType.Peashooter) != card.thePlantType)
			{
			}
		}
		if (num2 == 0)
		{
			return new List();
		}
		throw new NullReferenceException();
	}

	// Token: 0x060034A5 RID: 13477 RVA: 0x00115C78 File Offset: 0x00113E78
	[Token(Token = "0x60034A5")]
	[Address(RVA = "0x775F90", Offset = "0x774590", VA = "0x180775F90")]
	public static void ChangeCost(PlantType theSeedType, CardUI card)
	{
		int theBoardLevel = GameAPP.theBoardLevel;
		if (theBoardLevel > 131)
		{
			if (theBoardLevel == 159)
			{
			}
			if (theBoardLevel != 170)
			{
				goto IL_0024;
			}
		}
		Dictionary<PlantType, int> upgradeCost_Chess = ShootingData.UpgradeCost_Chess;
		IL_0024:
		bool flag;
		if (flag)
		{
			ulong num;
			card.theSeedCost = (int)num;
		}
	}

	// Token: 0x060034A6 RID: 13478 RVA: 0x00115CBC File Offset: 0x00113EBC
	[Token(Token = "0x60034A6")]
	[Address(RVA = "0x776C30", Offset = "0x775230", VA = "0x180776C30")]
	private static void ResurrectionPlant(CardUI card)
	{
		for (;;)
		{
			int num = 0;
			Board instance = Board.Instance;
			int num2 = 0;
			if (instance != num2)
			{
				Board instance2 = Board.Instance;
			}
			Dictionary<PlantType, int> upgradeCost_ = ShootingData.UpgradeCost_6;
			int theBoardLevel = GameAPP.theBoardLevel;
			if (theBoardLevel <= 131)
			{
				goto IL_0055;
			}
			if (theBoardLevel == 159)
			{
			}
			if (theBoardLevel == 170)
			{
				List<List<PlantType>> upgradeRoute_ = ShootingData.UpgradeRoute_8;
				goto IL_0055;
			}
			IL_005C:
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
					PlantType thePlantType = card.thePlantType;
				}
				if (num != 0)
				{
					goto IL_00EE;
				}
			}
			if (num == 0)
			{
				break;
			}
			continue;
			IL_0055:
			Dictionary<PlantType, int> upgradeCost_Chess = ShootingData.UpgradeCost_Chess;
			goto IL_005C;
		}
		int num3 = 0;
		Board instance3 = Board.Instance;
		if (num3 < instance3.columnNum)
		{
			Board instance4 = Board.Instance;
			if (num3 < instance4.rowNum)
			{
				CreatePlant instance5 = CreatePlant.Instance;
				int num4 = 0;
				Plant plant;
				if (plant != num4)
				{
					goto IL_00C8;
				}
				num3++;
			}
			num3++;
			IL_00C8:
			Board.Instance.UseSun(100f);
		}
		return;
		IL_00EE:
		throw new NullReferenceException();
	}

	// Token: 0x060034A7 RID: 13479 RVA: 0x00115DC0 File Offset: 0x00113FC0
	[Token(Token = "0x60034A7")]
	[Address(RVA = "0x775D30", Offset = "0x774330", VA = "0x180775D30")]
	private static void ChangeCardSprite(PlantType theSeedType, CardUI card)
	{
		Transform transform = card.transform;
		int num = 0;
		Image component = transform.GetChild(num).GetComponent<Image>();
		Transform transform2 = card.transform;
		int num2 = 0;
		RectTransform component2 = transform2.GetChild(num2).GetComponent<RectTransform>();
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			component.sprite = sprite;
		}
		component.SetNativeSize();
		Vector2 sizeDelta = component2.sizeDelta;
		int num3 = 0;
		Vector2 sizeDelta2 = component2.sizeDelta;
		component2.sizeDelta = num3;
	}

	// Token: 0x060034A8 RID: 13480 RVA: 0x00115E4C File Offset: 0x0011404C
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60034A8")]
	[Address(RVA = "0x7799F0", Offset = "0x777FF0", VA = "0x1807799F0")]
	static ShootingData()
	{
		List<List<PlantType>> list = new List();
		List<PlantType> list2 = new List();
		int size = list2._size;
		int size2 = list2._size;
		int size3 = list2._size;
		int size4 = list2._size;
		int size5 = list._size;
		list2._syncRoot = list2;
		List<PlantType> list3 = new List();
		int size6 = list3._size;
		int size7 = list3._size;
		int size8 = list3._size;
		int size9 = list3._size;
		int size10 = list._size;
		list3._syncRoot = list3;
		List<PlantType> list4 = new List();
		int size11 = list4._size;
		int size12 = list4._size;
		int size13 = list4._size;
		int size14 = list4._size;
		int size15 = list._size;
		list4._syncRoot = list4;
		List<PlantType> list5 = new List();
		int size16 = list5._size;
		int size17 = list5._size;
		int size18 = list5._size;
		int size19 = list._size;
		list5._syncRoot = list5;
		List<PlantType> list6 = new List();
		int size20 = list6._size;
		int size21 = list6._size;
		int size22 = list6._size;
		int size23 = list._size;
		list6._syncRoot = list6;
		ShootingData.UpgradeRoute_8 = list;
		ShootingData.UpgradeCost_8 = new Dictionary();
		List<List<PlantType>> list7 = new List();
		List<PlantType> list8 = new List();
		int size24 = list8._size;
		int size25 = list8._size;
		int size26 = list8._size;
		int size27 = list8._size;
		int size28 = list7._size;
		list8._syncRoot = list8;
		List<PlantType> list9 = new List();
		int size29 = list9._size;
		int size30 = list9._size;
		int size31 = list9._size;
		int size32 = list7._size;
		list9._syncRoot = list9;
		List<PlantType> list10 = new List();
		int size33 = list10._size;
		int size34 = list10._size;
		List<PlantType> list11 = new List();
		ShootingData.UpgradeRoute_7 = list7;
		ShootingData.UpgradeCost_7 = new Dictionary();
		List<List<PlantType>> list12 = new List();
		List<PlantType> list13 = new List();
		List<PlantType> list14 = new List();
		List<PlantType> list15 = new List();
	}

	// Token: 0x0400260D RID: 9741
	[Token(Token = "0x400260D")]
	public static readonly List<List<PlantType>> UpgradeRoute_8;

	// Token: 0x0400260E RID: 9742
	[Token(Token = "0x400260E")]
	private static readonly Dictionary<PlantType, int> UpgradeCost_8;

	// Token: 0x0400260F RID: 9743
	[Token(Token = "0x400260F")]
	public static readonly List<List<PlantType>> UpgradeRoute_7;

	// Token: 0x04002610 RID: 9744
	[Token(Token = "0x4002610")]
	private static readonly Dictionary<PlantType, int> UpgradeCost_7;

	// Token: 0x04002611 RID: 9745
	[Token(Token = "0x4002611")]
	public static readonly List<List<PlantType>> UpgradeRoute_6;

	// Token: 0x04002612 RID: 9746
	[Token(Token = "0x4002612")]
	private static readonly Dictionary<PlantType, int> UpgradeCost_6;

	// Token: 0x04002613 RID: 9747
	[Token(Token = "0x4002613")]
	public static readonly List<List<PlantType>> UpgradeRoute_Chess;

	// Token: 0x04002614 RID: 9748
	[Token(Token = "0x4002614")]
	private static readonly Dictionary<PlantType, int> UpgradeCost_Chess;
}
