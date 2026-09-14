using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000989 RID: 2441
[Token(Token = "0x2000989")]
public class UltimateFumeStrategy : BaseLevelStrategy
{
	// Token: 0x0600325E RID: 12894 RVA: 0x001088C0 File Offset: 0x00106AC0
	[Token(Token = "0x600325E")]
	[Address(RVA = "0x3F7020", Offset = "0x3F5620", VA = "0x1803F7020", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateFume;
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x001088D4 File Offset: 0x00106AD4
	[Token(Token = "0x600325F")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x001088E4 File Offset: 0x00106AE4
	[Token(Token = "0x6003260")]
	[Address(RVA = "0x72E910", Offset = "0x72CF10", VA = "0x18072E910", Slot = "24")]
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

	// Token: 0x06003261 RID: 12897 RVA: 0x0010898C File Offset: 0x00106B8C
	[Token(Token = "0x6003261")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.FumeShroom;
	}

	// Token: 0x06003262 RID: 12898 RVA: 0x0010899C File Offset: 0x00106B9C
	[Token(Token = "0x6003262")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night_6;
	}

	// Token: 0x06003263 RID: 12899 RVA: 0x001089AC File Offset: 0x00106BAC
	[Token(Token = "0x6003263")]
	[Address(RVA = "0x72E880", Offset = "0x72CE80", VA = "0x18072E880", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极大喷菇";
	}

	// Token: 0x06003264 RID: 12900 RVA: 0x001089C0 File Offset: 0x00106BC0
	[Token(Token = "0x6003264")]
	[Address(RVA = "0x72F200", Offset = "0x72D800", VA = "0x18072F200", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		config.zombieCountMultiplier = 2f;
		config.zombieSpeedMultiplier = 2f;
	}

	// Token: 0x06003265 RID: 12901 RVA: 0x001089F0 File Offset: 0x00106BF0
	[Token(Token = "0x6003265")]
	[Address(RVA = "0x72EFC0", Offset = "0x72D5C0", VA = "0x18072EFC0", Slot = "34")]
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

	// Token: 0x06003266 RID: 12902 RVA: 0x00108A84 File Offset: 0x00106C84
	[Token(Token = "0x6003266")]
	[Address(RVA = "0x72E8B0", Offset = "0x72CEB0", VA = "0x18072E8B0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极大喷菇可以获得1个星辉大喷菇";
		}
		return string.Empty;
	}

	// Token: 0x06003267 RID: 12903 RVA: 0x00108AA0 File Offset: 0x00106CA0
	[Token(Token = "0x6003267")]
	[Address(RVA = "0x72E630", Offset = "0x72CC30", VA = "0x18072E630", Slot = "22")]
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
			UltimateFumeStrategy.<>c.<>9__9_0 = () => MissionResult.Nothing;
		}
		advantureMission.target = <>9__9_;
		Func<ValueTuple<MissionResult, int>> func;
		advantureMission.onSubmit = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003268 RID: 12904 RVA: 0x00108B20 File Offset: 0x00106D20
	[Token(Token = "0x6003268")]
	[Address(RVA = "0x72EE80", Offset = "0x72D480", VA = "0x18072EE80", Slot = "35")]
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

	// Token: 0x06003269 RID: 12905 RVA: 0x00108C0C File Offset: 0x00106E0C
	[Token(Token = "0x6003269")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public UltimateFumeStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
