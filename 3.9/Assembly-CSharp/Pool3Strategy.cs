using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200092C RID: 2348
[Token(Token = "0x200092C")]
public class Pool3Strategy : BaseLevelStrategy
{
	// Token: 0x06002FEC RID: 12268 RVA: 0x00101DC0 File Offset: 0x000FFFC0
	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x71B770", Offset = "0x719D70", VA = "0x18071B770", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool3;
	}

	// Token: 0x06002FED RID: 12269 RVA: 0x00101DD0 File Offset: 0x000FFFD0
	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x71B880", Offset = "0x719E80", VA = "0x18071B880", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002FEE RID: 12270 RVA: 0x00101E14 File Offset: 0x00100014
	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ThreePeater;
	}

	// Token: 0x06002FEF RID: 12271 RVA: 0x00101E24 File Offset: 0x00100024
	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06002FF0 RID: 12272 RVA: 0x00101E34 File Offset: 0x00100034
	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FF1 RID: 12273 RVA: 0x00101E44 File Offset: 0x00100044
	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x71B740", Offset = "0x719D40", VA = "0x18071B740", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉泳池：第3关";
	}

	// Token: 0x06002FF2 RID: 12274 RVA: 0x00101E58 File Offset: 0x00100058
	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x71B800", Offset = "0x719E00", VA = "0x18071B800", Slot = "32")]
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

	// Token: 0x06002FF3 RID: 12275 RVA: 0x00101E80 File Offset: 0x00100080
	[Token(Token = "0x6002FF3")]
	[Address(RVA = "0x71B780", Offset = "0x719D80", VA = "0x18071B780", Slot = "33")]
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

	// Token: 0x06002FF4 RID: 12276 RVA: 0x00101EA8 File Offset: 0x001000A8
	[Token(Token = "0x6002FF4")]
	[Address(RVA = "0x71B580", Offset = "0x719B80", VA = "0x18071B580", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.endResult = (MissionResult)((ulong)1L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Func<MissionResult> func = delegate
		{
			if (board.theCurrentPlantCount > 12)
			{
				mission.endResult = (MissionResult)((ulong)0L);
			}
			throw new NullReferenceException();
		};
		mission3.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1347), 3, (MissionResult)((uint)2));
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06002FF5 RID: 12277 RVA: 0x00101F40 File Offset: 0x00100140
	[Token(Token = "0x6002FF5")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Pool3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
