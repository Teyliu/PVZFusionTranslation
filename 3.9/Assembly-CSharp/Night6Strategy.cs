using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200091F RID: 2335
[Token(Token = "0x200091F")]
public class Night6Strategy : BaseLevelStrategy
{
	// Token: 0x06002F92 RID: 12178 RVA: 0x00100F60 File Offset: 0x000FF160
	[Token(Token = "0x6002F92")]
	[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night6;
	}

	// Token: 0x06002F93 RID: 12179 RVA: 0x00100F70 File Offset: 0x000FF170
	[Token(Token = "0x6002F93")]
	[Address(RVA = "0x715AF0", Offset = "0x7140F0", VA = "0x180715AF0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)18L)
		};
		AdvantureMission mission2 = mission;
		Func<MissionResult> func = delegate
		{
			bool flag = mission.count >= 100;
			throw new NullReferenceException();
		};
		mission2.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1236), 5, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)18));
		return mission;
	}

	// Token: 0x06002F94 RID: 12180 RVA: 0x00100FEC File Offset: 0x000FF1EC
	[Token(Token = "0x6002F94")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F95 RID: 12181 RVA: 0x00100FFC File Offset: 0x000FF1FC
	[Token(Token = "0x6002F95")]
	[Address(RVA = "0x715DA0", Offset = "0x7143A0", VA = "0x180715DA0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002F96 RID: 12182 RVA: 0x00101048 File Offset: 0x000FF248
	[Token(Token = "0x6002F96")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002F97 RID: 12183 RVA: 0x00101058 File Offset: 0x000FF258
	[Token(Token = "0x6002F97")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002F98 RID: 12184 RVA: 0x00101068 File Offset: 0x000FF268
	[Token(Token = "0x6002F98")]
	[Address(RVA = "0x715C60", Offset = "0x714260", VA = "0x180715C60", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第6关";
	}

	// Token: 0x06002F99 RID: 12185 RVA: 0x0010107C File Offset: 0x000FF27C
	[Token(Token = "0x6002F99")]
	[Address(RVA = "0x715D20", Offset = "0x714320", VA = "0x180715D20", Slot = "32")]
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

	// Token: 0x06002F9A RID: 12186 RVA: 0x001010A4 File Offset: 0x000FF2A4
	[Token(Token = "0x6002F9A")]
	[Address(RVA = "0x715CA0", Offset = "0x7142A0", VA = "0x180715CA0", Slot = "33")]
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

	// Token: 0x06002F9B RID: 12187 RVA: 0x001010CC File Offset: 0x000FF2CC
	[Token(Token = "0x6002F9B")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Night6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
