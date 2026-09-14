using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008C3 RID: 2243
[Token(Token = "0x20008C3")]
public class Day1Strategy : BaseLevelStrategy
{
	// Token: 0x06002D95 RID: 11669 RVA: 0x000FA67C File Offset: 0x000F887C
	[Token(Token = "0x6002D95")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day1;
	}

	// Token: 0x06002D96 RID: 11670 RVA: 0x000FA68C File Offset: 0x000F888C
	[Token(Token = "0x6002D96")]
	[Address(RVA = "0x697030", Offset = "0x695630", VA = "0x180697030", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.theSun = (int)((ulong)1500L);
	}

	// Token: 0x06002D97 RID: 11671 RVA: 0x000FA6AC File Offset: 0x000F88AC
	[Token(Token = "0x6002D97")]
	[Address(RVA = "0x696CF0", Offset = "0x6952F0", VA = "0x180696CF0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)1L);
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureConfig.SetMissionDescription(advantureMission, (AdvantureLevel)((uint)1));
		return advantureMission;
	}

	// Token: 0x06002D98 RID: 11672 RVA: 0x000FA6F4 File Offset: 0x000F88F4
	[Token(Token = "0x6002D98")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "23")]
	public override int GetMaxWave()
	{
		return 8;
	}

	// Token: 0x06002D99 RID: 11673 RVA: 0x000FA704 File Offset: 0x000F8904
	[Token(Token = "0x6002D99")]
	[Address(RVA = "0x696F60", Offset = "0x695560", VA = "0x180696F60", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002D9A RID: 11674 RVA: 0x000FA73C File Offset: 0x000F893C
	[Token(Token = "0x6002D9A")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Peashooter;
	}

	// Token: 0x06002D9B RID: 11675 RVA: 0x000FA754 File Offset: 0x000F8954
	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002D9C RID: 11676 RVA: 0x000FA76C File Offset: 0x000F896C
	[Token(Token = "0x6002D9C")]
	[Address(RVA = "0x696E30", Offset = "0x695430", VA = "0x180696E30", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第1关";
	}

	// Token: 0x06002D9D RID: 11677 RVA: 0x000FA780 File Offset: 0x000F8980
	[Token(Token = "0x6002D9D")]
	[Address(RVA = "0x696EE0", Offset = "0x6954E0", VA = "0x180696EE0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "梦境之始：种植10株豌豆射手";
		}
		if (result == MissionResult.Second)
		{
			return "融合专精：融合5个双发射手（需要一直存在在场地上，直到任务完成）";
		}
		return string.Empty;
	}

	// Token: 0x06002D9E RID: 11678 RVA: 0x000FA7A8 File Offset: 0x000F89A8
	[Token(Token = "0x6002D9E")]
	[Address(RVA = "0x696E60", Offset = "0x695460", VA = "0x180696E60", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "每局开始赠送一个基础植物";
		}
		if (result == MissionResult.Second)
		{
			return "每局开始的第一次融合，都会奖励50阳光";
		}
		return string.Empty;
	}

	// Token: 0x06002D9F RID: 11679 RVA: 0x000FA7D0 File Offset: 0x000F89D0
	[Token(Token = "0x6002D9F")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Day1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
