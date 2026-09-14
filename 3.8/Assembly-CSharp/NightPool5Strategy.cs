using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000908 RID: 2312
[Token(Token = "0x2000908")]
public class NightPool5Strategy : BaseLevelStrategy
{
	// Token: 0x06002F57 RID: 12119 RVA: 0x000FEC78 File Offset: 0x000FCE78
	[Token(Token = "0x6002F57")]
	[Address(RVA = "0x69D470", Offset = "0x69BA70", VA = "0x18069D470", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool5;
	}

	// Token: 0x06002F58 RID: 12120 RVA: 0x000FEC88 File Offset: 0x000FCE88
	[Token(Token = "0x6002F58")]
	[Address(RVA = "0x69D580", Offset = "0x69BB80", VA = "0x18069D580", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002F59 RID: 12121 RVA: 0x000FECD4 File Offset: 0x000FCED4
	[Token(Token = "0x6002F59")]
	[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x06002F5A RID: 12122 RVA: 0x000FECE4 File Offset: 0x000FCEE4
	[Token(Token = "0x6002F5A")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x000FECF4 File Offset: 0x000FCEF4
	[Token(Token = "0x6002F5B")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x000FED04 File Offset: 0x000FCF04
	[Token(Token = "0x6002F5C")]
	[Address(RVA = "0x69D440", Offset = "0x69BA40", VA = "0x18069D440", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第5关";
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x000FED18 File Offset: 0x000FCF18
	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x69D500", Offset = "0x69BB00", VA = "0x18069D500", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "幸运五叶草：使用杨桃五叶草强化300发子弹";
		}
		if (result == MissionResult.Second)
		{
			return "精准数字：使用任意植物造成1437点伤害";
		}
		return string.Empty;
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x000FED40 File Offset: 0x000FCF40
	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x69D480", Offset = "0x69BA80", VA = "0x18069D480", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "杨桃五叶草额外为子弹提高20%伤害";
		}
		if (result == MissionResult.Second)
		{
			return "杨桃家族植物伤害增加20%";
		}
		return string.Empty;
	}

	// Token: 0x06002F5F RID: 12127 RVA: 0x000FED68 File Offset: 0x000FCF68
	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0x69D250", Offset = "0x69B850", VA = "0x18069D250", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission4 = mission;
		Action action = delegate
		{
			InGameText instance = InGameText.Instance;
			AdvantureMission mission3 = mission;
			int num;
			string text = string.Format("还需强化{0}发子弹", num);
			int num2 = 0;
			instance.ShowText(text, 3f, num2 != 0);
		};
		mission4.onLook = action;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x000FEDF0 File Offset: 0x000FCFF0
	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPool5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
