using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000959 RID: 2393
[Token(Token = "0x2000959")]
public class Roof5Strategy : BaseLevelStrategy
{
	// Token: 0x0600310F RID: 12559 RVA: 0x00104D2C File Offset: 0x00102F2C
	[Token(Token = "0x600310F")]
	[Address(RVA = "0x541530", Offset = "0x53FB30", VA = "0x180541530", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof5;
	}

	// Token: 0x06003110 RID: 12560 RVA: 0x00104D3C File Offset: 0x00102F3C
	[Token(Token = "0x6003110")]
	[Address(RVA = "0x721B20", Offset = "0x720120", VA = "0x180721B20", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06003111 RID: 12561 RVA: 0x00104D88 File Offset: 0x00102F88
	[Token(Token = "0x6003111")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x06003112 RID: 12562 RVA: 0x00104D98 File Offset: 0x00102F98
	[Token(Token = "0x6003112")]
	[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06003113 RID: 12563 RVA: 0x00104DA8 File Offset: 0x00102FA8
	[Token(Token = "0x6003113")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003114 RID: 12564 RVA: 0x00104DB8 File Offset: 0x00102FB8
	[Token(Token = "0x6003114")]
	[Address(RVA = "0x7219F0", Offset = "0x71FFF0", VA = "0x1807219F0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第5关";
	}

	// Token: 0x06003115 RID: 12565 RVA: 0x00104DCC File Offset: 0x00102FCC
	[Token(Token = "0x6003115")]
	[Address(RVA = "0x721AA0", Offset = "0x7200A0", VA = "0x180721AA0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "绝对防御：使用保护伞阻挡50发篮球";
		}
		if (result == MissionResult.Second)
		{
			return "别踩红线：不让僵尸越过红线";
		}
		return string.Empty;
	}

	// Token: 0x06003116 RID: 12566 RVA: 0x00104DF4 File Offset: 0x00102FF4
	[Token(Token = "0x6003116")]
	[Address(RVA = "0x721A20", Offset = "0x720020", VA = "0x180721A20", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "保护伞可以将抛射物反弹回去";
		}
		if (result == MissionResult.Second)
		{
			return "保护伞的血量增加10%";
		}
		return string.Empty;
	}

	// Token: 0x06003117 RID: 12567 RVA: 0x00104E1C File Offset: 0x0010301C
	[Token(Token = "0x6003117")]
	[Address(RVA = "0x7217F0", Offset = "0x71FDF0", VA = "0x1807217F0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)2L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission5 = mission;
		Func<Zombie, bool> <>9__2;
		Func<MissionResult> func = delegate
		{
			if (mission.count < 50)
			{
				List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
				Func<Zombie, bool> <>9__ = <>9__2;
				if (<>9__ == 0)
				{
					Func<Zombie, bool> func2 = delegate(Zombie z)
					{
						int column = z.Column;
						BoardConfig config = board.config;
						return column < config.redLineColumn;
					};
					<>9__2 = func2;
				}
				if (Enumerable.FirstOrDefault<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__)))
				{
					mission.endResult = (MissionResult)((ulong)0L);
				}
			}
			return MissionResult.First;
		};
		mission5.target = func;
		AdvantureMission mission2 = mission;
		Action action = delegate
		{
			InGameText instance = InGameText.Instance;
			AdvantureMission mission4 = mission;
			int num;
			string text = string.Format("还需反弹{0}个篮球", num);
		};
		mission2.onLook = action;
		AdvantureMission mission3 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003118 RID: 12568 RVA: 0x00104EC0 File Offset: 0x001030C0
	[Token(Token = "0x6003118")]
	[Address(RVA = "0x721CF0", Offset = "0x7202F0", VA = "0x180721CF0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.SetRedLine(7);
	}

	// Token: 0x06003119 RID: 12569 RVA: 0x00104EDC File Offset: 0x001030DC
	[Token(Token = "0x6003119")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Roof5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
