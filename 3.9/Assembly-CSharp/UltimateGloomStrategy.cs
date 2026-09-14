using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200098C RID: 2444
[Token(Token = "0x200098C")]
public class UltimateGloomStrategy : BaseLevelStrategy
{
	// Token: 0x06003271 RID: 12913 RVA: 0x00108D58 File Offset: 0x00106F58
	[Token(Token = "0x6003271")]
	[Address(RVA = "0x3F8A60", Offset = "0x3F7060", VA = "0x1803F8A60", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.UltimateGloom;
	}

	// Token: 0x06003272 RID: 12914 RVA: 0x00108D6C File Offset: 0x00106F6C
	[Token(Token = "0x6003272")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x06003273 RID: 12915 RVA: 0x00108D7C File Offset: 0x00106F7C
	[Token(Token = "0x6003273")]
	[Address(RVA = "0x72FFD0", Offset = "0x72E5D0", VA = "0x18072FFD0", Slot = "24")]
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

	// Token: 0x06003274 RID: 12916 RVA: 0x00108E24 File Offset: 0x00107024
	[Token(Token = "0x6003274")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.FumeShroom;
	}

	// Token: 0x06003275 RID: 12917 RVA: 0x00108E34 File Offset: 0x00107034
	[Token(Token = "0x6003275")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night_6;
	}

	// Token: 0x06003276 RID: 12918 RVA: 0x00108E44 File Offset: 0x00107044
	[Token(Token = "0x6003276")]
	[Address(RVA = "0x72FF40", Offset = "0x72E540", VA = "0x18072FF40", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉体验：究极忧郁菇";
	}

	// Token: 0x06003277 RID: 12919 RVA: 0x00108E58 File Offset: 0x00107058
	[Token(Token = "0x6003277")]
	[Address(RVA = "0x7305F0", Offset = "0x72EBF0", VA = "0x1807305F0", Slot = "21")]
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

	// Token: 0x06003278 RID: 12920 RVA: 0x00108EAC File Offset: 0x001070AC
	[Token(Token = "0x6003278")]
	[Address(RVA = "0x730540", Offset = "0x72EB40", VA = "0x180730540", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		plant.StarUp();
	}

	// Token: 0x06003279 RID: 12921 RVA: 0x00108ED0 File Offset: 0x001070D0
	[Token(Token = "0x6003279")]
	[Address(RVA = "0x72FF70", Offset = "0x72E570", VA = "0x18072FF70", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交5个究极忧郁菇可以获得1个星辉忧郁菇";
		}
		return string.Empty;
	}

	// Token: 0x0600327A RID: 12922 RVA: 0x00108EEC File Offset: 0x001070EC
	[Token(Token = "0x600327A")]
	[Address(RVA = "0x72FCF0", Offset = "0x72E2F0", VA = "0x18072FCF0", Slot = "22")]
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
			UltimateGloomStrategy.<>c.<>9__9_0 = () => MissionResult.Nothing;
		}
		advantureMission.target = <>9__9_;
		Func<ValueTuple<MissionResult, int>> func;
		advantureMission.onSubmit = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x0600327B RID: 12923 RVA: 0x00108F6C File Offset: 0x0010716C
	[Token(Token = "0x600327B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
	}

	// Token: 0x0600327C RID: 12924 RVA: 0x00108F7C File Offset: 0x0010717C
	[Token(Token = "0x600327C")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public UltimateGloomStrategy()
	{
		int num = 0;
		this.InitCard(num);
	}
}
