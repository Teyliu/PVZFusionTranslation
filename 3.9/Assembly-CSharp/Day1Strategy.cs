using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008FF RID: 2303
[Token(Token = "0x20008FF")]
public class Day1Strategy : BaseLevelStrategy
{
	// Token: 0x06002EC8 RID: 11976 RVA: 0x000FF14C File Offset: 0x000FD34C
	[Token(Token = "0x6002EC8")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day1;
	}

	// Token: 0x06002EC9 RID: 11977 RVA: 0x000FF15C File Offset: 0x000FD35C
	[Token(Token = "0x6002EC9")]
	[Address(RVA = "0x711130", Offset = "0x70F730", VA = "0x180711130", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.theSun = (int)((ulong)1500L);
	}

	// Token: 0x06002ECA RID: 11978 RVA: 0x000FF17C File Offset: 0x000FD37C
	[Token(Token = "0x6002ECA")]
	[Address(RVA = "0x710DF0", Offset = "0x70F3F0", VA = "0x180710DF0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)1L);
		Func<MissionResult> func = delegate
		{
			Board board3 = board;
			if (Lawnf.GetPlantCount(PlantType.Peashooter, board3) < 10)
			{
				Board board4 = board;
				int plantCount = Lawnf.GetPlantCount((PlantType)((uint)1030), board4);
			}
			return MissionResult.First;
		};
		advantureMission.target = func;
		AdvantureConfig.SetMissionDescription(advantureMission, (AdvantureLevel)((uint)1));
		return advantureMission;
	}

	// Token: 0x06002ECB RID: 11979 RVA: 0x000FF1D4 File Offset: 0x000FD3D4
	[Token(Token = "0x6002ECB")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "23")]
	public override int GetMaxWave()
	{
		return 8;
	}

	// Token: 0x06002ECC RID: 11980 RVA: 0x000FF1E4 File Offset: 0x000FD3E4
	[Token(Token = "0x6002ECC")]
	[Address(RVA = "0x711060", Offset = "0x70F660", VA = "0x180711060", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002ECD RID: 11981 RVA: 0x000FF21C File Offset: 0x000FD41C
	[Token(Token = "0x6002ECD")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Peashooter;
	}

	// Token: 0x06002ECE RID: 11982 RVA: 0x000FF234 File Offset: 0x000FD434
	[Token(Token = "0x6002ECE")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002ECF RID: 11983 RVA: 0x000FF24C File Offset: 0x000FD44C
	[Token(Token = "0x6002ECF")]
	[Address(RVA = "0x710F30", Offset = "0x70F530", VA = "0x180710F30", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第1关";
	}

	// Token: 0x06002ED0 RID: 11984 RVA: 0x000FF260 File Offset: 0x000FD460
	[Token(Token = "0x6002ED0")]
	[Address(RVA = "0x710FE0", Offset = "0x70F5E0", VA = "0x180710FE0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "梦境之始：种植10株豌豆射手";
		}
		if (result == MissionResult.Second)
		{
			return "融合专精：融合5个双发射手（需要一直存在在场地上，直到任务完成）";
		}
		return string.Empty;
	}

	// Token: 0x06002ED1 RID: 11985 RVA: 0x000FF288 File Offset: 0x000FD488
	[Token(Token = "0x6002ED1")]
	[Address(RVA = "0x710F60", Offset = "0x70F560", VA = "0x180710F60", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "每局开始赠送一个基础植物";
		}
		if (result == MissionResult.Second)
		{
			return "每局开始的第一次融合，都会奖励50阳光";
		}
		return string.Empty;
	}

	// Token: 0x06002ED2 RID: 11986 RVA: 0x000FF2B0 File Offset: 0x000FD4B0
	[Token(Token = "0x6002ED2")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Day1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
