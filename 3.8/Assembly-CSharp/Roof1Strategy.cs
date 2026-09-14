using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000912 RID: 2322
[Token(Token = "0x2000912")]
public class Roof1Strategy : BaseLevelStrategy
{
	// Token: 0x06002FA2 RID: 12194 RVA: 0x000FF728 File Offset: 0x000FD928
	[Token(Token = "0x6002FA2")]
	[Address(RVA = "0x6A64D0", Offset = "0x6A4AD0", VA = "0x1806A64D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof1;
	}

	// Token: 0x06002FA3 RID: 12195 RVA: 0x000FF738 File Offset: 0x000FD938
	[Token(Token = "0x6002FA3")]
	[Address(RVA = "0x6A65E0", Offset = "0x6A4BE0", VA = "0x1806A65E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002FA4 RID: 12196 RVA: 0x000FF784 File Offset: 0x000FD984
	[Token(Token = "0x6002FA4")]
	[Address(RVA = "0x6A11A0", Offset = "0x69F7A0", VA = "0x1806A11A0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cabbagepult;
	}

	// Token: 0x06002FA5 RID: 12197 RVA: 0x000FF794 File Offset: 0x000FD994
	[Token(Token = "0x6002FA5")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06002FA6 RID: 12198 RVA: 0x000FF7A4 File Offset: 0x000FD9A4
	[Token(Token = "0x6002FA6")]
	[Address(RVA = "0x6A64A0", Offset = "0x6A4AA0", VA = "0x1806A64A0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第1关";
	}

	// Token: 0x06002FA7 RID: 12199 RVA: 0x000FF7B8 File Offset: 0x000FD9B8
	[Token(Token = "0x6002FA7")]
	[Address(RVA = "0x6A6560", Offset = "0x6A4B60", VA = "0x1806A6560", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "资源紧张：进入关卡时最多携带6张卡牌";
		}
		if (result == MissionResult.Second)
		{
			return "无伤通关：不丢失花盆通关";
		}
		return string.Empty;
	}

	// Token: 0x06002FA8 RID: 12200 RVA: 0x000FF7E0 File Offset: 0x000FD9E0
	[Token(Token = "0x6002FA8")]
	[Address(RVA = "0x6A64E0", Offset = "0x6A4AE0", VA = "0x1806A64E0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "关卡开始时，位于卡槽前6位的卡牌价格降低5";
		}
		if (result == MissionResult.Second)
		{
			return "关卡开局额外赠送一列阳光花盆";
		}
		return string.Empty;
	}

	// Token: 0x06002FA9 RID: 12201 RVA: 0x000FF808 File Offset: 0x000FDA08
	[Token(Token = "0x6002FA9")]
	[Address(RVA = "0x6A6310", Offset = "0x6A4910", VA = "0x1806A6310", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)2L);
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002FAA RID: 12202 RVA: 0x000FF870 File Offset: 0x000FDA70
	[Token(Token = "0x6002FAA")]
	[Address(RVA = "0x6A67B0", Offset = "0x6A4DB0", VA = "0x1806A67B0", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		if (num < board.rowNum)
		{
			CreatePlant instance = CreatePlant.Instance;
			num++;
		}
		num++;
	}

	// Token: 0x06002FAB RID: 12203 RVA: 0x000FF8A4 File Offset: 0x000FDAA4
	[Token(Token = "0x6002FAB")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Roof1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
