using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000950 RID: 2384
[Token(Token = "0x2000950")]
public class UltimateGloomStrategy : BaseLevelStrategy
{
	// Token: 0x0600313E RID: 12606 RVA: 0x00103FEC File Offset: 0x001021EC
	[Token(Token = "0x600313E")]
	[Address(RVA = "0x3A7340", Offset = "0x3A5940", VA = "0x1803A7340", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateGloom;
	}

	// Token: 0x0600313F RID: 12607 RVA: 0x00104000 File Offset: 0x00102200
	[Token(Token = "0x600313F")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x06003140 RID: 12608 RVA: 0x00104010 File Offset: 0x00102210
	[Token(Token = "0x6003140")]
	[Address(RVA = "0x6B5DE0", Offset = "0x6B43E0", VA = "0x1806B5DE0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		int size15 = list._size;
		return list;
	}

	// Token: 0x06003141 RID: 12609 RVA: 0x001040B8 File Offset: 0x001022B8
	[Token(Token = "0x6003141")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.FumeShroom;
	}

	// Token: 0x06003142 RID: 12610 RVA: 0x001040C8 File Offset: 0x001022C8
	[Token(Token = "0x6003142")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night_6;
	}

	// Token: 0x06003143 RID: 12611 RVA: 0x001040D8 File Offset: 0x001022D8
	[Token(Token = "0x6003143")]
	[Address(RVA = "0x6B5D50", Offset = "0x6B4350", VA = "0x1806B5D50", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极忧郁菇";
	}

	// Token: 0x06003144 RID: 12612 RVA: 0x001040EC File Offset: 0x001022EC
	[Token(Token = "0x6003144")]
	[Address(RVA = "0x6B6400", Offset = "0x6B4A00", VA = "0x1806B6400", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag = (ulong)1L;
		TravelMgr instance = TravelMgr.Instance;
		List<PlantType> ulockedPlants_temp = instance.ulockedPlants_temp;
		int size = ulockedPlants_temp._size;
		ulockedPlants_temp._size = instance;
		TravelMgr instance2 = TravelMgr.Instance;
		int num = 0;
		instance2.GetUltiBuff((UltiBuff)((uint)11), num != 0);
	}

	// Token: 0x06003145 RID: 12613 RVA: 0x00104140 File Offset: 0x00102340
	[Token(Token = "0x6003145")]
	[Address(RVA = "0x6B6350", Offset = "0x6B4950", VA = "0x1806B6350", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.StarUp();
	}

	// Token: 0x06003146 RID: 12614 RVA: 0x00104164 File Offset: 0x00102364
	[Token(Token = "0x6003146")]
	[Address(RVA = "0x6B5D80", Offset = "0x6B4380", VA = "0x1806B5D80", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极忧郁菇可以获得1个星辉忧郁菇";
		}
		return string.Empty;
	}

	// Token: 0x06003147 RID: 12615 RVA: 0x00104180 File Offset: 0x00102380
	[Token(Token = "0x6003147")]
	[Address(RVA = "0x6B5B00", Offset = "0x6B4100", VA = "0x1806B5B00", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<MissionResult> <>9__9_ = UltimateGloomStrategy.<>c.<>9__9_0;
		if (<>9__9_ == 0)
		{
			Func<MissionResult> func;
			UltimateGloomStrategy.<>c.<>9__9_0 = func;
		}
		advantureMission.target = <>9__9_;
		Func<ValueTuple<MissionResult, int>> func2;
		advantureMission.onSubmit = func2;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003148 RID: 12616 RVA: 0x001041F0 File Offset: 0x001023F0
	[Token(Token = "0x6003148")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
	}

	// Token: 0x06003149 RID: 12617 RVA: 0x00104200 File Offset: 0x00102400
	[Token(Token = "0x6003149")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public UltimateGloomStrategy()
	{
		int num = 0;
		this.InitCard(num);
	}
}
