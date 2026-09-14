using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008EB RID: 2283
[Token(Token = "0x20008EB")]
public class Pool1Strategy : BaseLevelStrategy
{
	// Token: 0x06002EA0 RID: 11936 RVA: 0x000FCD60 File Offset: 0x000FAF60
	[Token(Token = "0x6002EA0")]
	[Address(RVA = "0x69E120", Offset = "0x69C720", VA = "0x18069E120", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool1;
	}

	// Token: 0x06002EA1 RID: 11937 RVA: 0x000FCD70 File Offset: 0x000FAF70
	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0x6A0E70", Offset = "0x69F470", VA = "0x1806A0E70", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002EA2 RID: 11938 RVA: 0x000FCDB8 File Offset: 0x000FAFB8
	[Token(Token = "0x6002EA2")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002EA3 RID: 11939 RVA: 0x000FCDC8 File Offset: 0x000FAFC8
	[Token(Token = "0x6002EA3")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002EA4 RID: 11940 RVA: 0x000FCDD8 File Offset: 0x000FAFD8
	[Token(Token = "0x6002EA4")]
	[Address(RVA = "0x6A0D40", Offset = "0x69F340", VA = "0x1806A0D40", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第1关";
	}

	// Token: 0x06002EA5 RID: 11941 RVA: 0x000FCDEC File Offset: 0x000FAFEC
	[Token(Token = "0x6002EA5")]
	[Address(RVA = "0x6A0DF0", Offset = "0x69F3F0", VA = "0x1806A0DF0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "整装待发：在第一波僵尸到达前，在水路种植8株植物";
		}
		if (result == MissionResult.Second)
		{
			return "睡莲爱好者：用睡莲铺满整个水池";
		}
		return string.Empty;
	}

	// Token: 0x06002EA6 RID: 11942 RVA: 0x000FCE14 File Offset: 0x000FB014
	[Token(Token = "0x6002EA6")]
	[Address(RVA = "0x6A0D70", Offset = "0x69F370", VA = "0x1806A0D70", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "特殊睡莲的生产速度增加20%";
		}
		if (result == MissionResult.Second)
		{
			return "种植睡莲不再消耗阳光";
		}
		return string.Empty;
	}

	// Token: 0x06002EA7 RID: 11943 RVA: 0x000FCE3C File Offset: 0x000FB03C
	[Token(Token = "0x6002EA7")]
	[Address(RVA = "0x6A0BC0", Offset = "0x69F1C0", VA = "0x1806A0BC0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06002EA8 RID: 11944 RVA: 0x000FCE8C File Offset: 0x000FB08C
	[Token(Token = "0x6002EA8")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Pool1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
