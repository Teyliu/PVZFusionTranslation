using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008CB RID: 2251
[Token(Token = "0x20008CB")]
public class Day5Strategy : BaseLevelStrategy
{
	// Token: 0x06002DC6 RID: 11718 RVA: 0x000FADCC File Offset: 0x000F8FCC
	[Token(Token = "0x6002DC6")]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day5;
	}

	// Token: 0x06002DC7 RID: 11719 RVA: 0x000FADDC File Offset: 0x000F8FDC
	[Token(Token = "0x6002DC7")]
	[Address(RVA = "0x697B90", Offset = "0x696190", VA = "0x180697B90", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		advantureMission.level = (AdvantureLevel)((ulong)5L);
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureConfig.SubmitPlantConfig(advantureMission, (PlantType)((uint)4), 16, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(advantureMission, (AdvantureLevel)((uint)5));
		return advantureMission;
	}

	// Token: 0x06002DC8 RID: 11720 RVA: 0x000FAE30 File Offset: 0x000F9030
	[Token(Token = "0x6002DC8")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002DC9 RID: 11721 RVA: 0x000FAE40 File Offset: 0x000F9040
	[Token(Token = "0x6002DC9")]
	[Address(RVA = "0x697E20", Offset = "0x696420", VA = "0x180697E20", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002DCA RID: 11722 RVA: 0x000FAE88 File Offset: 0x000F9088
	[Token(Token = "0x6002DCA")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.PotatoMine;
	}

	// Token: 0x06002DCB RID: 11723 RVA: 0x000FAE98 File Offset: 0x000F9098
	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002DCC RID: 11724 RVA: 0x000FAEB0 File Offset: 0x000F90B0
	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0x697CF0", Offset = "0x6962F0", VA = "0x180697CF0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉白天：第5关";
	}

	// Token: 0x06002DCD RID: 11725 RVA: 0x000FAEC4 File Offset: 0x000F90C4
	[Token(Token = "0x6002DCD")]
	[Address(RVA = "0x697DA0", Offset = "0x6963A0", VA = "0x180697DA0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "绝对低矮：第10波（第一大波僵尸）时，场上全部都是低矮植物";
		}
		if (result == MissionResult.Second)
		{
			return "炸土豆：提交16个土豆雷";
		}
		return string.Empty;
	}

	// Token: 0x06002DCE RID: 11726 RVA: 0x000FAEEC File Offset: 0x000F90EC
	[Token(Token = "0x6002DCE")]
	[Address(RVA = "0x697D20", Offset = "0x696320", VA = "0x180697D20", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "种植低矮植物时返还5点阳光";
		}
		if (result == MissionResult.Second)
		{
			return "土豆雷出土时间大幅降低";
		}
		return string.Empty;
	}

	// Token: 0x06002DCF RID: 11727 RVA: 0x000FAF14 File Offset: 0x000F9114
	[Token(Token = "0x6002DCF")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Day5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
