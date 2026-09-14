using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008F2 RID: 2290
[Token(Token = "0x20008F2")]
public class Pool4Strategy : BaseLevelStrategy
{
	// Token: 0x06002EC5 RID: 11973 RVA: 0x000FD3A4 File Offset: 0x000FB5A4
	[Token(Token = "0x6002EC5")]
	[Address(RVA = "0x6A1A60", Offset = "0x6A0060", VA = "0x1806A1A60", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool4;
	}

	// Token: 0x06002EC6 RID: 11974 RVA: 0x000FD3B4 File Offset: 0x000FB5B4
	[Token(Token = "0x6002EC6")]
	[Address(RVA = "0x6A1B70", Offset = "0x6A0170", VA = "0x1806A1B70", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002EC7 RID: 11975 RVA: 0x000FD3F8 File Offset: 0x000FB5F8
	[Token(Token = "0x6002EC7")]
	[Address(RVA = "0x56FE40", Offset = "0x56E440", VA = "0x18056FE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Tanglekelp;
	}

	// Token: 0x06002EC8 RID: 11976 RVA: 0x000FD408 File Offset: 0x000FB608
	[Token(Token = "0x6002EC8")]
	[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.ReversalPool;
	}

	// Token: 0x06002EC9 RID: 11977 RVA: 0x000FD418 File Offset: 0x000FB618
	[Token(Token = "0x6002EC9")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002ECA RID: 11978 RVA: 0x000FD428 File Offset: 0x000FB628
	[Token(Token = "0x6002ECA")]
	[Address(RVA = "0x6A1A30", Offset = "0x6A0030", VA = "0x1806A1A30", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第4关";
	}

	// Token: 0x06002ECB RID: 11979 RVA: 0x000FD43C File Offset: 0x000FB63C
	[Token(Token = "0x6002ECB")]
	[Address(RVA = "0x6A1AF0", Offset = "0x6A00F0", VA = "0x1806A1AF0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "水上霸主：不在陆地上放置植物";
		}
		if (result == MissionResult.Second)
		{
			return "深渊猎手：使用水草拖拽15只僵尸下水";
		}
		return string.Empty;
	}

	// Token: 0x06002ECC RID: 11980 RVA: 0x000FD464 File Offset: 0x000FB664
	[Token(Token = "0x6002ECC")]
	[Address(RVA = "0x6A1A70", Offset = "0x6A0070", VA = "0x1806A1A70", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "水生植物获得20%的伤害加成";
		}
		if (result == MissionResult.Second)
		{
			return "水草的冷却时间减少20%";
		}
		return string.Empty;
	}

	// Token: 0x06002ECD RID: 11981 RVA: 0x000FD48C File Offset: 0x000FB68C
	[Token(Token = "0x6002ECD")]
	[Address(RVA = "0x6A1890", Offset = "0x69FE90", VA = "0x1806A1890", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002ECE RID: 11982 RVA: 0x000FD4FC File Offset: 0x000FB6FC
	[Token(Token = "0x6002ECE")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Pool4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
