using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020009F8 RID: 2552
[Token(Token = "0x20009F8")]
public class TypeMgr
{
	// Token: 0x06003436 RID: 13366 RVA: 0x00116F14 File Offset: 0x00115114
	[Token(Token = "0x6003436")]
	[Address(RVA = "0x740810", Offset = "0x73EE10", VA = "0x180740810")]
	public static void GetPlantTag(Plant plant)
	{
		PlantType thePlantType = plant.thePlantType;
		HashSet<PlantType> potatoPlants = TypeData.PotatoPlants;
		bool flag;
		if (flag)
		{
			plant.plantTag.potatoPlant = true;
		}
		bool flag2;
		bool flag3;
		if (!flag2 && !flag3)
		{
			HashSet<PlantType> wallNutPlants = TypeData.WallNutPlants;
			bool flag4;
			if (!flag4)
			{
				goto IL_0044;
			}
		}
		plant.plantTag.nutPlant = true;
		IL_0044:
		bool flag5;
		if (flag5)
		{
			plant.plantTag.caltropPlant = true;
		}
		bool flag6;
		if (flag6)
		{
			plant.plantTag.tallNutPlant = true;
		}
		bool flag7;
		if (flag7)
		{
			plant.plantTag.pumpkinPlant = true;
		}
		bool flag8;
		if (flag8)
		{
			plant.plantTag.tanglekelpPlant = true;
		}
		bool flag9;
		if (flag9)
		{
			plant.plantTag.waterPlant = true;
		}
		bool flag10;
		if (!flag10)
		{
			HashSet<PlantType> smallPlanternPlants = TypeData.SmallPlanternPlants;
			bool flag11;
			if (!flag11)
			{
				goto IL_00C8;
			}
		}
		plant.plantTag.smallLanternPlant = true;
		IL_00C8:
		HashSet<PlantType> planternPlants = TypeData.PlanternPlants;
		bool flag12;
		if (flag12)
		{
			plant.plantTag.lanternPlant = true;
		}
		bool flag13;
		if (flag13)
		{
			plant.plantTag = (ulong)1L;
		}
		bool flag14;
		if (flag14)
		{
			plant.plantTag.puffPlant = true;
		}
		HashSet<PlantType> magnetPlants = TypeData.MagnetPlants;
		bool flag15;
		if (flag15)
		{
			plant.plantTag.magnetPlant = true;
		}
		bool flag16;
		if (flag16)
		{
			plant.plantTag.potPlant = true;
		}
		HashSet<PlantType> doubleBoxPlants = TypeData.DoubleBoxPlants;
		bool flag17;
		if (flag17)
		{
			plant.plantTag.doubleBoxPlant = true;
		}
		bool flag18;
		if (flag18)
		{
			plant.plantTag.spickRockPlant = true;
		}
		HashSet<PlantType> snowPlants = TypeData.SnowPlants;
		bool flag19;
		if (!flag19)
		{
			HashSet<PlantType> icePlants = TypeData.IcePlants;
			bool flag20;
			if (!flag20)
			{
				goto IL_0181;
			}
		}
		plant.plantTag.icePlant = true;
		IL_0181:
		bool flag21;
		if (!flag21)
		{
			HashSet<PlantType> firePlants = TypeData.FirePlants;
			bool flag22;
			if (!flag22)
			{
				return;
			}
		}
		plant.plantTag.firePlant = true;
	}

