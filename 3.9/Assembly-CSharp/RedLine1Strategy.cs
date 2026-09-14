using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x0200097D RID: 2429
[Token(Token = "0x200097D")]
public class RedLine1Strategy : BaseLevelStrategy
{
	// Token: 0x0600320B RID: 12811 RVA: 0x001074E8 File Offset: 0x001056E8
	[Token(Token = "0x600320B")]
	[Address(RVA = "0x3FA410", Offset = "0x3F8A10", VA = "0x1803FA410", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.RedLine1;
	}

	// Token: 0x0600320C RID: 12812 RVA: 0x001074FC File Offset: 0x001056FC
	[Token(Token = "0x600320C")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600320D RID: 12813 RVA: 0x0010750C File Offset: 0x0010570C
	[Token(Token = "0x600320D")]
	[Address(RVA = "0x720120", Offset = "0x71E720", VA = "0x180720120", Slot = "24")]
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

	// Token: 0x0600320E RID: 12814 RVA: 0x0010756C File Offset: 0x0010576C
	[Token(Token = "0x600320E")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x0600320F RID: 12815 RVA: 0x0010757C File Offset: 0x0010577C
	[Token(Token = "0x600320F")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06003210 RID: 12816 RVA: 0x00107594 File Offset: 0x00105794
	[Token(Token = "0x6003210")]
	[Address(RVA = "0x720050", Offset = "0x71E650", VA = "0x180720050", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：别踩红线";
	}

	// Token: 0x06003211 RID: 12817 RVA: 0x001075A8 File Offset: 0x001057A8
	[Token(Token = "0x6003211")]
	[Address(RVA = "0x720440", Offset = "0x71EA40", VA = "0x180720440", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.SetRedLine(4);
	}

	// Token: 0x06003212 RID: 12818 RVA: 0x001075C4 File Offset: 0x001057C4
	[Token(Token = "0x6003212")]
	[Address(RVA = "0x7200C0", Offset = "0x71E6C0", VA = "0x1807200C0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "不让僵尸越过红线";
		}
		return string.Empty;
	}

	// Token: 0x06003213 RID: 12819 RVA: 0x001075E0 File Offset: 0x001057E0
	[Token(Token = "0x6003213")]
	[Address(RVA = "0x720080", Offset = "0x71E680", VA = "0x180720080", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		return string.Empty;
	}

	// Token: 0x06003214 RID: 12820 RVA: 0x001075F4 File Offset: 0x001057F4
	[Token(Token = "0x6003214")]
	[Address(RVA = "0x71FED0", Offset = "0x71E4D0", VA = "0x18071FED0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<Zombie, bool> <>9__1;
		Func<MissionResult> func = delegate
		{
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__ = <>9__1;
			if (<>9__ == 0)
			{
				Func<Zombie, bool> func2 = delegate(Zombie z)
				{
					int column = z.Column;
					BoardConfig config = board.config;
					return column < config.redLineColumn;
				};
				<>9__1 = func2;
			}
			if (Enumerable.FirstOrDefault<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__)))
			{
				UIMgr.EnterLoseMenu("有僵尸越过了红线");
			}
			return MissionResult.Nothing;
		};
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003215 RID: 12821 RVA: 0x00107658 File Offset: 0x00105858
	[Token(Token = "0x6003215")]
	[Address(RVA = "0x720390", Offset = "0x71E990", VA = "0x180720390", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		CreatePlant instance = CreatePlant.Instance;
		BoardConfig config = board.config;
	}

	// Token: 0x06003216 RID: 12822 RVA: 0x0010767C File Offset: 0x0010587C
	[Token(Token = "0x6003216")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public RedLine1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
