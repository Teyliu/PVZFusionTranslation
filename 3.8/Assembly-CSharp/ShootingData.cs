using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009C4 RID: 2500
[Token(Token = "0x20009C4")]
public static class ShootingData
{
	// Token: 0x0600336B RID: 13163 RVA: 0x001103F4 File Offset: 0x0010E5F4
	[Token(Token = "0x600336B")]
	[Address(RVA = "0x7112C0", Offset = "0x70F8C0", VA = "0x1807112C0")]
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

	// Token: 0x0600336C RID: 13164 RVA: 0x001104C4 File Offset: 0x0010E6C4
	[Token(Token = "0x600336C")]
	[Address(RVA = "0x710BD0", Offset = "0x70F1D0", VA = "0x180710BD0")]
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

	// Token: 0x0600336D RID: 13165 RVA: 0x001105D4 File Offset: 0x0010E7D4
	[Token(Token = "0x600336D")]
	[Address(RVA = "0x711D70", Offset = "0x710370", VA = "0x180711D70")]
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
							goto IL_018A;
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
						goto IL_013D;
					}
					goto IL_01AE;
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
					goto IL_01A8;
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
					goto IL_01A2;
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
					goto IL_019C;
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
					goto IL_0196;
				}
				IL_013D:
				List<Plant> plantHead = Board.Instance.boardEntity.plantHead;
				Func<Plant, bool> func;
				if (CS$<>8__locals1.<>9__0 == 0)
				{
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
		IL_018A:
		throw new NullReferenceException();
		IL_0196:
		throw new NullReferenceException();
		IL_019C:
		throw new NullReferenceException();
		IL_01A2:
		throw new NullReferenceException();
		IL_01A8:
		throw new NullReferenceException();
		IL_01AE:
		throw new NullReferenceException();
	}

	// Token: 0x0600336E RID: 13166 RVA: 0x001107A8 File Offset: 0x0010E9A8
	[Token(Token = "0x600336E")]
	[Address(RVA = "0x713190", Offset = "0x711790", VA = "0x180713190")]
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
						goto IL_017E;
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
						goto IL_01AE;
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
					goto IL_01B4;
					IL_00F4:
					bool flag5;
					if (flag5)
					{
					}
					int num5;
					if (num5 != 0)
					{
						goto IL_01A2;
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
					goto IL_01A8;
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
					goto IL_019C;
					IL_00BA:
					bool flag8;
					if (flag8)
					{
					}
					int num8;
					if (num8 != 0)
					{
						goto IL_0190;
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
					goto IL_0196;
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
					goto IL_018A;
				}
				IL_0131:
				List<Plant> plantHead = Board.Instance.boardEntity.plantHead;
				Func<Plant, bool> func;
				if (CS$<>8__locals1.<>9__0 == 0)
				{
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
		IL_017E:
		throw new NullReferenceException();
		IL_018A:
		throw new NullReferenceException();
		IL_0190:
		throw new NullReferenceException();
		IL_0196:
		throw new NullReferenceException();
		IL_019C:
		throw new NullReferenceException();
		IL_01A2:
		throw new NullReferenceException();
		IL_01A8:
		throw new NullReferenceException();
		IL_01AE:
		throw new NullReferenceException();
		IL_01B4:
		throw new NullReferenceException();
	}

	// Token: 0x0600336F RID: 13167 RVA: 0x00110984 File Offset: 0x0010EB84
	[Token(Token = "0x600336F")]
	[Address(RVA = "0x712720", Offset = "0x710D20", VA = "0x180712720")]
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
						goto IL_011F;
					}
					goto IL_0196;
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
					goto IL_018A;
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
					goto IL_0184;
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
					goto IL_017E;
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
					goto IL_0178;
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
					goto IL_0172;
				}
				IL_011F:
				List<Plant> plantHead = Board.Instance.boardEntity.plantHead;
				Func<Plant, bool> func;
				if (CS$<>8__locals1.<>9__0 == 0)
				{
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
		IL_0172:
		throw new NullReferenceException();
		IL_0178:
		throw new NullReferenceException();
		IL_017E:
		throw new NullReferenceException();
		IL_0184:
		throw new NullReferenceException();
		IL_018A:
		throw new NullReferenceException();
		IL_0196:
		throw new NullReferenceException();
	}

	// Token: 0x06003370 RID: 13168 RVA: 0x00110B40 File Offset: 0x0010ED40
	[Token(Token = "0x6003370")]
	[Address(RVA = "0x713DC0", Offset = "0x7123C0", VA = "0x180713DC0")]
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

	// Token: 0x06003371 RID: 13169 RVA: 0x00110C64 File Offset: 0x0010EE64
	[Token(Token = "0x6003371")]
	[Address(RVA = "0x710A60", Offset = "0x70F060", VA = "0x180710A60")]
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

	// Token: 0x06003372 RID: 13170 RVA: 0x00110CA8 File Offset: 0x0010EEA8
	[Token(Token = "0x6003372")]
	[Address(RVA = "0x711700", Offset = "0x70FD00", VA = "0x180711700")]
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

	// Token: 0x06003373 RID: 13171 RVA: 0x00110DAC File Offset: 0x0010EFAC
	[Token(Token = "0x6003373")]
	[Address(RVA = "0x710800", Offset = "0x70EE00", VA = "0x180710800")]
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

	// Token: 0x06003374 RID: 13172 RVA: 0x00110E38 File Offset: 0x0010F038
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003374")]
	[Address(RVA = "0x7144C0", Offset = "0x712AC0", VA = "0x1807144C0")]
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

	// Token: 0x040024FB RID: 9467
	[Token(Token = "0x40024FB")]
	public static readonly List<List<PlantType>> UpgradeRoute_8;

	// Token: 0x040024FC RID: 9468
	[Token(Token = "0x40024FC")]
	private static readonly Dictionary<PlantType, int> UpgradeCost_8;

	// Token: 0x040024FD RID: 9469
	[Token(Token = "0x40024FD")]
	public static readonly List<List<PlantType>> UpgradeRoute_7;

	// Token: 0x040024FE RID: 9470
	[Token(Token = "0x40024FE")]
	private static readonly Dictionary<PlantType, int> UpgradeCost_7;

	// Token: 0x040024FF RID: 9471
	[Token(Token = "0x40024FF")]
	public static readonly List<List<PlantType>> UpgradeRoute_6;

	// Token: 0x04002500 RID: 9472
	[Token(Token = "0x4002500")]
	private static readonly Dictionary<PlantType, int> UpgradeCost_6;

	// Token: 0x04002501 RID: 9473
	[Token(Token = "0x4002501")]
	public static readonly List<List<PlantType>> UpgradeRoute_Chess;

	// Token: 0x04002502 RID: 9474
	[Token(Token = "0x4002502")]
	private static readonly Dictionary<PlantType, int> UpgradeCost_Chess;
}
