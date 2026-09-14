using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x0200093B RID: 2363
[Token(Token = "0x200093B")]
public class NightPool1Strategy : BaseLevelStrategy
{
	// Token: 0x06003054 RID: 12372 RVA: 0x00102F20 File Offset: 0x00101120
	[Token(Token = "0x6003054")]
	[Address(RVA = "0x50C610", Offset = "0x50AC10", VA = "0x18050C610", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool1;
	}

	// Token: 0x06003055 RID: 12373 RVA: 0x00102F30 File Offset: 0x00101130
	[Token(Token = "0x6003055")]
	[Address(RVA = "0x7162B0", Offset = "0x7148B0", VA = "0x1807162B0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06003056 RID: 12374 RVA: 0x00102F7C File Offset: 0x0010117C
	[Token(Token = "0x6003056")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x00102F8C File Offset: 0x0010118C
	[Token(Token = "0x6003057")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x00102F9C File Offset: 0x0010119C
	[Token(Token = "0x6003058")]
	[Address(RVA = "0x716180", Offset = "0x714780", VA = "0x180716180", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第1关";
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x00102FB0 File Offset: 0x001011B0
	[Token(Token = "0x6003059")]
	[Address(RVA = "0x716230", Offset = "0x714830", VA = "0x180716230", Slot = "32")]
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

	// Token: 0x0600305A RID: 12378 RVA: 0x00102FD8 File Offset: 0x001011D8
	[Token(Token = "0x600305A")]
	[Address(RVA = "0x7161B0", Offset = "0x7147B0", VA = "0x1807161B0", Slot = "33")]
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

	// Token: 0x0600305B RID: 12379 RVA: 0x00103000 File Offset: 0x00101200
	[Token(Token = "0x600305B")]
	[Address(RVA = "0x715F70", Offset = "0x714570", VA = "0x180715F70", Slot = "22")]
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
		};
		advantureMission.onLook = action;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<MissionResult> func = delegate
		{
			if (board.boardStatistics.sunConsumed > 500)
			{
				mission.endResult = (MissionResult)((ulong)0L);
			}
			throw new NullReferenceException();
		};
		mission3.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1067), 4, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x0600305C RID: 12380 RVA: 0x001030AC File Offset: 0x001012AC
	[Token(Token = "0x600305C")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPool1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
