using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200096C RID: 2412
[Token(Token = "0x200096C")]
public class Snow5Strategy : BaseLevelStrategy
{
	// Token: 0x06003190 RID: 12688 RVA: 0x001061DC File Offset: 0x001043DC
	[Token(Token = "0x6003190")]
	[Address(RVA = "0x7253D0", Offset = "0x7239D0", VA = "0x1807253D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow5;
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x001061EC File Offset: 0x001043EC
	[Token(Token = "0x6003191")]
	[Address(RVA = "0x7254E0", Offset = "0x723AE0", VA = "0x1807254E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		return list;
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x00106248 File Offset: 0x00104448
	[Token(Token = "0x6003192")]
	[Address(RVA = "0x716670", Offset = "0x714C70", VA = "0x180716670", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WaterAloes;
	}

	// Token: 0x06003193 RID: 12691 RVA: 0x00106258 File Offset: 0x00104458
	[Token(Token = "0x6003193")]
	[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow;
	}

	// Token: 0x06003194 RID: 12692 RVA: 0x00106268 File Offset: 0x00104468
	[Token(Token = "0x6003194")]
	[Address(RVA = "0x7253A0", Offset = "0x7239A0", VA = "0x1807253A0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉雪原：第5关";
	}

	// Token: 0x06003195 RID: 12693 RVA: 0x0010627C File Offset: 0x0010447C
	[Token(Token = "0x6003195")]
	[Address(RVA = "0x725460", Offset = "0x723A60", VA = "0x180725460", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "冰块连射：累计发射30次冰块";
		}
		if (result == MissionResult.Second)
		{
			return "水润全场：提交5株芦荟医师";
		}
		return string.Empty;
	}

	// Token: 0x06003196 RID: 12694 RVA: 0x001062A4 File Offset: 0x001044A4
	[Token(Token = "0x6003196")]
	[Address(RVA = "0x7253E0", Offset = "0x7239E0", VA = "0x1807253E0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "水芦荟的价格降低50";
		}
		if (result == MissionResult.Second)
		{
			return "芦荟医师的能量消耗降低2点";
		}
		return string.Empty;
	}

	// Token: 0x06003197 RID: 12695 RVA: 0x001062CC File Offset: 0x001044CC
	[Token(Token = "0x6003197")]
	[Address(RVA = "0x7251B0", Offset = "0x7237B0", VA = "0x1807251B0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		Func<ValueTuple<MissionResult, int>> func;
		advantureMission.onSubmit = func;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<MissionResult> func2 = delegate
		{
			bool flag = mission.count >= 30;
			throw new NullReferenceException();
		};
		mission3.target = func2;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003198 RID: 12696 RVA: 0x00106354 File Offset: 0x00104554
	[Token(Token = "0x6003198")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003199 RID: 12697 RVA: 0x00106364 File Offset: 0x00104564
	[Token(Token = "0x6003199")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Snow5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
