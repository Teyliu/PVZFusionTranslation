using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000954 RID: 2388
[Token(Token = "0x2000954")]
public class UltimateStarStrategy : BaseLevelStrategy
{
	// Token: 0x0600315B RID: 12635 RVA: 0x00104558 File Offset: 0x00102758
	[Token(Token = "0x600315B")]
	[Address(RVA = "0x3A6CA0", Offset = "0x3A52A0", VA = "0x1803A6CA0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateStar;
	}

	// Token: 0x0600315C RID: 12636 RVA: 0x0010456C File Offset: 0x0010276C
	[Token(Token = "0x600315C")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x0600315D RID: 12637 RVA: 0x0010457C File Offset: 0x0010277C
	[Token(Token = "0x600315D")]
	[Address(RVA = "0x6B67D0", Offset = "0x6B4DD0", VA = "0x1806B67D0", Slot = "24")]
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
		return list;
	}

	// Token: 0x0600315E RID: 12638 RVA: 0x001045F0 File Offset: 0x001027F0
	[Token(Token = "0x600315E")]
	[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.StarFruit;
	}

	// Token: 0x0600315F RID: 12639 RVA: 0x00104600 File Offset: 0x00102800
	[Token(Token = "0x600315F")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06003160 RID: 12640 RVA: 0x00104610 File Offset: 0x00102810
	[Token(Token = "0x6003160")]
	[Address(RVA = "0x6B6740", Offset = "0x6B4D40", VA = "0x1806B6740", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极杨桃大帝";
	}

	// Token: 0x06003161 RID: 12641 RVA: 0x00104624 File Offset: 0x00102824
	[Token(Token = "0x6003161")]
	[Address(RVA = "0x6B6DF0", Offset = "0x6B53F0", VA = "0x1806B6DF0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.config.zombieHealthMultiplier = 2f;
	}

	// Token: 0x06003162 RID: 12642 RVA: 0x00104648 File Offset: 0x00102848
	[Token(Token = "0x6003162")]
	[Address(RVA = "0x6B6C00", Offset = "0x6B5200", VA = "0x1806B6C00", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.StarUp();
		List<PlantType> ulockedPlants_temp = TravelMgr.Instance.ulockedPlants_temp;
		int num = ulockedPlants_temp._size + 1;
		ulockedPlants_temp._size = num;
		TravelMgr instance2 = TravelMgr.Instance;
		int num2 = 0;
		instance2.GetUltiBuff((UltiBuff)((uint)46), num2 != 0);
		TravelMgr instance3 = TravelMgr.Instance;
		int num3 = 0;
		instance3.GetUltiBuff((UltiBuff)((uint)47), num3 != 0);
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1017));
		TravelMgr.Instance.GetDebuff((TravelDebuff)((uint)6));
		TravelMgr.Instance.GetDebuff((TravelDebuff)((uint)7));
	}

	// Token: 0x06003163 RID: 12643 RVA: 0x001046F0 File Offset: 0x001028F0
	[Token(Token = "0x6003163")]
	[Address(RVA = "0x6B6770", Offset = "0x6B4D70", VA = "0x1806B6770", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极杨桃大帝可以获得1个星辉杨桃大帝";
		}
		return string.Empty;
	}

	// Token: 0x06003164 RID: 12644 RVA: 0x0010470C File Offset: 0x0010290C
	[Token(Token = "0x6003164")]
	[Address(RVA = "0x6B64F0", Offset = "0x6B4AF0", VA = "0x1806B64F0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<MissionResult> <>9__9_ = UltimateStarStrategy.<>c.<>9__9_0;
		if (<>9__9_ == 0)
		{
			Func<MissionResult> func;
			UltimateStarStrategy.<>c.<>9__9_0 = func;
		}
		advantureMission.target = <>9__9_;
		Func<ValueTuple<MissionResult, int>> func2;
		advantureMission.onSubmit = func2;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003165 RID: 12645 RVA: 0x0010477C File Offset: 0x0010297C
	[Token(Token = "0x6003165")]
	[Address(RVA = "0x6B6B40", Offset = "0x6B5140", VA = "0x1806B6B40", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		CardUI cardUI = board.CreateCard((PlantType)((uint)909), true, num != 0);
		int num2 = 0;
		cardUI.fullCD = 7.5f;
		CardUI cardUI2 = board.CreateCard((PlantType)((uint)920), true, num2 != 0);
		int num3 = 0;
		cardUI2.fullCD = 7.5f;
		CardUI cardUI3 = board.CreateCard((PlantType)((uint)977), true, num3 != 0);
		int num4 = 0;
		cardUI3.fullCD = 50f;
		board.CreateCard((PlantType)((uint)935), true, num4 != 0).fullCD = 30f;
	}

	// Token: 0x06003166 RID: 12646 RVA: 0x00104808 File Offset: 0x00102A08
	[Token(Token = "0x6003166")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public UltimateStarStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
