using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000930 RID: 2352
[Token(Token = "0x2000930")]
public class Pool5Strategy : BaseLevelStrategy
{
	// Token: 0x06003005 RID: 12293 RVA: 0x001021F0 File Offset: 0x001003F0
	[Token(Token = "0x6003005")]
	[Address(RVA = "0x71BFF0", Offset = "0x71A5F0", VA = "0x18071BFF0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool5;
	}

	// Token: 0x06003006 RID: 12294 RVA: 0x00102200 File Offset: 0x00100400
	[Token(Token = "0x6003006")]
	[Address(RVA = "0x71C100", Offset = "0x71A700", VA = "0x18071C100", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06003007 RID: 12295 RVA: 0x00102244 File Offset: 0x00100444
	[Token(Token = "0x6003007")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06003008 RID: 12296 RVA: 0x00102254 File Offset: 0x00100454
	[Token(Token = "0x6003008")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003009 RID: 12297 RVA: 0x00102264 File Offset: 0x00100464
	[Token(Token = "0x6003009")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600300A RID: 12298 RVA: 0x00102274 File Offset: 0x00100474
	[Token(Token = "0x600300A")]
	[Address(RVA = "0x71BFC0", Offset = "0x71A5C0", VA = "0x18071BFC0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第5关";
	}

	// Token: 0x0600300B RID: 12299 RVA: 0x00102288 File Offset: 0x00100488
	[Token(Token = "0x600300B")]
	[Address(RVA = "0x71C080", Offset = "0x71A680", VA = "0x18071C080", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "燃烧生命：使15株植物的血量低于100";
		}
		if (result == MissionResult.Second)
		{
			return "怒火攻心：使僵尸一共产生100次红温爆炸";
		}
		return string.Empty;
	}

	// Token: 0x0600300C RID: 12300 RVA: 0x001022B0 File Offset: 0x001004B0
	[Token(Token = "0x600300C")]
	[Address(RVA = "0x71C000", Offset = "0x71A600", VA = "0x18071C000", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "血量低于30%的植物获得50%伤害减免";
		}
		if (result == MissionResult.Second)
		{
			return "红温爆炸的影响范围增加50%";
		}
		return string.Empty;
	}

	// Token: 0x0600300D RID: 12301 RVA: 0x001022D8 File Offset: 0x001004D8
	[Token(Token = "0x600300D")]
	[Address(RVA = "0x71BE40", Offset = "0x71A440", VA = "0x18071BE40", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission4 = mission;
		Func<MissionResult> func = delegate
		{
			List<Plant> allPlants = Lawnf.GetAllPlants();
			Func<Plant, bool> <>9__8_ = Pool5Strategy.<>c.<>9__8_1;
			if (<>9__8_ == 0)
			{
				Pool5Strategy.<>c.<>9__8_1 = (Plant p) => p.thePlantHealth < 100;
			}
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Where<Plant>(allPlants, <>9__8_));
			AdvantureMission mission3 = mission;
			throw new NullReferenceException();
		};
		mission4.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x0600300E RID: 12302 RVA: 0x00102348 File Offset: 0x00100548
	[Token(Token = "0x600300E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Pool5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
