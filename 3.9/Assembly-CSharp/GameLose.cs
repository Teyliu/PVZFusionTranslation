using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x0200022B RID: 555
[Token(Token = "0x200022B")]
public class GameLose : MonoBehaviour
{
	// Token: 0x06000996 RID: 2454 RVA: 0x00033D98 File Offset: 0x00031F98
	[Token(Token = "0x6000996")]
	[Address(RVA = "0x90B7D0", Offset = "0x909DD0", VA = "0x18090B7D0")]
	private void Update()
	{
		float num = this.cooldownTimer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			int num3 = 0;
			this.cooldownTimer = (float)num3;
			this.canTriggerLose = true;
		}
		this.UpdateSecondChanceTimer();
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00033DD4 File Offset: 0x00031FD4
	[Token(Token = "0x6000997")]
	[Address(RVA = "0x90A280", Offset = "0x908880", VA = "0x18090A280")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		while (this.canTriggerLose)
		{
			BoardVictory boardVicotry = Board.Instance.boardVicotry;
			bool flag;
			ulong num;
			if ((boardVicotry != 0 && boardVicotry.VictoryType == VictoryType.IZVictory) || !flag || typeof(Board).TypeHandle == (ulong)232L || typeof(Board).TypeHandle == (ulong)231L || typeof(Board).TypeHandle == (ulong)45L || typeof(Board).TypeHandle == (ulong)247L || typeof(Board).TypeHandle == (ulong)63L || typeof(Board).TypeHandle == (ulong)260L || num == (ulong)0L)
			{
				break;
			}
			Board instance = Board.Instance;
			if (instance.over)
			{
				break;
			}
			bool flag2;
			if (flag2 && !TravelMgr.Instance.data.hideActive)
			{
				TravelMgr.Instance.data.hideActive = true;
				global::UnityEngine.Object.Destroy(this);
				int num2 = 0;
				instance.GetPoint(10000f, num2 != 0);
				instance.EnterNextRound();
				instance.boardTag.disableSummonZombie = true;
				instance.over = true;
				break;
			}
			bool flag3;
			while (flag3)
			{
			}
			bool flag4;
			if (flag4)
			{
				return;
			}
			bool flag5;
			if (flag5)
			{
				List<Zombie> list = this.secondChanceZombies;
				int num3 = list._size + 1;
				list._size = num3;
				while (this.secondChanceActive)
				{
				}
				this.secondChanceActive = true;
				this.secondChanceTimer = 1.5f;
				this.canTriggerLose = false;
				Time.timeScale = 0.2f;
				return;
			}
			if (!Board.Instance.over)
			{
				PVPRandomManager instance2 = PVPRandomManager.Instance;
				return;
			}
		}
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00033F7C File Offset: 0x0003217C
	[Token(Token = "0x6000998")]
	[Address(RVA = "0x90B4A0", Offset = "0x909AA0", VA = "0x18090B4A0")]
	private void UpdateCooldownTimer()
	{
		float num = this.cooldownTimer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			int num3 = 0;
			this.cooldownTimer = (float)num3;
			this.canTriggerLose = true;
		}
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00033FB0 File Offset: 0x000321B0
	[Token(Token = "0x6000999")]
	[Address(RVA = "0x90ACB0", Offset = "0x9092B0", VA = "0x18090ACB0")]
	private void SetCooldown(float time)
	{
		this.cooldownTimer = time;
		this.canTriggerLose = false;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00033FCC File Offset: 0x000321CC
	[Token(Token = "0x600099A")]
	[Address(RVA = "0x90ACC0", Offset = "0x9092C0", VA = "0x18090ACC0")]
	private bool ShouldCheckZombieEnter()
	{
		BoardVictory boardVicotry = Board.Instance.boardVicotry;
		return boardVicotry == 0 || boardVicotry.VictoryType != VictoryType.IZVictory;
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00033FFC File Offset: 0x000321FC
	[Token(Token = "0x600099B")]
	[Address(RVA = "0x90AD30", Offset = "0x909330", VA = "0x18090AD30")]
	private bool ShouldIgnoreZombie(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		if (theZombieType == ZombieType.SummonedHorse || theZombieType == ZombieType.HorseBoss || theZombieType == ZombieType.BungiZombie || theZombieType == ZombieType.VoodooDollZombie || theZombieType == ZombieType.GoldBungiZombie || theZombieType == ZombieType.FootballBoss || zombie.isMindControlled || zombie.Alive)
		{
		}
		return true;
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00034058 File Offset: 0x00032258
	[Token(Token = "0x600099C")]
	[Address(RVA = "0x90A250", Offset = "0x908850", VA = "0x18090A250")]
	private bool IsSpecialZombieType(ZombieType zombieType)
	{
		return zombieType == ZombieType.BungiZombie || zombieType == ZombieType.VoodooDollZombie || zombieType == ZombieType.GoldBungiZombie || zombieType == ZombieType.FootballBoss;
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00034084 File Offset: 0x00032284
	[Token(Token = "0x600099D")]
	[Address(RVA = "0x90A820", Offset = "0x908E20", VA = "0x18090A820")]
	private void ProcessZombieEnter(Zombie zombie)
	{
		Board instance;
		for (;;)
		{
			ZombieType theZombieType = zombie.theZombieType;
			if (theZombieType == ZombieType.SummonedHorse || theZombieType == ZombieType.HorseBoss || theZombieType == ZombieType.BungiZombie || theZombieType == ZombieType.VoodooDollZombie || theZombieType == ZombieType.GoldBungiZombie || theZombieType == ZombieType.FootballBoss || zombie.isMindControlled || !zombie.Alive)
			{
				return;
			}
			instance = Board.Instance;
			if (instance.over)
			{
				return;
			}
			if (global::Lawnf.TravelInvest((InvestBuff)((uint)2013)) && !TravelMgr.Instance.data.hideActive)
			{
				break;
			}
			bool flag;
			while (flag)
			{
			}
			bool flag2;
			if (flag2)
			{
				goto IL_0133;
			}
			if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)10015)))
			{
				goto Block_13;
			}
			if (!Board.Instance.over)
			{
				goto Block_14;
			}
		}
		TravelMgr.Instance.data.hideActive = true;
		global::UnityEngine.Object.Destroy(this);
		int num = 0;
		instance.GetPoint(10000f, num != 0);
		instance.EnterNextRound();
		instance.boardTag.disableSummonZombie = true;
		instance.over = true;
		return;
		Block_13:
		zombie.theOriginSpeed = 1.3f;
		Time.timeScale = 0.2f;
		return;
		Block_14:
		PVPRandomManager.Instance.ZombieEnterHouse(zombie);
		return;
		IL_0133:
		throw new NullReferenceException();
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x000341CC File Offset: 0x000323CC
	[Token(Token = "0x600099E")]
	[Address(RVA = "0x90ADA0", Offset = "0x9093A0", VA = "0x18090ADA0")]
	private bool TryHandleHideActiveBuff(Board board)
	{
		if (global::Lawnf.TravelInvest((InvestBuff)((uint)2013)) && !TravelMgr.Instance.data.hideActive)
		{
			TravelMgr.Instance.data.hideActive = true;
			global::UnityEngine.Object.Destroy(this);
			int num = 0;
			board.GetPoint(10000f, num != 0);
			board.EnterNextRound();
			board.boardTag.disableSummonZombie = true;
			board.over = true;
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00034248 File Offset: 0x00032448
	[Token(Token = "0x600099F")]
	[Address(RVA = "0x90B010", Offset = "0x909610", VA = "0x18090B010")]
	private bool TryHandleTotemBuff(Board board)
	{
		while (global::Lawnf.TravelAdvanced((AdvBuff)((uint)10004)))
		{
			List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
			int num = 0;
			bool flag;
			if (flag)
			{
			}
			if (num == 0)
			{
				int num2 = 0;
				bool flag2 = TravelMgr.Instance.data.advBuffs.Remove((uint)10004);
				if (num2 < board.rowNum)
				{
					num2++;
				}
				InGameText instance = InGameText.Instance;
				break;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x000342C4 File Offset: 0x000324C4
	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x90B2D0", Offset = "0x9098D0", VA = "0x18090B2D0")]
	private bool TryHandleTurnTheTide(Board board)
	{
		while (global::Lawnf.TravelAdvanced((AdvBuff)((uint)10012)))
		{
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			bool flag;
			ulong num;
			if ((!flag || global::UnityEngine.Random.Range(0, 3) == 0) && num == (ulong)0L)
			{
				InGameText instance = InGameText.Instance;
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00034318 File Offset: 0x00032518
	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x90AF60", Offset = "0x909560", VA = "0x18090AF60")]
	private bool TryHandleSecondChance(Zombie zombie)
	{
		if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)10015)))
		{
			List<Zombie> list = this.secondChanceZombies;
			if (!this.secondChanceActive)
			{
				this.secondChanceActive = true;
				this.secondChanceTimer = 1.5f;
				this.canTriggerLose = false;
				zombie.theOriginSpeed = 1.3f;
				Time.timeScale = 0.2f;
			}
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x0003437C File Offset: 0x0003257C
	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x90B500", Offset = "0x909B00", VA = "0x18090B500")]
	private void UpdateSecondChanceTimer()
	{
		if (this.secondChanceActive)
		{
			InGameText instance = InGameText.Instance;
			float num = this.secondChanceTimer;
			string text = string.Format("在<color=red>{0:F2}</color>秒内击杀进家僵尸！", instance);
			float num2 = this.secondChanceTimer;
			float deltaTime = Time.deltaTime;
			List<Zombie> list = this.secondChanceZombies;
			this.secondChanceTimer = num2;
			Predicate<Zombie> <>9__21_ = GameLose.<>c.<>9__21_0;
			if (<>9__21_ == 0)
			{
				Predicate<Zombie> predicate;
				GameLose.<>c.<>9__21_0 = predicate;
			}
			int num3 = list.RemoveAll(<>9__21_);
			List<Zombie> list2 = this.secondChanceZombies;
			this.secondChanceActive = false;
			this.canTriggerLose = true;
			int size = list2._size;
			list2._size = (int)((ulong)0L);
			if (size > 0)
			{
			}
			Board instance2 = Board.Instance;
			this.HandleGameLose(instance2);
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00034454 File Offset: 0x00032654
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x90AED0", Offset = "0x9094D0", VA = "0x18090AED0")]
	private bool TryHandlePVPMode(Zombie zombie)
	{
		if (!Board.Instance.over)
		{
			PVPRandomManager.Instance.ZombieEnterHouse(zombie);
		}
		return true;
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00034484 File Offset: 0x00032684
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x90A130", Offset = "0x908730", VA = "0x18090A130")]
	private void HandleGameLose(Board board)
	{
		bool flag;
		if (!board.over && (!flag || flag))
		{
			UIMgr.EnterLoseMenu("有僵尸进入了你的房子");
		}
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x000344BC File Offset: 0x000326BC
	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x90B830", Offset = "0x909E30", VA = "0x18090B830")]
	public GameLose()
	{
		List<Zombie> list = new List();
		this.secondChanceZombies = list;
		base..ctor();
	}

	// Token: 0x040004F8 RID: 1272
	[Token(Token = "0x40004F8")]
	private const float TotemCooldownTime = 3f;

	// Token: 0x040004F9 RID: 1273
	[Token(Token = "0x40004F9")]
	private const int HideActiveReward = 10000;

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x40004FA")]
	private const float TotemKnockbackDistance = 100f;

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x40004FB")]
	private const float SecondChanceGracePeriod = 1.5f;

	// Token: 0x040004FC RID: 1276
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004FC")]
	private float cooldownTimer;

	// Token: 0x040004FD RID: 1277
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004FD")]
	private bool canTriggerLose = true;

	// Token: 0x040004FE RID: 1278
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004FE")]
	private readonly List<Zombie> secondChanceZombies;

	// Token: 0x040004FF RID: 1279
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004FF")]
	private float secondChanceTimer;

	// Token: 0x04000500 RID: 1280
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000500")]
	private bool secondChanceActive;
}
