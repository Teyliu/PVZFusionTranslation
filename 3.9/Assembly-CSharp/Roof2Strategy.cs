using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000951 RID: 2385
[Token(Token = "0x2000951")]
public class Roof2Strategy : BaseLevelStrategy
{
	// Token: 0x060030E4 RID: 12516 RVA: 0x00104628 File Offset: 0x00102828
	[Token(Token = "0x60030E4")]
	[Address(RVA = "0x720BB0", Offset = "0x71F1B0", VA = "0x180720BB0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof2;
	}

	// Token: 0x060030E5 RID: 12517 RVA: 0x00104638 File Offset: 0x00102838
	[Token(Token = "0x60030E5")]
	[Address(RVA = "0x720CC0", Offset = "0x71F2C0", VA = "0x180720CC0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x060030E6 RID: 12518 RVA: 0x00104684 File Offset: 0x00102884
	[Token(Token = "0x60030E6")]
	[Address(RVA = "0x71B300", Offset = "0x719900", VA = "0x18071B300", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cabbagepult;
	}

	// Token: 0x060030E7 RID: 12519 RVA: 0x00104694 File Offset: 0x00102894
	[Token(Token = "0x60030E7")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x001046A4 File Offset: 0x001028A4
	[Token(Token = "0x60030E8")]
	[Address(RVA = "0x720B80", Offset = "0x71F180", VA = "0x180720B80", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第2关";
	}

	// Token: 0x060030E9 RID: 12521 RVA: 0x001046B8 File Offset: 0x001028B8
	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x720C40", Offset = "0x71F240", VA = "0x180720C40", Slot = "32")]
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

	// Token: 0x060030EA RID: 12522 RVA: 0x001046E0 File Offset: 0x001028E0
	[Token(Token = "0x60030EA")]
	[Address(RVA = "0x720BC0", Offset = "0x71F1C0", VA = "0x180720BC0", Slot = "33")]
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

	// Token: 0x060030EB RID: 12523 RVA: 0x00104708 File Offset: 0x00102908
	[Token(Token = "0x60030EB")]
	[Address(RVA = "0x720A00", Offset = "0x71F000", VA = "0x180720A00", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		Func<MissionResult> func = delegate
		{
			if (board.theWave == 0)
			{
				List<Plant> allPlants = Lawnf.GetAllPlants();
				Func<Plant, bool> <>9__7_ = Roof2Strategy.<>c.<>9__7_1;
				if (<>9__7_ == 0)
				{
					Roof2Strategy.<>c.<>9__7_1 = delegate(Plant p)
					{
						bool flag;
						return flag;
					};
				}
				List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, <>9__7_));
			}
			List<Plant> allPlants2 = Lawnf.GetAllPlants();
			Func<Plant, bool> func2;
			if (Roof2Strategy.<>c.<>9__7_2 == 0)
			{
				func2 = (Plant p) => p.plantTag.potPlant;
				Roof2Strategy.<>c.<>9__7_2 = func2;
			}
			List<Plant> list2 = Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants2, func2));
			throw new NullReferenceException();
		};
		advantureMission.target = func;
		AdvantureLevel level2 = this.GetLevel();
		return advantureMission;
	}

	// Token: 0x060030EC RID: 12524 RVA: 0x00104764 File Offset: 0x00102964
	[Token(Token = "0x60030EC")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Roof2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
