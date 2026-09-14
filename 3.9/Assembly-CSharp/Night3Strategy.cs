using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000918 RID: 2328
[Token(Token = "0x2000918")]
public class Night3Strategy : BaseLevelStrategy
{
	// Token: 0x06002F69 RID: 12137 RVA: 0x00100970 File Offset: 0x000FEB70
	[Token(Token = "0x6002F69")]
	[Address(RVA = "0x5D3550", Offset = "0x5D1B50", VA = "0x1805D3550", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night3;
	}

	// Token: 0x06002F6A RID: 12138 RVA: 0x00100980 File Offset: 0x000FEB80
	[Token(Token = "0x6002F6A")]
	[Address(RVA = "0x714E50", Offset = "0x713450", VA = "0x180714E50", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)15L)
		};
		AdvantureMission mission2 = mission;
		Func<MissionResult> func = delegate
		{
			bool flag = mission.count >= 10;
			throw new NullReferenceException();
		};
		mission2.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1147), 5, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)15));
		return mission;
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x001009FC File Offset: 0x000FEBFC
	[Token(Token = "0x6002F6B")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x00100A0C File Offset: 0x000FEC0C
	[Token(Token = "0x6002F6C")]
	[Address(RVA = "0x7150F0", Offset = "0x7136F0", VA = "0x1807150F0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x00100A50 File Offset: 0x000FEC50
	[Token(Token = "0x6002F6D")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002F6E RID: 12142 RVA: 0x00100A60 File Offset: 0x000FEC60
	[Token(Token = "0x6002F6E")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002F6F RID: 12143 RVA: 0x00100A70 File Offset: 0x000FEC70
	[Token(Token = "0x6002F6F")]
	[Address(RVA = "0x714FC0", Offset = "0x7135C0", VA = "0x180714FC0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第3关";
	}

	// Token: 0x06002F70 RID: 12144 RVA: 0x00100A84 File Offset: 0x000FEC84
	[Token(Token = "0x6002F70")]
	[Address(RVA = "0x715070", Offset = "0x713670", VA = "0x180715070", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "小局逆转：魅惑10个僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "熟能生巧：提交5个魅惑坚果";
		}
		return string.Empty;
	}

	// Token: 0x06002F71 RID: 12145 RVA: 0x00100AAC File Offset: 0x000FECAC
	[Token(Token = "0x6002F71")]
	[Address(RVA = "0x714FF0", Offset = "0x7135F0", VA = "0x180714FF0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "每局开始在每行生成一只魅惑僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "魅惑坚果生成僵尸的间隔减少5秒";
		}
		return string.Empty;
	}

	// Token: 0x06002F72 RID: 12146 RVA: 0x00100AD4 File Offset: 0x000FECD4
	[Token(Token = "0x6002F72")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Night3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
