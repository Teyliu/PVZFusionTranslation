using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008F0 RID: 2288
[Token(Token = "0x20008F0")]
public class Pool3Strategy : BaseLevelStrategy
{
	// Token: 0x06002EB9 RID: 11961 RVA: 0x000FD1D0 File Offset: 0x000FB3D0
	[Token(Token = "0x6002EB9")]
	[Address(RVA = "0x6A1610", Offset = "0x69FC10", VA = "0x1806A1610", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool3;
	}

	// Token: 0x06002EBA RID: 11962 RVA: 0x000FD1E0 File Offset: 0x000FB3E0
	[Token(Token = "0x6002EBA")]
	[Address(RVA = "0x6A1720", Offset = "0x69FD20", VA = "0x1806A1720", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002EBB RID: 11963 RVA: 0x000FD224 File Offset: 0x000FB424
	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ThreePeater;
	}

	// Token: 0x06002EBC RID: 11964 RVA: 0x000FD234 File Offset: 0x000FB434
	[Token(Token = "0x6002EBC")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002EBD RID: 11965 RVA: 0x000FD244 File Offset: 0x000FB444
	[Token(Token = "0x6002EBD")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002EBE RID: 11966 RVA: 0x000FD254 File Offset: 0x000FB454
	[Token(Token = "0x6002EBE")]
	[Address(RVA = "0x6A15E0", Offset = "0x69FBE0", VA = "0x1806A15E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第3关";
	}

	// Token: 0x06002EBF RID: 11967 RVA: 0x000FD268 File Offset: 0x000FB468
	[Token(Token = "0x6002EBF")]
	[Address(RVA = "0x6A16A0", Offset = "0x69FCA0", VA = "0x1806A16A0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "预算有限：场上不可同时存在超过12株植物（睡莲也计入在内）";
		}
		if (result == MissionResult.Second)
		{
			return "全线研究：提交3株特种三线射手";
		}
		return string.Empty;
	}

	// Token: 0x06002EC0 RID: 11968 RVA: 0x000FD290 File Offset: 0x000FB490
	[Token(Token = "0x6002EC0")]
	[Address(RVA = "0x6A1620", Offset = "0x69FC20", VA = "0x1806A1620", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "当前植物数量小于12时，新种下的植物获得20%伤害加成，该加成在植物数量大于12后也不会消失";
		}
		if (result == MissionResult.Second)
		{
			return "三线射手的价格降低75";
		}
		return string.Empty;
	}

	// Token: 0x06002EC1 RID: 11969 RVA: 0x000FD2B8 File Offset: 0x000FB4B8
	[Token(Token = "0x6002EC1")]
	[Address(RVA = "0x6A1420", Offset = "0x69FA20", VA = "0x1806A1420", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		AdvantureMission mission = advantureMission;
		Func<MissionResult> func;
		mission.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1347), 3, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002EC2 RID: 11970 RVA: 0x000FD33C File Offset: 0x000FB53C
	[Token(Token = "0x6002EC2")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Pool3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
