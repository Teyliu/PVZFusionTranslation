using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200091F RID: 2335
[Token(Token = "0x200091F")]
public class Roof6Strategy : BaseLevelStrategy
{
	// Token: 0x06002FEB RID: 12267 RVA: 0x001002B0 File Offset: 0x000FE4B0
	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x4A0640", Offset = "0x49EC40", VA = "0x1804A0640", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof6;
	}

	// Token: 0x06002FEC RID: 12268 RVA: 0x001002C0 File Offset: 0x000FE4C0
	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x6A7E70", Offset = "0x6A6470", VA = "0x1806A7E70", Slot = "24")]
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

	// Token: 0x06002FED RID: 12269 RVA: 0x00100314 File Offset: 0x000FE514
	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x6A3170", Offset = "0x6A1770", VA = "0x1806A3170", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Marigold;
	}

	// Token: 0x06002FEE RID: 12270 RVA: 0x00100324 File Offset: 0x000FE524
	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06002FEF RID: 12271 RVA: 0x00100334 File Offset: 0x000FE534
	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FF0 RID: 12272 RVA: 0x00100344 File Offset: 0x000FE544
	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x6A7D40", Offset = "0x6A6340", VA = "0x1806A7D40", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第6关";
	}

	// Token: 0x06002FF1 RID: 12273 RVA: 0x00100358 File Offset: 0x000FE558
	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x6A7DF0", Offset = "0x6A63F0", VA = "0x1806A7DF0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "大富翁：攒到30000金币";
		}
		if (result == MissionResult.Second)
		{
			return "阳光紧张：不携带向日葵通关关卡";
		}
		return string.Empty;
	}

	// Token: 0x06002FF2 RID: 12274 RVA: 0x00100380 File Offset: 0x000FE580
	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x6A7D70", Offset = "0x6A6370", VA = "0x1806A7D70", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "关卡开始时额外获得3000金币";
		}
		if (result == MissionResult.Second)
		{
			return "关卡开始时扣除阳光至100，每扣除1点阳光，获得50金币";
		}
		return string.Empty;
	}

	// Token: 0x06002FF3 RID: 12275 RVA: 0x001003A8 File Offset: 0x000FE5A8
	[Token(Token = "0x6002FF3")]
	[Address(RVA = "0x6A7BC0", Offset = "0x6A61C0", VA = "0x1806A7BC0", Slot = "22")]
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

	// Token: 0x06002FF4 RID: 12276 RVA: 0x001003F8 File Offset: 0x000FE5F8
	[Token(Token = "0x6002FF4")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Roof6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
