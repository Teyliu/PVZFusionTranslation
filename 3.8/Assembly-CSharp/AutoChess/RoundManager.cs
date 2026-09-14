using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace AutoChess
{
	// Token: 0x02000AB0 RID: 2736
	[Token(Token = "0x2000AB0")]
	public class RoundManager : MonoBehaviour
	{
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x0012AF50 File Offset: 0x00129150
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x0012AF64 File Offset: 0x00129164
		[Token(Token = "0x1700038B")]
		public static RoundManager Instance
		{
			[Token(Token = "0x600387B")]
			[Address(RVA = "0x7754A0", Offset = "0x773AA0", VA = "0x1807754A0")]
			get;
			[Token(Token = "0x600387C")]
			[Address(RVA = "0x7754E0", Offset = "0x773AE0", VA = "0x1807754E0")]
			private set;
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x0012AF78 File Offset: 0x00129178
		[Token(Token = "0x600387D")]
		[Address(RVA = "0x774810", Offset = "0x772E10", VA = "0x180774810")]
		public int RoundGroup(int round)
		{
			int num = round - 1;
			if (num > 7)
			{
				if (num <= 5)
				{
					return 2;
				}
				if (num <= 5)
				{
					return 3;
				}
			}
			return 1;
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x0012AF9C File Offset: 0x0012919C
		[Token(Token = "0x600387E")]
		[Address(RVA = "0x774350", Offset = "0x772950", VA = "0x180774350")]
		public int DamageWhenLose(int round)
		{
			int num = round - 1;
			if (num > 7)
			{
				if (num <= 5)
				{
					return 10;
				}
				if (num <= 5)
				{
					return 15;
				}
			}
			return 5;
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x0012AFC0 File Offset: 0x001291C0
		[Token(Token = "0x600387F")]
		[Address(RVA = "0x774840", Offset = "0x772E40", VA = "0x180774840")]
		public int RoundTime(int round)
		{
			Dictionary<int, ValueTuple<RoundType, string>> dictionary = this.rounds;
			int num = 0;
			if (dictionary.TryGetValue(round, num))
			{
				return 1000000;
			}
			int num2 = round - 1;
			if (num2 > 7)
			{
				if (num2 <= 5)
				{
					return 300;
				}
				if (num2 <= 5)
				{
					return 240;
				}
			}
			return 360;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0012B010 File Offset: 0x00129210
		[Token(Token = "0x6003880")]
		[Address(RVA = "0x774180", Offset = "0x772780", VA = "0x180774180")]
		private void Awake()
		{
			RoundManager.<Instance>k__BackingField = this;
			this.currentRound = (int)((ulong)1L);
			this.isGameOver = false;
			if (this.currentPhase != RoundPhase.Preparation)
			{
				this.currentPhase = (RoundPhase)((ulong)0L);
				this.StartRound();
				return;
			}
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0012B04C File Offset: 0x0012924C
		[Token(Token = "0x6003881")]
		[Address(RVA = "0x774C30", Offset = "0x773230", VA = "0x180774C30")]
		private void Update()
		{
			if (!this.isGameOver && this.currentPhase == RoundPhase.Battle)
			{
				Board instance = Board.Instance;
				Board.Instance.boardTag.disableSummonZombie = true;
				Board instance2 = Board.Instance;
				if (this.currentPhase != RoundPhase.Settlement)
				{
					this.currentPhase = (RoundPhase)((ulong)2L);
					this.ProcessBattleResult(true);
					return;
				}
			}
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x0012B0A8 File Offset: 0x001292A8
		[Token(Token = "0x6003882")]
		[Address(RVA = "0x774410", Offset = "0x772A10", VA = "0x180774410")]
		private void InitializeGame()
		{
			this.currentRound = (int)((ulong)1L);
			this.isGameOver = false;
			if (this.currentPhase != RoundPhase.Preparation)
			{
				this.currentPhase = (RoundPhase)((ulong)0L);
				this.StartRound();
				return;
			}
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x0012B0E0 File Offset: 0x001292E0
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x774900", Offset = "0x772F00", VA = "0x180774900")]
		private void StartRound()
		{
			int num2;
			for (;;)
			{
				if (this.currentRound != 1)
				{
					EconomyManager economyManager = EconomyManager.<Instance>k__BackingField;
				}
				EconomyManager.<Instance>k__BackingField.OnRoundStart(true);
				int num = this.currentRound;
				num2 = 0;
				if (num == 9)
				{
					Board instance = Board.Instance;
					if (num2 >= instance.columnNum)
					{
						break;
					}
					CreatePlant instance2 = CreatePlant.Instance;
					num2++;
					if (Board.Instance != (ulong)15L)
					{
						break;
					}
					Board instance3 = Board.Instance;
					if (num2 >= instance3.columnNum)
					{
						break;
					}
					CreatePlant instance4 = CreatePlant.Instance;
					num2++;
					if (Board.Instance == 0)
					{
						break;
					}
				}
			}
			ShopManager shopManager = ShopManager.<Instance>k__BackingField;
			InGameUI.Instance.SeedBank.SetActive(true);
			shopManager.rerollCountThisRound = num2;
			if ((shopManager.isShopLocked ? 1 : 0) == num2)
			{
				int num3 = 0;
				shopManager.RefreshShopInternal(num3 != 0);
			}
			Debug.Log("[ShopManager] 新回合开始，刷新次数已重置");
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x0012B1AC File Offset: 0x001293AC
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x774230", Offset = "0x772830", VA = "0x180774230")]
		public void ChangeStatus(RoundPhase roundPhase, bool win = false)
		{
			if (this.currentPhase != roundPhase)
			{
				this.currentPhase = roundPhase;
				if (roundPhase != RoundPhase.Preparation)
				{
					if (roundPhase == RoundPhase.Preparation)
					{
						GameObject seedBank = InGameUI.Instance.SeedBank;
						int num = 0;
						seedBank.SetActive(num != 0);
						Board.Instance.boardTag.disableSummonZombie = false;
						Board.Instance.timeUntilNextWave = 0.01f;
						return;
					}
					if (roundPhase == RoundPhase.Battle)
					{
						this.ProcessBattleResult(win);
						return;
					}
				}
				else
				{
					this.StartRound();
				}
			}
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x0012B220 File Offset: 0x00129420
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x774470", Offset = "0x772A70", VA = "0x180774470")]
		private void ProcessBattleResult(bool win)
		{
			Dictionary<int, ValueTuple<RoundType, string>> dictionary = this.rounds;
			int num = this.currentRound;
			int num2 = Enumerable.Max(dictionary.Keys);
			if (num < num2)
			{
				if (!win)
				{
					this.lastRoundWon = win;
					EconomyManager economyManager = EconomyManager.<Instance>k__BackingField;
					if (this.currentRound <= 8 || typeof(EconomyManager).TypeHandle <= (ulong)5L || typeof(EconomyManager).TypeHandle <= (ulong)5L)
					{
					}
					int num3 = economyManager.currentHealth;
					uint num4;
					num3 -= (int)num4;
					Action<int, int> onHealthChanged = economyManager.OnHealthChanged;
					economyManager.currentHealth = num3;
					if (onHealthChanged != 0)
					{
					}
					int currentHealth = economyManager.currentHealth;
					int num5;
					int num6;
					Debug.Log(string.Format("[EconomyManager] 受到伤害: -{0}, 当前血量: {1}/{2}", num5, num5, num6));
					if (economyManager.OnGameOver != 0)
					{
					}
					Debug.Log("[EconomyManager] 游戏结束 - 血量归零");
				}
				this.lastRoundWon = true;
				EconomyManager economyManager2 = EconomyManager.<Instance>k__BackingField;
				int num7 = economyManager2.winStreak;
				num7++;
				economyManager2.winStreak = num7;
				Debug.Log(string.Format("[EconomyManager] 战斗胜利! 连胜: {0}", num7));
				Debug.Log("[RoundManager] 战斗胜利！获得胜利奖励");
				int num8 = 0;
				int num9 = 0;
				this.ChangeStatus((RoundPhase)num9, num8 != 0);
				return;
			}
			this.isGameOver = true;
			Board.Instance.boardVicotry.Win();
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x0012B344 File Offset: 0x00129544
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x774380", Offset = "0x772980", VA = "0x180774380")]
		private void GameOver(bool victory)
		{
			this.isGameOver = true;
			if (!victory)
			{
				UIMgr.EnterLoseMenu("游戏失败");
				return;
			}
			Board.Instance.boardVicotry.Win();
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x0012B37C File Offset: 0x0012957C
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x774D60", Offset = "0x773360", VA = "0x180774D60")]
		public RoundManager()
		{
			Dictionary<int, ValueTuple<RoundType, string>> dictionary = new Dictionary();
			int num = 0;
			dictionary[1] = num;
			int num2 = 0;
			dictionary[2] = num2;
			int num3 = 0;
			dictionary[3] = num3;
			int num4 = 0;
			dictionary[4] = num4;
			int num5 = 0;
			dictionary[5] = num5;
			int num6 = 0;
			dictionary[6] = num6;
			int num7 = 0;
			dictionary[7] = num7;
			int num8 = 0;
			dictionary[8] = num8;
			int num9 = 0;
			dictionary[9] = num9;
			int num10 = 0;
			dictionary[10] = num10;
			int num11 = 0;
			dictionary[11] = num11;
			int num12 = 0;
			dictionary[12] = num12;
			int num13 = 0;
			dictionary[13] = num13;
			int num14 = 0;
			dictionary[14] = num14;
			int num15 = 0;
			dictionary[15] = num15;
			int num16 = 0;
			dictionary[16] = num16;
			int num17 = 0;
			dictionary[17] = num17;
			int num18 = 0;
			dictionary[18] = num18;
			int num19 = 0;
			dictionary[19] = num19;
			int num20 = 0;
			dictionary[20] = num20;
			this.rounds = dictionary;
			base..ctor();
		}

		// Token: 0x04002A77 RID: 10871
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A77")]
		[TupleElementNames(new string[] { "type", "name" })]
		public Dictionary<int, ValueTuple<RoundType, string>> rounds;

		// Token: 0x04002A78 RID: 10872
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A78")]
		public int currentRound;

		// Token: 0x04002A79 RID: 10873
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002A79")]
		public RoundPhase currentPhase;

		// Token: 0x04002A7A RID: 10874
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002A7A")]
		public bool isGameOver;

		// Token: 0x04002A7B RID: 10875
		[FieldOffset(Offset = "0x31")]
		[Token(Token = "0x4002A7B")]
		public bool lastRoundWon;
	}
}
