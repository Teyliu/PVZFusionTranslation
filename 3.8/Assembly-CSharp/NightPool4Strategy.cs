using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000906 RID: 2310
[Token(Token = "0x2000906")]
public class NightPool4Strategy : BaseLevelStrategy
{
	// Token: 0x06002F4A RID: 12106 RVA: 0x000FEA4C File Offset: 0x000FCC4C
	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool4;
	}

	// Token: 0x06002F4B RID: 12107 RVA: 0x000FEA5C File Offset: 0x000FCC5C
	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0x69D030", Offset = "0x69B630", VA = "0x18069D030", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		return list;
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x000FEAB0 File Offset: 0x000FCCB0
	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x000FEAC0 File Offset: 0x000FCCC0
	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F4E RID: 12110 RVA: 0x000FEAD0 File Offset: 0x000FCCD0
	[Token(Token = "0x6002F4E")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x000FEAE0 File Offset: 0x000FCCE0
	[Token(Token = "0x6002F4F")]
	[Address(RVA = "0x69CEF0", Offset = "0x69B4F0", VA = "0x18069CEF0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第4关";
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x000FEAF4 File Offset: 0x000FCCF4
	[Token(Token = "0x6002F50")]
	[Address(RVA = "0x69CFB0", Offset = "0x69B5B0", VA = "0x18069CFB0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "强风吹拂：使用三叶草吹跑10个气球僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "飞行植物研究：提交4株浮空仙人球";
		}
		return string.Empty;
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x000FEB1C File Offset: 0x000FCD1C
	[Token(Token = "0x6002F51")]
	[Address(RVA = "0x69CF30", Offset = "0x69B530", VA = "0x18069CF30", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "三叶草的风力效果提高20%，并且可动铁气球";
		}
		if (result == MissionResult.Second)
		{
			return "飞行植物获得30%伤害加成";
		}
		return string.Empty;
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x000FEB44 File Offset: 0x000FCD44
	[Token(Token = "0x6002F52")]
	[Address(RVA = "0x69CCE0", Offset = "0x69B2E0", VA = "0x18069CCE0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission4 = mission;
		Action action = delegate
		{
			InGameText instance = InGameText.Instance;
			AdvantureMission mission3 = mission;
			int num;
			string text = string.Format("还需吹跑{0}只僵尸", num);
			int num2 = 0;
			instance.ShowText(text, 3f, num2 != 0);
		};
		mission4.onLook = action;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1082), 4, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002F53 RID: 12115 RVA: 0x000FEBD8 File Offset: 0x000FCDD8
	[Token(Token = "0x6002F53")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPool4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
