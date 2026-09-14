using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000985 RID: 2437
[Token(Token = "0x2000985")]
public class UltimateChomperStrategy : BaseLevelStrategy
{
	// Token: 0x06003242 RID: 12866 RVA: 0x001081A4 File Offset: 0x001063A4
	[Token(Token = "0x6003242")]
	[Address(RVA = "0x3F7B60", Offset = "0x3F6160", VA = "0x1803F7B60", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateChomper;
	}

	// Token: 0x06003243 RID: 12867 RVA: 0x001081B8 File Offset: 0x001063B8
	[Token(Token = "0x6003243")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x06003244 RID: 12868 RVA: 0x001081C8 File Offset: 0x001063C8
	[Token(Token = "0x6003244")]
	[Address(RVA = "0x72DFB0", Offset = "0x72C5B0", VA = "0x18072DFB0", Slot = "24")]
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

	// Token: 0x06003245 RID: 12869 RVA: 0x00108244 File Offset: 0x00106444
	[Token(Token = "0x6003245")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06003246 RID: 12870 RVA: 0x00108254 File Offset: 0x00106454
	[Token(Token = "0x6003246")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06003247 RID: 12871 RVA: 0x0010826C File Offset: 0x0010646C
	[Token(Token = "0x6003247")]
	[Address(RVA = "0x72DF20", Offset = "0x72C520", VA = "0x18072DF20", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极樱桃战神";
	}

	// Token: 0x06003248 RID: 12872 RVA: 0x00108280 File Offset: 0x00106480
	[Token(Token = "0x6003248")]
	[Address(RVA = "0x72E600", Offset = "0x72CC00", VA = "0x18072E600", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.config.zombieCountMultiplier = 2f;
		board.boardTag.disableSelectCard = true;
	}

	// Token: 0x06003249 RID: 12873 RVA: 0x001082B0 File Offset: 0x001064B0
	[Token(Token = "0x6003249")]
	[Address(RVA = "0x72E510", Offset = "0x72CB10", VA = "0x18072E510", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.StarUp();
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
	}

	// Token: 0x0600324A RID: 12874 RVA: 0x001082E8 File Offset: 0x001064E8
	[Token(Token = "0x600324A")]
	[Address(RVA = "0x72DF50", Offset = "0x72C550", VA = "0x18072DF50", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极樱桃战神可以获得1个星辉樱桃战神";
		}
		return string.Empty;
	}

	// Token: 0x0600324B RID: 12875 RVA: 0x00108304 File Offset: 0x00106504
	[Token(Token = "0x600324B")]
	[Address(RVA = "0x72DCD0", Offset = "0x72C2D0", VA = "0x18072DCD0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<MissionResult> <>9__9_ = UltimateChomperStrategy.<>c.<>9__9_0;
		if (<>9__9_ == 0)
		{
			UltimateChomperStrategy.<>c.<>9__9_0 = () => MissionResult.Nothing;
		}
		advantureMission.target = <>9__9_;
		Func<ValueTuple<MissionResult, int>> func;
		advantureMission.onSubmit = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x0600324C RID: 12876 RVA: 0x00108384 File Offset: 0x00106584
	[Token(Token = "0x600324C")]
	[Address(RVA = "0x72E380", Offset = "0x72C980", VA = "0x18072E380", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		CardUI cardUI = board.CreateCard((PlantType)((uint)254), true, num != 0);
		int num2 = 0;
		CardUI cardUI2 = board.CreateCard((PlantType)((uint)254), true, num2 != 0);
		int num3 = 0;
		CardUI cardUI3 = board.CreateCard((PlantType)((uint)254), true, num3 != 0);
		int num4 = 0;
		CardUI cardUI4 = board.CreateCard((PlantType)((uint)254), true, num4 != 0);
		int num5 = 0;
		CardUI cardUI5 = board.CreateCard((PlantType)((uint)254), true, num5 != 0);
		int num6 = 0;
		CardUI cardUI6 = board.CreateCard((PlantType)((uint)254), true, num6 != 0);
		int num7 = 0;
		CardUI cardUI7 = board.CreateCard((PlantType)((uint)254), true, num7 != 0);
		int num8 = 0;
		CardUI cardUI8 = board.CreateCard((PlantType)((uint)254), true, num8 != 0);
		int num9 = 0;
		CardUI cardUI9 = board.CreateCard((PlantType)((uint)254), true, num9 != 0);
		int num10 = 0;
		CardUI cardUI10 = board.CreateCard((PlantType)((uint)254), true, num10 != 0);
		int num11 = 0;
		CardUI cardUI11 = board.CreateCard((PlantType)((uint)254), true, num11 != 0);
		board.PreSelect((PlantType)((uint)903)).fullCD = 50f;
		board.PreSelect((PlantType)((uint)903)).fullCD = 50f;
		board.PreSelect((PlantType)((uint)903)).fullCD = 50f;
	}

	// Token: 0x0600324D RID: 12877 RVA: 0x001084B4 File Offset: 0x001066B4
	[Token(Token = "0x600324D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public UltimateChomperStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
