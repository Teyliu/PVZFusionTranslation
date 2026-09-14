using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008D6 RID: 2262
[Token(Token = "0x20008D6")]
public class Night1Strategy : BaseLevelStrategy
{
	// Token: 0x06002E18 RID: 11800 RVA: 0x000FB9A8 File Offset: 0x000F9BA8
	[Token(Token = "0x6002E18")]
	[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night1;
	}

	// Token: 0x06002E19 RID: 11801 RVA: 0x000FB9B8 File Offset: 0x000F9BB8
	[Token(Token = "0x6002E19")]
	[Address(RVA = "0x69A4D0", Offset = "0x698AD0", VA = "0x18069A4D0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)13L),
			endResult = (MissionResult)((ulong)1L)
		};
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1065), 3, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)13));
		return mission;
	}

	// Token: 0x06002E1A RID: 11802 RVA: 0x000FBA30 File Offset: 0x000F9C30
	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002E1B RID: 11803 RVA: 0x000FBA40 File Offset: 0x000F9C40
	[Token(Token = "0x6002E1B")]
	[Address(RVA = "0x69A780", Offset = "0x698D80", VA = "0x18069A780", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002E1C RID: 11804 RVA: 0x000FBA88 File Offset: 0x000F9C88
	[Token(Token = "0x6002E1C")]
	[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SmallPuff;
	}

	// Token: 0x06002E1D RID: 11805 RVA: 0x000FBA98 File Offset: 0x000F9C98
	[Token(Token = "0x6002E1D")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E1E RID: 11806 RVA: 0x000FBAA8 File Offset: 0x000F9CA8
	[Token(Token = "0x6002E1E")]
	[Address(RVA = "0x69A650", Offset = "0x698C50", VA = "0x18069A650", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第1关";
	}

	// Token: 0x06002E1F RID: 11807 RVA: 0x000FBABC File Offset: 0x000F9CBC
	[Token(Token = "0x6002E1F")]
	[Address(RVA = "0x69A700", Offset = "0x698D00", VA = "0x18069A700", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "开源节流：不携带向日葵进入关卡";
		}
		if (result == MissionResult.Second)
		{
			return "合理密植：提交3个机枪小喷菇";
		}
		return string.Empty;
	}

	// Token: 0x06002E20 RID: 11808 RVA: 0x000FBAE4 File Offset: 0x000F9CE4
	[Token(Token = "0x6002E20")]
	[Address(RVA = "0x69A680", Offset = "0x698C80", VA = "0x18069A680", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "向日葵的阳光消耗降低5";
		}
		if (result == MissionResult.Second)
		{
			return "小喷菇的冷却时间降低20%";
		}
		return string.Empty;
	}

	// Token: 0x06002E21 RID: 11809 RVA: 0x000FBB0C File Offset: 0x000F9D0C
	[Token(Token = "0x6002E21")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Night1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
