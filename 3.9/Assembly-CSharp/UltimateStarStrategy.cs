using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000990 RID: 2448
[Token(Token = "0x2000990")]
public class UltimateStarStrategy : BaseLevelStrategy
{
	// Token: 0x0600328E RID: 12942 RVA: 0x001092BC File Offset: 0x001074BC
	[Token(Token = "0x600328E")]
	[Address(RVA = "0x3F2C00", Offset = "0x3F1200", VA = "0x1803F2C00", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateStar;
	}

	// Token: 0x0600328F RID: 12943 RVA: 0x001092D0 File Offset: 0x001074D0
	[Token(Token = "0x600328F")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x06003290 RID: 12944 RVA: 0x001092E0 File Offset: 0x001074E0
	[Token(Token = "0x6003290")]
	[Address(RVA = "0x7309C0", Offset = "0x72EFC0", VA = "0x1807309C0", Slot = "24")]
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

	// Token: 0x06003291 RID: 12945 RVA: 0x00109354 File Offset: 0x00107554
	[Token(Token = "0x6003291")]
	[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.StarFruit;
	}

	// Token: 0x06003292 RID: 12946 RVA: 0x00109364 File Offset: 0x00107564
	[Token(Token = "0x6003292")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06003293 RID: 12947 RVA: 0x00109374 File Offset: 0x00107574
	[Token(Token = "0x6003293")]
	[Address(RVA = "0x730930", Offset = "0x72EF30", VA = "0x180730930", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极杨桃大帝";
	}

	// Token: 0x06003294 RID: 12948 RVA: 0x00109388 File Offset: 0x00107588
	[Token(Token = "0x6003294")]
	[Address(RVA = "0x730FE0", Offset = "0x72F5E0", VA = "0x180730FE0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.config.zombieHealthMultiplier = 2f;
	}

	// Token: 0x06003295 RID: 12949 RVA: 0x001093AC File Offset: 0x001075AC
	[Token(Token = "0x6003295")]
	[Address(RVA = "0x730DF0", Offset = "0x72F3F0", VA = "0x180730DF0", Slot = "34")]
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

	// Token: 0x06003296 RID: 12950 RVA: 0x00109454 File Offset: 0x00107654
	[Token(Token = "0x6003296")]
	[Address(RVA = "0x730960", Offset = "0x72EF60", VA = "0x180730960", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极杨桃大帝可以获得1个星辉杨桃大帝";
		}
		return string.Empty;
	}

	// Token: 0x06003297 RID: 12951 RVA: 0x00109470 File Offset: 0x00107670
	[Token(Token = "0x6003297")]
	[Address(RVA = "0x7306E0", Offset = "0x72ECE0", VA = "0x1807306E0", Slot = "22")]
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
			UltimateStarStrategy.<>c.<>9__9_0 = () => MissionResult.Nothing;
		}
		advantureMission.target = <>9__9_;
		Func<ValueTuple<MissionResult, int>> func;
		advantureMission.onSubmit = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003298 RID: 12952 RVA: 0x001094F0 File Offset: 0x001076F0
	[Token(Token = "0x6003298")]
	[Address(RVA = "0x730D30", Offset = "0x72F330", VA = "0x180730D30", Slot = "35")]
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

	// Token: 0x06003299 RID: 12953 RVA: 0x0010957C File Offset: 0x0010777C
	[Token(Token = "0x6003299")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public UltimateStarStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
