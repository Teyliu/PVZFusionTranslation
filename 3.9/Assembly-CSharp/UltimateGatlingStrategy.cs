using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000982 RID: 2434
[Token(Token = "0x2000982")]
public class UltimateGatlingStrategy : BaseLevelStrategy
{
	// Token: 0x0600322F RID: 12847 RVA: 0x00107E0C File Offset: 0x0010600C
	[Token(Token = "0x600322F")]
	[Address(RVA = "0x3F6F40", Offset = "0x3F5540", VA = "0x1803F6F40", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateGatling;
	}

	// Token: 0x06003230 RID: 12848 RVA: 0x00107E20 File Offset: 0x00106020
	[Token(Token = "0x6003230")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x06003231 RID: 12849 RVA: 0x00107E30 File Offset: 0x00106030
	[Token(Token = "0x6003231")]
	[Address(RVA = "0x72F830", Offset = "0x72DE30", VA = "0x18072F830", Slot = "24")]
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

	// Token: 0x06003232 RID: 12850 RVA: 0x00107EAC File Offset: 0x001060AC
	[Token(Token = "0x6003232")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06003233 RID: 12851 RVA: 0x00107EBC File Offset: 0x001060BC
	[Token(Token = "0x6003233")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06003234 RID: 12852 RVA: 0x00107ED4 File Offset: 0x001060D4
	[Token(Token = "0x6003234")]
	[Address(RVA = "0x72F7A0", Offset = "0x72DDA0", VA = "0x18072F7A0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极樱桃射手";
	}

	// Token: 0x06003235 RID: 12853 RVA: 0x00107EE8 File Offset: 0x001060E8
	[Token(Token = "0x6003235")]
	[Address(RVA = "0x72FCB0", Offset = "0x72E2B0", VA = "0x18072FCB0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.config.zombieCountMultiplier = 2f;
	}

	// Token: 0x06003236 RID: 12854 RVA: 0x00107F2C File Offset: 0x0010612C
	[Token(Token = "0x6003236")]
	[Address(RVA = "0x72FC00", Offset = "0x72E200", VA = "0x18072FC00", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.StarUp();
	}

	// Token: 0x06003237 RID: 12855 RVA: 0x00107F50 File Offset: 0x00106150
	[Token(Token = "0x6003237")]
	[Address(RVA = "0x72F480", Offset = "0x72DA80", VA = "0x18072F480", Slot = "26")]
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

	// Token: 0x06003238 RID: 12856 RVA: 0x00107FBC File Offset: 0x001061BC
	[Token(Token = "0x6003238")]
	[Address(RVA = "0x72F7D0", Offset = "0x72DDD0", VA = "0x18072F7D0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极樱桃射手可以获得1个星辉樱桃射手";
		}
		return string.Empty;
	}

	// Token: 0x06003239 RID: 12857 RVA: 0x00107FD8 File Offset: 0x001061D8
	[Token(Token = "0x6003239")]
	[Address(RVA = "0x72F230", Offset = "0x72D830", VA = "0x18072F230", Slot = "22")]
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
			UltimateGatlingStrategy.<>c.<>9__10_0 = () => MissionResult.Nothing;
		}
		advantureMission.target = <>9__10_;
		Func<ValueTuple<MissionResult, int>> func;
		advantureMission.onSubmit = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x0600323A RID: 12858 RVA: 0x00108058 File Offset: 0x00106258
	[Token(Token = "0x600323A")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public UltimateGatlingStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
