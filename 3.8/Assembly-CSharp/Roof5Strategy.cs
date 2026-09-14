using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x0200091D RID: 2333
[Token(Token = "0x200091D")]
public class Roof5Strategy : BaseLevelStrategy
{
	// Token: 0x06002FDC RID: 12252 RVA: 0x0010000C File Offset: 0x000FE20C
	[Token(Token = "0x6002FDC")]
	[Address(RVA = "0x4E30C0", Offset = "0x4E16C0", VA = "0x1804E30C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Roof5;
	}

	// Token: 0x06002FDD RID: 12253 RVA: 0x0010001C File Offset: 0x000FE21C
	[Token(Token = "0x6002FDD")]
	[Address(RVA = "0x6A79C0", Offset = "0x6A5FC0", VA = "0x1806A79C0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002FDE RID: 12254 RVA: 0x00100068 File Offset: 0x000FE268
	[Token(Token = "0x6002FDE")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Umbrellaleaf;
	}

	// Token: 0x06002FDF RID: 12255 RVA: 0x00100078 File Offset: 0x000FE278
	[Token(Token = "0x6002FDF")]
	[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Roof;
	}

	// Token: 0x06002FE0 RID: 12256 RVA: 0x00100088 File Offset: 0x000FE288
	[Token(Token = "0x6002FE0")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FE1 RID: 12257 RVA: 0x00100098 File Offset: 0x000FE298
	[Token(Token = "0x6002FE1")]
	[Address(RVA = "0x6A7890", Offset = "0x6A5E90", VA = "0x1806A7890", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉屋顶：第5关";
	}

	// Token: 0x06002FE2 RID: 12258 RVA: 0x001000AC File Offset: 0x000FE2AC
	[Token(Token = "0x6002FE2")]
	[Address(RVA = "0x6A7940", Offset = "0x6A5F40", VA = "0x1806A7940", Slot = "32")]
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

	// Token: 0x06002FE3 RID: 12259 RVA: 0x001000D4 File Offset: 0x000FE2D4
	[Token(Token = "0x6002FE3")]
	[Address(RVA = "0x6A78C0", Offset = "0x6A5EC0", VA = "0x1806A78C0", Slot = "33")]
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

	// Token: 0x06002FE4 RID: 12260 RVA: 0x001000FC File Offset: 0x000FE2FC
	[Token(Token = "0x6002FE4")]
	[Address(RVA = "0x6A7690", Offset = "0x6A5C90", VA = "0x1806A7690", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)2L);
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureMission mission4 = mission;
		Action action = delegate
		{
			InGameText instance = InGameText.Instance;
			AdvantureMission mission3 = mission;
			int num;
			string text = string.Format("还需反弹{0}个篮球", num);
			int num2 = 0;
			instance.ShowText(text, 3f, num2 != 0);
		};
		mission4.onLook = action;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002FE5 RID: 12261 RVA: 0x0010018C File Offset: 0x000FE38C
	[Token(Token = "0x6002FE5")]
	[Address(RVA = "0x6A7B90", Offset = "0x6A6190", VA = "0x1806A7B90", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.SetRedLine(7);
	}

	// Token: 0x06002FE6 RID: 12262 RVA: 0x001001A8 File Offset: 0x000FE3A8
	[Token(Token = "0x6002FE6")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Roof5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
