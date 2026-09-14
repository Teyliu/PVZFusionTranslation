using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x020008FF RID: 2303
[Token(Token = "0x20008FF")]
public class NightPool1Strategy : BaseLevelStrategy
{
	// Token: 0x06002F21 RID: 12065 RVA: 0x000FE2D4 File Offset: 0x000FC4D4
	[Token(Token = "0x6002F21")]
	[Address(RVA = "0x49CC10", Offset = "0x49B210", VA = "0x18049CC10", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool1;
	}

	// Token: 0x06002F22 RID: 12066 RVA: 0x000FE2E4 File Offset: 0x000FC4E4
	[Token(Token = "0x6002F22")]
	[Address(RVA = "0x69C150", Offset = "0x69A750", VA = "0x18069C150", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002F23 RID: 12067 RVA: 0x000FE330 File Offset: 0x000FC530
	[Token(Token = "0x6002F23")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002F24 RID: 12068 RVA: 0x000FE340 File Offset: 0x000FC540
	[Token(Token = "0x6002F24")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F25 RID: 12069 RVA: 0x000FE350 File Offset: 0x000FC550
	[Token(Token = "0x6002F25")]
	[Address(RVA = "0x69C020", Offset = "0x69A620", VA = "0x18069C020", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第1关";
	}

	// Token: 0x06002F26 RID: 12070 RVA: 0x000FE364 File Offset: 0x000FC564
	[Token(Token = "0x6002F26")]
	[Address(RVA = "0x69C0D0", Offset = "0x69A6D0", VA = "0x18069C0D0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "开源节流II：不能消耗超过500的阳光";
		}
		if (result == MissionResult.Second)
		{
			return "魔法猫咪：提交4个香蒲";
		}
		return string.Empty;
	}

	// Token: 0x06002F27 RID: 12071 RVA: 0x000FE38C File Offset: 0x000FC58C
	[Token(Token = "0x6002F27")]
	[Address(RVA = "0x69C050", Offset = "0x69A650", VA = "0x18069C050", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "每次消耗阳光时，消耗的阳光减少10%";
		}
		if (result == MissionResult.Second)
		{
			return "冰火香蒲的子弹有概率直接触发寒冰和红温的效果";
		}
		return string.Empty;
	}

	// Token: 0x06002F28 RID: 12072 RVA: 0x000FE3B4 File Offset: 0x000FC5B4
	[Token(Token = "0x6002F28")]
	[Address(RVA = "0x69BE10", Offset = "0x69A410", VA = "0x18069BE10", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		Action action = delegate
		{
			InGameText instance = InGameText.Instance;
			int sunConsumed = board.boardStatistics.sunConsumed;
			string text = string.Format("已使用{0}阳光，不可超过500", instance);
			int num = 0;
			instance.ShowText(text, 3f, num != 0);
		};
		advantureMission.onLook = action;
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1067), 4, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002F29 RID: 12073 RVA: 0x000FE450 File Offset: 0x000FC650
	[Token(Token = "0x6002F29")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPool1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
