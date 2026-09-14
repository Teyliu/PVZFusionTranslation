using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000942 RID: 2370
[Token(Token = "0x2000942")]
public class NightPool4Strategy : BaseLevelStrategy
{
	// Token: 0x0600307D RID: 12413 RVA: 0x001036C4 File Offset: 0x001018C4
	[Token(Token = "0x600307D")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool4;
	}

	// Token: 0x0600307E RID: 12414 RVA: 0x001036D4 File Offset: 0x001018D4
	[Token(Token = "0x600307E")]
	[Address(RVA = "0x717190", Offset = "0x715790", VA = "0x180717190", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		return list;
	}

	// Token: 0x0600307F RID: 12415 RVA: 0x00103728 File Offset: 0x00101928
	[Token(Token = "0x600307F")]
	[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x06003080 RID: 12416 RVA: 0x00103738 File Offset: 0x00101938
	[Token(Token = "0x6003080")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06003081 RID: 12417 RVA: 0x00103748 File Offset: 0x00101948
	[Token(Token = "0x6003081")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003082 RID: 12418 RVA: 0x00103758 File Offset: 0x00101958
	[Token(Token = "0x6003082")]
	[Address(RVA = "0x717050", Offset = "0x715650", VA = "0x180717050", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第4关";
	}

	// Token: 0x06003083 RID: 12419 RVA: 0x0010376C File Offset: 0x0010196C
	[Token(Token = "0x6003083")]
	[Address(RVA = "0x717110", Offset = "0x715710", VA = "0x180717110", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "强风吹拂：使用三叶草吹跑10个气球僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "飞行植物研究：提交4株浮空仙人球";
		}
		return string.Empty;
	}

	// Token: 0x06003084 RID: 12420 RVA: 0x00103794 File Offset: 0x00101994
	[Token(Token = "0x6003084")]
	[Address(RVA = "0x717090", Offset = "0x715690", VA = "0x180717090", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "三叶草的风力效果提高20%，并且可动铁气球";
		}
		if (result == MissionResult.Second)
		{
			return "飞行植物获得30%伤害加成";
		}
		return string.Empty;
	}

	// Token: 0x06003085 RID: 12421 RVA: 0x001037BC File Offset: 0x001019BC
	[Token(Token = "0x6003085")]
	[Address(RVA = "0x716E40", Offset = "0x715440", VA = "0x180716E40", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission5 = mission;
		Action action = delegate
		{
			InGameText instance = InGameText.Instance;
			AdvantureMission mission4 = mission;
			int num;
			string text = string.Format("还需吹跑{0}只僵尸", num);
		};
		mission5.onLook = action;
		AdvantureMission mission2 = mission;
		Func<MissionResult> func = delegate
		{
			bool flag = mission.count >= 10;
			throw new NullReferenceException();
		};
		mission2.target = func;
		AdvantureConfig.SubmitPlantConfig(mission, (PlantType)((uint)1082), 4, (MissionResult)((uint)2));
		AdvantureMission mission3 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003086 RID: 12422 RVA: 0x00103860 File Offset: 0x00101A60
	[Token(Token = "0x6003086")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPool4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
