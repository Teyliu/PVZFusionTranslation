using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000944 RID: 2372
[Token(Token = "0x2000944")]
public class NightPool5Strategy : BaseLevelStrategy
{
	// Token: 0x0600308A RID: 12426 RVA: 0x001038F0 File Offset: 0x00101AF0
	[Token(Token = "0x600308A")]
	[Address(RVA = "0x7175D0", Offset = "0x715BD0", VA = "0x1807175D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool5;
	}

	// Token: 0x0600308B RID: 12427 RVA: 0x00103900 File Offset: 0x00101B00
	[Token(Token = "0x600308B")]
	[Address(RVA = "0x7176E0", Offset = "0x715CE0", VA = "0x1807176E0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x0600308C RID: 12428 RVA: 0x0010394C File Offset: 0x00101B4C
	[Token(Token = "0x600308C")]
	[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Cactus;
	}

	// Token: 0x0600308D RID: 12429 RVA: 0x0010395C File Offset: 0x00101B5C
	[Token(Token = "0x600308D")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x0600308E RID: 12430 RVA: 0x0010396C File Offset: 0x00101B6C
	[Token(Token = "0x600308E")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600308F RID: 12431 RVA: 0x0010397C File Offset: 0x00101B7C
	[Token(Token = "0x600308F")]
	[Address(RVA = "0x7175A0", Offset = "0x715BA0", VA = "0x1807175A0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉迷雾：第5关";
	}

	// Token: 0x06003090 RID: 12432 RVA: 0x00103990 File Offset: 0x00101B90
	[Token(Token = "0x6003090")]
	[Address(RVA = "0x717660", Offset = "0x715C60", VA = "0x180717660", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "幸运五叶草：使用杨桃五叶草强化300发子弹";
		}
		if (result == MissionResult.Second)
		{
			return "精准数字：使用任意植物造成1437点伤害";
		}
		return string.Empty;
	}

	// Token: 0x06003091 RID: 12433 RVA: 0x001039B8 File Offset: 0x00101BB8
	[Token(Token = "0x6003091")]
	[Address(RVA = "0x7175E0", Offset = "0x715BE0", VA = "0x1807175E0", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "杨桃五叶草额外为子弹提高20%伤害";
		}
		if (result == MissionResult.Second)
		{
			return "杨桃家族植物伤害增加20%";
		}
		return string.Empty;
	}

	// Token: 0x06003092 RID: 12434 RVA: 0x001039E0 File Offset: 0x00101BE0
	[Token(Token = "0x6003092")]
	[Address(RVA = "0x7173B0", Offset = "0x7159B0", VA = "0x1807173B0", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		AdvantureMission mission = advantureMission;
		AdvantureMission mission5 = mission;
		Action action = delegate
		{
			InGameText instance = InGameText.Instance;
			AdvantureMission mission4 = mission;
			int num;
			string text = string.Format("还需强化{0}发子弹", num);
		};
		mission5.onLook = action;
		AdvantureMission mission2 = mission;
		Func<MissionResult> func = delegate
		{
			while (mission.count < 300)
			{
				Dictionary<PlantType, long> reportDic = board.damageReporter.ReportDic;
				bool flag;
				if (flag)
				{
					return MissionResult.Second;
				}
				ulong num2;
				if (num2 == (ulong)0L)
				{
					break;
				}
			}
			return MissionResult.First;
		};
		mission2.target = func;
		AdvantureMission mission3 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003093 RID: 12435 RVA: 0x00103A78 File Offset: 0x00101C78
	[Token(Token = "0x6003093")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPool5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
