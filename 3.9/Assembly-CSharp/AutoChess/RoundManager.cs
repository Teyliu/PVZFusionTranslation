using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace AutoChess
{
	// Token: 0x02000AF0 RID: 2800
	[Token(Token = "0x2000AF0")]
	public class RoundManager : MonoBehaviour
	{
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060039BF RID: 14783 RVA: 0x00130174 File Offset: 0x0012E374
		// (set) Token: 0x060039C0 RID: 14784 RVA: 0x00130188 File Offset: 0x0012E388
		[Token(Token = "0x170003D3")]
		public static RoundManager Instance
		{
			[Token(Token = "0x60039BF")]
			[Address(RVA = "0x7DC330", Offset = "0x7DA930", VA = "0x1807DC330")]
			get;
			[Token(Token = "0x60039C0")]
			[Address(RVA = "0x7DC370", Offset = "0x7DA970", VA = "0x1807DC370")]
			private set;
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x0013019C File Offset: 0x0012E39C
		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x7DB6A0", Offset = "0x7D9CA0", VA = "0x1807DB6A0")]
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

		// Token: 0x060039C2 RID: 14786 RVA: 0x001301C0 File Offset: 0x0012E3C0
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x7DB1E0", Offset = "0x7D97E0", VA = "0x1807DB1E0")]
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

		// Token: 0x060039C3 RID: 14787 RVA: 0x001301E4 File Offset: 0x0012E3E4
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x7DB6D0", Offset = "0x7D9CD0", VA = "0x1807DB6D0")]
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

		// Token: 0x060039C4 RID: 14788 RVA: 0x00130234 File Offset: 0x0012E434
		[Token(Token = "0x60039C4")]
		[Address(RVA = "0x7DB010", Offset = "0x7D9610", VA = "0x1807DB010")]
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

		// Token: 0x060039C5 RID: 14789 RVA: 0x00130270 File Offset: 0x0012E470
		[Token(Token = "0x60039C5")]
		[Address(RVA = "0x7DBAC0", Offset = "0x7DA0C0", VA = "0x1807DBAC0")]
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

		// Token: 0x060039C6 RID: 14790 RVA: 0x001302CC File Offset: 0x0012E4CC
		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x7DB2A0", Offset = "0x7D98A0", VA = "0x1807DB2A0")]
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

		// Token: 0x060039C7 RID: 14791 RVA: 0x00130304 File Offset: 0x0012E504
		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x7DB790", Offset = "0x7D9D90", VA = "0x1807DB790")]
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

		// Token: 0x060039C8 RID: 14792 RVA: 0x001303D0 File Offset: 0x0012E5D0
		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x7DB0C0", Offset = "0x7D96C0", VA = "0x1807DB0C0")]
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

		// Token: 0x060039C9 RID: 14793 RVA: 0x00130444 File Offset: 0x0012E644
		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x7DB300", Offset = "0x7D9900", VA = "0x1807DB300")]
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

		// Token: 0x060039CA RID: 14794 RVA: 0x00130568 File Offset: 0x0012E768
		[Token(Token = "0x60039CA")]
		[Address(RVA = "0x7DB210", Offset = "0x7D9810", VA = "0x1807DB210")]
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

		// Token: 0x060039CB RID: 14795 RVA: 0x001305A0 File Offset: 0x0012E7A0
		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x7DBBF0", Offset = "0x7DA1F0", VA = "0x1807DBBF0")]
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

		// Token: 0x04002BEA RID: 11242
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BEA")]
		[TupleElementNames(new string[] { "type", "name" })]
		public Dictionary<int, ValueTuple<RoundType, string>> rounds;

		// Token: 0x04002BEB RID: 11243
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002BEB")]
		public int currentRound;

		// Token: 0x04002BEC RID: 11244
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002BEC")]
		public RoundPhase currentPhase;

		// Token: 0x04002BED RID: 11245
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002BED")]
		public bool isGameOver;

		// Token: 0x04002BEE RID: 11246
		[FieldOffset(Offset = "0x31")]
		[Token(Token = "0x4002BEE")]
		public bool lastRoundWon;
	}
}
