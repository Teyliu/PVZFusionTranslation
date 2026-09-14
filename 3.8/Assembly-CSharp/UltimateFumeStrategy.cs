using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x0200094D RID: 2381
[Token(Token = "0x200094D")]
public class UltimateFumeStrategy : BaseLevelStrategy
{
	// Token: 0x0600312B RID: 12587 RVA: 0x00103B4C File Offset: 0x00101D4C
	[Token(Token = "0x600312B")]
	[Address(RVA = "0x3AB220", Offset = "0x3A9820", VA = "0x1803AB220", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateFume;
	}

	// Token: 0x0600312C RID: 12588 RVA: 0x00103B60 File Offset: 0x00101D60
	[Token(Token = "0x600312C")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x0600312D RID: 12589 RVA: 0x00103B70 File Offset: 0x00101D70
	[Token(Token = "0x600312D")]
	[Address(RVA = "0x6B4720", Offset = "0x6B2D20", VA = "0x1806B4720", Slot = "24")]
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

	// Token: 0x0600312E RID: 12590 RVA: 0x00103C18 File Offset: 0x00101E18
	[Token(Token = "0x600312E")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.FumeShroom;
	}

	// Token: 0x0600312F RID: 12591 RVA: 0x00103C28 File Offset: 0x00101E28
	[Token(Token = "0x600312F")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night_6;
	}

	// Token: 0x06003130 RID: 12592 RVA: 0x00103C38 File Offset: 0x00101E38
	[Token(Token = "0x6003130")]
	[Address(RVA = "0x6B4690", Offset = "0x6B2C90", VA = "0x1806B4690", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极大喷菇";
	}

	// Token: 0x06003131 RID: 12593 RVA: 0x00103C4C File Offset: 0x00101E4C
	[Token(Token = "0x6003131")]
	[Address(RVA = "0x6B5010", Offset = "0x6B3610", VA = "0x1806B5010", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieCountMultiplier = 2f;
		config.zombieSpeedMultiplier = 2f;
	}

	// Token: 0x06003132 RID: 12594 RVA: 0x00103C7C File Offset: 0x00101E7C
	[Token(Token = "0x6003132")]
	[Address(RVA = "0x6B4DD0", Offset = "0x6B33D0", VA = "0x1806B4DD0", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.StarUp();
		TravelMgr instance2 = TravelMgr.Instance;
		instance2.GetNormalBuff((AdvBuff)((uint)11));
		instance2.GetNormalBuff((AdvBuff)((uint)10));
		List<PlantType> ulockedPlants_temp = instance2.ulockedPlants_temp;
		int num = ulockedPlants_temp._size + 1;
		ulockedPlants_temp._size = num;
		List<PlantType> ulockedPlants_temp2 = instance2.ulockedPlants_temp;
		int size = ulockedPlants_temp2._size;
		ulockedPlants_temp2._size = num;
		List<PlantType> ulockedPlants_temp3 = instance2.ulockedPlants_temp;
		int size2 = ulockedPlants_temp3._size;
	}

	// Token: 0x06003133 RID: 12595 RVA: 0x00103D10 File Offset: 0x00101F10
	[Token(Token = "0x6003133")]
	[Address(RVA = "0x6B46C0", Offset = "0x6B2CC0", VA = "0x1806B46C0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极大喷菇可以获得1个星辉大喷菇";
		}
		return string.Empty;
	}

	// Token: 0x06003134 RID: 12596 RVA: 0x00103D2C File Offset: 0x00101F2C
	[Token(Token = "0x6003134")]
	[Address(RVA = "0x6B4440", Offset = "0x6B2A40", VA = "0x1806B4440", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<MissionResult> <>9__9_ = UltimateFumeStrategy.<>c.<>9__9_0;
		if (<>9__9_ == 0)
		{
			Func<MissionResult> func;
			UltimateFumeStrategy.<>c.<>9__9_0 = func;
		}
		advantureMission.target = <>9__9_;
		Func<ValueTuple<MissionResult, int>> func2;
		advantureMission.onSubmit = func2;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003135 RID: 12597 RVA: 0x00103D9C File Offset: 0x00101F9C
	[Token(Token = "0x6003135")]
	[Address(RVA = "0x6B4C90", Offset = "0x6B3290", VA = "0x1806B4C90", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		CardUI cardUI = board.CreateCard((PlantType)((uint)908), true, num != 0);
		int num2 = 0;
		cardUI.fullCD = 3f;
		CardUI cardUI2 = board.CreateCard((PlantType)((uint)904), true, num2 != 0);
		int num3 = 0;
		cardUI2.fullCD = 7.5f;
		CardUI cardUI3 = board.CreateCard((PlantType)((uint)916), true, num3 != 0);
		int num4 = 0;
		cardUI3.fullCD = 7.5f;
		CardUI cardUI4 = board.CreateCard((PlantType)((uint)913), true, num4 != 0);
		int num5 = 0;
		cardUI4.fullCD = 30f;
		CardUI cardUI5 = board.CreateCard((PlantType)((uint)913), true, num5 != 0);
		int num6 = 0;
		cardUI5.fullCD = 30f;
		CardUI cardUI6 = board.CreateCard((PlantType)((uint)935), true, num6 != 0);
		int num7 = 0;
		cardUI6.fullCD = 30f;
		board.CreateCard((PlantType)((uint)935), true, num7 != 0).fullCD = 30f;
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x00103E88 File Offset: 0x00102088
	[Token(Token = "0x6003136")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public UltimateFumeStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
