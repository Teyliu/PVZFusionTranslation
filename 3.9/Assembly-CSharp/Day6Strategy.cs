using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090A RID: 2314
[Token(Token = "0x200090A")]
public class Day6Strategy : BaseLevelStrategy
{
	// Token: 0x06002F08 RID: 12040 RVA: 0x000FFAFC File Offset: 0x000FDCFC
	[Token(Token = "0x6002F08")]
	[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day6;
	}

	// Token: 0x06002F09 RID: 12041 RVA: 0x000FFB0C File Offset: 0x000FDD0C
	[Token(Token = "0x6002F09")]
	[Address(RVA = "0x712090", Offset = "0x710690", VA = "0x180712090", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)6L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission2 = mission;
		Func<MissionResult> func = delegate
		{
			int num;
			do
			{
				int i = 0;
				num = 0;
				List<Plant> plantHead = board.boardEntity.plantHead;
				bool flag;
				if (flag)
				{
					if (i > 1)
					{
						while (i > 2)
						{
						}
					}
					num++;
				}
			}
			while (num != 0);
			if (num < 5)
			{
			}
			return MissionResult.First;
		};
		mission2.target = func;
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)6));
		return mission;
	}

	// Token: 0x06002F0A RID: 12042 RVA: 0x000FFB7C File Offset: 0x000FDD7C
	[Token(Token = "0x6002F0A")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F0B RID: 12043 RVA: 0x000FFB8C File Offset: 0x000FDD8C
	[Token(Token = "0x6002F0B")]
	[Address(RVA = "0x712320", Offset = "0x710920", VA = "0x180712320", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002F0C RID: 12044 RVA: 0x000FFBD4 File Offset: 0x000FDDD4
	[Token(Token = "0x6002F0C")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002F0D RID: 12045 RVA: 0x000FFBE4 File Offset: 0x000FDDE4
	[Token(Token = "0x6002F0D")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002F0E RID: 12046 RVA: 0x000FFBFC File Offset: 0x000FDDFC
	[Token(Token = "0x6002F0E")]
	[Address(RVA = "0x7121F0", Offset = "0x7107F0", VA = "0x1807121F0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第6关";
	}

	// Token: 0x06002F0F RID: 12047 RVA: 0x000FFC10 File Offset: 0x000FDE10
	[Token(Token = "0x6002F0F")]
	[Address(RVA = "0x7122A0", Offset = "0x7108A0", VA = "0x1807122A0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "大嘴狂欢：在场上集齐豌豆、向日葵、樱桃炸弹、坚果墙、土豆雷的大嘴花融合体";
		}
		if (result == MissionResult.Second)
		{
			return "盛宴：使用任意大嘴花吞咽25只僵尸";
		}
		return string.Empty;
	}

	// Token: 0x06002F10 RID: 12048 RVA: 0x000FFC38 File Offset: 0x000FDE38
	[Token(Token = "0x6002F10")]
	[Address(RVA = "0x712220", Offset = "0x710820", VA = "0x180712220", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "所有的大嘴花咀嚼速度+50%";
		}
		if (result == MissionResult.Second)
		{
			return "大嘴花的攻击范围+100%";
		}
		return string.Empty;
	}

	// Token: 0x06002F11 RID: 12049 RVA: 0x000FFC60 File Offset: 0x000FDE60
	[Token(Token = "0x6002F11")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Day6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
