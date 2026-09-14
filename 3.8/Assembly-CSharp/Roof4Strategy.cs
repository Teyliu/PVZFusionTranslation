using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200091A RID: 2330
[Token(Token = "0x200091A")]
public class Roof4Strategy : BaseLevelStrategy
{
	// Token: 0x06002FCC RID: 12236 RVA: 0x000FFD7C File Offset: 0x000FDF7C
	[Token(Token = "0x6002FCC")]
	[Address(RVA = "0x41CE10", Offset = "0x41B410", VA = "0x18041CE10", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof4;
	}

	// Token: 0x06002FCD RID: 12237 RVA: 0x000FFD8C File Offset: 0x000FDF8C
	[Token(Token = "0x6002FCD")]
	[Address(RVA = "0x6A74C0", Offset = "0x6A5AC0", VA = "0x1806A74C0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002FCE RID: 12238 RVA: 0x000FFDD8 File Offset: 0x000FDFD8
	[Token(Token = "0x6002FCE")]
	[Address(RVA = "0x6A1E90", Offset = "0x6A0490", VA = "0x1806A1E90", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Garlic;
	}

	// Token: 0x06002FCF RID: 12239 RVA: 0x000FFDE8 File Offset: 0x000FDFE8
	[Token(Token = "0x6002FCF")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06002FD0 RID: 12240 RVA: 0x000FFDF8 File Offset: 0x000FDFF8
	[Token(Token = "0x6002FD0")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FD1 RID: 12241 RVA: 0x000FFE08 File Offset: 0x000FE008
	[Token(Token = "0x6002FD1")]
	[Address(RVA = "0x6A7390", Offset = "0x6A5990", VA = "0x1806A7390", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第4关";
	}

	// Token: 0x06002FD2 RID: 12242 RVA: 0x000FFE1C File Offset: 0x000FE01C
	[Token(Token = "0x6002FD2")]
	[Address(RVA = "0x6A7440", Offset = "0x6A5A40", VA = "0x1806A7440", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "蒜毒骤发：使用蒜卷心菜造成40000点伤害";
		}
		if (result == MissionResult.Second)
		{
			return "路线管理：不在2、4路放置植物";
		}
		return string.Empty;
	}

	// Token: 0x06002FD3 RID: 12243 RVA: 0x000FFE44 File Offset: 0x000FE044
	[Token(Token = "0x6002FD3")]
	[Address(RVA = "0x6A73C0", Offset = "0x6A59C0", VA = "0x1806A73C0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "蒜毒的持续伤害增加+20%";
		}
		if (result == MissionResult.Second)
		{
			return "大蒜植物被啃咬时扣除的生命值减少5";
		}
		return string.Empty;
	}

	// Token: 0x06002FD4 RID: 12244 RVA: 0x000FFE6C File Offset: 0x000FE06C
	[Token(Token = "0x6002FD4")]
	[Address(RVA = "0x6A71F0", Offset = "0x6A57F0", VA = "0x1806A71F0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
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

	// Token: 0x06002FD5 RID: 12245 RVA: 0x000FFEDC File Offset: 0x000FE0DC
	[Token(Token = "0x6002FD5")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Roof4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
