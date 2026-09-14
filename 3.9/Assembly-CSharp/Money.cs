using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020002DB RID: 731
[Token(Token = "0x20002DB")]
public class Money : MonoBehaviour
{
	// Token: 0x06000D15 RID: 3349 RVA: 0x0004AC58 File Offset: 0x00048E58
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x43B320", Offset = "0x439920", VA = "0x18043B320")]
	private void Awake()
	{
		Money.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x0004AC78 File Offset: 0x00048E78
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x43C200", Offset = "0x43A800", VA = "0x18043C200")]
	private void Update()
	{
		Board board = this.board;
		int theMoney = board.theMoney;
		GameObject gameObject = this.count;
		ulong num;
		num += num;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
		ulong num3;
		gameObject.SetActive(num3 != 0UL);
		TextMeshProUGUI textMeshProUGUI = this.beanCount2;
		string text;
		this.textMesh.text = text;
		TextMeshProUGUI textMeshProUGUI2 = this.beanCount;
		string text3;
		string text2 = "x" + text3 + "(E)";
		textMeshProUGUI2.text = text2;
		TextMeshProUGUI textMeshProUGUI3 = this.beanCount;
		TextMeshProUGUI textMeshProUGUI4 = this.beanCount2;
		string text4 = textMeshProUGUI3.text;
		textMeshProUGUI4.text = text4;
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x0004AD18 File Offset: 0x00048F18
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x43B3A0", Offset = "0x4399A0", VA = "0x18043B3A0")]
	public void EnableMoneyBank()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0004AD38 File Offset: 0x00048F38
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x43BA30", Offset = "0x43A030", VA = "0x18043BA30")]
	public void ReinforcePlant(Plant plant)
	{
		PlantType thePlantType;
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			int thePlantColumn = plant.thePlantColumn;
			int num3 = plant.thePlantRow;
			thePlantType = plant.thePlantType;
			if (thePlantType <= PlantType.SuperUmbrella)
			{
				goto IL_009B;
			}
			if (thePlantType <= PlantType.GoldDoom)
			{
				goto IL_0080;
			}
			if (thePlantType > PlantType.GoldNut)
			{
				if (thePlantType == PlantType.SilverIceShroom)
				{
					goto IL_0080;
				}
				if (thePlantType == PlantType.GoldIceShroom || "大招需要{0}金币" == 0)
				{
					goto IL_018F;
				}
				if ("大招需要{0}金币" == 0)
				{
					goto IL_01FB;
				}
				if ("大招需要{0}金币" == 0)
				{
					goto IL_0080;
				}
			}
			if (thePlantType != PlantType.SilverNut)
			{
			}
			if (thePlantType != PlantType.SilverDoom)
			{
				goto IL_0080;
			}
			IL_0092:
			if (thePlantType != PlantType.SilverSunflower)
			{
				goto IL_009B;
			}
			goto IL_00D6;
			IL_0080:
			if (thePlantType <= PlantType.GoldSunflower || thePlantType != PlantType.SilverDoom)
			{
				goto IL_0092;
			}
			goto IL_0092;
			IL_0100:
			int num4;
			num3 = num4;
			uint num5;
			num5 += (uint)num3;
			int num7;
			long num6 = (long)(num7 * (int)((uint)2000));
			bool flag;
			if (flag)
			{
			}
			Board board = this.board;
			Dictionary<PlantType, PlantType> dictionary = this.plantUpgrades;
			bool flag2;
			if (!flag2)
			{
				return;
			}
			CreatePlant instance = CreatePlant.Instance;
			uint num8;
			this.UsedEvent(thePlantColumn, num3, (int)num8);
			List<Plant> plants = this.board.gridSystem.GetGrid(thePlantColumn, num3).plants;
			bool flag3;
			if (flag3)
			{
				int num9 = 0;
				bool flag4 = num2 != num9;
				while (!flag4)
				{
				}
				if (!flag4 && !flag4)
				{
					while (!flag4)
					{
					}
				}
			}
			if (num == 0)
			{
				goto IL_018F;
			}
			continue;
			IL_009B:
			if (thePlantType <= PlantType.EmeraldUmbrella)
			{
				break;
			}
			if (thePlantType <= PlantType.UltimateCabbage)
			{
				goto IL_01CE;
			}
			if (num2 <= 1)
			{
				goto IL_018F;
			}
			if (num2 > 14)
			{
				goto IL_01FB;
			}
			while (num2 == 0)
			{
			}
			while (num2 == 0)
			{
			}
			if (num2 == 0)
			{
				goto IL_0100;
			}
			while (num2 == 0)
			{
			}
			if (num2 == 1)
			{
				goto IL_0100;
			}
			IL_00D6:
			if (plant != 0)
			{
				while (plant == 0)
				{
				}
				while (plant == 0)
				{
				}
				while (plant == 0)
				{
				}
				while (plant == (ulong)1L)
				{
				}
				while (thePlantType != PlantType.SilverSunflower)
				{
				}
				int num11;
				long num10 = (long)(num11 * (int)((uint)3000));
				goto IL_0100;
			}
			goto IL_0100;
		}
		IL_01D7:
		while (thePlantType == PlantType.SolarSunflower)
		{
		}
		while (thePlantType == PlantType.EmeraldUmbrella)
		{
		}
		while (thePlantType == PlantType.PassionFruit)
		{
		}
		while (thePlantType == PlantType.UltimateRedLunar)
		{
		}
		goto IL_01FB;
		IL_01CE:
		while (thePlantType == PlantType.RedEmeraldUmbrella)
		{
		}
		goto IL_01D7;
		IL_018F:
		Board instance2 = Board.Instance;
		if (plant.SuperSkill())
		{
			int thePlantColumn;
			int num3;
			int num12;
			this.UsedEvent(thePlantColumn, num3, num12);
			this.OtherSuperSkill(plant);
			InGameText instance3 = InGameText.Instance;
			string text = string.Format("升级需要{0}金币", instance3);
		}
		return;
		IL_01FB:
		InGameText instance4 = InGameText.Instance;
		InGameText instance5 = InGameText.Instance;
		string text2 = string.Format("大招需要{0}金币", instance5);
		throw new NullReferenceException();
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x0004AF70 File Offset: 0x00049170
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x43C3B0", Offset = "0x43A9B0", VA = "0x18043C3B0")]
	private void UsedEvent(int theColumn, int theRow, int cost)
	{
		Board.Instance.UseMoney(theColumn);
		Board board = this.board;
		ulong num;
		num += num;
		int num2 = 0;
		if ((ulong)num2 < num)
		{
			CreateItem instance = CreateItem.Instance;
			num2++;
		}
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0004AFB0 File Offset: 0x000491B0
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x43B720", Offset = "0x439D20", VA = "0x18043B720")]
	private void OtherSuperSkill(Plant originalPlant)
	{
		ulong num3;
		do
		{
			int num = 0;
			PlantType thePlantType = originalPlant.thePlantType;
			if (thePlantType == PlantType.GoldSunflower)
			{
				break;
			}
			if (!originalPlant.WithGoldPot)
			{
				return;
			}
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2) || !(num != originalPlant))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
				int superSkillCost = Money.GetSuperSkillCost((PlantType)num);
			}
		}
		while (num3 != (ulong)0L);
		Plant next = originalPlant.next;
		int num4 = 0;
		if (next != num4)
		{
			bool flag3 = originalPlant.next.SuperSkill();
		}
		Plant pre = originalPlant.pre;
		int num5 = 0;
		if (pre != num5)
		{
			bool flag4 = originalPlant.pre.SuperSkill();
		}
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x0004B070 File Offset: 0x00049270
	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x43B520", Offset = "0x439B20", VA = "0x18043B520")]
	private int GetUpgradeCost(PlantType thePlantType)
	{
		if (thePlantType > PlantType.SilverSunflower)
		{
			if (thePlantType > PlantType.SilverNut && thePlantType != PlantType.GoldIceShroom)
			{
				return 0;
			}
			if (thePlantType != PlantType.SilverDoom)
			{
				return 0;
			}
		}
		if (this == 0)
		{
			return 0;
		}
		if (this == 0)
		{
			return 0;
		}
		if (this != 0)
		{
			if (this == 0)
			{
				return 0;
			}
			if (this != (ulong)1L)
			{
				while (this == 0)
				{
				}
				if (this == 0)
				{
					return 0;
				}
				if (this == 0)
				{
					return 0;
				}
				if (this == 0)
				{
					return 0;
				}
				if (this == (ulong)1L)
				{
					return 0;
				}
				if (thePlantType != PlantType.SilverSunflower)
				{
					return 0;
				}
				int num2;
				long num = (long)(num2 * (int)((uint)3000));
			}
		}
		int num3;
		int num4;
		num3 += num4;
		int num5;
		num3 += num5;
		long num6 = (long)(num3 * (int)((uint)2000));
		bool flag;
		if (flag)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x0004B11C File Offset: 0x0004931C
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x43B3D0", Offset = "0x4399D0", VA = "0x18043B3D0")]
	private static int GetSuperSkillCost(PlantType thePlantType)
	{
		if (thePlantType <= PlantType.UltimateLunarCabbage)
		{
			goto IL_0058;
		}
		if (thePlantType > PlantType.GoldSunflower)
		{
			if (thePlantType > PlantType.GoldNut)
			{
				if (thePlantType == PlantType.GoldIceShroom)
				{
					goto IL_0090;
				}
				if (thePlantType == PlantType.BigCoinShroom)
				{
					goto IL_0098;
				}
			}
			if (thePlantType == PlantType.GoldDoom)
			{
				goto IL_0090;
			}
			if (thePlantType == PlantType.GoldNut)
			{
				goto IL_0098;
			}
		}
		if (thePlantType > PlantType.GoldCorn)
		{
		}
		if (thePlantType == PlantType.GoldCabbage)
		{
			goto IL_0098;
		}
		if (thePlantType != PlantType.GoldCorn)
		{
			goto IL_0058;
		}
		IL_0090:
		while (thePlantType != PlantType.UltimateRedLunar)
		{
		}
		goto IL_0098;
		IL_0058:
		if (thePlantType > PlantType.EmeraldUmbrella)
		{
			if (thePlantType > PlantType.UltimateCabbage && thePlantType == PlantType.UltimateSunflower)
			{
				goto IL_0090;
			}
			if (thePlantType == PlantType.RedEmeraldUmbrella)
			{
				goto IL_0098;
			}
		}
		if (thePlantType <= PlantType.UltimateRedLunar || thePlantType == PlantType.SolarSunflower)
		{
		}
		if (thePlantType == PlantType.PassionFruit)
		{
			goto IL_0090;
		}
		goto IL_0090;
		IL_0098:
		ulong num = (ulong)((int)num + thePlantType);
		return 0;
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x0004B1C8 File Offset: 0x000493C8
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x43B6E0", Offset = "0x439CE0", VA = "0x18043B6E0")]
	public static bool IsGoldPlant(PlantType thePlantType)
	{
		return thePlantType == PlantType.SolarPot || thePlantType == PlantType.SolarLily || thePlantType == PlantType.GoldPot || Money.GetSuperSkillCost(thePlantType) != int.MaxValue;
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x0004B200 File Offset: 0x00049400
	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x43C4F0", Offset = "0x43AAF0", VA = "0x18043C4F0")]
	public Money()
	{
	}

	// Token: 0x0400093C RID: 2364
	[Token(Token = "0x400093C")]
	public static Money Instance;

	// Token: 0x0400093D RID: 2365
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400093D")]
	public Transform moneyPos;

	// Token: 0x0400093E RID: 2366
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400093E")]
	public TextMeshProUGUI textMesh;

	// Token: 0x0400093F RID: 2367
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400093F")]
	public TextMeshProUGUI beanCount;

	// Token: 0x04000940 RID: 2368
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000940")]
	public TextMeshProUGUI beanCount2;

	// Token: 0x04000941 RID: 2369
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000941")]
	public GameObject count;

	// Token: 0x04000942 RID: 2370
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000942")]
	private Board board;

	// Token: 0x04000943 RID: 2371
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000943")]
	private readonly Dictionary<PlantType, PlantType> plantUpgrades = new Dictionary
	{
		{
			(uint)1134,
			(uint)1135
		},
		{
			(uint)1138,
			(uint)1139
		},
		{
			(uint)1145,
			(uint)1146
		},
		{
			(uint)1141,
			(uint)1142
		},
		{
			(uint)1136,
			(uint)1137
		},
		{
			(uint)1187,
			(uint)1188
		},
		{
			(uint)1143,
			(uint)1144
		},
		{
			(uint)1251,
			(uint)1252
		},
		{
			(uint)1284,
			(uint)1285
		},
		{
			(uint)1367,
			(uint)1368
		},
		{
			(uint)1449,
			(uint)1450
		}
	};
}
