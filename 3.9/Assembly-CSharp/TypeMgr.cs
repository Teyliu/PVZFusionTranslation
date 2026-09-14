using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000A34 RID: 2612
[Token(Token = "0x2000A34")]
public class TypeMgr
{
	// Token: 0x0600356B RID: 13675 RVA: 0x0011BE80 File Offset: 0x0011A080
	[Token(Token = "0x600356B")]
	[Address(RVA = "0x7A71B0", Offset = "0x7A57B0", VA = "0x1807A71B0")]
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
		bool flag19;
		if (!flag19)
		{
			HashSet<PlantType> icePlants = TypeData.IcePlants;
			bool flag20;
			if (!flag20)
			{
				goto IL_017D;
			}
		}
		plant.plantTag.icePlant = true;
		IL_017D:
		bool flag21;
		if (!flag21)
		{
			HashSet<PlantType> firePlants = TypeData.FirePlants;
			bool flag22;
			if (!flag22)
			{
				goto IL_019D;
			}
		}
		plant.plantTag.firePlant = true;
		IL_019D:
		int thePlantType2 = (int)plant.thePlantType;
		bool flag23;
		plant.plantTag.snowPlant = flag23;
	}

	// Token: 0x0600356C RID: 13676 RVA: 0x0011C048 File Offset: 0x0011A248
	[Token(Token = "0x600356C")]
	[Address(RVA = "0x7A8480", Offset = "0x7A6A80", VA = "0x1807A8480")]
	public static bool IsSnowPlant(PlantType theSeedType)
	{
		HashSet<PlantType> snowPlants = TypeData.SnowPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600356D RID: 13677 RVA: 0x0011C064 File Offset: 0x0011A264
	[Token(Token = "0x600356D")]
	[Address(RVA = "0x7A8080", Offset = "0x7A6680", VA = "0x1807A8080")]
	public static bool IsPickaxeStar(PlantType theSeedType)
	{
		HashSet<PlantType> pickaxeStars = TypeData.PickaxeStars;
		bool flag;
		return flag;
	}

	// Token: 0x0600356E RID: 13678 RVA: 0x0011C080 File Offset: 0x0011A280
	[Token(Token = "0x600356E")]
	[Address(RVA = "0x7A7BC0", Offset = "0x7A61C0", VA = "0x1807A7BC0")]
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

	// Token: 0x0600356F RID: 13679 RVA: 0x0011C0A4 File Offset: 0x0011A2A4
	[Token(Token = "0x600356F")]
	[Address(RVA = "0x7A7D70", Offset = "0x7A6370", VA = "0x1807A7D70")]
	public static bool IsIcePlant(PlantType theSeedType)
	{
		bool flag;
		if (!flag)
		{
			HashSet<PlantType> icePlants = TypeData.IcePlants;
			bool flag2;
			return flag2;
		}
		return true;
	}

	// Token: 0x06003570 RID: 13680 RVA: 0x0011C0C8 File Offset: 0x0011A2C8
	[Token(Token = "0x6003570")]
	[Address(RVA = "0x7A8280", Offset = "0x7A6880", VA = "0x1807A8280")]
	public static bool IsPuff(PlantType theSeedType)
	{
		HashSet<PlantType> puffPlants = TypeData.PuffPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003571 RID: 13681 RVA: 0x0011C0E4 File Offset: 0x0011A2E4
	[Token(Token = "0x6003571")]
	[Address(RVA = "0x7A8700", Offset = "0x7A6D00", VA = "0x1807A8700")]
	public static bool IsVirtualPlant(PlantType theSeedType)
	{
		HashSet<PlantType> virtualPlants = TypeData.VirtualPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003572 RID: 13682 RVA: 0x0011C100 File Offset: 0x0011A300
	[Token(Token = "0x6003572")]
	[Address(RVA = "0x7A8180", Offset = "0x7A6780", VA = "0x1807A8180")]
	public static bool IsPot(PlantType thePlantType)
	{
		HashSet<PlantType> potPlants = TypeData.PotPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003573 RID: 13683 RVA: 0x0011C11C File Offset: 0x0011A31C
	[Token(Token = "0x6003573")]
	[Address(RVA = "0x7A8200", Offset = "0x7A6800", VA = "0x1807A8200")]
	public static bool IsPotatoMine(PlantType theSeedType)
	{
		HashSet<PlantType> potatoPlants = TypeData.PotatoPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003574 RID: 13684 RVA: 0x0011C138 File Offset: 0x0011A338
	[Token(Token = "0x6003574")]
	[Address(RVA = "0x7A6EE0", Offset = "0x7A54E0", VA = "0x1807A6EE0")]
	public static bool BigNut(PlantType theSeedType)
	{
		HashSet<PlantType> bigNutPlants = TypeData.BigNutPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003575 RID: 13685 RVA: 0x0011C154 File Offset: 0x0011A354
	[Token(Token = "0x6003575")]
	[Address(RVA = "0x7A7FB0", Offset = "0x7A65B0", VA = "0x1807A7FB0")]
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

	// Token: 0x06003576 RID: 13686 RVA: 0x0011C180 File Offset: 0x0011A380
	[Token(Token = "0x6003576")]
	[Address(RVA = "0x7A7A00", Offset = "0x7A6000", VA = "0x1807A7A00")]
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

	// Token: 0x06003577 RID: 13687 RVA: 0x0011C1A4 File Offset: 0x0011A3A4
	[Token(Token = "0x6003577")]
	[Address(RVA = "0x7A8500", Offset = "0x7A6B00", VA = "0x1807A8500")]
	public static bool IsSpickRock(PlantType theSeedType)
	{
		HashSet<PlantType> spikeRockPlants = TypeData.SpikeRockPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003578 RID: 13688 RVA: 0x0011C1C0 File Offset: 0x0011A3C0
	[Token(Token = "0x6003578")]
	[Address(RVA = "0x7A8580", Offset = "0x7A6B80", VA = "0x1807A8580")]
	public static bool IsTallNut(PlantType theSeedType)
	{
		HashSet<PlantType> tallNutPlants = TypeData.TallNutPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003579 RID: 13689 RVA: 0x0011C1DC File Offset: 0x0011A3DC
	[Token(Token = "0x6003579")]
	[Address(RVA = "0x7A8300", Offset = "0x7A6900", VA = "0x1807A8300")]
	public static bool IsPumpkin(PlantType theSeedType)
	{
		HashSet<PlantType> pumpkinPlants = TypeData.PumpkinPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600357A RID: 13690 RVA: 0x0011C1F8 File Offset: 0x0011A3F8
	[Token(Token = "0x600357A")]
	[Address(RVA = "0x7A8600", Offset = "0x7A6C00", VA = "0x1807A8600")]
	public static bool IsTangkelp(PlantType theSeedType)
	{
		HashSet<PlantType> kelpPlants = TypeData.KelpPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600357B RID: 13691 RVA: 0x0011C214 File Offset: 0x0011A414
	[Token(Token = "0x600357B")]
	[Address(RVA = "0x7A7EB0", Offset = "0x7A64B0", VA = "0x1807A7EB0")]
	public static bool IsLily(PlantType theSeedType)
	{
		HashSet<PlantType> lilyPlants = TypeData.LilyPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600357C RID: 13692 RVA: 0x0011C230 File Offset: 0x0011A430
	[Token(Token = "0x600357C")]
	[Address(RVA = "0x7A8780", Offset = "0x7A6D80", VA = "0x1807A8780")]
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

	// Token: 0x0600357D RID: 13693 RVA: 0x0011C25C File Offset: 0x0011A45C
	[Token(Token = "0x600357D")]
	[Address(RVA = "0x7A8680", Offset = "0x7A6C80", VA = "0x1807A8680")]
	public static bool IsTorch(PlantType theSeedType)
	{
		HashSet<PlantType> torchPlants = TypeData.TorchPlants;
		bool flag;
		return flag;
	}

	// Token: 0x0600357E RID: 13694 RVA: 0x0011C278 File Offset: 0x0011A478
	[Token(Token = "0x600357E")]
	[Address(RVA = "0x7A83C0", Offset = "0x7A69C0", VA = "0x1807A83C0")]
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

	// Token: 0x0600357F RID: 13695 RVA: 0x0011C29C File Offset: 0x0011A49C
	[Token(Token = "0x600357F")]
	[Address(RVA = "0x7A8100", Offset = "0x7A6700", VA = "0x1807A8100")]
	public static bool IsPlantern(PlantType theSeedType)
	{
		HashSet<PlantType> planternPlants = TypeData.PlanternPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003580 RID: 13696 RVA: 0x0011C2B8 File Offset: 0x0011A4B8
	[Token(Token = "0x6003580")]
	[Address(RVA = "0x7A7130", Offset = "0x7A5730", VA = "0x1807A7130")]
	public static bool FlyingPlants(PlantType thePlantType)
	{
		HashSet<PlantType> flyingPlants = TypeData.FlyingPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003581 RID: 13697 RVA: 0x0011C2D4 File Offset: 0x0011A4D4
	[Token(Token = "0x6003581")]
	[Address(RVA = "0x7A8C40", Offset = "0x7A7240", VA = "0x1807A8C40")]
	public static bool UmbrellaPlants(PlantType thePlantType)
	{
		HashSet<PlantType> umbrellaPlants = TypeData.UmbrellaPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003582 RID: 13698 RVA: 0x0011C2F0 File Offset: 0x0011A4F0
	[Token(Token = "0x6003582")]
	[Address(RVA = "0x7A7020", Offset = "0x7A5620", VA = "0x1807A7020")]
	public static bool DoubleBoxPlants(PlantType thePlantType)
	{
		HashSet<PlantType> doubleBoxPlants = TypeData.DoubleBoxPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003583 RID: 13699 RVA: 0x0011C30C File Offset: 0x0011A50C
	[Token(Token = "0x6003583")]
	[Address(RVA = "0x7A7F30", Offset = "0x7A6530", VA = "0x1807A7F30")]
	public static bool IsMagnetPlants(PlantType thePlantType)
	{
		HashSet<PlantType> magnetPlants = TypeData.MagnetPlants;
		bool flag;
		return flag;
	}

	// Token: 0x06003584 RID: 13700 RVA: 0x0011C328 File Offset: 0x0011A528
	[Token(Token = "0x6003584")]
	[Address(RVA = "0x7A7920", Offset = "0x7A5F20", VA = "0x1807A7920")]
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

	// Token: 0x06003585 RID: 13701 RVA: 0x0011C36C File Offset: 0x0011A56C
	[Token(Token = "0x6003585")]
	[Address(RVA = "0x7A6CB0", Offset = "0x7A52B0", VA = "0x1807A6CB0")]
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

	// Token: 0x06003586 RID: 13702 RVA: 0x0011C458 File Offset: 0x0011A658
	[Token(Token = "0x6003586")]
	[Address(RVA = "0x7A8850", Offset = "0x7A6E50", VA = "0x1807A8850")]
	public static bool NotRandomBungiZombie(ZombieType theZombieType)
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
		int num = 0;
		bool flag3;
		while (flag3)
		{
		}
		if (theZombieType > ZombieType.MachineNutZombie)
		{
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
					goto IL_0093;
				}
			}
			while (theZombieType == ZombieType.NormalZombie)
			{
			}
			if (theZombieType == ZombieType.NormalZombie)
			{
				goto IL_0093;
			}
			while (theZombieType == ZombieType.NormalZombie)
			{
			}
			if (theZombieType == ZombieType.NormalZombie)
			{
				goto IL_0093;
			}
			while (theZombieType == ZombieType.FlagZombie)
			{
			}
			while (theZombieType == ZombieType.GoldBungiZombie)
			{
			}
		}
		int i;
		if (theZombieType > ZombieType.DancePolZombie2)
		{
			if (theZombieType > ZombieType.MachineNutZombie)
			{
				goto IL_0093;
			}
			i = 0;
		}
		while (theZombieType == ZombieType.PolevaulterZombie)
		{
		}
		while (i <= 1)
		{
		}
		IL_0093:
		num.m_value = 0;
		num.m_value = 0;
		num.m_value = 0;
		return false;
		IL_0028:
		if (theZombieType > ZombieType.SnowDolphinrider)
		{
			while (theZombieType == ZombieType.BoatImp)
			{
			}
		}
		ulong num2;
		if (num2 <= (ulong)8L)
		{
		}
		while (theZombieType == ZombieType.SnowDolphinrider)
		{
		}
		goto IL_003D;
	}

	// Token: 0x06003587 RID: 13703 RVA: 0x0011C514 File Offset: 0x0011A714
	[Token(Token = "0x6003587")]
	[Address(RVA = "0x7A8D80", Offset = "0x7A7380", VA = "0x1807A8D80")]
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

	// Token: 0x06003588 RID: 13704 RVA: 0x0011C578 File Offset: 0x0011A778
	[Token(Token = "0x6003588")]
	[Address(RVA = "0x7A6F60", Offset = "0x7A5560", VA = "0x1807A6F60")]
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

	// Token: 0x06003589 RID: 13705 RVA: 0x0011C5B8 File Offset: 0x0011A7B8
	[Token(Token = "0x6003589")]
	[Address(RVA = "0x7A8E50", Offset = "0x7A7450", VA = "0x1807A8E50")]
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

	// Token: 0x0600358A RID: 13706 RVA: 0x0011C5FC File Offset: 0x0011A7FC
	[Token(Token = "0x600358A")]
	[Address(RVA = "0x7A7B30", Offset = "0x7A6130", VA = "0x1807A7B30")]
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

	// Token: 0x0600358B RID: 13707 RVA: 0x0011C62C File Offset: 0x0011A82C
	[Token(Token = "0x600358B")]
	[Address(RVA = "0x7A78D0", Offset = "0x7A5ED0", VA = "0x1807A78D0")]
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

	// Token: 0x0600358C RID: 13708 RVA: 0x0011C670 File Offset: 0x0011A870
	[Token(Token = "0x600358C")]
	[Address(RVA = "0x7A7C70", Offset = "0x7A6270", VA = "0x1807A7C70")]
	public static bool IsGargantuar(ZombieType theZombieType)
	{
		bool flag;
		if (!flag)
		{
			if (theZombieType <= ZombieType.YellowGargantuar)
			{
				goto IL_002D;
			}
			if (theZombieType > ZombieType.UltimateGoldGargantuar && theZombieType != ZombieType.BlackElephantZombie && flag > true)
			{
				goto IL_0048;
			}
		}
		while (theZombieType == ZombieType.ArmedGargantuar)
		{
		}
		while (flag <= true)
		{
		}
		IL_002D:
		int num;
		if (theZombieType > ZombieType.DrownGargantuar)
		{
			while (theZombieType == ZombieType.ElephantZombie)
			{
			}
			while (flag <= true)
			{
			}
			num = 0;
		}
		if (num <= 8)
		{
		}
		while (theZombieType == ZombieType.DrownGargantuar)
		{
		}
		IL_0048:
		int num2 = 0;
		num2 += num;
		return false;
	}

	// Token: 0x0600358D RID: 13709 RVA: 0x0011C6D0 File Offset: 0x0011A8D0
	[Token(Token = "0x600358D")]
	[Address(RVA = "0x7A8C30", Offset = "0x7A7230", VA = "0x1807A8C30")]
	public static bool UltimateZombie(ZombieType theZombieType)
	{
		return theZombieType >= ZombieType.SuperSubmarine;
	}

	// Token: 0x0600358E RID: 13710 RVA: 0x0011C6E8 File Offset: 0x0011A8E8
	[Token(Token = "0x600358E")]
	[Address(RVA = "0x7A70A0", Offset = "0x7A56A0", VA = "0x1807A70A0")]
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

	// Token: 0x0600358F RID: 13711 RVA: 0x0011C728 File Offset: 0x0011A928
	[Token(Token = "0x600358F")]
	[Address(RVA = "0x7A8380", Offset = "0x7A6980", VA = "0x1807A8380")]
	public static bool IsPurplePlant(PlantType theSeedType)
	{
		return (theSeedType > PlantType.CattailPlant && (theSeedType == PlantType.GloomShroom || theSeedType == PlantType.CobCannon || theSeedType == PlantType.SpruceBallista)) || theSeedType == PlantType.TallNut || theSeedType == PlantType.SpikeRock || theSeedType == PlantType.CattailPlant;
	}

	// Token: 0x06003590 RID: 13712 RVA: 0x0011C774 File Offset: 0x0011A974
	[Token(Token = "0x6003590")]
	[Address(RVA = "0x7A7980", Offset = "0x7A5F80", VA = "0x1807A7980")]
	public static bool IsBossZombie(ZombieType theZombieType)
	{
		HashSet<ZombieType> bossZombies = TypeMgr.BossZombies;
		bool flag;
		return flag;
	}

	// Token: 0x06003591 RID: 13713 RVA: 0x0011C790 File Offset: 0x0011A990
	[Token(Token = "0x6003591")]
	[Address(RVA = "0x7A7E30", Offset = "0x7A6430", VA = "0x1807A7E30")]
	public static bool IsLeaderZombie(ZombieType theZombieType)
	{
		HashSet<ZombieType> leaderZombies = TypeMgr.LeaderZombies;
		bool flag;
		return flag;
	}

	// Token: 0x06003592 RID: 13714 RVA: 0x0011C7AC File Offset: 0x0011A9AC
	[Token(Token = "0x6003592")]
	[Address(RVA = "0x7A8CC0", Offset = "0x7A72C0", VA = "0x1807A8CC0")]
	public static bool UncrashablePlant(Plant plant)
	{
		HashSet<PlantType> uncrashablePlants = TypeMgr.UncrashablePlants;
		PlantType thePlantType = plant.thePlantType;
		return uncrashablePlants.Contains(thePlantType) || plant.jigsawType.Contains((uint)7) || plant.uncrashable;
	}

	// Token: 0x06003593 RID: 13715 RVA: 0x0011C7F0 File Offset: 0x0011A9F0
	[Token(Token = "0x6003593")]
	[Address(RVA = "0x7A8AA0", Offset = "0x7A70A0", VA = "0x1807A8AA0")]
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

	// Token: 0x06003594 RID: 13716 RVA: 0x0011C824 File Offset: 0x0011AA24
	[Token(Token = "0x6003594")]
	[Address(RVA = "0x7A8BB0", Offset = "0x7A71B0", VA = "0x1807A8BB0")]
	public static bool UltiZombie_level_water(ZombieType zombieType)
	{
		HashSet<ZombieType> ultieZombie_level_water = TypeMgr.UltieZombie_level_water;
		bool flag;
		return flag;
	}

	// Token: 0x06003595 RID: 13717 RVA: 0x0011C840 File Offset: 0x0011AA40
	[Token(Token = "0x6003595")]
	[Address(RVA = "0x7A7AB0", Offset = "0x7A60B0", VA = "0x1807A7AB0")]
	public static bool IsClassicPlant(PlantType thePlantType)
	{
		HashSet<PlantType> classicPlant = TypeMgr.ClassicPlant;
		bool flag;
		return flag;
	}

	// Token: 0x06003596 RID: 13718 RVA: 0x0011C85C File Offset: 0x0011AA5C
	[Token(Token = "0x6003596")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public TypeMgr()
	{
	}

	// Token: 0x06003597 RID: 13719 RVA: 0x0011C870 File Offset: 0x0011AA70
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003597")]
	[Address(RVA = "0x7A8F30", Offset = "0x7A7530", VA = "0x1807A8F30")]
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

	// Token: 0x040028D7 RID: 10455
	[Token(Token = "0x40028D7")]
	public static readonly Dictionary<ZombieType, ZombieType> AmphibiousZombieToWater = new Dictionary();

	// Token: 0x040028D8 RID: 10456
	[Token(Token = "0x40028D8")]
	public static readonly Dictionary<ZombieType, ZombieType> AmphibiousZombieToLand;

	// Token: 0x040028D9 RID: 10457
	[Token(Token = "0x40028D9")]
	public static readonly HashSet<ZombieType> BossZombies;

	// Token: 0x040028DA RID: 10458
	[Token(Token = "0x40028DA")]
	public static readonly HashSet<ZombieType> LeaderZombies;

	// Token: 0x040028DB RID: 10459
	[Token(Token = "0x40028DB")]
	private static readonly HashSet<PlantType> UncrashablePlants;

	// Token: 0x040028DC RID: 10460
	[Token(Token = "0x40028DC")]
	public static readonly HashSet<ZombieType> UltiZombie_level_a;

	// Token: 0x040028DD RID: 10461
	[Token(Token = "0x40028DD")]
	public static readonly HashSet<ZombieType> UltiZombie_level_b;

	// Token: 0x040028DE RID: 10462
	[Token(Token = "0x40028DE")]
	public static readonly HashSet<ZombieType> UltiZombie_level_c;

	// Token: 0x040028DF RID: 10463
	[Token(Token = "0x40028DF")]
	public static readonly HashSet<ZombieType> UltieZombie_level_water;

	// Token: 0x040028E0 RID: 10464
	[Token(Token = "0x40028E0")]
	public static readonly HashSet<PlantType> RedPlant;

	// Token: 0x040028E1 RID: 10465
	[Token(Token = "0x40028E1")]
	private static readonly HashSet<PlantType> ClassicPlant;
}
