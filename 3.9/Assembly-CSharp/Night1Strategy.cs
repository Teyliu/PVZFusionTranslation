using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000912 RID: 2322
[Token(Token = "0x2000912")]
public class Night1Strategy : BaseLevelStrategy
{
	// Token: 0x06002F4B RID: 12107 RVA: 0x001004DC File Offset: 0x000FE6DC
	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night1;
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x001004EC File Offset: 0x000FE6EC
	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0x714630", Offset = "0x712C30", VA = "0x180714630", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission mission = new AdvantureMission
		{
			board = board,
			level = (AdvantureLevel)((ulong)13L),
			endResult = (MissionResult)((ulong)1L)
		};
		AdvantureMission mission2 = mission;
		Func<MissionResult> func = delegate
		{
			List<CardUI> cards = InGameUI.Instance.Cards;
			Func<CardUI, bool> <>9__1_ = Night1Strategy.<>c.<>9__1_1;
			if (<>9__1_ == 0)
			{
				Night1Strategy.<>c.<>9__1_1 = (CardUI c) => c.thePlantType == PlantType.SunFlower;
			}
			if (Enumerable.FirstOrDefault<CardUI>(cards, <>9__1_))
			{
				mission.endResult = (MissionResult)((ulong)0L);
			}
			throw new NullReferenceException();
		};
		mission2.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1065), 3, (MissionResult)((uint)2));
		AdvantureConfig.SetMissionDescription(mission, (AdvantureLevel)((uint)13));
		return mission;
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x00100574 File Offset: 0x000FE774
	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002F4E RID: 12110 RVA: 0x00100584 File Offset: 0x000FE784
	[Token(Token = "0x6002F4E")]
	[Address(RVA = "0x7148E0", Offset = "0x712EE0", VA = "0x1807148E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x001005CC File Offset: 0x000FE7CC
	[Token(Token = "0x6002F4F")]
	[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SmallPuff;
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x001005DC File Offset: 0x000FE7DC
	[Token(Token = "0x6002F50")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x001005EC File Offset: 0x000FE7EC
	[Token(Token = "0x6002F51")]
	[Address(RVA = "0x7147B0", Offset = "0x712DB0", VA = "0x1807147B0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第1关";
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x00100600 File Offset: 0x000FE800
	[Token(Token = "0x6002F52")]
	[Address(RVA = "0x714860", Offset = "0x712E60", VA = "0x180714860", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "开源节流：不携带向日葵进入关卡";
		}
		if (result == MissionResult.Second)
		{
			return "合理密植：提交3个机枪小喷菇";
		}
		return string.Empty;
	}

	// Token: 0x06002F53 RID: 12115 RVA: 0x00100628 File Offset: 0x000FE828
	[Token(Token = "0x6002F53")]
	[Address(RVA = "0x7147E0", Offset = "0x712DE0", VA = "0x1807147E0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "向日葵的阳光消耗降低5";
		}
		if (result == MissionResult.Second)
		{
			return "小喷菇的冷却时间降低20%";
		}
		return string.Empty;
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x00100650 File Offset: 0x000FE850
	[Token(Token = "0x6002F54")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Night1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
