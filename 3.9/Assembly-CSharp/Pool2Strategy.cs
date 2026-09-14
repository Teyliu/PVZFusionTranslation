using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200092A RID: 2346
[Token(Token = "0x200092A")]
public class Pool2Strategy : BaseLevelStrategy
{
	// Token: 0x06002FE1 RID: 12257 RVA: 0x00101BEC File Offset: 0x000FFDEC
	[Token(Token = "0x6002FE1")]
	[Address(RVA = "0x71B300", Offset = "0x719900", VA = "0x18071B300", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool2;
	}

	// Token: 0x06002FE2 RID: 12258 RVA: 0x00101BFC File Offset: 0x000FFDFC
	[Token(Token = "0x6002FE2")]
	[Address(RVA = "0x71B410", Offset = "0x719A10", VA = "0x18071B410", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002FE3 RID: 12259 RVA: 0x00101C40 File Offset: 0x000FFE40
	[Token(Token = "0x6002FE3")]
	[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Squash;
	}

	// Token: 0x06002FE4 RID: 12260 RVA: 0x00101C50 File Offset: 0x000FFE50
	[Token(Token = "0x6002FE4")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002FE5 RID: 12261 RVA: 0x00101C60 File Offset: 0x000FFE60
	[Token(Token = "0x6002FE5")]
	[Address(RVA = "0x71B2D0", Offset = "0x7198D0", VA = "0x18071B2D0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第2关";
	}

	// Token: 0x06002FE6 RID: 12262 RVA: 0x00101C74 File Offset: 0x000FFE74
	[Token(Token = "0x6002FE6")]
	[Address(RVA = "0x71B390", Offset = "0x719990", VA = "0x18071B390", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "泰山压顶：使用窝瓜一次性压中5只僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "重力打击：使用窝瓜坚果对僵尸造成10000点伤害";
		}
		return string.Empty;
	}

	// Token: 0x06002FE7 RID: 12263 RVA: 0x00101C9C File Offset: 0x000FFE9C
	[Token(Token = "0x6002FE7")]
	[Address(RVA = "0x71B310", Offset = "0x719910", VA = "0x18071B310", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "窝瓜每压到一只僵尸，伤害额外增加10%";
		}
		if (result == MissionResult.Second)
		{
			return "僵尸受到压扁类型的伤害增加20%";
		}
		return string.Empty;
	}

	// Token: 0x06002FE8 RID: 12264 RVA: 0x00101CC4 File Offset: 0x000FFEC4
	[Token(Token = "0x6002FE8")]
	[Address(RVA = "0x71B140", Offset = "0x719740", VA = "0x18071B140", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission4 = mission;
		Func<MissionResult> func = delegate
		{
			AdvantureMission mission3 = mission;
			int num = 0;
			if (mission3.count < 1)
			{
				if (board.damageReporter.ReportDic.TryGetValue((uint)1250, num))
				{
				}
			}
			return MissionResult.First;
		};
		mission4.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002FE9 RID: 12265 RVA: 0x00101D40 File Offset: 0x000FFF40
	[Token(Token = "0x6002FE9")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Pool2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
