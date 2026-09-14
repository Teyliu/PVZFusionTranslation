using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000949 RID: 2377
[Token(Token = "0x2000949")]
public class UltimateChomperStrategy : BaseLevelStrategy
{
	// Token: 0x0600310F RID: 12559 RVA: 0x00103428 File Offset: 0x00101628
	[Token(Token = "0x600310F")]
	[Address(RVA = "0x3ABD60", Offset = "0x3AA360", VA = "0x1803ABD60", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateChomper;
	}

	// Token: 0x06003110 RID: 12560 RVA: 0x0010343C File Offset: 0x0010163C
	[Token(Token = "0x6003110")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x06003111 RID: 12561 RVA: 0x0010344C File Offset: 0x0010164C
	[Token(Token = "0x6003111")]
	[Address(RVA = "0x6B3DC0", Offset = "0x6B23C0", VA = "0x1806B3DC0", Slot = "24")]
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

	// Token: 0x06003112 RID: 12562 RVA: 0x001034C8 File Offset: 0x001016C8
	[Token(Token = "0x6003112")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06003113 RID: 12563 RVA: 0x001034D8 File Offset: 0x001016D8
	[Token(Token = "0x6003113")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06003114 RID: 12564 RVA: 0x001034F0 File Offset: 0x001016F0
	[Token(Token = "0x6003114")]
	[Address(RVA = "0x6B3D30", Offset = "0x6B2330", VA = "0x1806B3D30", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极樱桃战神";
	}

	// Token: 0x06003115 RID: 12565 RVA: 0x00103504 File Offset: 0x00101704
	[Token(Token = "0x6003115")]
	[Address(RVA = "0x6B4410", Offset = "0x6B2A10", VA = "0x1806B4410", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.config.zombieCountMultiplier = 2f;
		board.boardTag.disableSelectCard = true;
	}

	// Token: 0x06003116 RID: 12566 RVA: 0x00103534 File Offset: 0x00101734
	[Token(Token = "0x6003116")]
	[Address(RVA = "0x6B4320", Offset = "0x6B2920", VA = "0x1806B4320", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.StarUp();
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
	}

	// Token: 0x06003117 RID: 12567 RVA: 0x0010356C File Offset: 0x0010176C
	[Token(Token = "0x6003117")]
	[Address(RVA = "0x6B3D60", Offset = "0x6B2360", VA = "0x1806B3D60", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极樱桃战神可以获得1个星辉樱桃战神";
		}
		return string.Empty;
	}

	// Token: 0x06003118 RID: 12568 RVA: 0x00103588 File Offset: 0x00101788
	[Token(Token = "0x6003118")]
	[Address(RVA = "0x6B3AE0", Offset = "0x6B20E0", VA = "0x1806B3AE0", Slot = "22")]
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
			Func<MissionResult> func;
			UltimateChomperStrategy.<>c.<>9__9_0 = func;
		}
		advantureMission.target = <>9__9_;
		Func<ValueTuple<MissionResult, int>> func2;
		advantureMission.onSubmit = func2;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003119 RID: 12569 RVA: 0x001035F8 File Offset: 0x001017F8
	[Token(Token = "0x6003119")]
	[Address(RVA = "0x6B4190", Offset = "0x6B2790", VA = "0x1806B4190", Slot = "35")]
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

	// Token: 0x0600311A RID: 12570 RVA: 0x00103728 File Offset: 0x00101928
	[Token(Token = "0x600311A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public UltimateChomperStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
