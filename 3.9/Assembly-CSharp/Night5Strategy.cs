using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200091D RID: 2333
[Token(Token = "0x200091D")]
public class Night5Strategy : BaseLevelStrategy
{
	// Token: 0x06002F84 RID: 12164 RVA: 0x00100D74 File Offset: 0x000FEF74
	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x715870", Offset = "0x713E70", VA = "0x180715870", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night5;
	}

	// Token: 0x06002F85 RID: 12165 RVA: 0x00100D84 File Offset: 0x000FEF84
	[Token(Token = "0x6002F85")]
	[Address(RVA = "0x715690", Offset = "0x713C90", VA = "0x180715690", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		advantureMission.board = board;
		advantureMission.level = (AdvantureLevel)((ulong)17L);
		Func<MissionResult> <>9__1_ = Night5Strategy.<>c.<>9__1_0;
		if (<>9__1_ == 0)
		{
			Night5Strategy.<>c.<>9__1_0 = delegate
			{
				List<Zombie> allZombies = Lawnf.GetAllZombies(false);
				Func<Zombie, bool> <>9__1_2 = Night5Strategy.<>c.<>9__1_1;
				if (<>9__1_2 == 0)
				{
					Night5Strategy.<>c.<>9__1_1 = delegate(Zombie z)
					{
						if (z == 0)
						{
							return true;
						}
						throw new NullReferenceException();
					};
				}
				List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__1_2));
				throw new NullReferenceException();
			};
		}
		advantureMission.target = <>9__1_;
		return advantureMission;
	}

	// Token: 0x06002F86 RID: 12166 RVA: 0x00100DD8 File Offset: 0x000FEFD8
	[Token(Token = "0x6002F86")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F87 RID: 12167 RVA: 0x00100DE8 File Offset: 0x000FEFE8
	[Token(Token = "0x6002F87")]
	[Address(RVA = "0x715980", Offset = "0x713F80", VA = "0x180715980", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002F88 RID: 12168 RVA: 0x00100E2C File Offset: 0x000FF02C
	[Token(Token = "0x6002F88")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06002F89 RID: 12169 RVA: 0x00100E3C File Offset: 0x000FF03C
	[Token(Token = "0x6002F89")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002F8A RID: 12170 RVA: 0x00100E4C File Offset: 0x000FF04C
	[Token(Token = "0x6002F8A")]
	[Address(RVA = "0x715840", Offset = "0x713E40", VA = "0x180715840", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉黑夜：第5关";
	}

	// Token: 0x06002F8B RID: 12171 RVA: 0x00100E60 File Offset: 0x000FF060
	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x715900", Offset = "0x713F00", VA = "0x180715900", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "冰天雪地：同时冻结50个僵尸";
		}
		if (result == MissionResult.Second)
		{
			return "及时雨：提交3个寒冰机枪射手";
		}
		return string.Empty;
	}

	// Token: 0x06002F8C RID: 12172 RVA: 0x00100E88 File Offset: 0x000FF088
	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x715880", Offset = "0x713E80", VA = "0x180715880", Slot = "33")]
	public override string GetMissionAwardDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "冻结僵尸的时长+10%";
		}
		if (result == MissionResult.Second)
		{
			return "寒冰豌豆命中僵尸时有概率直接令僵尸冻结";
		}
		return string.Empty;
	}

	// Token: 0x06002F8D RID: 12173 RVA: 0x00100EB0 File Offset: 0x000FF0B0
	[Token(Token = "0x6002F8D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Night5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
