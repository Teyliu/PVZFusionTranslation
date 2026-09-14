using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008DE RID: 2270
[Token(Token = "0x20008DE")]
public class Night4Strategy : BaseLevelStrategy
{
	// Token: 0x06002E42 RID: 11842 RVA: 0x000FBFB0 File Offset: 0x000FA1B0
	[Token(Token = "0x6002E42")]
	[Address(RVA = "0x69B2B0", Offset = "0x6998B0", VA = "0x18069B2B0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night4;
	}

	// Token: 0x06002E43 RID: 11843 RVA: 0x000FBFC0 File Offset: 0x000FA1C0
	[Token(Token = "0x6002E43")]
	[Address(RVA = "0x69B100", Offset = "0x699700", VA = "0x18069B100", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)16L),
			endResult = (MissionResult)((ulong)1L)
		};
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)9), 10, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)16));
		return mission;
	}

	// Token: 0x06002E44 RID: 11844 RVA: 0x000FC034 File Offset: 0x000FA234
	[Token(Token = "0x6002E44")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002E45 RID: 11845 RVA: 0x000FC044 File Offset: 0x000FA244
	[Token(Token = "0x6002E45")]
	[Address(RVA = "0x69B3C0", Offset = "0x6999C0", VA = "0x18069B3C0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002E46 RID: 11846 RVA: 0x000FC088 File Offset: 0x000FA288
	[Token(Token = "0x6002E46")]
	[Address(RVA = "0x3AC960", Offset = "0x3AAF60", VA = "0x1803AC960", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ScaredyShroom;
	}

	// Token: 0x06002E47 RID: 11847 RVA: 0x000FC098 File Offset: 0x000FA298
	[Token(Token = "0x6002E47")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E48 RID: 11848 RVA: 0x000FC0A8 File Offset: 0x000FA2A8
	[Token(Token = "0x6002E48")]
	[Address(RVA = "0x69B280", Offset = "0x699880", VA = "0x18069B280", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第4关";
	}

	// Token: 0x06002E49 RID: 11849 RVA: 0x000FC0BC File Offset: 0x000FA2BC
	[Token(Token = "0x6002E49")]
	[Address(RVA = "0x69B340", Offset = "0x699940", VA = "0x18069B340", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "前线作战：不在第3列及以左放置植物（从左到右开始一共10列）";
		}
		if (result == MissionResult.Second)
		{
			return "物美价廉：提交10个胆小菇";
		}
		return string.Empty;
	}

	// Token: 0x06002E4A RID: 11850 RVA: 0x000FC0E4 File Offset: 0x000FA2E4
	[Token(Token = "0x6002E4A")]
	[Address(RVA = "0x69B2C0", Offset = "0x6998C0", VA = "0x18069B2C0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "每一波僵尸的自然刷新间隔增加5秒";
		}
		if (result == MissionResult.Second)
		{
			return "蘑菇在黑夜时冷却降低10%，在白天时价格降低10";
		}
		return string.Empty;
	}

	// Token: 0x06002E4B RID: 11851 RVA: 0x000FC10C File Offset: 0x000FA30C
	[Token(Token = "0x6002E4B")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Night4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
