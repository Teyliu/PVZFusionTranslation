using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000956 RID: 2390
[Token(Token = "0x2000956")]
public class Roof4Strategy : BaseLevelStrategy
{
	// Token: 0x060030FF RID: 12543 RVA: 0x00104A64 File Offset: 0x00102C64
	[Token(Token = "0x60030FF")]
	[Address(RVA = "0x473CB0", Offset = "0x4722B0", VA = "0x180473CB0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof4;
	}

	// Token: 0x06003100 RID: 12544 RVA: 0x00104A74 File Offset: 0x00102C74
	[Token(Token = "0x6003100")]
	[Address(RVA = "0x721620", Offset = "0x71FC20", VA = "0x180721620", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06003101 RID: 12545 RVA: 0x00104AC0 File Offset: 0x00102CC0
	[Token(Token = "0x6003101")]
	[Address(RVA = "0x71BFF0", Offset = "0x71A5F0", VA = "0x18071BFF0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Garlic;
	}

	// Token: 0x06003102 RID: 12546 RVA: 0x00104AD0 File Offset: 0x00102CD0
	[Token(Token = "0x6003102")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003103 RID: 12547 RVA: 0x00104AE0 File Offset: 0x00102CE0
	[Token(Token = "0x6003103")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003104 RID: 12548 RVA: 0x00104AF0 File Offset: 0x00102CF0
	[Token(Token = "0x6003104")]
	[Address(RVA = "0x7214F0", Offset = "0x71FAF0", VA = "0x1807214F0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第4关";
	}

	// Token: 0x06003105 RID: 12549 RVA: 0x00104B04 File Offset: 0x00102D04
	[Token(Token = "0x6003105")]
	[Address(RVA = "0x7215A0", Offset = "0x71FBA0", VA = "0x1807215A0", Slot = "32")]
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

	// Token: 0x06003106 RID: 12550 RVA: 0x00104B2C File Offset: 0x00102D2C
	[Token(Token = "0x6003106")]
	[Address(RVA = "0x721520", Offset = "0x71FB20", VA = "0x180721520", Slot = "33")]
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

	// Token: 0x06003107 RID: 12551 RVA: 0x00104B54 File Offset: 0x00102D54
	[Token(Token = "0x6003107")]
	[Address(RVA = "0x721350", Offset = "0x71F950", VA = "0x180721350", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)2L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<MissionResult> func = delegate
		{
			Dictionary<PlantType, long> reportDic = board.damageReporter.ReportDic;
			bool flag;
			if (flag)
			{
			}
			uint num;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(board, (int)num);
			Func<Plant, bool> func2;
			if (Roof4Strategy.<>c.<>9__8_1 == 0)
			{
				func2 = delegate(Plant p)
				{
					bool flag2;
					return flag2;
				};
				Roof4Strategy.<>c.<>9__8_1 = func2;
			}
			if (!Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(plantsByRow, func2)))
			{
				uint num2;
				List<Plant> plantsByRow2 = Lawnf.GetPlantsByRow(board, (int)num2);
				Func<Plant, bool> func3;
				if (Roof4Strategy.<>c.<>9__8_2 == 0)
				{
					func3 = delegate(Plant p)
					{
						bool flag3;
						return flag3;
					};
					Roof4Strategy.<>c.<>9__8_2 = func3;
				}
				if (!Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(plantsByRow2, func3)))
				{
					goto IL_00AF;
				}
			}
			mission.endResult = (MissionResult)((ulong)0L);
			IL_00AF:
			throw new NullReferenceException();
		};
		mission3.target = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003108 RID: 12552 RVA: 0x00104BD8 File Offset: 0x00102DD8
	[Token(Token = "0x6003108")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Roof4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
