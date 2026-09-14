using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000907 RID: 2311
[Token(Token = "0x2000907")]
public class Day5Strategy : BaseLevelStrategy
{
	// Token: 0x06002EF9 RID: 12025 RVA: 0x000FF8D0 File Offset: 0x000FDAD0
	[Token(Token = "0x6002EF9")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day5;
	}

	// Token: 0x06002EFA RID: 12026 RVA: 0x000FF8E0 File Offset: 0x000FDAE0
	[Token(Token = "0x6002EFA")]
	[Address(RVA = "0x711C90", Offset = "0x710290", VA = "0x180711C90", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)5L);
		Func<MissionResult> func = delegate
		{
			if (board.theWave == 10)
			{
				List<Plant> allPlants = Lawnf.GetAllPlants();
				Func<Plant, bool> <>9__1_ = Day5Strategy.<>c.<>9__1_1;
				if (<>9__1_ == 0)
				{
					Day5Strategy.<>c.<>9__1_1 = (Plant p) => p.isShort;
				}
				bool flag = Enumerable.All<Plant>(allPlants, <>9__1_);
			}
			throw new NullReferenceException();
		};
		advantureMission.target = func;
		AdvantureConfig.SubmitPlantConfig(advantureMission, (PlantType)((uint)4), 16, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(advantureMission, (AdvantureLevel)((uint)5));
		return advantureMission;
	}

	// Token: 0x06002EFB RID: 12027 RVA: 0x000FF944 File Offset: 0x000FDB44
	[Token(Token = "0x6002EFB")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002EFC RID: 12028 RVA: 0x000FF954 File Offset: 0x000FDB54
	[Token(Token = "0x6002EFC")]
	[Address(RVA = "0x711F20", Offset = "0x710520", VA = "0x180711F20", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002EFD RID: 12029 RVA: 0x000FF99C File Offset: 0x000FDB9C
	[Token(Token = "0x6002EFD")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PotatoMine;
	}

	// Token: 0x06002EFE RID: 12030 RVA: 0x000FF9AC File Offset: 0x000FDBAC
	[Token(Token = "0x6002EFE")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002EFF RID: 12031 RVA: 0x000FF9C4 File Offset: 0x000FDBC4
	[Token(Token = "0x6002EFF")]
	[Address(RVA = "0x711DF0", Offset = "0x7103F0", VA = "0x180711DF0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第5关";
	}

	// Token: 0x06002F00 RID: 12032 RVA: 0x000FF9D8 File Offset: 0x000FDBD8
	[Token(Token = "0x6002F00")]
	[Address(RVA = "0x711EA0", Offset = "0x7104A0", VA = "0x180711EA0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "绝对低矮：第10波（第一大波僵尸）时，场上全部都是低矮植物";
		}
		if (result == MissionResult.Second)
		{
			return "炸土豆：提交16个土豆雷";
		}
		return string.Empty;
	}

	// Token: 0x06002F01 RID: 12033 RVA: 0x000FFA00 File Offset: 0x000FDC00
	[Token(Token = "0x6002F01")]
	[Address(RVA = "0x711E20", Offset = "0x710420", VA = "0x180711E20", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "种植低矮植物时返还5点阳光";
		}
		if (result == MissionResult.Second)
		{
			return "土豆雷出土时间大幅降低";
		}
		return string.Empty;
	}

	// Token: 0x06002F02 RID: 12034 RVA: 0x000FFA28 File Offset: 0x000FDC28
	[Token(Token = "0x6002F02")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Day5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
