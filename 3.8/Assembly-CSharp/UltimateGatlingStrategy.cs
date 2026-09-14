using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000946 RID: 2374
[Token(Token = "0x2000946")]
public class UltimateGatlingStrategy : BaseLevelStrategy
{
	// Token: 0x060030FC RID: 12540 RVA: 0x00103088 File Offset: 0x00101288
	[Token(Token = "0x60030FC")]
	[Address(RVA = "0x3AB140", Offset = "0x3A9740", VA = "0x1803AB140", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateGatling;
	}

	// Token: 0x060030FD RID: 12541 RVA: 0x0010309C File Offset: 0x0010129C
	[Token(Token = "0x60030FD")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x060030FE RID: 12542 RVA: 0x001030AC File Offset: 0x001012AC
	[Token(Token = "0x60030FE")]
	[Address(RVA = "0x6B5640", Offset = "0x6B3C40", VA = "0x1806B5640", Slot = "24")]
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
		return list;
	}

	// Token: 0x060030FF RID: 12543 RVA: 0x00103128 File Offset: 0x00101328
	[Token(Token = "0x60030FF")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06003100 RID: 12544 RVA: 0x00103138 File Offset: 0x00101338
	[Token(Token = "0x6003100")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06003101 RID: 12545 RVA: 0x00103150 File Offset: 0x00101350
	[Token(Token = "0x6003101")]
	[Address(RVA = "0x6B55B0", Offset = "0x6B3BB0", VA = "0x1806B55B0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极樱桃射手";
	}

	// Token: 0x06003102 RID: 12546 RVA: 0x00103164 File Offset: 0x00101364
	[Token(Token = "0x6003102")]
	[Address(RVA = "0x6B5AC0", Offset = "0x6B40C0", VA = "0x1806B5AC0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.config.zombieCountMultiplier = 2f;
	}

	// Token: 0x06003103 RID: 12547 RVA: 0x001031A8 File Offset: 0x001013A8
	[Token(Token = "0x6003103")]
	[Address(RVA = "0x6B5A10", Offset = "0x6B4010", VA = "0x1806B5A10", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.StarUp();
	}

	// Token: 0x06003104 RID: 12548 RVA: 0x001031CC File Offset: 0x001013CC
	[Token(Token = "0x6003104")]
	[Address(RVA = "0x6B5290", Offset = "0x6B3890", VA = "0x1806B5290", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		return list;
	}

	// Token: 0x06003105 RID: 12549 RVA: 0x00103238 File Offset: 0x00101438
	[Token(Token = "0x6003105")]
	[Address(RVA = "0x6B55E0", Offset = "0x6B3BE0", VA = "0x1806B55E0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极樱桃射手可以获得1个星辉樱桃射手";
		}
		return string.Empty;
	}

	// Token: 0x06003106 RID: 12550 RVA: 0x00103254 File Offset: 0x00101454
	[Token(Token = "0x6003106")]
	[Address(RVA = "0x6B5040", Offset = "0x6B3640", VA = "0x1806B5040", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<MissionResult> <>9__10_ = UltimateGatlingStrategy.<>c.<>9__10_0;
		if (<>9__10_ == 0)
		{
			Func<MissionResult> func;
			UltimateGatlingStrategy.<>c.<>9__10_0 = func;
		}
		advantureMission.target = <>9__10_;
		Func<ValueTuple<MissionResult, int>> func2;
		advantureMission.onSubmit = func2;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003107 RID: 12551 RVA: 0x001032C4 File Offset: 0x001014C4
	[Token(Token = "0x6003107")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public UltimateGatlingStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
