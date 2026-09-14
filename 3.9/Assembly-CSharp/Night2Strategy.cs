using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000915 RID: 2325
[Token(Token = "0x2000915")]
public class Night2Strategy : BaseLevelStrategy
{
	// Token: 0x06002F5A RID: 12122 RVA: 0x0010072C File Offset: 0x000FE92C
	[Token(Token = "0x6002F5A")]
	[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night2;
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x0010073C File Offset: 0x000FE93C
	[Token(Token = "0x6002F5B")]
	[Address(RVA = "0x714A50", Offset = "0x713050", VA = "0x180714A50", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)14L),
			endResult = (MissionResult)((ulong)1L)
		};
		AdvantureMission mission3 = mission;
		Func<MissionResult> func = delegate
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			Func<Plant, bool> <>9__1_ = Night2Strategy.<>c.<>9__1_1;
			if (<>9__1_ == 0)
			{
				Night2Strategy.<>c.<>9__1_1 = (Plant p) => p.thePlantColumn > 3;
			}
			bool flag = Enumerable.FirstOrDefault<Plant>(allPlants, <>9__1_);
			int num = 0;
			if (flag)
			{
				mission.endResult = (MissionResult)num;
			}
			AdvantureMission mission2 = mission;
			throw new NullReferenceException();
		};
		mission3.target = func;
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)14));
		return mission;
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x001007B0 File Offset: 0x000FE9B0
	[Token(Token = "0x6002F5C")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x001007C0 File Offset: 0x000FE9C0
	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x714CE0", Offset = "0x7132E0", VA = "0x180714CE0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x00100808 File Offset: 0x000FEA08
	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.FumeShroom;
	}

	// Token: 0x06002F5F RID: 12127 RVA: 0x00100818 File Offset: 0x000FEA18
	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x00100828 File Offset: 0x000FEA28
	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x714BA0", Offset = "0x7131A0", VA = "0x180714BA0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第2关";
	}

	// Token: 0x06002F61 RID: 12129 RVA: 0x0010083C File Offset: 0x000FEA3C
	[Token(Token = "0x6002F61")]
	[Address(RVA = "0x714C60", Offset = "0x713260", VA = "0x180714C60", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "后勤补给：不在第5列及以右放置植物（从左到右开始一共10列）";
		}
		if (result == MissionResult.Second)
		{
			return "墓碑克星：使用墓碑吞噬者消灭15个墓碑（通过支线1获取植物）（需要开启难度3及以上）";
		}
		return string.Empty;
	}

	// Token: 0x06002F62 RID: 12130 RVA: 0x00100864 File Offset: 0x000FEA64
	[Token(Token = "0x6002F62")]
	[Address(RVA = "0x714BE0", Offset = "0x7131E0", VA = "0x180714BE0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "第一波僵尸到达的时间延后5秒";
		}
		if (result == MissionResult.Second)
		{
			return "额外的墓碑数量减半";
		}
		return string.Empty;
	}

	// Token: 0x06002F63 RID: 12131 RVA: 0x0010088C File Offset: 0x000FEA8C
	[Token(Token = "0x6002F63")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Night2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
