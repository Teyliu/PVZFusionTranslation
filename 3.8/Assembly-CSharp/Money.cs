using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020002CD RID: 717
[Token(Token = "0x20002CD")]
public class Money : MonoBehaviour
{
	// Token: 0x06000CD2 RID: 3282 RVA: 0x0004A070 File Offset: 0x00048270
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x3EA830", Offset = "0x3E8E30", VA = "0x1803EA830")]
	private void Awake()
	{
		Money.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x0004A090 File Offset: 0x00048290
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x3EB6E0", Offset = "0x3E9CE0", VA = "0x1803EB6E0")]
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

	// Token: 0x06000CD4 RID: 3284 RVA: 0x0004A130 File Offset: 0x00048330
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x3EA8B0", Offset = "0x3E8EB0", VA = "0x1803EA8B0")]
	public void EnableMoneyBank()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x0004A150 File Offset: 0x00048350
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x3EAF30", Offset = "0x3E9530", VA = "0x1803EAF30")]
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
			if (thePlantType <= PlantType.SuperUmbrella || ((thePlantType <= PlantType.GoldDoom || ((thePlantType <= PlantType.GoldNut || thePlantType != PlantType.SilverIceShroom) && thePlantType != PlantType.SilverNut)) && (thePlantType <= PlantType.GoldSunflower || thePlantType != PlantType.SilverDoom) && thePlantType != PlantType.SilverSunflower))
			{
				if (thePlantType <= PlantType.EmeraldUmbrella)
				{
					break;
				}
				if (thePlantType <= PlantType.UltimateCabbage)
				{
					goto IL_01EE;
				}
				if (num2 <= 1)
				{
					goto IL_019C;
				}
				if (num2 > 14)
				{
					goto IL_021B;
				}
			}
			if (thePlantType <= PlantType.SilverSunflower)
			{
				goto IL_00B6;
			}
			if (thePlantType == PlantType.SilverDoom)
			{
			}
			if (thePlantType != PlantType.SilverNut && thePlantType == PlantType.GoldIceShroom)
			{
				goto IL_00B6;
			}
			IL_0128:
			Board board = this.board;
			Dictionary<PlantType, PlantType> dictionary = this.plantUpgrades;
			bool flag;
			if (!flag)
			{
				return;
			}
			CreatePlant instance = CreatePlant.Instance;
			uint num4;
			this.UsedEvent(thePlantColumn, num3, (int)num4);
			List<Plant> plants = this.board.gridSystem.GetGrid(thePlantColumn, num3).plants;
			bool flag2;
			if (flag2)
			{
				int num5 = 0;
				bool flag3 = num2 != num5;
				while (!flag3)
				{
				}
				if (!flag3 && !flag3)
				{
					while (!flag3)
					{
					}
				}
			}
			if (num == 0)
			{
				goto IL_019C;
			}
			continue;
			IL_00B6:
			if ("大招需要{0}金币" == 0 || "大招需要{0}金币" == 0)
			{
				goto IL_0128;
			}
			if ("大招需要{0}金币" != 0)
			{
				if ("大招需要{0}金币" == 0)
				{
					goto IL_0128;
				}
				if ("大招需要{0}金币" != (ulong)1L)
				{
					while (plant == 0)
					{
					}
					if (plant == 0 || plant == 0 || plant == 0 || plant == (ulong)1L || thePlantType != PlantType.SilverSunflower)
					{
						goto IL_0128;
					}
					int num7;
					long num6 = (long)(num7 * (int)((uint)3000));
				}
			}
			int num8;
			num3 = num8;
			uint num9;
			num9 += (uint)num3;
			int num11;
			long num10 = (long)(num11 * (int)((uint)2000));
			bool flag4;
			if (flag4)
			{
				goto IL_0128;
			}
			goto IL_0128;
		}
		IL_01F7:
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
		goto IL_021B;
		IL_01EE:
		while (thePlantType == PlantType.RedEmeraldUmbrella)
		{
		}
		goto IL_01F7;
		IL_019C:
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
			int num13 = 0;
			instance3.ShowText(text, 5f, num13 != 0);
		}
		return;
		IL_021B:
		InGameText instance4 = InGameText.Instance;
		InGameText instance5 = InGameText.Instance;
		string text2 = string.Format("大招需要{0}金币", instance5);
		throw new NullReferenceException();
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x0004A3A8 File Offset: 0x000485A8
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x3EB890", Offset = "0x3E9E90", VA = "0x1803EB890")]
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

	// Token: 0x06000CD7 RID: 3287 RVA: 0x0004A3E8 File Offset: 0x000485E8
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x3EAC20", Offset = "0x3E9220", VA = "0x1803EAC20")]
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

	// Token: 0x06000CD8 RID: 3288 RVA: 0x0004A4A8 File Offset: 0x000486A8
	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x3EAA20", Offset = "0x3E9020", VA = "0x1803EAA20")]
	private int GetUpgradeCost(PlantType thePlantType)
	{
		if (thePlantType > PlantType.SilverSunflower)
		{
			if (thePlantType == PlantType.SilverDoom)
			{
			}
			if (thePlantType == PlantType.SilverNut)
			{
				return 0;
			}
			if (thePlantType != PlantType.GoldIceShroom)
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

	// Token: 0x06000CD9 RID: 3289 RVA: 0x0004A550 File Offset: 0x00048750
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x3EA8E0", Offset = "0x3E8EE0", VA = "0x1803EA8E0")]
	private static int GetSuperSkillCost(PlantType thePlantType)
	{
		if (thePlantType > PlantType.UltimateSunflower)
		{
			if (thePlantType > PlantType.SuperUmbrella)
			{
				if (thePlantType > PlantType.GoldDoom)
				{
					if (thePlantType == PlantType.GoldNut)
					{
						goto IL_00A1;
					}
					if (thePlantType == PlantType.GoldIceShroom)
					{
						goto IL_0099;
					}
				}
				if (thePlantType == PlantType.GoldSunflower)
				{
					goto IL_00A1;
				}
				if (thePlantType == PlantType.GoldDoom)
				{
					goto IL_0099;
				}
			}
			if (thePlantType > PlantType.GoldCabbage && thePlantType == PlantType.GoldCorn)
			{
				goto IL_0099;
			}
			if (thePlantType == PlantType.UltimateLunarCabbage || thePlantType == PlantType.GoldCabbage)
			{
				goto IL_00A1;
			}
		}
		if (thePlantType > PlantType.SolarSunflower)
		{
			if (thePlantType > PlantType.RedEmeraldUmbrella)
			{
				if (thePlantType == PlantType.UltimateCabbage)
				{
					goto IL_00A1;
				}
				if (thePlantType == PlantType.UltimateSunflower)
				{
					goto IL_0099;
				}
			}
			if (thePlantType == PlantType.EmeraldUmbrella || thePlantType == PlantType.RedEmeraldUmbrella)
			{
				goto IL_00A1;
			}
		}
		if (thePlantType == PlantType.PassionFruit)
		{
		}
		IL_0099:
		if (thePlantType == PlantType.UltimateRedLunar)
		{
		}
		IL_00A1:
		if (thePlantType != PlantType.SolarSunflower)
		{
		}
		uint num = (uint)((int)num + thePlantType);
		return 0;
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x0004A610 File Offset: 0x00048810
	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x3EABE0", Offset = "0x3E91E0", VA = "0x1803EABE0")]
	public static bool IsGoldPlant(PlantType thePlantType)
	{
		return thePlantType == PlantType.SolarPot || thePlantType == PlantType.SolarLily || thePlantType == PlantType.GoldPot || Money.GetSuperSkillCost(thePlantType) != int.MaxValue;
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x0004A648 File Offset: 0x00048848
	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x3EB9D0", Offset = "0x3E9FD0", VA = "0x1803EB9D0")]
	public Money()
	{
	}

	// Token: 0x040008FF RID: 2303
	[Token(Token = "0x40008FF")]
	public static Money Instance;

	// Token: 0x04000900 RID: 2304
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000900")]
	public Transform moneyPos;

	// Token: 0x04000901 RID: 2305
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000901")]
	public TextMeshProUGUI textMesh;

	// Token: 0x04000902 RID: 2306
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000902")]
	public TextMeshProUGUI beanCount;

	// Token: 0x04000903 RID: 2307
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000903")]
	public TextMeshProUGUI beanCount2;

	// Token: 0x04000904 RID: 2308
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000904")]
	public GameObject count;

	// Token: 0x04000905 RID: 2309
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000905")]
	private Board board;

	// Token: 0x04000906 RID: 2310
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000906")]
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
		}
	};
}
