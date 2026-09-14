using System;
using Cpp2IlInjected;

// Token: 0x020000D6 RID: 214
[Token(Token = "0x20000D6")]
public class OldIZLevel
{
	// Token: 0x060003FA RID: 1018 RVA: 0x00013EEC File Offset: 0x000120EC
	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x4C2870", Offset = "0x4C0E70", VA = "0x1804C2870")]
	public static void SetPlants(int level)
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.DoubleShooter,
			PlantType.GatlingPea,
			PlantType.Peashooter,
			PlantType.SnowPeaShooter,
			PlantType.DoubleShooter,
			PlantType.IronPea
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		num++;
		num++;
		CreatePlant instance2 = CreatePlant.Instance;
		PlantType[] array2 = new PlantType[]
		{
			PlantType.CherryChomper,
			PlantType.NutChomper,
			PlantType.PeaChomper,
			PlantType.PotatoChomper,
			PlantType.SnowPeaShooter,
			PlantType.DoubleShooter
		};
		int num2 = 0;
		if (num2 != 0)
		{
			PlantType randomNumberInNumbers2 = OldIZLevel.GetRandomNumberInNumbers(array2);
		}
		num2++;
		num2++;
		CreatePlant instance3 = CreatePlant.Instance;
		PlantType[] array3 = new PlantType[]
		{
			PlantType.PotatoChomper,
			PlantType.PotatoMine,
			PlantType.PeaMine,
			PlantType.Chomper,
			PlantType.CherryChomper
		};
		int num3 = 0;
		PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		Plant plant;
		if (plant != 0)
		{
			int num4 = 0;
			plant.AttributeCountdown = (float)num4;
		}
		num3++;
		num3++;
		CreatePlant instance4 = CreatePlant.Instance;
		PlantType[] array4 = new PlantType[]
		{
			PlantType.NutChomper,
			PlantType.CherryNut,
			PlantType.IronNut,
			PlantType.PeaNut,
			PlantType.WallNut,
			PlantType.SnowPeaShooter
		};
		int num5 = 0;
		PlantType randomNumberInNumbers4 = OldIZLevel.GetRandomNumberInNumbers(array4);
		num5++;
		num5++;
		CreatePlant instance5 = CreatePlant.Instance;
		PlantType[] array5 = new PlantType[]
		{
			PlantType.Cherryshooter,
			PlantType.DoubleCherry,
			PlantType.CherryGatling,
			PlantType.CherryNut,
			PlantType.PotatoNut,
			PlantType.SuperChomper,
			PlantType.SnowPeaShooter,
			PlantType.IronNut,
			PlantType.IronPea,
			PlantType.CherryChomper
		};
		int num6 = 0;
		PlantType randomNumberInNumbers5 = OldIZLevel.GetRandomNumberInNumbers(array5);
		num6++;
		num6++;
		CreatePlant instance6 = CreatePlant.Instance;
		PlantType[] array6 = new PlantType[]
		{
			PlantType.PuffNut,
			PlantType.HypnoPuff,
			PlantType.DoublePuff,
			PlantType.PeaPuff,
			PlantType.SmallPuff,
			PlantType.SmallIceShroom
		};
		int num7 = 0;
		PlantType randomNumberInNumbers6 = OldIZLevel.GetRandomNumberInNumbers(array6);
		CreatePlant instance7 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
		}
		num7++;
		num7++;
		CreatePlant instance8 = CreatePlant.Instance;
		PlantType[] array7 = new PlantType[]
		{
			PlantType.FumeShroom,
			PlantType.HypnoFume,
			PlantType.IceFumeShroom,
			PlantType.ScaredFume,
			PlantType.SmallPuff,
			PlantType.PeaPuff
		};
		int num8 = 0;
		PlantType randomNumberInNumbers7 = OldIZLevel.GetRandomNumberInNumbers(array7);
		CreatePlant instance9 = CreatePlant.Instance;
		bool flag2;
		if (flag2)
		{
		}
		num8++;
		num8++;
		CreatePlant instance10 = CreatePlant.Instance;
		PlantType[] array8 = new PlantType[]
		{
			PlantType.HypnoPuff,
			PlantType.HypnoShroom,
			PlantType.IceHypno,
			PlantType.ScaredyHypno,
			PlantType.FumeShroom,
			PlantType.PuffNut,
			PlantType.PeaPuff
		};
		int num9 = 0;
		PlantType randomNumberInNumbers8 = OldIZLevel.GetRandomNumberInNumbers(array8);
		CreatePlant instance11 = CreatePlant.Instance;
		bool flag3;
		if (flag3)
		{
		}
		num9++;
		num9++;
		CreatePlant instance12 = CreatePlant.Instance;
		PlantType[] array9 = new PlantType[]
		{
			PlantType.ScaredFume,
			PlantType.ScaredyHypno,
			PlantType.ScaredyShroom,
			PlantType.SuperHypno,
			PlantType.IceScaredyShroom,
			PlantType.FumeShroom,
			PlantType.PeaPuff
		};
		int num10 = 0;
		PlantType randomNumberInNumbers9 = OldIZLevel.GetRandomNumberInNumbers(array9);
		CreatePlant instance13 = CreatePlant.Instance;
		bool flag4;
		if (flag4)
		{
		}
		num10++;
		num10++;
		CreatePlant instance14 = CreatePlant.Instance;
		PlantType[] array10 = new PlantType[]
		{
			PlantType.IcePuff,
			PlantType.IceHypno,
			PlantType.IceFumeShroom,
			PlantType.SmallIceShroom,
			PlantType.TallIceNut,
			PlantType.IceScaredyShroom
		};
		int num11 = 0;
		PlantType randomNumberInNumbers10 = OldIZLevel.GetRandomNumberInNumbers(array10);
		CreatePlant instance15 = CreatePlant.Instance;
		bool flag5;
		if (flag5)
		{
		}
		num11++;
		num11++;
		CreatePlant instance16 = CreatePlant.Instance;
		PlantType[] array11 = new PlantType[]
		{
			PlantType.IceFumeShroom,
			PlantType.IceScaredyShroom,
			PlantType.SuperFume,
			PlantType.SuperHypno,
			PlantType.HypnoFume,
			PlantType.ScaredyHypno,
			PlantType.PuffDoom,
			PlantType.ScaredyDoom,
			PlantType.PuffNut,
			PlantType.SuperHypno,
			PlantType.IcePuff,
			PlantType.DoublePuff,
			PlantType.ScaredFume,
			PlantType.TallNutFootball
		};
		int num12 = 0;
		PlantType randomNumberInNumbers11 = OldIZLevel.GetRandomNumberInNumbers(array11);
		CreatePlant instance17 = CreatePlant.Instance;
		bool flag6;
		if (flag6)
		{
		}
		num12++;
		num12++;
		OldIZLevel.SetPlantsInLv13();
		OldIZLevel.SetPlantsInLv14();
		OldIZLevel.SetPlantsInLv15();
		OldIZLevel.SetPlantsInLv16();
		OldIZLevel.SetPlantsInLv17();
		OldIZLevel.SetPlantsInLv18();
		OldIZLevel.SetPlantsInLv19();
		OldIZLevel.SetPlantsInLv20();
		OldIZLevel.SetPlantsInLv21();
		OldIZLevel.SetPlantsInLv22();
		OldIZLevel.SetPlantsInLv23();
		OldIZLevel.SetPlantsInLv24();
		OldIZLevel.SetPlantsInLv25();
		OldIZLevel.SetPlantsInLv26();
		OldIZLevel.SetPlantsInLv27();
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00014224 File Offset: 0x00012424
	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x4C18F0", Offset = "0x4BFEF0", VA = "0x1804C18F0")]
	private static void SetPlantsInLv27()
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		int num2;
		if (num < num2)
		{
			int num3;
			if (num < num3)
			{
				if (num != 1 || num != 4)
				{
					Plant plant;
					IntPtr intPtr = plant.m_CachedPtr * (IntPtr)num;
					intPtr += (IntPtr)num;
				}
				num++;
				num++;
			}
			num++;
			num++;
		}
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00014290 File Offset: 0x00012490
	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x4C1670", Offset = "0x4BFC70", VA = "0x1804C1670")]
	private static void SetPlantsInLv26()
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		int num2;
		if (num < num2)
		{
			int num3;
			if (num < num3)
			{
				Plant plant;
				IntPtr intPtr = plant.m_CachedPtr * (IntPtr)num;
				intPtr += (IntPtr)num;
				num++;
				num++;
			}
			num++;
			num++;
		}
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x000142F0 File Offset: 0x000124F0
	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x4C12E0", Offset = "0x4BF8E0", VA = "0x1804C12E0")]
	private static void SetPlantsInLv25()
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		int num2;
		if (num < num2)
		{
			int num3;
			if (num < num3)
			{
				Plant plant;
				IntPtr intPtr = plant.m_CachedPtr * (IntPtr)num;
				intPtr += (IntPtr)num;
				num++;
				num++;
			}
			num++;
			num++;
		}
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00014350 File Offset: 0x00012550
	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x4C1090", Offset = "0x4BF690", VA = "0x1804C1090")]
	private static void SetPlantsInLv24()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.TallNutFootball,
			PlantType.Magnetshroom,
			PlantType.CherryGatling,
			PlantType.SuperFume,
			PlantType.SuperHypno,
			PlantType.SuperStar,
			PlantType.MagnetCactus,
			PlantType.SuperPumpkin
		};
		PlantType[] array2 = new PlantType[] { (PlantType)((ulong)12L) };
		PlantType[] array3 = new PlantType[]
		{
			PlantType.TallNutFootball,
			PlantType.Magnetshroom,
			PlantType.CherryGatling,
			PlantType.SuperFume,
			PlantType.SuperHypno,
			PlantType.SuperStar,
			PlantType.MagnetCactus,
			PlantType.SuperPumpkin
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x000143DC File Offset: 0x000125DC
	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x4C0E60", Offset = "0x4BF460", VA = "0x1804C0E60")]
	private static void SetPlantsInLv23()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.TallNut,
			PlantType.Magnetshroom,
			PlantType.SplitPea,
			PlantType.Chomper,
			PlantType.ThreePeater,
			PlantType.StarFruit,
			PlantType.Peashooter,
			PlantType.DoubleSnow,
			PlantType.CacstusStar
		};
		PlantType[] array2 = new PlantType[]
		{
			PlantType.LilyPad,
			PlantType.LilyPad,
			PlantType.LilyPad
		};
		PlantType[] array3 = new PlantType[]
		{
			PlantType.TallNut,
			PlantType.Magnetshroom,
			PlantType.SplitPea,
			PlantType.Chomper,
			PlantType.ThreePeater,
			PlantType.StarFruit,
			PlantType.Peashooter,
			PlantType.DoubleSnow,
			PlantType.CacstusStar
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00014468 File Offset: 0x00012668
	[Token(Token = "0x6000400")]
	[Address(RVA = "0x4C0C30", Offset = "0x4BF230", VA = "0x1804C0C30")]
	private static void SetPlantsInLv22()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.Magnetshroom,
			PlantType.LanternMagnet,
			PlantType.MagnetCactus,
			PlantType.JackboxStar,
			PlantType.PickaxeStar,
			PlantType.SuperStar
		};
		PlantType[] array2 = new PlantType[]
		{
			PlantType.LilyPad,
			PlantType.LilyPad,
			PlantType.LilyPad
		};
		PlantType[] array3 = new PlantType[]
		{
			PlantType.Magnetshroom,
			PlantType.LanternMagnet,
			PlantType.MagnetCactus,
			PlantType.JackboxStar,
			PlantType.PickaxeStar
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x000144F4 File Offset: 0x000126F4
	[Token(Token = "0x6000401")]
	[Address(RVA = "0x4C0A00", Offset = "0x4BF000", VA = "0x1804C0A00")]
	private static void SetPlantsInLv21()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.StarFruit,
			PlantType.IronStar,
			PlantType.CacstusStar,
			PlantType.JackboxStar,
			PlantType.PickaxeStar,
			PlantType.StarBlover,
			PlantType.SplitPea,
			PlantType.CherrySplit,
			PlantType.SnowSplit
		};
		PlantType[] array2 = new PlantType[]
		{
			PlantType.LilyPad,
			PlantType.LilyPad,
			PlantType.LilyPad,
			PlantType.SeaStarfruit
		};
		PlantType[] array3 = new PlantType[]
		{
			PlantType.StarFruit,
			PlantType.IronStar,
			PlantType.CacstusStar,
			PlantType.JackboxStar,
			PlantType.PickaxeStar,
			PlantType.StarBlover,
			PlantType.SplitPea,
			PlantType.CherrySplit,
			PlantType.SnowSplit
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00014580 File Offset: 0x00012780
	[Token(Token = "0x6000402")]
	[Address(RVA = "0x4C07D0", Offset = "0x4BEDD0", VA = "0x1804C07D0")]
	private static void SetPlantsInLv20()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.Cactus,
			PlantType.Plantern,
			PlantType.LanternCactus,
			PlantType.ScaredyShroom,
			PlantType.ThreePeater,
			PlantType.MagnetCactus,
			PlantType.StarFruit,
			PlantType.LanternStar
		};
		PlantType[] array2 = new PlantType[]
		{
			PlantType.LilyPad,
			PlantType.SeaCactus,
			PlantType.SeaShroom,
			PlantType.SeaMagnet
		};
		PlantType[] array3 = new PlantType[]
		{
			PlantType.StarFruit,
			PlantType.LanternStar,
			PlantType.Cactus,
			PlantType.Plantern,
			PlantType.LanternCactus,
			PlantType.ScaredyShroom,
			PlantType.ThreePeater,
			PlantType.MagnetCactus
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x0001460C File Offset: 0x0001280C
	[Token(Token = "0x6000403")]
	[Address(RVA = "0x4C05A0", Offset = "0x4BEBA0", VA = "0x1804C05A0")]
	private static void SetPlantsInLv19()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.Cactus,
			PlantType.Plantern,
			PlantType.LanternCactus,
			PlantType.ScaredyShroom,
			PlantType.SnowSplit,
			PlantType.ThreePeater,
			PlantType.MagnetCactus
		};
		PlantType[] array2 = new PlantType[]
		{
			PlantType.LilyPad,
			PlantType.SeaCactus,
			PlantType.SeaShroom
		};
		PlantType[] array3 = new PlantType[]
		{
			PlantType.Cactus,
			PlantType.Plantern,
			PlantType.LanternCactus,
			PlantType.ScaredyShroom,
			PlantType.SnowSplit,
			PlantType.ThreePeater,
			PlantType.MagnetCactus
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00014698 File Offset: 0x00012898
	[Token(Token = "0x6000404")]
	[Address(RVA = "0x4BF140", Offset = "0x4BD740", VA = "0x1804BF140")]
	private static PlantType GetRandomNumberInNumbers(PlantType[] numbers)
	{
		Random random = new Random();
		int length = numbers.Length;
		int num = random.Next(length);
		return numbers[num];
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x000146C8 File Offset: 0x000128C8
	[Token(Token = "0x6000405")]
	[Address(RVA = "0x4C1C70", Offset = "0x4C0270", VA = "0x1804C1C70")]
	private static void SetPlantsInLv2()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.DoubleShooter,
			PlantType.GatlingPea,
			PlantType.Peashooter,
			PlantType.SnowPeaShooter,
			PlantType.DoubleShooter,
			PlantType.IronPea
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		num++;
		num++;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00014708 File Offset: 0x00012908
	[Token(Token = "0x6000406")]
	[Address(RVA = "0x4C1D90", Offset = "0x4C0390", VA = "0x1804C1D90")]
	private static void SetPlantsInLv3()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.CherryChomper,
			PlantType.NutChomper,
			PlantType.PeaChomper,
			PlantType.PotatoChomper,
			PlantType.SnowPeaShooter,
			PlantType.DoubleShooter
		};
		int num = 0;
		if (num != 0)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		num++;
		num++;
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00014750 File Offset: 0x00012950
	[Token(Token = "0x6000407")]
	[Address(RVA = "0x4C1EE0", Offset = "0x4C04E0", VA = "0x1804C1EE0")]
	private static void SetPlantsInLv4()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.PotatoChomper,
			PlantType.PotatoMine,
			PlantType.PeaMine,
			PlantType.Chomper,
			PlantType.CherryChomper
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		Plant plant;
		if (plant != 0)
		{
			int num2 = 0;
			plant.AttributeCountdown = (float)num2;
		}
		num++;
		num++;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x000147A4 File Offset: 0x000129A4
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x4C2060", Offset = "0x4C0660", VA = "0x1804C2060")]
	private static void SetPlantsInLv5()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.NutChomper,
			PlantType.CherryNut,
			PlantType.IronNut,
			PlantType.PeaNut,
			PlantType.WallNut,
			PlantType.SnowPeaShooter
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		num++;
		num++;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x000147E4 File Offset: 0x000129E4
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x4C2180", Offset = "0x4C0780", VA = "0x1804C2180")]
	private static void SetPlantsInLv6()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.Cherryshooter,
			PlantType.DoubleCherry,
			PlantType.CherryGatling,
			PlantType.CherryNut,
			PlantType.PotatoNut,
			PlantType.SuperChomper,
			PlantType.SnowPeaShooter,
			PlantType.IronNut,
			PlantType.IronPea,
			PlantType.CherryChomper
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		num++;
		num++;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00014828 File Offset: 0x00012A28
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x4C22A0", Offset = "0x4C08A0", VA = "0x1804C22A0")]
	private static void SetPlantsInLv7()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.PuffNut,
			PlantType.HypnoPuff,
			PlantType.DoublePuff,
			PlantType.PeaPuff,
			PlantType.SmallPuff,
			PlantType.SmallIceShroom
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		CreatePlant instance2 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
		}
		num++;
		num++;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00014874 File Offset: 0x00012A74
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x4C2490", Offset = "0x4C0A90", VA = "0x1804C2490")]
	private static void SetPlantsInLv8()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.FumeShroom,
			PlantType.HypnoFume,
			PlantType.IceFumeShroom,
			PlantType.ScaredFume,
			PlantType.SmallPuff,
			PlantType.PeaPuff
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		CreatePlant instance2 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
		}
		num++;
		num++;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x000148C0 File Offset: 0x00012AC0
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x4C2680", Offset = "0x4C0C80", VA = "0x1804C2680")]
	private static void SetPlantsInLv9()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.HypnoPuff,
			PlantType.HypnoShroom,
			PlantType.IceHypno,
			PlantType.ScaredyHypno,
			PlantType.FumeShroom,
			PlantType.PuffNut,
			PlantType.PeaPuff
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		CreatePlant instance2 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
		}
		num++;
		num++;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0001490C File Offset: 0x00012B0C
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x4BF1D0", Offset = "0x4BD7D0", VA = "0x1804BF1D0")]
	private static void SetPlantsInLv10()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.ScaredFume,
			PlantType.ScaredyHypno,
			PlantType.ScaredyShroom,
			PlantType.SuperHypno,
			PlantType.IceScaredyShroom,
			PlantType.FumeShroom,
			PlantType.PeaPuff
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		CreatePlant instance2 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
		}
		num++;
		num++;
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00014958 File Offset: 0x00012B58
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x4BF3C0", Offset = "0x4BD9C0", VA = "0x1804BF3C0")]
	private static void SetPlantsInLv11()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.IcePuff,
			PlantType.IceHypno,
			PlantType.IceFumeShroom,
			PlantType.SmallIceShroom,
			PlantType.TallIceNut,
			PlantType.IceScaredyShroom
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		CreatePlant instance2 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
		}
		num++;
		num++;
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x000149A4 File Offset: 0x00012BA4
	[Token(Token = "0x600040F")]
	[Address(RVA = "0x4BF5B0", Offset = "0x4BDBB0", VA = "0x1804BF5B0")]
	private static void SetPlantsInLv12()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.IceFumeShroom,
			PlantType.IceScaredyShroom,
			PlantType.SuperFume,
			PlantType.SuperHypno,
			PlantType.HypnoFume,
			PlantType.ScaredyHypno,
			PlantType.PuffDoom,
			PlantType.ScaredyDoom,
			PlantType.PuffNut,
			PlantType.SuperHypno,
			PlantType.IcePuff,
			PlantType.DoublePuff,
			PlantType.ScaredFume,
			PlantType.TallNutFootball
		};
		int num = 0;
		PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		CreatePlant instance2 = CreatePlant.Instance;
		bool flag;
		if (flag)
		{
		}
		num++;
		num++;
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x000149F4 File Offset: 0x00012BF4
	[Token(Token = "0x6000410")]
	[Address(RVA = "0x4BF7A0", Offset = "0x4BDDA0", VA = "0x1804BF7A0")]
	private static void SetPlantsInLv13()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.SuperCherryShooter,
			PlantType.GatlingPea,
			PlantType.SnowPeaShooter,
			PlantType.Caltrop,
			PlantType.GatlingPea,
			PlantType.ThreeSquash
		};
		PlantType[] array2 = new PlantType[]
		{
			PlantType.LilyPad,
			PlantType.Tanglekelp,
			PlantType.Threekelp
		};
		PlantType[] array3 = new PlantType[]
		{
			PlantType.SuperCherryShooter,
			PlantType.GatlingPea,
			PlantType.SnowPeaShooter,
			PlantType.GatlingPea
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00014A80 File Offset: 0x00012C80
	[Token(Token = "0x6000411")]
	[Address(RVA = "0x4BF9D0", Offset = "0x4BDFD0", VA = "0x1804BF9D0")]
	private static void SetPlantsInLv14()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.ThreePeater,
			PlantType.ThreeTorch,
			PlantType.ThreeSpike,
			PlantType.ThreeSquash
		};
		PlantType[] array2 = new PlantType[2];
		array2[0] = (PlantType)((ulong)12L);
		array2[0] = (PlantType)((ulong)1051L);
		PlantType[] array3 = new PlantType[]
		{
			PlantType.ThreePeater,
			PlantType.ThreeTorch,
			PlantType.ThreeSquash
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00014B18 File Offset: 0x00012D18
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x4BFC40", Offset = "0x4BE240", VA = "0x1804BFC40")]
	private static void SetPlantsInLv15()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.Squash,
			PlantType.JalaSquash,
			PlantType.SquashSpike,
			PlantType.Chomper,
			PlantType.CherryChomper,
			PlantType.WallNut
		};
		PlantType[] array2 = new PlantType[] { (PlantType)((ulong)12L) };
		PlantType[] array3 = new PlantType[]
		{
			PlantType.Squash,
			PlantType.JalaSquash,
			PlantType.Chomper,
			PlantType.WallNut
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00014BA4 File Offset: 0x00012DA4
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x4BFEA0", Offset = "0x4BE4A0", VA = "0x1804BFEA0")]
	private static void SetPlantsInLv16()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.TorchSpike,
			PlantType.JalaCaltrop,
			PlantType.SquashSpike,
			PlantType.ThreeSpike,
			PlantType.SpikeRock,
			PlantType.WallNut
		};
		PlantType[] array2 = new PlantType[]
		{
			PlantType.LilyPad,
			PlantType.Jalakelp,
			PlantType.Tanglekelp
		};
		PlantType[] array3 = new PlantType[2];
		array3[0] = (PlantType)((ulong)1070L);
		int num = 0;
		array3[0] = (PlantType)((ulong)3L);
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00014C3C File Offset: 0x00012E3C
	[Token(Token = "0x6000414")]
	[Address(RVA = "0x4C0100", Offset = "0x4BE700", VA = "0x1804C0100")]
	private static void SetPlantsInLv17()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.GatlingPea,
			PlantType.CherryGatling,
			PlantType.ThreePeater,
			PlantType.SuperTorch,
			PlantType.ThreeTorch,
			PlantType.JalaTorch,
			PlantType.TorchSpike
		};
		PlantType[] array2 = new PlantType[2];
		array2[0] = (PlantType)((ulong)12L);
		array2[0] = (PlantType)((ulong)1050L);
		PlantType[] array3 = new PlantType[]
		{
			PlantType.GatlingPea,
			PlantType.CherryGatling,
			PlantType.SuperTorch,
			PlantType.ThreeTorch,
			PlantType.JalaTorch
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00014CD4 File Offset: 0x00012ED4
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x4C0370", Offset = "0x4BE970", VA = "0x1804C0370")]
	private static void SetPlantsInLv18()
	{
		CreatePlant instance = CreatePlant.Instance;
		PlantType[] array = new PlantType[]
		{
			PlantType.ThreeSquash,
			PlantType.TallFireNut,
			PlantType.SuperTorch,
			PlantType.DarkThreePeater,
			PlantType.SpikeRock,
			PlantType.SquashSpike,
			PlantType.ThreePeater,
			PlantType.JalaCaltrop,
			PlantType.CherryChomper,
			PlantType.IronPea,
			PlantType.ThreeTorch
		};
		PlantType[] array2 = new PlantType[]
		{
			PlantType.LilyPad,
			PlantType.CattailPlant,
			PlantType.Tanglekelp,
			PlantType.Threekelp,
			PlantType.KelpTorch
		};
		PlantType[] array3 = new PlantType[]
		{
			PlantType.ThreeSquash,
			PlantType.SuperTorch,
			PlantType.DarkThreePeater,
			PlantType.ThreePeater,
			PlantType.TallFireNut,
			PlantType.CherryChomper,
			PlantType.IronPea,
			PlantType.ThreeTorch
		};
		int num = 0;
		if (18446744073709551614UL > (ulong)1L)
		{
			PlantType randomNumberInNumbers = OldIZLevel.GetRandomNumberInNumbers(array);
		}
		int randomNumberInNumbers2 = (int)OldIZLevel.GetRandomNumberInNumbers(array2);
		if (randomNumberInNumbers2 == 12)
		{
			PlantType randomNumberInNumbers3 = OldIZLevel.GetRandomNumberInNumbers(array3);
		}
		num++;
		num++;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00014D60 File Offset: 0x00012F60
	[Token(Token = "0x6000416")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public OldIZLevel()
	{
	}
}
