using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008E1 RID: 2273
[Token(Token = "0x20008E1")]
public class Night5Strategy : BaseLevelStrategy
{
	// Token: 0x06002E51 RID: 11857 RVA: 0x000FC1D8 File Offset: 0x000FA3D8
	[Token(Token = "0x6002E51")]
	[Address(RVA = "0x69B710", Offset = "0x699D10", VA = "0x18069B710", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night5;
	}

	// Token: 0x06002E52 RID: 11858 RVA: 0x000FC1E8 File Offset: 0x000FA3E8
	[Token(Token = "0x6002E52")]
	[Address(RVA = "0x69B530", Offset = "0x699B30", VA = "0x18069B530", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		advantureMission.level = (AdvantureLevel)((ulong)17L);
		Func<MissionResult> <>9__1_ = Night5Strategy.<>c.<>9__1_0;
		if (<>9__1_ == 0)
		{
			Func<MissionResult> func;
			Night5Strategy.<>c.<>9__1_0 = func;
		}
		advantureMission.target = <>9__1_;
		return advantureMission;
	}

	// Token: 0x06002E53 RID: 11859 RVA: 0x000FC22C File Offset: 0x000FA42C
	[Token(Token = "0x6002E53")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002E54 RID: 11860 RVA: 0x000FC23C File Offset: 0x000FA43C
	[Token(Token = "0x6002E54")]
	[Address(RVA = "0x69B820", Offset = "0x699E20", VA = "0x18069B820", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002E55 RID: 11861 RVA: 0x000FC280 File Offset: 0x000FA480
	[Token(Token = "0x6002E55")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06002E56 RID: 11862 RVA: 0x000FC290 File Offset: 0x000FA490
	[Token(Token = "0x6002E56")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E57 RID: 11863 RVA: 0x000FC2A0 File Offset: 0x000FA4A0
	[Token(Token = "0x6002E57")]
	[Address(RVA = "0x69B6E0", Offset = "0x699CE0", VA = "0x18069B6E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第5关";
	}

	// Token: 0x06002E58 RID: 11864 RVA: 0x000FC2B4 File Offset: 0x000FA4B4
	[Token(Token = "0x6002E58")]
	[Address(RVA = "0x69B7A0", Offset = "0x699DA0", VA = "0x18069B7A0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "冰天雪地：同时冻结50个僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "及时雨：提交3个寒冰机枪射手";
		}
		return string.Empty;
	}

	// Token: 0x06002E59 RID: 11865 RVA: 0x000FC2DC File Offset: 0x000FA4DC
	[Token(Token = "0x6002E59")]
	[Address(RVA = "0x69B720", Offset = "0x699D20", VA = "0x18069B720", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "冻结僵尸的时长+10%";
		}
		if (result == MissionResult.Second)
		{
			return "寒冰豌豆命中僵尸时有概率直接令僵尸冻结";
		}
		return string.Empty;
	}

	// Token: 0x06002E5A RID: 11866 RVA: 0x000FC304 File Offset: 0x000FA504
	[Token(Token = "0x6002E5A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Night5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
