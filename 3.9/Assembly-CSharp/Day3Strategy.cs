using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000903 RID: 2307
[Token(Token = "0x2000903")]
public class Day3Strategy : BaseLevelStrategy
{
	// Token: 0x06002EE1 RID: 12001 RVA: 0x000FF4D4 File Offset: 0x000FD6D4
	[Token(Token = "0x6002EE1")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day3;
	}

	// Token: 0x06002EE2 RID: 12002 RVA: 0x000FF4E4 File Offset: 0x000FD6E4
	[Token(Token = "0x6002EE2")]
	[Address(RVA = "0x7114B0", Offset = "0x70FAB0", VA = "0x1807114B0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)3L);
		advantureMission.timer = -1f;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		float startSun = 0f;
		Func<MissionResult> func = delegate
		{
			Board board3 = board;
			float time = Time.time;
			AdvantureMission mission2 = mission;
			int num = 0;
			if (num <= (int)mission2.timer)
			{
				float startSun2 = startSun;
				float num2 = mission2.timer;
				if (num2 <= (float)num)
				{
					goto IL_004C;
				}
				num2 = time;
				if (num2 <= 1f)
				{
					goto IL_004C;
				}
			}
			mission2.timer = time;
			IL_004C:
			if (mission.timer > (float)num)
			{
			}
			throw new NullReferenceException();
		};
		mission3.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1017), 3, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)3));
		return mission;
	}

	// Token: 0x06002EE3 RID: 12003 RVA: 0x000FF580 File Offset: 0x000FD780
	[Token(Token = "0x6002EE3")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002EE4 RID: 12004 RVA: 0x000FF590 File Offset: 0x000FD790
	[Token(Token = "0x6002EE4")]
	[Address(RVA = "0x711770", Offset = "0x70FD70", VA = "0x180711770", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x06002EE5 RID: 12005 RVA: 0x000FF5D0 File Offset: 0x000FD7D0
	[Token(Token = "0x6002EE5")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002EE6 RID: 12006 RVA: 0x000FF5E0 File Offset: 0x000FD7E0
	[Token(Token = "0x6002EE6")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002EE7 RID: 12007 RVA: 0x000FF5F8 File Offset: 0x000FD7F8
	[Token(Token = "0x6002EE7")]
	[Address(RVA = "0x711640", Offset = "0x70FC40", VA = "0x180711640", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第3关";
	}

	// Token: 0x06002EE8 RID: 12008 RVA: 0x000FF60C File Offset: 0x000FD80C
	[Token(Token = "0x6002EE8")]
	[Address(RVA = "0x7116F0", Offset = "0x70FCF0", VA = "0x1807116F0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "极速制备：在1秒内获得250阳光";
		}
		if (result == MissionResult.Second)
		{
			return "樱桃研究：提交3个樱桃机枪射手";
		}
		return string.Empty;
	}

	// Token: 0x06002EE9 RID: 12009 RVA: 0x000FF634 File Offset: 0x000FD834
	[Token(Token = "0x6002EE9")]
	[Address(RVA = "0x711670", Offset = "0x70FC70", VA = "0x180711670", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "阳光炸弹的阳光产量永久x3";
		}
		if (result == MissionResult.Second)
		{
			return "樱桃子弹击中僵尸时有概率释放小樱桃爆炸";
		}
		return string.Empty;
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x000FF65C File Offset: 0x000FD85C
	[Token(Token = "0x6002EEA")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Day3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
