using System;
using Cpp2IlInjected;

// Token: 0x020000DB RID: 219
[Token(Token = "0x20000DB")]
public class OldIZLevel
{
	// Token: 0x06000415 RID: 1045 RVA: 0x0001428C File Offset: 0x0001248C
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x502650", Offset = "0x500C50", VA = "0x180502650")]
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

	// Token: 0x06000416 RID: 1046 RVA: 0x000145C4 File Offset: 0x000127C4
	[Token(Token = "0x6000416")]
	[Address(RVA = "0x5016D0", Offset = "0x4FFCD0", VA = "0x1805016D0")]
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

	// Token: 0x06000417 RID: 1047 RVA: 0x00014630 File Offset: 0x00012830
	[Token(Token = "0x6000417")]
	[Address(RVA = "0x501450", Offset = "0x4FFA50", VA = "0x180501450")]
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

	// Token: 0x06000418 RID: 1048 RVA: 0x00014690 File Offset: 0x00012890
	[Token(Token = "0x6000418")]
	[Address(RVA = "0x5010C0", Offset = "0x4FF6C0", VA = "0x1805010C0")]
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

	// Token: 0x06000419 RID: 1049 RVA: 0x000146F0 File Offset: 0x000128F0
	[Token(Token = "0x6000419")]
	[Address(RVA = "0x500E70", Offset = "0x4FF470", VA = "0x180500E70")]
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

	// Token: 0x0600041A RID: 1050 RVA: 0x0001477C File Offset: 0x0001297C
	[Token(Token = "0x600041A")]
	[Address(RVA = "0x500C40", Offset = "0x4FF240", VA = "0x180500C40")]
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

	// Token: 0x0600041B RID: 1051 RVA: 0x00014808 File Offset: 0x00012A08
	[Token(Token = "0x600041B")]
	[Address(RVA = "0x500A10", Offset = "0x4FF010", VA = "0x180500A10")]
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

	// Token: 0x0600041C RID: 1052 RVA: 0x00014894 File Offset: 0x00012A94
	[Token(Token = "0x600041C")]
	[Address(RVA = "0x5007E0", Offset = "0x4FEDE0", VA = "0x1805007E0")]
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

	// Token: 0x0600041D RID: 1053 RVA: 0x00014920 File Offset: 0x00012B20
	[Token(Token = "0x600041D")]
	[Address(RVA = "0x5005B0", Offset = "0x4FEBB0", VA = "0x1805005B0")]
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

	// Token: 0x0600041E RID: 1054 RVA: 0x000149AC File Offset: 0x00012BAC
	[Token(Token = "0x600041E")]
	[Address(RVA = "0x500380", Offset = "0x4FE980", VA = "0x180500380")]
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

	// Token: 0x0600041F RID: 1055 RVA: 0x00014A38 File Offset: 0x00012C38
	[Token(Token = "0x600041F")]
	[Address(RVA = "0x4FEF20", Offset = "0x4FD520", VA = "0x1804FEF20")]
	private static PlantType GetRandomNumberInNumbers(PlantType[] numbers)
	{
		Random random = new Random();
		int length = numbers.Length;
		int num = random.Next(length);
		return numbers[num];
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00014A68 File Offset: 0x00012C68
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x501A50", Offset = "0x500050", VA = "0x180501A50")]
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

	// Token: 0x06000421 RID: 1057 RVA: 0x00014AA8 File Offset: 0x00012CA8
	[Token(Token = "0x6000421")]
	[Address(RVA = "0x501B70", Offset = "0x500170", VA = "0x180501B70")]
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

	// Token: 0x06000422 RID: 1058 RVA: 0x00014AF0 File Offset: 0x00012CF0
	[Token(Token = "0x6000422")]
	[Address(RVA = "0x501CC0", Offset = "0x5002C0", VA = "0x180501CC0")]
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

	// Token: 0x06000423 RID: 1059 RVA: 0x00014B44 File Offset: 0x00012D44
	[Token(Token = "0x6000423")]
	[Address(RVA = "0x501E40", Offset = "0x500440", VA = "0x180501E40")]
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

	// Token: 0x06000424 RID: 1060 RVA: 0x00014B84 File Offset: 0x00012D84
	[Token(Token = "0x6000424")]
	[Address(RVA = "0x501F60", Offset = "0x500560", VA = "0x180501F60")]
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

	// Token: 0x06000425 RID: 1061 RVA: 0x00014BC8 File Offset: 0x00012DC8
	[Token(Token = "0x6000425")]
	[Address(RVA = "0x502080", Offset = "0x500680", VA = "0x180502080")]
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

	// Token: 0x06000426 RID: 1062 RVA: 0x00014C14 File Offset: 0x00012E14
	[Token(Token = "0x6000426")]
	[Address(RVA = "0x502270", Offset = "0x500870", VA = "0x180502270")]
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

	// Token: 0x06000427 RID: 1063 RVA: 0x00014C60 File Offset: 0x00012E60
	[Token(Token = "0x6000427")]
	[Address(RVA = "0x502460", Offset = "0x500A60", VA = "0x180502460")]
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

	// Token: 0x06000428 RID: 1064 RVA: 0x00014CAC File Offset: 0x00012EAC
	[Token(Token = "0x6000428")]
	[Address(RVA = "0x4FEFB0", Offset = "0x4FD5B0", VA = "0x1804FEFB0")]
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

	// Token: 0x06000429 RID: 1065 RVA: 0x00014CF8 File Offset: 0x00012EF8
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x4FF1A0", Offset = "0x4FD7A0", VA = "0x1804FF1A0")]
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

	// Token: 0x0600042A RID: 1066 RVA: 0x00014D44 File Offset: 0x00012F44
	[Token(Token = "0x600042A")]
	[Address(RVA = "0x4FF390", Offset = "0x4FD990", VA = "0x1804FF390")]
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

	// Token: 0x0600042B RID: 1067 RVA: 0x00014D94 File Offset: 0x00012F94
	[Token(Token = "0x600042B")]
	[Address(RVA = "0x4FF580", Offset = "0x4FDB80", VA = "0x1804FF580")]
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

	// Token: 0x0600042C RID: 1068 RVA: 0x00014E20 File Offset: 0x00013020
	[Token(Token = "0x600042C")]
	[Address(RVA = "0x4FF7B0", Offset = "0x4FDDB0", VA = "0x1804FF7B0")]
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

	// Token: 0x0600042D RID: 1069 RVA: 0x00014EB8 File Offset: 0x000130B8
	[Token(Token = "0x600042D")]
	[Address(RVA = "0x4FFA20", Offset = "0x4FE020", VA = "0x1804FFA20")]
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

	// Token: 0x0600042E RID: 1070 RVA: 0x00014F44 File Offset: 0x00013144
	[Token(Token = "0x600042E")]
	[Address(RVA = "0x4FFC80", Offset = "0x4FE280", VA = "0x1804FFC80")]
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

	// Token: 0x0600042F RID: 1071 RVA: 0x00014FDC File Offset: 0x000131DC
	[Token(Token = "0x600042F")]
	[Address(RVA = "0x4FFEE0", Offset = "0x4FE4E0", VA = "0x1804FFEE0")]
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

	// Token: 0x06000430 RID: 1072 RVA: 0x00015074 File Offset: 0x00013274
	[Token(Token = "0x6000430")]
	[Address(RVA = "0x500150", Offset = "0x4FE750", VA = "0x180500150")]
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

	// Token: 0x06000431 RID: 1073 RVA: 0x00015100 File Offset: 0x00013300
	[Token(Token = "0x6000431")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public OldIZLevel()
	{
	}
}
