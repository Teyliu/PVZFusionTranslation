using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000915 RID: 2325
[Token(Token = "0x2000915")]
public class Roof2Strategy : BaseLevelStrategy
{
	// Token: 0x06002FB1 RID: 12209 RVA: 0x000FF97C File Offset: 0x000FDB7C
	[Token(Token = "0x6002FB1")]
	[Address(RVA = "0x6A6A50", Offset = "0x6A5050", VA = "0x1806A6A50", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof2;
	}

	// Token: 0x06002FB2 RID: 12210 RVA: 0x000FF98C File Offset: 0x000FDB8C
	[Token(Token = "0x6002FB2")]
	[Address(RVA = "0x6A6B60", Offset = "0x6A5160", VA = "0x1806A6B60", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002FB3 RID: 12211 RVA: 0x000FF9D8 File Offset: 0x000FDBD8
	[Token(Token = "0x6002FB3")]
	[Address(RVA = "0x6A11A0", Offset = "0x69F7A0", VA = "0x1806A11A0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cabbagepult;
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x000FF9E8 File Offset: 0x000FDBE8
	[Token(Token = "0x6002FB4")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06002FB5 RID: 12213 RVA: 0x000FF9F8 File Offset: 0x000FDBF8
	[Token(Token = "0x6002FB5")]
	[Address(RVA = "0x6A6A20", Offset = "0x6A5020", VA = "0x1806A6A20", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第2关";
	}

	// Token: 0x06002FB6 RID: 12214 RVA: 0x000FFA0C File Offset: 0x000FDC0C
	[Token(Token = "0x6002FB6")]
	[Address(RVA = "0x6A6AE0", Offset = "0x6A50E0", VA = "0x1806A6AE0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "极速备战：在第一波僵尸到达前种植10株植物（花盆除外）";
		}
		if (result == MissionResult.Second)
		{
			return "无限花盆：在场上种植40个花盆";
		}
		return string.Empty;
	}

	// Token: 0x06002FB7 RID: 12215 RVA: 0x000FFA34 File Offset: 0x000FDC34
	[Token(Token = "0x6002FB7")]
	[Address(RVA = "0x6A6A60", Offset = "0x6A5060", VA = "0x1806A6A60", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "在第一波僵尸到达前，卡牌冷却速度提高20%";
		}
		if (result == MissionResult.Second)
		{
			return "种植花盆不再消耗阳光";
		}
		return string.Empty;
	}

	// Token: 0x06002FB8 RID: 12216 RVA: 0x000FFA5C File Offset: 0x000FDC5C
	[Token(Token = "0x6002FB8")]
	[Address(RVA = "0x6A68A0", Offset = "0x6A4EA0", VA = "0x1806A68A0", Slot = "22")]
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

	// Token: 0x06002FB9 RID: 12217 RVA: 0x000FFAAC File Offset: 0x000FDCAC
	[Token(Token = "0x6002FB9")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Roof2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
