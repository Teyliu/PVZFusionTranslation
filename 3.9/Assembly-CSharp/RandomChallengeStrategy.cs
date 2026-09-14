using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

// Token: 0x0200097F RID: 2431
[Token(Token = "0x200097F")]
public class RandomChallengeStrategy : BaseLevelStrategy
{
	// Token: 0x0600321A RID: 12826 RVA: 0x00107738 File Offset: 0x00105938
	[Token(Token = "0x600321A")]
	[Address(RVA = "0x3F9540", Offset = "0x3F7B40", VA = "0x1803F9540", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.RandomChallenge;
	}

	// Token: 0x0600321B RID: 12827 RVA: 0x0010774C File Offset: 0x0010594C
	[Token(Token = "0x600321B")]
	[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x0600321C RID: 12828 RVA: 0x0010775C File Offset: 0x0010595C
	[Token(Token = "0x600321C")]
	[Address(RVA = "0x71F730", Offset = "0x71DD30", VA = "0x18071F730", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		if (!this.lockZombie)
		{
			this.lockZombie = true;
			List<ZombieType> list = new List();
			List<ZombieType> list2 = new List();
			int num = 0;
			DaySub5Strategy daySub5Strategy;
			daySub5Strategy.SetupBoard(num);
			List<ZombieType> zombieTypes = daySub5Strategy.GetZombieTypes();
			list.AddRange(zombieTypes);
			List<ZombieType> zombieTypes2 = new DaySub6Strategy().GetZombieTypes();
			list.AddRange(zombieTypes2);
			List<ZombieType> zombieTypes3 = new NightSub5Strategy().GetZombieTypes();
			list.AddRange(zombieTypes3);
			List<ZombieType> zombieTypes4 = new NightSub6Strategy().GetZombieTypes();
			list.AddRange(zombieTypes4);
			List<ZombieType> zombieTypes5 = new RoofSub5Strategy().GetZombieTypes();
			list.AddRange(zombieTypes5);
			List<ZombieType> zombieTypes6 = new RoofSub6Strategy().GetZombieTypes();
			list.AddRange(zombieTypes6);
			List<ZombieType> zombieTypes7 = new PoolSub5Strategy().GetZombieTypes();
			list2.AddRange(zombieTypes7);
			List<ZombieType> zombieTypes8 = new PoolSub6Strategy().GetZombieTypes();
			list2.AddRange(zombieTypes8);
			List<ZombieType> zombieTypes9 = new NightPoolSub5Strategy().GetZombieTypes();
			list2.AddRange(zombieTypes9);
			List<ZombieType> zombieTypes10 = new NightPoolSub6Strategy().GetZombieTypes();
			list2.AddRange(zombieTypes10);
			if (this.sceneType > SceneType.Night)
			{
				uint num2;
				List<ZombieType> random = ListExtensions.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(Enumerable.ToHashSet<ZombieType>(list)), (int)num2);
				this.zombies = random;
			}
			uint num3;
			List<ZombieType> random2 = ListExtensions.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(Enumerable.ToHashSet<ZombieType>(list)), (int)num3);
			this.zombies = random2;
			List<ZombieType> list3 = this.zombies;
			Func<ZombieType, bool> <>9__6_ = RandomChallengeStrategy.<>c.<>9__6_0;
			if (<>9__6_ == 0)
			{
				RandomChallengeStrategy.<>c.<>9__6_0 = delegate(ZombieType a)
				{
					bool flag;
					return flag;
				};
			}
			uint num4;
			List<ZombieType> random3 = ListExtensions.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(Enumerable.Where<ZombieType>(list2, <>9__6_)), (int)num4);
			list3.AddRange(random3);
			List<ZombieType> list4 = this.zombies;
			int size = list4._size;
			list4._size = 1;
			List<ZombieType> list5 = this.zombies;
			int size2 = list5._size;
			uint num6;
			uint num5 = num6 + 1U;
			list5._size = (int)num5;
			return this.zombies;
		}
		return this.zombies;
	}

