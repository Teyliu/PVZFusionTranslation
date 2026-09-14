using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200095B RID: 2395
[Token(Token = "0x200095B")]
public class Roof6Strategy : BaseLevelStrategy
{
	// Token: 0x0600311E RID: 12574 RVA: 0x00104FE4 File Offset: 0x001031E4
	[Token(Token = "0x600311E")]
	[Address(RVA = "0x5202F0", Offset = "0x51E8F0", VA = "0x1805202F0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof6;
	}

	// Token: 0x0600311F RID: 12575 RVA: 0x00104FF4 File Offset: 0x001031F4
	[Token(Token = "0x600311F")]
	[Address(RVA = "0x721FD0", Offset = "0x7205D0", VA = "0x180721FD0", Slot = "24")]
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

	// Token: 0x06003120 RID: 12576 RVA: 0x00105048 File Offset: 0x00103248
	[Token(Token = "0x6003120")]
	[Address(RVA = "0x71D2D0", Offset = "0x71B8D0", VA = "0x18071D2D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Marigold;
	}

	// Token: 0x06003121 RID: 12577 RVA: 0x00105058 File Offset: 0x00103258
	[Token(Token = "0x6003121")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003122 RID: 12578 RVA: 0x00105068 File Offset: 0x00103268
	[Token(Token = "0x6003122")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003123 RID: 12579 RVA: 0x00105078 File Offset: 0x00103278
	[Token(Token = "0x6003123")]
	[Address(RVA = "0x721EA0", Offset = "0x7204A0", VA = "0x180721EA0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第6关";
	}

	// Token: 0x06003124 RID: 12580 RVA: 0x0010508C File Offset: 0x0010328C
	[Token(Token = "0x6003124")]
	[Address(RVA = "0x721F50", Offset = "0x720550", VA = "0x180721F50", Slot = "32")]
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

	// Token: 0x06003125 RID: 12581 RVA: 0x001050B4 File Offset: 0x001032B4
	[Token(Token = "0x6003125")]
	[Address(RVA = "0x721ED0", Offset = "0x7204D0", VA = "0x180721ED0", Slot = "33")]
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

	// Token: 0x06003126 RID: 12582 RVA: 0x001050DC File Offset: 0x001032DC
	[Token(Token = "0x6003126")]
	[Address(RVA = "0x721D20", Offset = "0x720320", VA = "0x180721D20", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		Func<MissionResult> func = delegate
		{
			List<CardUI> cards = InGameUI.Instance.Cards;
			Func<CardUI, bool> <>9__8_ = Roof6Strategy.<>c.<>9__8_1;
			if (<>9__8_ == 0)
			{
				Roof6Strategy.<>c.<>9__8_1 = (CardUI c) => c.thePlantType == PlantType.SunFlower;
			}
			if (Enumerable.FirstOrDefault<CardUI>(cards, <>9__8_))
			{
				bool flag = board.theMoney >= 30000;
			}
			throw new NullReferenceException();
		};
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x06003127 RID: 12583 RVA: 0x00105138 File Offset: 0x00103338
	[Token(Token = "0x6003127")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Roof6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