	// Token: 0x06003437 RID: 13367 RVA: 0x001170CC File Offset: 0x001152CC
	[Token(Token = "0x6003437")]
	[Address(RVA = "0x741B60", Offset = "0x740160", VA = "0x180741B60")]
	public static bool IsSnowPlant(PlantType theSeedType)
	{
		HashSet<PlantType> snowPlants = TypeData.SnowPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003438 RID: 13368 RVA: 0x001170E8 File Offset: 0x001152E8
	[Token(Token = "0x6003438")]
	[Address(RVA = "0x741760", Offset = "0x73FD60", VA = "0x180741760")]
	public static bool IsPickaxeStar(PlantType theSeedType)
	{
		HashSet<PlantType> pickaxeStars = TypeData.PickaxeStars;
		bool flag;
		return flag;
	}

	// Token: 0x06003439 RID: 13369 RVA: 0x00117104 File Offset: 0x00115304
	[Token(Token = "0x6003439")]
	[Address(RVA = "0x741250", Offset = "0x73F850", VA = "0x180741250")]
	public static bool IsFirePlant(PlantType theSeedType)
	{
		bool flag;
		if (!flag)
		{
			HashSet<PlantType> firePlants = TypeData.FirePlants;
			bool flag2;
			return flag2;
		}
		return true;
	}

	// Token: 0x0600343A RID: 13370 RVA: 0x00117128 File Offset: 0x00115328
	[Token(Token = "0x600343A")]
	[Address(RVA = "0x741400", Offset = "0x73FA00", VA = "0x180741400")]
	public static bool IsIcePlant(PlantType theSeedType)
	{
		HashSet<PlantType> snowPlants = TypeData.SnowPlants;
		bool flag;
		if (!flag)
		{
			HashSet<PlantType> icePlants = TypeData.IcePlants;
			bool flag2;
			return flag2;
		}
		return true;
	}

	// Token: 0x0600343B RID: 13371 RVA: 0x00117150 File Offset: 0x00115350
	[Token(Token = "0x600343B")]
	[Address(RVA = "0x741960", Offset = "0x73FF60", VA = "0x180741960")]
	public static bool IsPuff(PlantType theSeedType)
	{
		HashSet<PlantType> puffPlants = TypeData.PuffPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600343C RID: 13372 RVA: 0x0011716C File Offset: 0x0011536C
	[Token(Token = "0x600343C")]
	[Address(RVA = "0x741DE0", Offset = "0x7403E0", VA = "0x180741DE0")]
	public static bool IsVirtualPlant(PlantType theSeedType)
	{
		HashSet<PlantType> virtualPlants = TypeData.VirtualPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600343D RID: 13373 RVA: 0x00117188 File Offset: 0x00115388
	[Token(Token = "0x600343D")]
	[Address(RVA = "0x741860", Offset = "0x73FE60", VA = "0x180741860")]
	public static bool IsPot(PlantType thePlantType)
	{
		HashSet<PlantType> potPlants = TypeData.PotPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600343E RID: 13374 RVA: 0x001171A4 File Offset: 0x001153A4
	[Token(Token = "0x600343E")]
	[Address(RVA = "0x7418E0", Offset = "0x73FEE0", VA = "0x1807418E0")]
	public static bool IsPotatoMine(PlantType theSeedType)
	{
		HashSet<PlantType> potatoPlants = TypeData.PotatoPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600343F RID: 13375 RVA: 0x001171C0 File Offset: 0x001153C0
	[Token(Token = "0x600343F")]
	[Address(RVA = "0x740540", Offset = "0x73EB40", VA = "0x180740540")]
	public static bool BigNut(PlantType theSeedType)
	{
		HashSet<PlantType> bigNutPlants = TypeData.BigNutPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003440 RID: 13376 RVA: 0x001171DC File Offset: 0x001153DC
	[Token(Token = "0x6003440")]
	[Address(RVA = "0x741690", Offset = "0x73FC90", VA = "0x180741690")]
	public static bool IsNut(PlantType theSeedType)
	{
		bool flag;
		bool flag2;
		if (!flag && !flag2)
		{
			HashSet<PlantType> wallNutPlants = TypeData.WallNutPlants;
			bool flag3;
			return flag3;
		}
		return true;
	}

	// Token: 0x06003441 RID: 13377 RVA: 0x00117208 File Offset: 0x00115408
	[Token(Token = "0x6003441")]
	[Address(RVA = "0x741090", Offset = "0x73F690", VA = "0x180741090")]
	public static bool IsCaltrop(PlantType theSeedType)
	{
		bool flag;
		if (!flag)
		{
			HashSet<PlantType> caltropPlants = TypeData.CaltropPlants;
			bool flag2;
			return flag2;
		}
		return true;
	}

	// Token: 0x06003442 RID: 13378 RVA: 0x0011722C File Offset: 0x0011542C
	[Token(Token = "0x6003442")]
	[Address(RVA = "0x741BE0", Offset = "0x7401E0", VA = "0x180741BE0")]
	public static bool IsSpickRock(PlantType theSeedType)
	{
		HashSet<PlantType> spikeRockPlants = TypeData.SpikeRockPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003443 RID: 13379 RVA: 0x00117248 File Offset: 0x00115448
	[Token(Token = "0x6003443")]
	[Address(RVA = "0x741C60", Offset = "0x740260", VA = "0x180741C60")]
	public static bool IsTallNut(PlantType theSeedType)
	{
		HashSet<PlantType> tallNutPlants = TypeData.TallNutPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003444 RID: 13380 RVA: 0x00117264 File Offset: 0x00115464
	[Token(Token = "0x6003444")]
	[Address(RVA = "0x7419E0", Offset = "0x73FFE0", VA = "0x1807419E0")]
	public static bool IsPumpkin(PlantType theSeedType)
	{
		HashSet<PlantType> pumpkinPlants = TypeData.PumpkinPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003445 RID: 13381 RVA: 0x00117280 File Offset: 0x00115480
	[Token(Token = "0x6003445")]
	[Address(RVA = "0x741CE0", Offset = "0x7402E0", VA = "0x180741CE0")]
	public static bool IsTangkelp(PlantType theSeedType)
	{
		HashSet<PlantType> kelpPlants = TypeData.KelpPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003446 RID: 13382 RVA: 0x0011729C File Offset: 0x0011549C
	[Token(Token = "0x6003446")]
	[Address(RVA = "0x741590", Offset = "0x73FB90", VA = "0x180741590")]
	public static bool IsLily(PlantType theSeedType)
	{
		HashSet<PlantType> lilyPlants = TypeData.LilyPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003447 RID: 13383 RVA: 0x001172B8 File Offset: 0x001154B8
	[Token(Token = "0x6003447")]
	[Address(RVA = "0x741E60", Offset = "0x740460", VA = "0x180741E60")]
	public static bool IsWaterPlant(PlantType theSeedType)
	{
		bool flag;
		bool flag2;
		if (!flag && !flag2)
		{
			HashSet<PlantType> waterPlants = TypeData.WaterPlants;
			bool flag3;
			return flag3;
		}
		return true;
	}

	// Token: 0x06003448 RID: 13384 RVA: 0x001172E4 File Offset: 0x001154E4
	[Token(Token = "0x6003448")]
	[Address(RVA = "0x741D60", Offset = "0x740360", VA = "0x180741D60")]
	public static bool IsTorch(PlantType theSeedType)
	{
		HashSet<PlantType> torchPlants = TypeData.TorchPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003449 RID: 13385 RVA: 0x00117300 File Offset: 0x00115500
	[Token(Token = "0x6003449")]
	[Address(RVA = "0x741AA0", Offset = "0x7400A0", VA = "0x180741AA0")]
	public static bool IsSmallRangeLantern(PlantType theSeedType)
	{
		bool flag;
		if (!flag)
		{
			HashSet<PlantType> smallPlanternPlants = TypeData.SmallPlanternPlants;
			bool flag2;
			return flag2;
		}
		return true;
	}

	// Token: 0x0600344A RID: 13386 RVA: 0x00117324 File Offset: 0x00115524
	[Token(Token = "0x600344A")]
	[Address(RVA = "0x7417E0", Offset = "0x73FDE0", VA = "0x1807417E0")]
	public static bool IsPlantern(PlantType theSeedType)
	{
		HashSet<PlantType> planternPlants = TypeData.PlanternPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600344B RID: 13387 RVA: 0x00117340 File Offset: 0x00115540
	[Token(Token = "0x600344B")]
	[Address(RVA = "0x740790", Offset = "0x73ED90", VA = "0x180740790")]
	public static bool FlyingPlants(PlantType thePlantType)
	{
		HashSet<PlantType> flyingPlants = TypeData.FlyingPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600344C RID: 13388 RVA: 0x0011735C File Offset: 0x0011555C
	[Token(Token = "0x600344C")]
	[Address(RVA = "0x742320", Offset = "0x740920", VA = "0x180742320")]
	public static bool UmbrellaPlants(PlantType thePlantType)
	{
		HashSet<PlantType> umbrellaPlants = TypeData.UmbrellaPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600344D RID: 13389 RVA: 0x00117378 File Offset: 0x00115578
	[Token(Token = "0x600344D")]
	[Address(RVA = "0x740680", Offset = "0x73EC80", VA = "0x180740680")]
	public static bool DoubleBoxPlants(PlantType thePlantType)
	{
		HashSet<PlantType> doubleBoxPlants = TypeData.DoubleBoxPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600344E RID: 13390 RVA: 0x00117394 File Offset: 0x00115594
	[Token(Token = "0x600344E")]
	[Address(RVA = "0x741610", Offset = "0x73FC10", VA = "0x180741610")]
	public static bool IsMagnetPlants(PlantType thePlantType)
	{
		HashSet<PlantType> magnetPlants = TypeData.MagnetPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600344F RID: 13391 RVA: 0x001173B0 File Offset: 0x001155B0
	[Token(Token = "0x600344F")]
	[Address(RVA = "0x740FB0", Offset = "0x73F5B0", VA = "0x180740FB0")]
	public static bool IsAirZombie(ZombieType theZombieType)
	{
		if (theZombieType > ZombieType.IronBalloonZombie2 && theZombieType > ZombieType.SuperLevatation)
		{
			if (theZombieType == ZombieType.MachineLevatation || theZombieType != ZombieType.PortalBalloonZombie)
			{
			}
			return true;
		}
		if (theZombieType > ZombieType.IronBalloonZombie)
		{
			while (theZombieType == ZombieType.LevatationZombie)
			{
			}
			while (theZombieType == ZombieType.IronBalloonZombie2)
			{
			}
		}
		return theZombieType == ZombieType.IronBalloonZombie;
	}

	// Token: 0x06003450 RID: 13392 RVA: 0x001173F4 File Offset: 0x001155F4
	[Token(Token = "0x6003450")]
	[Address(RVA = "0x740310", Offset = "0x73E910", VA = "0x180740310")]
	public static bool BannedInRandomZombies(ZombieType theZombieType)
	{
		int i = (int)theZombieType;
		if (i > 119)
		{
			if (i > 236 && i != 245 && i != 250 && typeof(TypeMgr).TypeHandle > (ulong)2L)
			{
				goto IL_004C;
			}
			while (typeof(TypeMgr).TypeHandle <= (ulong)1L)
			{
			}
		}
		if (i > 29)
		{
			while (i == 53)
			{
			}
		}
		while (typeof(TypeMgr).TypeHandle <= (ulong)1L)
		{
		}
		while (i == 29)
		{
		}
		IL_004C:
		Board instance = Board.Instance;
		int num = 0;
		if (!(instance == num))
		{
			HashSet<SceneType> snowMaps = MapData_cs.SnowMaps;
			SceneType sceneType = instance.sceneType;
			bool flag = snowMaps.Contains(sceneType);
			bool flag2;
			if ((!flag && flag <= true) || flag2)
			{
				goto IL_00D6;
			}
			if (i > 70)
			{
				if (i > 127 && ((i > 211 && i == 232) || i == 129))
				{
					goto IL_00D6;
				}
				i += -73;
				if (i <= 54)
				{
				}
			}
		}
		if (i > 54)
		{
			i += -60;
			while (i > 10)
			{
			}
		}
		uint num2;
		if (num2 > (uint)2 && num2 > (uint)2)
		{
			while (i != 54)
			{
			}
		}
		IL_00D6:
		throw new NullReferenceException();
	}

	// Token: 0x06003451 RID: 13393 RVA: 0x001174E0 File Offset: 0x001156E0
	[Token(Token = "0x6003451")]
	[Address(RVA = "0x741F30", Offset = "0x740530", VA = "0x180741F30")]
	public static bool NotRandomBungiZombie(ZombieType theZombieType)
	{
		for (;;)
		{
			bool flag;
			if (!flag)
			{
				if (theZombieType <= ZombieType.DrownGargantuar)
				{
					goto IL_0028;
				}
				if (theZombieType > ZombieType.SuperSubmarine && theZombieType != ZombieType.DolphinGatlingZombie)
				{
					if (flag <= true)
					{
					}
					if (flag > true)
					{
						goto IL_003D;
					}
				}
			}
			while (theZombieType == ZombieType.DolphinPeaZombie)
			{
			}
			goto IL_0028;
			IL_003D:
			bool flag2;
			while (flag2)
			{
			}
			bool flag3;
			while (flag3)
			{
			}
			if (theZombieType <= ZombieType.MachineNutZombie)
			{
				goto IL_007B;
			}
			if (theZombieType > ZombieType.GoldBungiZombie)
			{
				while (theZombieType == ZombieType.SuperPolevaulter)
				{
				}
				while (theZombieType == ZombieType.RandomZombie)
				{
				}
				if (theZombieType != ZombieType.RandomPlusZombie)
				{
					goto IL_0090;
				}
			}
			while (theZombieType == ZombieType.NormalZombie)
			{
			}
			if (theZombieType != ZombieType.NormalZombie)
			{
				while (theZombieType == ZombieType.NormalZombie)
				{
				}
				if (theZombieType != ZombieType.NormalZombie)
				{
					while (theZombieType == ZombieType.FlagZombie)
					{
					}
					while (theZombieType == ZombieType.GoldBungiZombie)
					{
					}
					goto IL_007B;
				}
			}
			IL_0090:
			int i;
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
			}
			if (i != 1)
			{
				break;
			}
			continue;
			IL_007B:
			if (theZombieType > ZombieType.DancePolZombie2)
			{
				if (theZombieType > ZombieType.MachineNutZombie)
				{
					goto IL_0090;
				}
				i = 0;
			}
			while (theZombieType == ZombieType.PolevaulterZombie)
			{
			}
			while (i <= 1)
			{
			}
			goto IL_0090;
			IL_0028:
			if (theZombieType > ZombieType.SnowDolphinrider)
			{
				while (theZombieType == ZombieType.BoatImp)
				{
				}
			}
			ulong num;
			if (num <= (ulong)8L)
			{
			}
			while (theZombieType == ZombieType.SnowDolphinrider)
			{
			}
			goto IL_003D;
		}
		return false;
	}

	// Token: 0x06003452 RID: 13394 RVA: 0x001175D4 File Offset: 0x001157D4
	[Token(Token = "0x6003452")]
	[Address(RVA = "0x742460", Offset = "0x740A60", VA = "0x180742460")]
	public static bool UselessHypnoZombie(ZombieType theZombieType)
	{
		int num = (int)theZombieType;
		bool flag;
		if (!flag)
		{
			if (num <= 32)
			{
				goto IL_0036;
			}
			if (num <= 73)
			{
				goto IL_002A;
			}
			if (num > 113 && num != 202 && num != 226)
			{
				return false;
			}
		}
		while (num == 77)
		{
		}
		IL_002A:
		num += -34;
		if (num > 39)
		{
			return false;
		}
		IL_0036:
		if (num > 17)
		{
			while (num == 19)
			{
			}
			while (flag <= true)
			{
			}
		}
		while (num == 3)
		{
		}
		while (flag <= true)
		{
		}
		while (num == 17)
		{
		}
		return false;
	}

	// Token: 0x06003453 RID: 13395 RVA: 0x00117638 File Offset: 0x00115838
	[Token(Token = "0x6003453")]
	[Address(RVA = "0x7405C0", Offset = "0x73EBC0", VA = "0x1807405C0")]
	public static bool BigZombie(ZombieType theZombieType)
	{
		bool flag;
		bool flag2;
		if (!flag && !flag2)
		{
			if (theZombieType > ZombieType.SuperMachineNutZombie)
			{
				if (theZombieType == ZombieType.UltimateMachineNutZombie || flag2 <= true)
				{
					return true;
				}
			}
			else
			{
				while (theZombieType == ZombieType.MachineNutZombie)
				{
				}
				while (theZombieType == ZombieType.SuperMachineNutZombie)
				{
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x06003454 RID: 13396 RVA: 0x00117678 File Offset: 0x00115878
	[Token(Token = "0x6003454")]
	[Address(RVA = "0x742530", Offset = "0x740B30", VA = "0x180742530")]
	public static bool WaterZombie(ZombieType theZombieType)
	{
		if (theZombieType > ZombieType.DrownGargantuar)
		{
			if (theZombieType <= ZombieType.SuperSubmarine || theZombieType != ZombieType.DolphinGatlingZombie)
			{
			}
			while (theZombieType == ZombieType.DolphinPeaZombie)
			{
			}
			while (theZombieType == ZombieType.SuperSubmarine)
			{
			}
		}
		if (theZombieType > ZombieType.SnowDolphinrider)
		{
			while (theZombieType == ZombieType.BoatImp)
			{
			}
		}
		return theZombieType == ZombieType.SnowDolphinrider;
	}

	// Token: 0x06003455 RID: 13397 RVA: 0x001176F8 File Offset: 0x001158F8
	[Token(Token = "0x6003455")]
	[Address(RVA = "0x7411C0", Offset = "0x73F7C0", VA = "0x1807411C0")]
	public static bool IsDriverZombie(ZombieType theZombieType)
	{
		if (theZombieType <= ZombieType.DrownpultZombie || theZombieType > ZombieType.CherrySubmarine)
		{
		}
		if (theZombieType > ZombieType.CatapultZombie)
		{
			while (theZombieType == ZombieType.CherryCatapultZombie)
			{
			}
		}
		while (theZombieType == ZombieType.CatapultZombie)
		{
		}
		return false;
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x00117728 File Offset: 0x00115928
	[Token(Token = "0x6003456")]
	[Address(RVA = "0x740F60", Offset = "0x73F560", VA = "0x180740F60")]
	public static bool IsAirShipZombie(ZombieType theZombieType)
	{
		if (theZombieType > ZombieType.SuperBombThrower)
		{
			if (theZombieType > ZombieType.SuperLevatation)
			{
				if (theZombieType != ZombieType.MachineLevatation)
				{
				}
				return true;
			}
			while (theZombieType == ZombieType.UltimateKirovZombie)
			{
			}
			while (theZombieType == ZombieType.SuperLevatation)
			{
			}
		}
		while (theZombieType == ZombieType.KirovZombie)
		{
		}
		while (theZombieType == ZombieType.LevatationZombie)
		{
		}
		return false;
	}

	// Token: 0x06003457 RID: 13399 RVA: 0x0011776C File Offset: 0x0011596C
	[Token(Token = "0x6003457")]
	[Address(RVA = "0x741300", Offset = "0x73F900", VA = "0x180741300")]
	public static bool IsGargantuar(ZombieType theZombieType)
	{
		bool flag;
		do
		{
			if (!flag)
			{
				if (theZombieType <= ZombieType.YellowGargantuar)
				{
					goto IL_002D;
				}
				if (theZombieType > ZombieType.UltimateGoldGargantuar && theZombieType != ZombieType.BlackElephantZombie && flag > true)
				{
					return false;
				}
			}
			while (theZombieType == ZombieType.ArmedGargantuar)
			{
			}
			while (flag <= true)
			{
			}
			IL_002D:;
		}
		while (theZombieType <= ZombieType.DrownGargantuar);
		while (theZombieType == ZombieType.ElephantZombie)
		{
		}
		while (flag <= true)
		{
		}
		if (0 <= 8)
		{
		}
		while (theZombieType == ZombieType.DrownGargantuar)
		{
		}
		return false;
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x001177C4 File Offset: 0x001159C4
	[Token(Token = "0x6003458")]
	[Address(RVA = "0x742310", Offset = "0x740910", VA = "0x180742310")]
	public static bool UltimateZombie(ZombieType theZombieType)
	{
		return theZombieType >= ZombieType.SuperSubmarine;
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x001177DC File Offset: 0x001159DC
	[Token(Token = "0x6003459")]
	[Address(RVA = "0x740700", Offset = "0x73ED00", VA = "0x180740700")]
	public static bool EliteZombie(ZombieType theZombieType)
	{
		if (theZombieType > ZombieType.DollDiamond)
		{
			if (theZombieType > ZombieType.RedGargantuar)
			{
			}
			while (theZombieType == ZombieType.KirovZombie)
			{
			}
		}
		if (theZombieType > ZombieType.JacksonZombie)
		{
			while (theZombieType == ZombieType.ElitePaperZombie)
			{
			}
			while (theZombieType == ZombieType.DollDiamond)
			{
			}
		}
		while (theZombieType == ZombieType.DancePolZombie)
		{
		}
		return theZombieType == ZombieType.JacksonZombie;
	}

	// Token: 0x0600345A RID: 13402 RVA: 0x00117828 File Offset: 0x00115A28
	[Token(Token = "0x600345A")]
	[Address(RVA = "0x741A60", Offset = "0x740060", VA = "0x180741A60")]
	public static bool IsPurplePlant(PlantType theSeedType)
	{
		return (theSeedType > PlantType.CattailPlant && (theSeedType == PlantType.GloomShroom || theSeedType == PlantType.CobCannon || theSeedType == PlantType.SpruceBallista)) || theSeedType == PlantType.TallNut || theSeedType == PlantType.SpikeRock || theSeedType == PlantType.CattailPlant;
	}

	// Token: 0x0600345B RID: 13403 RVA: 0x00117874 File Offset: 0x00115A74
	[Token(Token = "0x600345B")]
	[Address(RVA = "0x741010", Offset = "0x73F610", VA = "0x180741010")]
	public static bool IsBossZombie(ZombieType theZombieType)
	{
		HashSet<ZombieType> bossZombies = TypeMgr.BossZombies;
		bool flag;
		return flag;
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x00117890 File Offset: 0x00115A90
	[Token(Token = "0x600345C")]
	[Address(RVA = "0x741510", Offset = "0x73FB10", VA = "0x180741510")]
	public static bool IsLeaderZombie(ZombieType theZombieType)
	{
		HashSet<ZombieType> leaderZombies = TypeMgr.LeaderZombies;
		bool flag;
		return flag;
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x001178AC File Offset: 0x00115AAC
	[Token(Token = "0x600345D")]
	[Address(RVA = "0x7423A0", Offset = "0x7409A0", VA = "0x1807423A0")]
	public static bool UncrashablePlant(Plant plant)
	{
		HashSet<PlantType> uncrashablePlants = TypeMgr.UncrashablePlants;
		PlantType thePlantType = plant.thePlantType;
		return uncrashablePlants.Contains(thePlantType) || plant.jigsawType.Contains((uint)7) || plant.uncrashable;
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x001178F0 File Offset: 0x00115AF0
	[Token(Token = "0x600345E")]
	[Address(RVA = "0x742180", Offset = "0x740780", VA = "0x180742180")]
	public static bool UltiZombie_level(ZombieType zombieType)
	{
		HashSet<ZombieType> ultiZombie_level_a = TypeMgr.UltiZombie_level_a;
		bool flag;
		if (!flag)
		{
			HashSet<ZombieType> ultiZombie_level_b = TypeMgr.UltiZombie_level_b;
			bool flag2;
			if (!flag2)
			{
				HashSet<ZombieType> ultiZombie_level_c = TypeMgr.UltiZombie_level_c;
				bool flag3;
				return flag3;
			}
		}
		return true;
	}

	// Token: 0x0600345F RID: 13407 RVA: 0x00117924 File Offset: 0x00115B24
	[Token(Token = "0x600345F")]
	[Address(RVA = "0x742290", Offset = "0x740890", VA = "0x180742290")]
	public static bool UltiZombie_level_water(ZombieType zombieType)
	{
		HashSet<ZombieType> ultieZombie_level_water = TypeMgr.UltieZombie_level_water;
		bool flag;
		return flag;
	}

	// Token: 0x06003460 RID: 13408 RVA: 0x00117940 File Offset: 0x00115B40
	[Token(Token = "0x6003460")]
	[Address(RVA = "0x741140", Offset = "0x73F740", VA = "0x180741140")]
	public static bool IsClassicPlant(PlantType thePlantType)
	{
		HashSet<PlantType> classicPlant = TypeMgr.ClassicPlant;
		bool flag;
		return flag;
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x0011795C File Offset: 0x00115B5C
	[Token(Token = "0x6003461")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public TypeMgr()
	{
	}

	// Token: 0x06003462 RID: 13410 RVA: 0x00117970 File Offset: 0x00115B70
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003462")]
	[Address(RVA = "0x742610", Offset = "0x740C10", VA = "0x180742610")]
	static TypeMgr()
	{
		Func<KeyValuePair<ZombieType, ZombieType>, ZombieType> func;
		Func<KeyValuePair<ZombieType, ZombieType>, ZombieType> func2;
		TypeMgr.AmphibiousZombieToLand = Enumerable.ToDictionary<KeyValuePair<ZombieType, ZombieType>, ZombieType, ZombieType>(TypeMgr.AmphibiousZombieToWater, func, func2);
		TypeMgr.BossZombies = new HashSet();
		TypeMgr.LeaderZombies = new HashSet();
		TypeMgr.UncrashablePlants = new HashSet();
		TypeMgr.UltiZombie_level_a = new HashSet();
		TypeMgr.UltiZombie_level_b = new HashSet();
		TypeMgr.UltiZombie_level_c = new HashSet();
		TypeMgr.UltieZombie_level_water = new HashSet();
		TypeMgr.RedPlant = new HashSet();
		HashSet<PlantType> hashSet = new HashSet();
		int num = 0;
		bool flag = hashSet.Add(num);
		TypeMgr.ClassicPlant = hashSet;
		throw new NullReferenceException();
	}

	// Token: 0x04002777 RID: 10103
	[Token(Token = "0x4002777")]
	public static readonly Dictionary<ZombieType, ZombieType> AmphibiousZombieToWater = new Dictionary();

	// Token: 0x04002778 RID: 10104
	[Token(Token = "0x4002778")]
	public static readonly Dictionary<ZombieType, ZombieType> AmphibiousZombieToLand;

	// Token: 0x04002779 RID: 10105
	[Token(Token = "0x4002779")]
	public static readonly HashSet<ZombieType> BossZombies;

	// Token: 0x0400277A RID: 10106
	[Token(Token = "0x400277A")]
	public static readonly HashSet<ZombieType> LeaderZombies;

	// Token: 0x0400277B RID: 10107
	[Token(Token = "0x400277B")]
	private static readonly HashSet<PlantType> UncrashablePlants;

	// Token: 0x0400277C RID: 10108
	[Token(Token = "0x400277C")]
	public static readonly HashSet<ZombieType> UltiZombie_level_a;

	// Token: 0x0400277D RID: 10109
	[Token(Token = "0x400277D")]
	public static readonly HashSet<ZombieType> UltiZombie_level_b;

	// Token: 0x0400277E RID: 10110
	[Token(Token = "0x400277E")]
	public static readonly HashSet<ZombieType> UltiZombie_level_c;

	// Token: 0x0400277F RID: 10111
	[Token(Token = "0x400277F")]
	public static readonly HashSet<ZombieType> UltieZombie_level_water;

	// Token: 0x04002780 RID: 10112
	[Token(Token = "0x4002780")]
	public static readonly HashSet<PlantType> RedPlant;

	// Token: 0x04002781 RID: 10113
	[Token(Token = "0x4002781")]
	private static readonly HashSet<PlantType> ClassicPlant;
}
