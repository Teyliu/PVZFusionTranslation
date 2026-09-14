using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace AutoChess
{
	// Token: 0x02000AED RID: 2797
	[Token(Token = "0x2000AED")]
	public class EconomyManager : MonoBehaviour
	{
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x0012F7D0 File Offset: 0x0012D9D0
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x0012F7E4 File Offset: 0x0012D9E4
		[Token(Token = "0x170003C8")]
		public static EconomyManager Instance
		{
			[Token(Token = "0x6003992")]
			[Address(RVA = "0x7D0F80", Offset = "0x7CF580", VA = "0x1807D0F80")]
			get;
			[Token(Token = "0x6003993")]
			[Address(RVA = "0x7D1490", Offset = "0x7CFA90", VA = "0x1807D1490")]
			private set;
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x0012F7F8 File Offset: 0x0012D9F8
		[Token(Token = "0x170003C9")]
		public int CurrentGold
		{
			[Token(Token = "0x6003994")]
			[Address(RVA = "0x7D0EB0", Offset = "0x7CF4B0", VA = "0x1807D0EB0")]
			get
			{
				return Board.Instance.theSun;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x0012F818 File Offset: 0x0012DA18
		[Token(Token = "0x170003CA")]
		public int CurrentLevel
		{
			[Token(Token = "0x6003995")]
			[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
			get
			{
				return this.currentLevel;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06003996 RID: 14742 RVA: 0x0012F82C File Offset: 0x0012DA2C
		[Token(Token = "0x170003CB")]
		public int CurrentExp
		{
			[Token(Token = "0x6003996")]
			[Address(RVA = "0x590AF0", Offset = "0x58F0F0", VA = "0x180590AF0")]
			get
			{
				return this.currentExp;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x0012F840 File Offset: 0x0012DA40
		[Token(Token = "0x170003CC")]
		public int CurrentHealth
		{
			[Token(Token = "0x6003997")]
			[Address(RVA = "0x590B00", Offset = "0x58F100", VA = "0x180590B00")]
			get
			{
				return this.currentHealth;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x0012F854 File Offset: 0x0012DA54
		[Token(Token = "0x170003CD")]
		public int WinStreak
		{
			[Token(Token = "0x6003998")]
			[Address(RVA = "0x4F65C0", Offset = "0x4F4BC0", VA = "0x1804F65C0")]
			get
			{
				return this.winStreak;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x0012F868 File Offset: 0x0012DA68
		[Token(Token = "0x170003CE")]
		public int CurrentRound
		{
			[Token(Token = "0x6003999")]
			[Address(RVA = "0x515930", Offset = "0x513F30", VA = "0x180515930")]
			get
			{
				return this.currentRound;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x0012F87C File Offset: 0x0012DA7C
		[Token(Token = "0x170003CF")]
		public int RefreshCost
		{
			[Token(Token = "0x600399A")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x0012F88C File Offset: 0x0012DA8C
		[Token(Token = "0x170003D0")]
		public int ExpCost
		{
			[Token(Token = "0x600399B")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250")]
			get
			{
				return 4;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x0012F89C File Offset: 0x0012DA9C
		[Token(Token = "0x170003D1")]
		public int ExpToNextLevel
		{
			[Token(Token = "0x600399C")]
			[Address(RVA = "0x7D0F00", Offset = "0x7CF500", VA = "0x1807D0F00")]
			get
			{
				if (this.currentLevel < 10)
				{
					return 0;
				}
				return 0;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x0012F8B8 File Offset: 0x0012DAB8
		[Token(Token = "0x170003D2")]
		public int MaxPlantCount
		{
			[Token(Token = "0x600399D")]
			[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
			get
			{
				return this.currentLevel;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600399E RID: 14750 RVA: 0x0012F8CC File Offset: 0x0012DACC
		// (remove) Token: 0x0600399F RID: 14751 RVA: 0x0012F8FC File Offset: 0x0012DAFC
		[Token(Token = "0x14000007")]
		public event Action<int> OnGoldChanged
		{
			[Token(Token = "0x600399E")]
			[Address(RVA = "0x7D0B40", Offset = "0x7CF140", VA = "0x1807D0B40")]
			[CompilerGenerated]
			add
			{
				Action<int> onGoldChanged = this.OnGoldChanged;
				Delegate @delegate = Delegate.Combine(onGoldChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onGoldChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x600399F")]
			[Address(RVA = "0x7D1120", Offset = "0x7CF720", VA = "0x1807D1120")]
			[CompilerGenerated]
			remove
			{
				Action<int> onGoldChanged = this.OnGoldChanged;
				Delegate @delegate = Delegate.Remove(onGoldChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onGoldChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060039A0 RID: 14752 RVA: 0x0012F92C File Offset: 0x0012DB2C
		// (remove) Token: 0x060039A1 RID: 14753 RVA: 0x0012F95C File Offset: 0x0012DB5C
		[Token(Token = "0x14000008")]
		public event Action<int> OnIncomeReceived
		{
			[Token(Token = "0x60039A0")]
			[Address(RVA = "0x7D0CA0", Offset = "0x7CF2A0", VA = "0x1807D0CA0")]
			[CompilerGenerated]
			add
			{
				Action<int> onIncomeReceived = this.OnIncomeReceived;
				Delegate @delegate = Delegate.Combine(onIncomeReceived, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onIncomeReceived)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60039A1")]
			[Address(RVA = "0x7D1280", Offset = "0x7CF880", VA = "0x1807D1280")]
			[CompilerGenerated]
			remove
			{
				Action<int> onIncomeReceived = this.OnIncomeReceived;
				Delegate @delegate = Delegate.Remove(onIncomeReceived, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onIncomeReceived)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060039A2 RID: 14754 RVA: 0x0012F98C File Offset: 0x0012DB8C
		// (remove) Token: 0x060039A3 RID: 14755 RVA: 0x0012F9BC File Offset: 0x0012DBBC
		[Token(Token = "0x14000009")]
		public event Action<int> OnLevelChanged
		{
			[Token(Token = "0x60039A2")]
			[Address(RVA = "0x7D0D50", Offset = "0x7CF350", VA = "0x1807D0D50")]
			[CompilerGenerated]
			add
			{
				Action<int> onLevelChanged = this.OnLevelChanged;
				Delegate @delegate = Delegate.Combine(onLevelChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLevelChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60039A3")]
			[Address(RVA = "0x7D1330", Offset = "0x7CF930", VA = "0x1807D1330")]
			[CompilerGenerated]
			remove
			{
				Action<int> onLevelChanged = this.OnLevelChanged;
				Delegate @delegate = Delegate.Remove(onLevelChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLevelChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060039A4 RID: 14756 RVA: 0x0012F9EC File Offset: 0x0012DBEC
		// (remove) Token: 0x060039A5 RID: 14757 RVA: 0x0012FA1C File Offset: 0x0012DC1C
		[Token(Token = "0x1400000A")]
		public event Action<int, int> OnExpChanged
		{
			[Token(Token = "0x60039A4")]
			[Address(RVA = "0x7D09E0", Offset = "0x7CEFE0", VA = "0x1807D09E0")]
			[CompilerGenerated]
			add
			{
				Action<int, int> onExpChanged = this.OnExpChanged;
				Delegate @delegate = Delegate.Combine(onExpChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onExpChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60039A5")]
			[Address(RVA = "0x7D0FC0", Offset = "0x7CF5C0", VA = "0x1807D0FC0")]
			[CompilerGenerated]
			remove
			{
				Action<int, int> onExpChanged = this.OnExpChanged;
				Delegate @delegate = Delegate.Remove(onExpChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onExpChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060039A6 RID: 14758 RVA: 0x0012FA4C File Offset: 0x0012DC4C
		// (remove) Token: 0x060039A7 RID: 14759 RVA: 0x0012FA7C File Offset: 0x0012DC7C
		[Token(Token = "0x1400000B")]
		public event Action<int, int> OnHealthChanged
		{
			[Token(Token = "0x60039A6")]
			[Address(RVA = "0x7D0BF0", Offset = "0x7CF1F0", VA = "0x1807D0BF0")]
			[CompilerGenerated]
			add
			{
				Action<int, int> onHealthChanged = this.OnHealthChanged;
				Delegate @delegate = Delegate.Combine(onHealthChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onHealthChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60039A7")]
			[Address(RVA = "0x7D11D0", Offset = "0x7CF7D0", VA = "0x1807D11D0")]
			[CompilerGenerated]
			remove
			{
				Action<int, int> onHealthChanged = this.OnHealthChanged;
				Delegate @delegate = Delegate.Remove(onHealthChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onHealthChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060039A8 RID: 14760 RVA: 0x0012FAAC File Offset: 0x0012DCAC
		// (remove) Token: 0x060039A9 RID: 14761 RVA: 0x0012FADC File Offset: 0x0012DCDC
		[Token(Token = "0x1400000C")]
		public event Action<int> OnRoundChanged
		{
			[Token(Token = "0x60039A8")]
			[Address(RVA = "0x7D0E00", Offset = "0x7CF400", VA = "0x1807D0E00")]
			[CompilerGenerated]
			add
			{
				Action<int> onRoundChanged = this.OnRoundChanged;
				Delegate @delegate = Delegate.Combine(onRoundChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onRoundChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60039A9")]
			[Address(RVA = "0x7D13E0", Offset = "0x7CF9E0", VA = "0x1807D13E0")]
			[CompilerGenerated]
			remove
			{
				Action<int> onRoundChanged = this.OnRoundChanged;
				Delegate @delegate = Delegate.Remove(onRoundChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onRoundChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060039AA RID: 14762 RVA: 0x0012FB0C File Offset: 0x0012DD0C
		// (remove) Token: 0x060039AB RID: 14763 RVA: 0x0012FB3C File Offset: 0x0012DD3C
		[Token(Token = "0x1400000D")]
		public event Action<bool> OnGameOver
		{
			[Token(Token = "0x60039AA")]
			[Address(RVA = "0x7D0A90", Offset = "0x7CF090", VA = "0x1807D0A90")]
			[CompilerGenerated]
			add
			{
				Action<bool> onGameOver = this.OnGameOver;
				Delegate @delegate = Delegate.Combine(onGameOver, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onGameOver)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60039AB")]
			[Address(RVA = "0x7D1070", Offset = "0x7CF670", VA = "0x1807D1070")]
			[CompilerGenerated]
			remove
			{
				Action<bool> onGameOver = this.OnGameOver;
				Delegate @delegate = Delegate.Remove(onGameOver, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onGameOver)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x0012FB6C File Offset: 0x0012DD6C
		[Token(Token = "0x60039AC")]
		[Address(RVA = "0x7CF610", Offset = "0x7CDC10", VA = "0x1807CF610")]
		private void Awake()
		{
			EconomyManager.<Instance>k__BackingField = this;
			this.InitializeGameData();
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x0012FB88 File Offset: 0x0012DD88
		[Token(Token = "0x60039AD")]
		[Address(RVA = "0x7CFE00", Offset = "0x7CE400", VA = "0x1807CFE00")]
		private void InitializeGameData()
		{
			Board instance = Board.Instance;
			instance.theSun = (int)((ulong)3L);
			Action<int> onGoldChanged = this.OnGoldChanged;
			this.currentLevel = (int)((ulong)3L);
			this.currentHealth = (int)((ulong)100L);
			this.currentRound = (int)((ulong)1L);
			if (onGoldChanged != 0)
			{
				Board instance2 = Board.Instance;
			}
			if (this.OnLevelChanged != 0)
			{
			}
			if (this.OnExpChanged == 0 || this.currentLevel >= 10 || instance <= (ulong)6L)
			{
			}
			if (this.OnHealthChanged != 0)
			{
			}
			if (this.OnRoundChanged != 0)
			{
			}
			int theSun = Board.Instance.theSun;
			int num = this.currentLevel;
			int num2 = this.currentHealth;
			Debug.Log(string.Format("[EconomyManager] 游戏初始化完成 - 金币:{0} 等级:{1} 血量:{2}", theSun, theSun, theSun));
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x0012FC3C File Offset: 0x0012DE3C
		[Token(Token = "0x60039AE")]
		[Address(RVA = "0x7D0440", Offset = "0x7CEA40", VA = "0x1807D0440")]
		public void ResetGameData()
		{
			this.InitializeGameData();
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x0012FC50 File Offset: 0x0012DE50
		[Token(Token = "0x60039AF")]
		[Address(RVA = "0x7D0510", Offset = "0x7CEB10", VA = "0x1807D0510")]
		public bool SpendGold(int amount)
		{
			if (amount > 0)
			{
				if (Board.Instance.theSun < amount)
				{
					GameAPP.PlaySound(26, 0.5f, 1f);
					int theSun = Board.Instance.theSun;
				}
				if (this.OnGoldChanged != 0)
				{
					Board instance = Board.Instance;
				}
				int theSun2 = Board.Instance.theSun;
				string text;
				Debug.Log(text);
				return true;
			}
			Debug.LogWarning(string.Format("[EconomyManager] 花费金额必须大于0: {0}", "[EconomyManager] 花费金币: -{0}, 剩余: {1}"));
			throw new NullReferenceException();
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x0012FCCC File Offset: 0x0012DECC
		[Token(Token = "0x60039B0")]
		[Address(RVA = "0x7CF900", Offset = "0x7CDF00", VA = "0x1807CF900")]
		public void EarnGold(int amount)
		{
			if (amount > 0)
			{
				int theSun = Board.Instance.theSun;
				int num = Board.Instance.theSun;
				Action<int> onGoldChanged = this.OnGoldChanged;
				num -= theSun;
				if (onGoldChanged != 0)
				{
					ulong num2;
					if (num2 == (ulong)0L)
					{
					}
					Board instance = Board.Instance;
				}
				int theSun2 = Board.Instance.theSun;
				string text;
				Debug.Log(text);
				return;
			}
			Debug.LogWarning(string.Format("[EconomyManager] 获得金额必须大于0: {0}", "[EconomyManager] 金币达到上限! 实际获得: {0}/{1}"));
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0012FD54 File Offset: 0x0012DF54
		[Token(Token = "0x60039B1")]
		[Address(RVA = "0x7D0450", Offset = "0x7CEA50", VA = "0x1807D0450")]
		public void SellPlant(int plantCost)
		{
			if (plantCost > 0)
			{
				this.EarnGold(plantCost);
				return;
			}
			Debug.LogWarning(string.Format("[EconomyManager] 植物费用必须大于0: {0}", "[EconomyManager] 植物费用必须大于0: {0}"));
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0012FD84 File Offset: 0x0012DF84
		[Token(Token = "0x60039B2")]
		[Address(RVA = "0x7CF7F0", Offset = "0x7CDDF0", VA = "0x1807CF7F0")]
		public int CalculateIncome(bool isWin)
		{
			if (Board.Instance.theSun < 40)
			{
				ulong num;
				num += num;
			}
			int num3;
			if (isWin && this.winStreak > 0)
			{
				uint num2;
				if (this.winStreak < (int)num2)
				{
					num3 = this.winStreak;
				}
			}
			return num3;
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0012FDCC File Offset: 0x0012DFCC
		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x7CF890", Offset = "0x7CDE90", VA = "0x1807CF890")]
		private int CalculateInterest()
		{
			if (Board.Instance.theSun < 40)
			{
				ulong num;
				num += num;
			}
			throw new NullReferenceException();
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x0012FDF4 File Offset: 0x0012DFF4
		[Token(Token = "0x60039B4")]
		[Address(RVA = "0x7D0340", Offset = "0x7CE940", VA = "0x1807D0340")]
		public void OnRoundStart(bool isWin)
		{
			if (Board.Instance.theSun < 40)
			{
				ulong num;
				num += num;
			}
			int num3;
			if (isWin && this.winStreak > 0)
			{
				uint num2;
				if (this.winStreak < (int)num2)
				{
					num3 = this.winStreak;
				}
			}
			this.EarnGold(num3);
			if (this.OnIncomeReceived != 0)
			{
			}
			int num4 = this.currentRound;
			Action<int> onRoundChanged = this.OnRoundChanged;
			num4++;
			this.currentRound = num4;
			if (onRoundChanged != 0)
			{
			}
			uint num5;
			this.AddExp((int)num5);
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0012FE74 File Offset: 0x0012E074
		[Token(Token = "0x60039B5")]
		[Address(RVA = "0x7CFBE0", Offset = "0x7CE1E0", VA = "0x1807CFBE0")]
		private int GetRequiredExp(int level)
		{
			if (level < 10)
			{
				return 0;
			}
			return 0;
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x0012FE8C File Offset: 0x0012E08C
		[Token(Token = "0x60039B6")]
		[Address(RVA = "0x7CF360", Offset = "0x7CD960", VA = "0x1807CF360")]
		public void AddExp(int amount)
		{
			while (amount > 0)
			{
				if (this.currentLevel < 10)
				{
					int num = this.currentExp;
					num += amount;
					Action<int, int> onExpChanged = this.OnExpChanged;
					this.currentExp = num;
					if (onExpChanged != 0)
					{
						int expToNextLevel = this.ExpToNextLevel;
					}
					if (this.currentLevel >= 10 || "[EconomyManager] 已达到最高等级: {0}" <= (ulong)6L)
					{
					}
					if (this.currentLevel >= 10)
					{
						return;
					}
					uint num2;
					if (num2 <= (uint)6)
					{
					}
					if (this.OnLevelChanged != 0)
					{
					}
					if (this.OnExpChanged == 0)
					{
						continue;
					}
					int expToNextLevel2 = this.ExpToNextLevel;
				}
				int num3;
				Debug.Log(string.Format("[EconomyManager] 已达到最高等级: {0}", num3));
				return;
			}
			Debug.LogWarning(string.Format("[EconomyManager] 经验值必须大于0: {0}", "[EconomyManager] 已达到最高等级: {0}"));
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0012FF34 File Offset: 0x0012E134
		[Token(Token = "0x60039B7")]
		[Address(RVA = "0x7CF670", Offset = "0x7CDC70", VA = "0x1807CF670")]
		public bool BuyExp()
		{
			bool flag = this.SpendGold(4);
			if (!flag)
			{
				return flag;
			}
			this.AddExp(4);
			return true;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0012FF58 File Offset: 0x0012E158
		[Token(Token = "0x60039B8")]
		[Address(RVA = "0x7CFC60", Offset = "0x7CE260", VA = "0x1807CFC60")]
		public int GetUpgradeCost()
		{
			if (this.currentLevel < 10)
			{
				return this.currentLevel;
			}
			return 999;
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0012FF7C File Offset: 0x0012E17C
		[Token(Token = "0x60039B9")]
		[Address(RVA = "0x7CF6B0", Offset = "0x7CDCB0", VA = "0x1807CF6B0")]
		public bool BuyLevelUp()
		{
			if (this.currentLevel >= 10)
			{
				int num;
				Debug.LogWarning(string.Format("[EconomyManager] 已达到最高等级: {0}", num));
				return false;
			}
			bool flag;
			if (!flag)
			{
				return flag;
			}
			int expToNextLevel = this.ExpToNextLevel;
			this.AddExp(expToNextLevel);
			Debug.Log(string.Format("[EconomyManager] 购买升级: -{0}金币", expToNextLevel));
			return true;
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x0012FFD0 File Offset: 0x0012E1D0
		[Token(Token = "0x60039BA")]
		[Address(RVA = "0x7D0810", Offset = "0x7CEE10", VA = "0x1807D0810")]
		public void TakeDamage(int damage)
		{
			if (damage > 0)
			{
				int num = this.currentHealth;
				num -= damage;
				Action<int, int> onHealthChanged = this.OnHealthChanged;
				this.currentHealth = num;
				if (onHealthChanged != 0)
				{
				}
				int num2 = this.currentHealth;
				int num3;
				Debug.Log(string.Format("[EconomyManager] 受到伤害: -{0}, 当前血量: {1}/{2}", num, damage, num3));
				if (this.OnGameOver != 0)
				{
				}
				Debug.Log("[EconomyManager] 游戏结束 - 血量归零");
				return;
			}
			Debug.LogWarning(string.Format("[EconomyManager] 伤害值必须大于0: {0}", "[EconomyManager] 游戏结束 - 血量归零"));
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x00130044 File Offset: 0x0012E244
		[Token(Token = "0x60039BB")]
		[Address(RVA = "0x7CFC80", Offset = "0x7CE280", VA = "0x1807CFC80")]
		public void Heal(int amount)
		{
			if (amount > 0)
			{
				int num = this.currentHealth;
				Action<int, int> onHealthChanged = this.OnHealthChanged;
				this.currentHealth = "[EconomyManager] 治疗量必须大于0: {0}";
				if (onHealthChanged != 0)
				{
				}
				int num2 = this.currentHealth;
				int num3;
				Debug.Log(string.Format("[EconomyManager] 治疗血量: +{0}, 当前: {1}/{2}", "[EconomyManager] 治疗量必须大于0: {0}", "[EconomyManager] 治疗量必须大于0: {0}", num3));
				return;
			}
			Debug.LogWarning(string.Format("[EconomyManager] 治疗量必须大于0: {0}", "[EconomyManager] 治疗量必须大于0: {0}"));
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x001300AC File Offset: 0x0012E2AC
		[Token(Token = "0x60039BC")]
		[Address(RVA = "0x7D00C0", Offset = "0x7CE6C0", VA = "0x1807D00C0")]
		public void OnBattleLose(int damage)
		{
			if (damage > 0)
			{
				int num = this.currentHealth;
				num -= damage;
				Action<int, int> onHealthChanged = this.OnHealthChanged;
				this.currentHealth = num;
				if (onHealthChanged != 0)
				{
				}
				int num2 = this.currentHealth;
				int num3;
				Debug.Log(string.Format("[EconomyManager] 受到伤害: -{0}, 当前血量: {1}/{2}", num, damage, num3));
				if (this.OnGameOver != 0)
				{
				}
				Debug.Log("[EconomyManager] 游戏结束 - 血量归零");
				this.winStreak = (int)((ulong)0L);
				return;
			}
			Debug.LogWarning(string.Format("[EconomyManager] 伤害值必须大于0: {0}", "[EconomyManager] 游戏结束 - 血量归零"));
			this.winStreak = (int)((ulong)0L);
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x00130130 File Offset: 0x0012E330
		[Token(Token = "0x60039BD")]
		[Address(RVA = "0x7D02A0", Offset = "0x7CE8A0", VA = "0x1807D02A0")]
		public void OnBattleWin()
		{
			int num = this.winStreak;
			num++;
			this.winStreak = num;
			Debug.Log(string.Format("[EconomyManager] 战斗胜利! 连胜: {0}", num));
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x00130160 File Offset: 0x0012E360
		[Token(Token = "0x60039BE")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public EconomyManager()
		{
		}

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		private const int initialGold = 3;

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		private const int baseIncome = 5;

		// Token: 0x04002BCA RID: 11210
		[Token(Token = "0x4002BCA")]
		private const int winReward = 1;

		// Token: 0x04002BCB RID: 11211
		[Token(Token = "0x4002BCB")]
		private const int refreshCost = 2;

		// Token: 0x04002BCC RID: 11212
		[Token(Token = "0x4002BCC")]
		private const int expCost = 4;

		// Token: 0x04002BCD RID: 11213
		[Token(Token = "0x4002BCD")]
		private const int maxInterest = 4;

		// Token: 0x04002BCE RID: 11214
		[Token(Token = "0x4002BCE")]
		private const int initialLevel = 3;

		// Token: 0x04002BCF RID: 11215
		[Token(Token = "0x4002BCF")]
		private const int initialExp = 0;

		// Token: 0x04002BD0 RID: 11216
		[Token(Token = "0x4002BD0")]
		public const int maxLevel = 10;

		// Token: 0x04002BD1 RID: 11217
		[Token(Token = "0x4002BD1")]
		private const int initialHealth = 100;

		// Token: 0x04002BD2 RID: 11218
		[Token(Token = "0x4002BD2")]
		private const int maxHealth = 100;

		// Token: 0x04002BD3 RID: 11219
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BD3")]
		private int currentLevel;

		// Token: 0x04002BD4 RID: 11220
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002BD4")]
		private int currentExp;

		// Token: 0x04002BD5 RID: 11221
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002BD5")]
		private int currentHealth;

		// Token: 0x04002BD6 RID: 11222
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002BD6")]
		private int winStreak;

		// Token: 0x04002BD7 RID: 11223
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002BD7")]
		private int currentRound;
	}
}
