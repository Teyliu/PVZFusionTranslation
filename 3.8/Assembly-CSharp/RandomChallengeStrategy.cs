using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

// Token: 0x02000943 RID: 2371
[Token(Token = "0x2000943")]
public class RandomChallengeStrategy : BaseLevelStrategy
{
	// Token: 0x060030E7 RID: 12519 RVA: 0x0010299C File Offset: 0x00100B9C
	[Token(Token = "0x60030E7")]
	[Address(RVA = "0x3AD6D0", Offset = "0x3ABCD0", VA = "0x1803AD6D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.RandomChallenge;
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x001029B0 File Offset: 0x00100BB0
	[Token(Token = "0x60030E8")]
	[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "23")]
	public override int GetMaxWave()
	{
		return 40;
	}

	// Token: 0x060030E9 RID: 12521 RVA: 0x001029C0 File Offset: 0x00100BC0
	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x6A55D0", Offset = "0x6A3BD0", VA = "0x1806A55D0", Slot = "24")]
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

	// Token: 0x060030EA RID: 12522 RVA: 0x00102B9C File Offset: 0x00100D9C
	[Token(Token = "0x60030EA")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060030EB RID: 12523 RVA: 0x00102BAC File Offset: 0x00100DAC
	[Token(Token = "0x60030EB")]
	[Address(RVA = "0x6A5350", Offset = "0x6A3950", VA = "0x1806A5350", Slot = "29")]
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

	// Token: 0x060030EC RID: 12524 RVA: 0x00102C24 File Offset: 0x00100E24
	[Token(Token = "0x60030EC")]
	[Address(RVA = "0x6A51E0", Offset = "0x6A37E0", VA = "0x1806A51E0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：随机挑战";
	}

	// Token: 0x060030ED RID: 12525 RVA: 0x00102C38 File Offset: 0x00100E38
	[Token(Token = "0x60030ED")]
	[Address(RVA = "0x6A5210", Offset = "0x6A3810", VA = "0x1806A5210", Slot = "31")]
	public override string GetLevelTip()
	{
		AdvantureData data = AdvantureConfig.data;
		string text;
		return "通关后随机刷新本关场景和僵尸\n" + text;
	}

	// Token: 0x060030EE RID: 12526 RVA: 0x00102C60 File Offset: 0x00100E60
	[Token(Token = "0x60030EE")]
	[Address(RVA = "0x6A5D60", Offset = "0x6A4360", VA = "0x1806A5D60")]
	public void Unlock()
	{
		this.lockScene = false;
	}

	// Token: 0x060030EF RID: 12527 RVA: 0x00102C74 File Offset: 0x00100E74
	[Token(Token = "0x60030EF")]
	[Address(RVA = "0x6A52F0", Offset = "0x6A38F0", VA = "0x1806A52F0", Slot = "32")]
	public override string GetMissionDescription(MissionResult result)
	{
		if (result == MissionResult.First)
		{
			return "提交任务可随机抽取一个究极植物\n但有小概率敌方会出现究极僵尸，这个概率随着抽取次数变高而变高";
		}
		return string.Empty;
	}

	// Token: 0x060030F0 RID: 12528 RVA: 0x00102C90 File Offset: 0x00100E90
	[Token(Token = "0x60030F0")]
	[Address(RVA = "0x6A4F00", Offset = "0x6A3500", VA = "0x1806A4F00", Slot = "22")]
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
			Func<MissionResult> func;
			RandomChallengeStrategy.<>c.<>9__13_2 = func;
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
			int num = 0;
			instance.ShowText(text, 3f, num != 0);
		};
		mission3.onLook = action;
		Func<ValueTuple<MissionResult, int>> func2;
		mission.onSubmit = func2;
		AdvantureMission mission2 = mission;
		AdvantureLevel level2 = this.GetLevel();
		return mission;
	}

	// Token: 0x060030F1 RID: 12529 RVA: 0x00102D58 File Offset: 0x00100F58
	[Token(Token = "0x60030F1")]
	[Address(RVA = "0x6A5D00", Offset = "0x6A4300", VA = "0x1806A5D00", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		board.CreateCard((FunctionCardType)((uint)14), num != 0).theSeedCost = (int)((ulong)500L);
		int num2 = 0;
		board.CreateCard((FunctionCardType)((uint)15), num2 != 0).theSeedCost = (int)((ulong)500L);
	}

	// Token: 0x060030F2 RID: 12530 RVA: 0x00102D9C File Offset: 0x00100F9C
	[Token(Token = "0x60030F2")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public RandomChallengeStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}

	// Token: 0x04001C62 RID: 7266
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001C62")]
	public bool lockScene;

	// Token: 0x04001C63 RID: 7267
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4001C63")]
	public bool lockZombie;

	// Token: 0x04001C64 RID: 7268
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001C64")]
	private SceneType sceneType;

	// Token: 0x04001C65 RID: 7269
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001C65")]
	private List<ZombieType> zombies;
}