	// Token: 0x0600321D RID: 12829 RVA: 0x00107938 File Offset: 0x00105B38
	[Token(Token = "0x600321D")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x0600321E RID: 12830 RVA: 0x00107948 File Offset: 0x00105B48
	[Token(Token = "0x600321E")]
	[Address(RVA = "0x71F4B0", Offset = "0x71DAB0", VA = "0x18071F4B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		if (!this.lockScene)
		{
			this.lockScene = true;
			List<SceneType> list = new List();
			int size = list._size;
			int size2 = list._size;
			int size3 = list._size;
			int size4 = list._size;
			int size5 = list._size;
			SceneType random = ListExtensions.GetRandom<SceneType>(list);
			this.sceneType = random;
			return random;
		}
		return this.sceneType;
	}

	// Token: 0x0600321F RID: 12831 RVA: 0x001079C0 File Offset: 0x00105BC0
	[Token(Token = "0x600321F")]
	[Address(RVA = "0x71F340", Offset = "0x71D940", VA = "0x18071F340", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：随机挑战";
	}

	// Token: 0x06003220 RID: 12832 RVA: 0x001079D4 File Offset: 0x00105BD4
	[Token(Token = "0x6003220")]
	[Address(RVA = "0x71F370", Offset = "0x71D970", VA = "0x18071F370", Slot = "31")]
	public override string GetLevelTip()
	{
		AdvantureData data = AdvantureConfig.data;
		string text;
		return "通关后随机刷新本关场景和僵尸\n" + text;
	}

	// Token: 0x06003221 RID: 12833 RVA: 0x001079FC File Offset: 0x00105BFC
	[Token(Token = "0x6003221")]
	[Address(RVA = "0x71FEC0", Offset = "0x71E4C0", VA = "0x18071FEC0")]
	public void Unlock()
	{
		this.lockScene = false;
	}

	// Token: 0x06003222 RID: 12834 RVA: 0x00107A10 File Offset: 0x00105C10
	[Token(Token = "0x6003222")]
	[Address(RVA = "0x71F450", Offset = "0x71DA50", VA = "0x18071F450", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交任务可随机抽取一个究极植物\n但有小概率敌方会出现究极僵尸，这个概率随着抽取次数变高而变高";
		}
		return string.Empty;
	}

	// Token: 0x06003223 RID: 12835 RVA: 0x00107A2C File Offset: 0x00105C2C
	[Token(Token = "0x6003223")]
	[Address(RVA = "0x71F060", Offset = "0x71D660", VA = "0x18071F060", Slot = "22")]
	public override AdvantureMission CreateMission(Board board)
	{
		AdvantureMission advantureMission = new AdvantureMission();
		Board board2 = board;
		AdvantureLevel level = this.GetLevel();
		advantureMission.level = level;
		advantureMission.single = true;
		advantureMission.needSubmitCount = (int)((ulong)300L);
		Func<MissionResult> <>9__13_ = RandomChallengeStrategy.<>c.<>9__13_2;
		if (<>9__13_ == 0)
		{
			RandomChallengeStrategy.<>c.<>9__13_2 = () => MissionResult.Nothing;
		}
		advantureMission.target = <>9__13_;
		advantureMission.submitCount = (int)((ulong)2147483647L);
		AdvantureMission mission = advantureMission;
		AdvantureMission mission3 = mission;
		Action action = delegate
		{
			InGameText instance = InGameText.Instance;
			int needSubmitCount = mission.needSubmitCount;
			string text = string.Format("抽取究极需要{0}点阳光", instance);
		};
		mission3.onLook = action;
		Func<ValueTuple<MissionResult, int>> func;
		mission.onSubmit = func;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x06003224 RID: 12836 RVA: 0x00107B00 File Offset: 0x00105D00
	[Token(Token = "0x6003224")]
	[Address(RVA = "0x71FE60", Offset = "0x71E460", VA = "0x18071FE60", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		board.CreateCard((FunctionCardType)((uint)14), num != 0).theSeedCost = (int)((ulong)500L);
		int num2 = 0;
		board.CreateCard((FunctionCardType)((uint)15), num2 != 0).theSeedCost = (int)((ulong)500L);
	}

	// Token: 0x06003225 RID: 12837 RVA: 0x00107B44 File Offset: 0x00105D44
	[Token(Token = "0x6003225")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public RandomChallengeStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}

	// Token: 0x04001D52 RID: 7506
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001D52")]
	public bool lockScene;

	// Token: 0x04001D53 RID: 7507
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4001D53")]
	public bool lockZombie;

	// Token: 0x04001D54 RID: 7508
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001D54")]
	private SceneType sceneType;

	// Token: 0x04001D55 RID: 7509
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D55")]
	private List<ZombieType> zombies;
}
