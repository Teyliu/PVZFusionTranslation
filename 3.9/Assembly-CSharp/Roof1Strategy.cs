using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200094E RID: 2382
[Token(Token = "0x200094E")]
public class Roof1Strategy : BaseLevelStrategy
{
	// Token: 0x060030D5 RID: 12501 RVA: 0x001043B0 File Offset: 0x001025B0
	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x720630", Offset = "0x71EC30", VA = "0x180720630", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof1;
	}

	// Token: 0x060030D6 RID: 12502 RVA: 0x001043C0 File Offset: 0x001025C0
	[Token(Token = "0x60030D6")]
	[Address(RVA = "0x720740", Offset = "0x71ED40", VA = "0x180720740", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x060030D7 RID: 12503 RVA: 0x0010440C File Offset: 0x0010260C
	[Token(Token = "0x60030D7")]
	[Address(RVA = "0x71B300", Offset = "0x719900", VA = "0x18071B300", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cabbagepult;
	}

	// Token: 0x060030D8 RID: 12504 RVA: 0x0010441C File Offset: 0x0010261C
	[Token(Token = "0x60030D8")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x060030D9 RID: 12505 RVA: 0x0010442C File Offset: 0x0010262C
	[Token(Token = "0x60030D9")]
	[Address(RVA = "0x720600", Offset = "0x71EC00", VA = "0x180720600", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第1关";
	}

	// Token: 0x060030DA RID: 12506 RVA: 0x00104440 File Offset: 0x00102640
	[Token(Token = "0x60030DA")]
	[Address(RVA = "0x7206C0", Offset = "0x71ECC0", VA = "0x1807206C0", Slot = "32")]
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

	// Token: 0x060030DB RID: 12507 RVA: 0x00104468 File Offset: 0x00102668
	[Token(Token = "0x60030DB")]
	[Address(RVA = "0x720640", Offset = "0x71EC40", VA = "0x180720640", Slot = "33")]
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

	// Token: 0x060030DC RID: 12508 RVA: 0x00104490 File Offset: 0x00102690
	[Token(Token = "0x60030DC")]
	[Address(RVA = "0x720470", Offset = "0x71EA70", VA = "0x180720470", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)2L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<MissionResult> func = delegate
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			Func<Plant, bool> <>9__7_ = Roof1Strategy.<>c.<>9__7_1;
			if (<>9__7_ == 0)
			{
				Roof1Strategy.<>c.<>9__7_1 = (Plant p) => p.plantTag.potPlant;
			}
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, <>9__7_));
			int num = 0;
			mission.endResult = (MissionResult)num;
			List<CardUI> cards = InGameUI.Instance.Cards;
			throw new NullReferenceException();
		};
		mission3.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x060030DD RID: 12509 RVA: 0x0010450C File Offset: 0x0010270C
	[Token(Token = "0x60030DD")]
	[Address(RVA = "0x720910", Offset = "0x71EF10", VA = "0x180720910", Slot = "34")]
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

	// Token: 0x060030DE RID: 12510 RVA: 0x00104540 File Offset: 0x00102740
	[Token(Token = "0x60030DE")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Roof1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
