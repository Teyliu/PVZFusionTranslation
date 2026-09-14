using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000968 RID: 2408
[Token(Token = "0x2000968")]
public class Snow3Strategy : BaseLevelStrategy
{
	// Token: 0x06003178 RID: 12664 RVA: 0x00105D48 File Offset: 0x00103F48
	[Token(Token = "0x6003178")]
	[Address(RVA = "0x524F40", Offset = "0x523540", VA = "0x180524F40", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow3;
	}

	// Token: 0x06003179 RID: 12665 RVA: 0x00105D58 File Offset: 0x00103F58
	[Token(Token = "0x6003179")]
	[Address(RVA = "0x724AA0", Offset = "0x7230A0", VA = "0x180724AA0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x0600317A RID: 12666 RVA: 0x00105DA8 File Offset: 0x00103FA8
	[Token(Token = "0x600317A")]
	[Address(RVA = "0x71D780", Offset = "0x71BD80", VA = "0x18071D780", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Shulkflower;
	}

	// Token: 0x0600317B RID: 12667 RVA: 0x00105DB8 File Offset: 0x00103FB8
	[Token(Token = "0x600317B")]
	[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x0600317C RID: 12668 RVA: 0x00105DC8 File Offset: 0x00103FC8
	[Token(Token = "0x600317C")]
	[Address(RVA = "0x724970", Offset = "0x722F70", VA = "0x180724970", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第3关";
	}

	// Token: 0x0600317D RID: 12669 RVA: 0x00105DDC File Offset: 0x00103FDC
	[Token(Token = "0x600317D")]
	[Address(RVA = "0x724A20", Offset = "0x723020", VA = "0x180724A20", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "坚盾如铁：使用钢叶草护盾缓和10000点伤害";
		}
		if (result == MissionResult.Second)
		{
			return "爆发输出：使用钢叶草在1秒内造成1000伤害";
		}
		return string.Empty;
	}

	// Token: 0x0600317E RID: 12670 RVA: 0x00105E04 File Offset: 0x00104004
	[Token(Token = "0x600317E")]
	[Address(RVA = "0x7249A0", Offset = "0x722FA0", VA = "0x1807249A0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "钢叶草的护盾上限翻倍，护盾获取效率翻倍";
		}
		if (result == MissionResult.Second)
		{
			return "钢叶草攻击群怪时伤害不再衰减";
		}
		return string.Empty;
	}

	// Token: 0x0600317F RID: 12671 RVA: 0x00105E2C File Offset: 0x0010402C
	[Token(Token = "0x600317F")]
	[Address(RVA = "0x7247D0", Offset = "0x722DD0", VA = "0x1807247D0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.timer = -1f;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission5 = mission;
		float startDamage = 0f;
		Func<MissionResult> func = delegate
		{
			AdvantureMission mission3 = mission;
			int num = 0;
			if (mission3.count < 10000)
			{
				bool flag = board.damageReporter.ReportDic.TryGetValue((uint)33, num);
				float time = Time.time;
				AdvantureMission mission4 = mission;
				int num2 = 0;
				if (num2 <= (int)mission4.timer)
				{
					float startDamage2 = startDamage;
					int num3 = 0;
					if (startDamage2 <= (float)num3)
					{
						float num4 = mission4.timer;
						if (num4 <= (float)num2)
						{
							goto IL_0093;
						}
						num4 = time;
						if (num4 <= 1f)
						{
							goto IL_0093;
						}
					}
				}
				int num5 = 0;
				mission4.timer = time;
				startDamage = (float)num5;
				IL_0093:
				if (mission.timer > (float)num2)
				{
				}
			}
			return MissionResult.First;
		};
		mission5.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003180 RID: 12672 RVA: 0x00105EBC File Offset: 0x001040BC
	[Token(Token = "0x6003180")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003181 RID: 12673 RVA: 0x00105ECC File Offset: 0x001040CC
	[Token(Token = "0x6003181")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Snow3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
