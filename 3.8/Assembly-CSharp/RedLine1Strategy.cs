using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000941 RID: 2369
[Token(Token = "0x2000941")]
public class RedLine1Strategy : BaseLevelStrategy
{
	// Token: 0x060030D8 RID: 12504 RVA: 0x00102768 File Offset: 0x00100968
	[Token(Token = "0x60030D8")]
	[Address(RVA = "0x3AE5A0", Offset = "0x3ACBA0", VA = "0x1803AE5A0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.RedLine1;
	}

	// Token: 0x060030D9 RID: 12505 RVA: 0x0010277C File Offset: 0x0010097C
	[Token(Token = "0x60030D9")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060030DA RID: 12506 RVA: 0x0010278C File Offset: 0x0010098C
	[Token(Token = "0x60030DA")]
	[Address(RVA = "0x6A5FC0", Offset = "0x6A45C0", VA = "0x1806A5FC0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		return list;
	}

	// Token: 0x060030DB RID: 12507 RVA: 0x001027EC File Offset: 0x001009EC
	[Token(Token = "0x60030DB")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060030DC RID: 12508 RVA: 0x001027FC File Offset: 0x001009FC
	[Token(Token = "0x60030DC")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x060030DD RID: 12509 RVA: 0x00102814 File Offset: 0x00100A14
	[Token(Token = "0x60030DD")]
	[Address(RVA = "0x6A5EF0", Offset = "0x6A44F0", VA = "0x1806A5EF0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：别踩红线";
	}

	// Token: 0x060030DE RID: 12510 RVA: 0x00102828 File Offset: 0x00100A28
	[Token(Token = "0x60030DE")]
	[Address(RVA = "0x6A62E0", Offset = "0x6A48E0", VA = "0x1806A62E0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.SetRedLine(4);
	}

	// Token: 0x060030DF RID: 12511 RVA: 0x00102844 File Offset: 0x00100A44
	[Token(Token = "0x60030DF")]
	[Address(RVA = "0x6A5F60", Offset = "0x6A4560", VA = "0x1806A5F60", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "不让僵尸越过红线";
		}
		return string.Empty;
	}

	// Token: 0x060030E0 RID: 12512 RVA: 0x00102860 File Offset: 0x00100A60
	[Token(Token = "0x60030E0")]
	[Address(RVA = "0x6A5F20", Offset = "0x6A4520", VA = "0x1806A5F20", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		return string.Empty;
	}

	// Token: 0x060030E1 RID: 12513 RVA: 0x00102874 File Offset: 0x00100A74
	[Token(Token = "0x60030E1")]
	[Address(RVA = "0x6A5D70", Offset = "0x6A4370", VA = "0x1806A5D70", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<MissionResult> func;
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x060030E2 RID: 12514 RVA: 0x001028CC File Offset: 0x00100ACC
	[Token(Token = "0x60030E2")]
	[Address(RVA = "0x6A6230", Offset = "0x6A4830", VA = "0x1806A6230", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		BoardConfig config = board.config;
	}

	// Token: 0x060030E3 RID: 12515 RVA: 0x001028F0 File Offset: 0x00100AF0
	[Token(Token = "0x60030E3")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public RedLine1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
