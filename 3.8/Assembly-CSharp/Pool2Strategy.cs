using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008EE RID: 2286
[Token(Token = "0x20008EE")]
public class Pool2Strategy : BaseLevelStrategy
{
	// Token: 0x06002EAE RID: 11950 RVA: 0x000FD010 File Offset: 0x000FB210
	[Token(Token = "0x6002EAE")]
	[Address(RVA = "0x6A11A0", Offset = "0x69F7A0", VA = "0x1806A11A0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool2;
	}

	// Token: 0x06002EAF RID: 11951 RVA: 0x000FD020 File Offset: 0x000FB220
	[Token(Token = "0x6002EAF")]
	[Address(RVA = "0x6A12B0", Offset = "0x69F8B0", VA = "0x1806A12B0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002EB0 RID: 11952 RVA: 0x000FD064 File Offset: 0x000FB264
	[Token(Token = "0x6002EB0")]
	[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Squash;
	}

	// Token: 0x06002EB1 RID: 11953 RVA: 0x000FD074 File Offset: 0x000FB274
	[Token(Token = "0x6002EB1")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002EB2 RID: 11954 RVA: 0x000FD084 File Offset: 0x000FB284
	[Token(Token = "0x6002EB2")]
	[Address(RVA = "0x6A1170", Offset = "0x69F770", VA = "0x1806A1170", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第2关";
	}

	// Token: 0x06002EB3 RID: 11955 RVA: 0x000FD098 File Offset: 0x000FB298
	[Token(Token = "0x6002EB3")]
	[Address(RVA = "0x6A1230", Offset = "0x69F830", VA = "0x1806A1230", Slot = "32")]
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

	// Token: 0x06002EB4 RID: 11956 RVA: 0x000FD0C0 File Offset: 0x000FB2C0
	[Token(Token = "0x6002EB4")]
	[Address(RVA = "0x6A11B0", Offset = "0x69F7B0", VA = "0x1806A11B0", Slot = "33")]
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

	// Token: 0x06002EB5 RID: 11957 RVA: 0x000FD0E8 File Offset: 0x000FB2E8
	[Token(Token = "0x6002EB5")]
	[Address(RVA = "0x6A0FE0", Offset = "0x69F5E0", VA = "0x1806A0FE0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002EB6 RID: 11958 RVA: 0x000FD150 File Offset: 0x000FB350
	[Token(Token = "0x6002EB6")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Pool2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
