using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008DC RID: 2268
[Token(Token = "0x20008DC")]
public class Night3Strategy : BaseLevelStrategy
{
	// Token: 0x06002E36 RID: 11830 RVA: 0x000FBDFC File Offset: 0x000F9FFC
	[Token(Token = "0x6002E36")]
	[Address(RVA = "0x56FE40", Offset = "0x56E440", VA = "0x18056FE40", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night3;
	}

	// Token: 0x06002E37 RID: 11831 RVA: 0x000FBE0C File Offset: 0x000FA00C
	[Token(Token = "0x6002E37")]
	[Address(RVA = "0x69ACF0", Offset = "0x6992F0", VA = "0x18069ACF0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)15L)
		};
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1147), 5, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)15));
		return mission;
	}

	// Token: 0x06002E38 RID: 11832 RVA: 0x000FBE7C File Offset: 0x000FA07C
	[Token(Token = "0x6002E38")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002E39 RID: 11833 RVA: 0x000FBE8C File Offset: 0x000FA08C
	[Token(Token = "0x6002E39")]
	[Address(RVA = "0x69AF90", Offset = "0x699590", VA = "0x18069AF90", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002E3A RID: 11834 RVA: 0x000FBED0 File Offset: 0x000FA0D0
	[Token(Token = "0x6002E3A")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002E3B RID: 11835 RVA: 0x000FBEE0 File Offset: 0x000FA0E0
	[Token(Token = "0x6002E3B")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E3C RID: 11836 RVA: 0x000FBEF0 File Offset: 0x000FA0F0
	[Token(Token = "0x6002E3C")]
	[Address(RVA = "0x69AE60", Offset = "0x699460", VA = "0x18069AE60", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第3关";
	}

	// Token: 0x06002E3D RID: 11837 RVA: 0x000FBF04 File Offset: 0x000FA104
	[Token(Token = "0x6002E3D")]
	[Address(RVA = "0x69AF10", Offset = "0x699510", VA = "0x18069AF10", Slot = "32")]
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

	// Token: 0x06002E3E RID: 11838 RVA: 0x000FBF2C File Offset: 0x000FA12C
	[Token(Token = "0x6002E3E")]
	[Address(RVA = "0x69AE90", Offset = "0x699490", VA = "0x18069AE90", Slot = "33")]
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

	// Token: 0x06002E3F RID: 11839 RVA: 0x000FBF54 File Offset: 0x000FA154
	[Token(Token = "0x6002E3F")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Night3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
