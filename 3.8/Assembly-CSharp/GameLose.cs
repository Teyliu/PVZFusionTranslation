using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x02000226 RID: 550
[Token(Token = "0x2000226")]
public class GameLose : MonoBehaviour
{
	// Token: 0x06000980 RID: 2432 RVA: 0x00033F58 File Offset: 0x00032158
	[Token(Token = "0x6000980")]
	[Address(RVA = "0x87BCD0", Offset = "0x87A2D0", VA = "0x18087BCD0")]
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

	// Token: 0x06000981 RID: 2433 RVA: 0x00033F94 File Offset: 0x00032194
	[Token(Token = "0x6000981")]
	[Address(RVA = "0x87A7F0", Offset = "0x878DF0", VA = "0x18087A7F0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		while (this.canTriggerLose)
		{
			BoardVictory boardVicotry = Board.Instance.boardVicotry;
			bool flag;
			bool flag2;
			if ((boardVicotry != 0 && boardVicotry.VictoryType == VictoryType.IZVictory) || !flag || typeof(Board).TypeHandle == (ulong)232L || typeof(Board).TypeHandle == (ulong)231L || typeof(Board).TypeHandle == (ulong)45L || typeof(Board).TypeHandle == (ulong)247L || typeof(Board).TypeHandle == (ulong)63L || typeof(Board).TypeHandle == (ulong)260L || !flag2)
			{
				break;
			}
			Board instance = Board.Instance;
			if (instance.over)
			{
				break;
			}
			bool flag3;
			if (flag3 && !TravelMgr.Instance.data.hideActive)
			{
				TravelMgr.Instance.data.hideActive = true;
				global::UnityEngine.Object.Destroy(this);
				int num = 0;
				instance.GetPoint(10000f, num != 0);
				instance.EnterNextRound();
				instance.boardTag.disableSummonZombie = true;
				instance.over = true;
				break;
			}
			bool flag4;
			while (flag4)
			{
			}
			bool flag5;
			if (flag5)
			{
				return;
			}
			bool flag6;
			if (flag6)
			{
				List<Zombie> list = this.secondChanceZombies;
				int num2 = list._size + 1;
				list._size = num2;
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

	// Token: 0x06000982 RID: 2434 RVA: 0x00034138 File Offset: 0x00032338
	[Token(Token = "0x6000982")]
	[Address(RVA = "0x87B9C0", Offset = "0x879FC0", VA = "0x18087B9C0")]
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

	// Token: 0x06000983 RID: 2435 RVA: 0x0003416C File Offset: 0x0003236C
	[Token(Token = "0x6000983")]
	[Address(RVA = "0x87B200", Offset = "0x879800", VA = "0x18087B200")]
	private void SetCooldown(float time)
	{
		this.cooldownTimer = time;
		this.canTriggerLose = false;
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00034188 File Offset: 0x00032388
	[Token(Token = "0x6000984")]
	[Address(RVA = "0x87B210", Offset = "0x879810", VA = "0x18087B210")]
	private bool ShouldCheckZombieEnter()
	{
		BoardVictory boardVicotry = Board.Instance.boardVicotry;
		return boardVicotry == 0 || boardVicotry.VictoryType != VictoryType.IZVictory;
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x000341B8 File Offset: 0x000323B8
	[Token(Token = "0x6000985")]
	[Address(RVA = "0x87B280", Offset = "0x879880", VA = "0x18087B280")]
	private bool ShouldIgnoreZombie(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		if (theZombieType == ZombieType.SummonedHorse || theZombieType == ZombieType.HorseBoss || theZombieType == ZombieType.BungiZombie || theZombieType == ZombieType.VoodooDollZombie || theZombieType == ZombieType.GoldBungiZombie || theZombieType == ZombieType.FootballBoss || zombie.isMindControlled || zombie.Alive)
		{
		}
		return true;
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00034214 File Offset: 0x00032414
	[Token(Token = "0x6000986")]
	[Address(RVA = "0x87A7C0", Offset = "0x878DC0", VA = "0x18087A7C0")]
	private bool IsSpecialZombieType(ZombieType zombieType)
	{
		return zombieType == ZombieType.BungiZombie || zombieType == ZombieType.VoodooDollZombie || zombieType == ZombieType.GoldBungiZombie || zombieType == ZombieType.FootballBoss;
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00034240 File Offset: 0x00032440
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x87AD80", Offset = "0x879380", VA = "0x18087AD80")]
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

	// Token: 0x06000988 RID: 2440 RVA: 0x00034388 File Offset: 0x00032588
	[Token(Token = "0x6000988")]
	[Address(RVA = "0x87B2E0", Offset = "0x8798E0", VA = "0x18087B2E0")]
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

	// Token: 0x06000989 RID: 2441 RVA: 0x00034404 File Offset: 0x00032604
	[Token(Token = "0x6000989")]
	[Address(RVA = "0x87B550", Offset = "0x879B50", VA = "0x18087B550")]
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
				int num3 = 0;
				instance.ShowText("词条【不死图腾】触发了", 3f, num3 != 0);
				break;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00034494 File Offset: 0x00032694
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x87B800", Offset = "0x879E00", VA = "0x18087B800")]
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
				int num2 = 0;
				instance.ShowText("词条【力挽狂澜】触发了", 3f, num2 != 0);
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00034500 File Offset: 0x00032700
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x87B4A0", Offset = "0x879AA0", VA = "0x18087B4A0")]
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

	// Token: 0x0600098C RID: 2444 RVA: 0x00034564 File Offset: 0x00032764
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x87BA20", Offset = "0x87A020", VA = "0x18087BA20")]
	private void UpdateSecondChanceTimer()
	{
		if (this.secondChanceActive)
		{
			InGameText instance = InGameText.Instance;
			float num = this.secondChanceTimer;
			int num2 = 0;
			string text = string.Format("在<color=red>{0:F2}</color>秒内击杀进家僵尸！", instance);
			int num3 = 0;
			instance.ShowText(text, (float)num2, num3 != 0);
			float num4 = this.secondChanceTimer;
			float deltaTime = Time.deltaTime;
			List<Zombie> list = this.secondChanceZombies;
			this.secondChanceTimer = num4;
			Predicate<Zombie> <>9__21_ = GameLose.<>c.<>9__21_0;
			if (<>9__21_ == 0)
			{
				Predicate<Zombie> predicate;
				GameLose.<>c.<>9__21_0 = predicate;
			}
			int num5 = list.RemoveAll(<>9__21_);
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

	// Token: 0x0600098D RID: 2445 RVA: 0x00034650 File Offset: 0x00032850
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x87B410", Offset = "0x879A10", VA = "0x18087B410")]
	private bool TryHandlePVPMode(Zombie zombie)
	{
		if (!Board.Instance.over)
		{
			PVPRandomManager.Instance.ZombieEnterHouse(zombie);
		}
		return true;
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00034680 File Offset: 0x00032880
	[Token(Token = "0x600098E")]
	[Address(RVA = "0x87A6A0", Offset = "0x878CA0", VA = "0x18087A6A0")]
	private void HandleGameLose(Board board)
	{
		bool flag;
		if (!board.over && (!flag || flag))
		{
			UIMgr.EnterLoseMenu("有僵尸进入了你的房子");
		}
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x000346B8 File Offset: 0x000328B8
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x87BD30", Offset = "0x87A330", VA = "0x18087BD30")]
	public GameLose()
	{
		List<Zombie> list = new List();
		this.secondChanceZombies = list;
		base..ctor();
	}

	// Token: 0x040004F2 RID: 1266
	[Token(Token = "0x40004F2")]
	private const float TotemCooldownTime = 3f;

	// Token: 0x040004F3 RID: 1267
	[Token(Token = "0x40004F3")]
	private const int HideActiveReward = 10000;

	// Token: 0x040004F4 RID: 1268
	[Token(Token = "0x40004F4")]
	private const float TotemKnockbackDistance = 100f;

	// Token: 0x040004F5 RID: 1269
	[Token(Token = "0x40004F5")]
	private const float SecondChanceGracePeriod = 1.5f;

	// Token: 0x040004F6 RID: 1270
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004F6")]
	private float cooldownTimer;

	// Token: 0x040004F7 RID: 1271
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004F7")]
	private bool canTriggerLose = true;

	// Token: 0x040004F8 RID: 1272
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004F8")]
	private readonly List<Zombie> secondChanceZombies;

	// Token: 0x040004F9 RID: 1273
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004F9")]
	private float secondChanceTimer;

	// Token: 0x040004FA RID: 1274
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004FA")]
	private bool secondChanceActive;
}
