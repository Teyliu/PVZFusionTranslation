using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008E3 RID: 2275
[Token(Token = "0x20008E3")]
public class Night6Strategy : BaseLevelStrategy
{
	// Token: 0x06002E5F RID: 11871 RVA: 0x000FC3A8 File Offset: 0x000FA5A8
	[Token(Token = "0x6002E5F")]
	[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night6;
	}

	// Token: 0x06002E60 RID: 11872 RVA: 0x000FC3B8 File Offset: 0x000FA5B8
	[Token(Token = "0x6002E60")]
	[Address(RVA = "0x69B990", Offset = "0x699F90", VA = "0x18069B990", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)18L)
		};
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1236), 5, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)18));
		return mission;
	}

	// Token: 0x06002E61 RID: 11873 RVA: 0x000FC428 File Offset: 0x000FA628
	[Token(Token = "0x6002E61")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002E62 RID: 11874 RVA: 0x000FC438 File Offset: 0x000FA638
	[Token(Token = "0x6002E62")]
	[Address(RVA = "0x69BC40", Offset = "0x69A240", VA = "0x18069BC40", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002E63 RID: 11875 RVA: 0x000FC484 File Offset: 0x000FA684
	[Token(Token = "0x6002E63")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002E64 RID: 11876 RVA: 0x000FC494 File Offset: 0x000FA694
	[Token(Token = "0x6002E64")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E65 RID: 11877 RVA: 0x000FC4A4 File Offset: 0x000FA6A4
	[Token(Token = "0x6002E65")]
	[Address(RVA = "0x69BB00", Offset = "0x69A100", VA = "0x18069BB00", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第6关";
	}

	// Token: 0x06002E66 RID: 11878 RVA: 0x000FC4B8 File Offset: 0x000FA6B8
	[Token(Token = "0x6002E66")]
	[Address(RVA = "0x69BBC0", Offset = "0x69A1C0", VA = "0x18069BBC0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "毁天灭地：使100只僵尸化为灰烬";
		}
		if (result == MissionResult.Second)
		{
			return "核弹储备：提交5个毁灭坚果";
		}
		return string.Empty;
	}

	// Token: 0x06002E67 RID: 11879 RVA: 0x000FC4E0 File Offset: 0x000FA6E0
	[Token(Token = "0x6002E67")]
	[Address(RVA = "0x69BB40", Offset = "0x69A140", VA = "0x18069BB40", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "灰烬伤害对僵尸额外造成10%的伤害";
		}
		if (result == MissionResult.Second)
		{
			return "毁灭菇的冷却时间-10%";
		}
		return string.Empty;
	}

	// Token: 0x06002E68 RID: 11880 RVA: 0x000FC508 File Offset: 0x000FA708
	[Token(Token = "0x6002E68")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Night6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
