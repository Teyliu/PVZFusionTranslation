using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000946 RID: 2374
[Token(Token = "0x2000946")]
public class NightPool6Strategy : BaseLevelStrategy
{
	// Token: 0x06003097 RID: 12439 RVA: 0x00103B30 File Offset: 0x00101D30
	[Token(Token = "0x6003097")]
	[Address(RVA = "0x717A90", Offset = "0x716090", VA = "0x180717A90", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool6;
	}

	// Token: 0x06003098 RID: 12440 RVA: 0x00103B40 File Offset: 0x00101D40
	[Token(Token = "0x6003098")]
	[Address(RVA = "0x717BA0", Offset = "0x7161A0", VA = "0x180717BA0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06003099 RID: 12441 RVA: 0x00103B8C File Offset: 0x00101D8C
	[Token(Token = "0x6003099")]
	[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x0600309A RID: 12442 RVA: 0x00103B9C File Offset: 0x00101D9C
	[Token(Token = "0x600309A")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x0600309B RID: 12443 RVA: 0x00103BAC File Offset: 0x00101DAC
	[Token(Token = "0x600309B")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600309C RID: 12444 RVA: 0x00103BBC File Offset: 0x00101DBC
	[Token(Token = "0x600309C")]
	[Address(RVA = "0x717A60", Offset = "0x716060", VA = "0x180717A60", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第6关";
	}

	// Token: 0x0600309D RID: 12445 RVA: 0x00103BD0 File Offset: 0x00101DD0
	[Token(Token = "0x600309D")]
	[Address(RVA = "0x717B20", Offset = "0x716120", VA = "0x180717B20", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "爆炸保护：小丑王爆炸次数不能超过1次";
		}
		if (result == MissionResult.Second)
		{
			return "保护IV：提交6个原版南瓜头";
		}
		return string.Empty;
	}

	// Token: 0x0600309E RID: 12446 RVA: 0x00103BF8 File Offset: 0x00101DF8
	[Token(Token = "0x600309E")]
	[Address(RVA = "0x717AA0", Offset = "0x7160A0", VA = "0x180717AA0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "小丑爆炸伤害降低至5000，且不再伤害南瓜里的植物";
		}
		if (result == MissionResult.Second)
		{
			return "南瓜植物获得30%伤害减免";
		}
		return string.Empty;
	}

	// Token: 0x0600309F RID: 12447 RVA: 0x00103C20 File Offset: 0x00101E20
	[Token(Token = "0x600309F")]
	[Address(RVA = "0x7178B0", Offset = "0x715EB0", VA = "0x1807178B0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission4 = mission;
		Func<MissionResult> func = delegate
		{
			AdvantureMission mission3 = mission;
			if (mission3.count > 1)
			{
				mission3.endResult = (MissionResult)((ulong)0L);
			}
			throw new NullReferenceException();
		};
		mission4.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)24), 6, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x060030A0 RID: 12448 RVA: 0x00103CAC File Offset: 0x00101EAC
	[Token(Token = "0x60030A0")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPool6Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
