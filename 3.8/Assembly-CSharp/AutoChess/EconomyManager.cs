using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace AutoChess
{
	// Token: 0x02000AAD RID: 2733
	[Token(Token = "0x2000AAD")]
	public class EconomyManager : MonoBehaviour
	{
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600384E RID: 14414 RVA: 0x0012A5A0 File Offset: 0x001287A0
		// (set) Token: 0x0600384F RID: 14415 RVA: 0x0012A5B4 File Offset: 0x001287B4
		[Token(Token = "0x17000380")]
		public static EconomyManager Instance
		{
			[Token(Token = "0x600384E")]
			[Address(RVA = "0x76A140", Offset = "0x768740", VA = "0x18076A140")]
			get;
			[Token(Token = "0x600384F")]
			[Address(RVA = "0x76A650", Offset = "0x768C50", VA = "0x18076A650")]
			private set;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x0012A5C8 File Offset: 0x001287C8
		[Token(Token = "0x17000381")]
		public int CurrentGold
		{
			[Token(Token = "0x6003850")]
			[Address(RVA = "0x76A070", Offset = "0x768670", VA = "0x18076A070")]
			get
			{
				return Board.Instance.theSun;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x0012A5E8 File Offset: 0x001287E8
		[Token(Token = "0x17000382")]
		public int CurrentLevel
		{
			[Token(Token = "0x6003851")]
			[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
			get
			{
				return this.currentLevel;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x0012A5FC File Offset: 0x001287FC
		[Token(Token = "0x17000383")]
		public int CurrentExp
		{
			[Token(Token = "0x6003852")]
			[Address(RVA = "0x525960", Offset = "0x523F60", VA = "0x180525960")]
			get
			{
				return this.currentExp;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x0012A610 File Offset: 0x00128810
		[Token(Token = "0x17000384")]
		public int CurrentHealth
		{
			[Token(Token = "0x6003853")]
			[Address(RVA = "0x525970", Offset = "0x523F70", VA = "0x180525970")]
			get
			{
				return this.currentHealth;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x0012A624 File Offset: 0x00128824
		[Token(Token = "0x17000385")]
		public int WinStreak
		{
			[Token(Token = "0x6003854")]
			[Address(RVA = "0x4B6F00", Offset = "0x4B5500", VA = "0x1804B6F00")]
			get
			{
				return this.winStreak;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x0012A638 File Offset: 0x00128838
		[Token(Token = "0x17000386")]
		public int CurrentRound
		{
			[Token(Token = "0x6003855")]
			[Address(RVA = "0x4A9D00", Offset = "0x4A8300", VA = "0x1804A9D00")]
			get
			{
				return this.currentRound;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x0012A64C File Offset: 0x0012884C
		[Token(Token = "0x17000387")]
		public int RefreshCost
		{
			[Token(Token = "0x6003856")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0")]
			get
			{
				return 2;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06003857 RID: 14423 RVA: 0x0012A65C File Offset: 0x0012885C
		[Token(Token = "0x17000388")]
		public int ExpCost
		{
			[Token(Token = "0x6003857")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06003858 RID: 14424 RVA: 0x0012A66C File Offset: 0x0012886C
		[Token(Token = "0x17000389")]
		public int ExpToNextLevel
		{
			[Token(Token = "0x6003858")]
			[Address(RVA = "0x76A0C0", Offset = "0x7686C0", VA = "0x18076A0C0")]
			get
			{
				if (this.currentLevel < 10)
				{
					return 0;
				}
				return 0;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x0012A688 File Offset: 0x00128888
		[Token(Token = "0x1700038A")]
		public int MaxPlantCount
		{
			[Token(Token = "0x6003859")]
			[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
			get
			{
				return this.currentLevel;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600385A RID: 14426 RVA: 0x0012A69C File Offset: 0x0012889C
		// (remove) Token: 0x0600385B RID: 14427 RVA: 0x0012A6CC File Offset: 0x001288CC
		[Token(Token = "0x14000007")]
		public event Action<int> OnGoldChanged
		{
			[Token(Token = "0x600385A")]
			[Address(RVA = "0x769D00", Offset = "0x768300", VA = "0x180769D00")]
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
			[Token(Token = "0x600385B")]
			[Address(RVA = "0x76A2E0", Offset = "0x7688E0", VA = "0x18076A2E0")]
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
		// (add) Token: 0x0600385C RID: 14428 RVA: 0x0012A6FC File Offset: 0x001288FC
		// (remove) Token: 0x0600385D RID: 14429 RVA: 0x0012A72C File Offset: 0x0012892C
		[Token(Token = "0x14000008")]
		public event Action<int> OnIncomeReceived
		{
			[Token(Token = "0x600385C")]
			[Address(RVA = "0x769E60", Offset = "0x768460", VA = "0x180769E60")]
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
			[Token(Token = "0x600385D")]
			[Address(RVA = "0x76A440", Offset = "0x768A40", VA = "0x18076A440")]
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
		// (add) Token: 0x0600385E RID: 14430 RVA: 0x0012A75C File Offset: 0x0012895C
		// (remove) Token: 0x0600385F RID: 14431 RVA: 0x0012A78C File Offset: 0x0012898C
		[Token(Token = "0x14000009")]
		public event Action<int> OnLevelChanged
		{
			[Token(Token = "0x600385E")]
			[Address(RVA = "0x769F10", Offset = "0x768510", VA = "0x180769F10")]
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
			[Token(Token = "0x600385F")]
			[Address(RVA = "0x76A4F0", Offset = "0x768AF0", VA = "0x18076A4F0")]
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
		// (add) Token: 0x06003860 RID: 14432 RVA: 0x0012A7BC File Offset: 0x001289BC
		// (remove) Token: 0x06003861 RID: 14433 RVA: 0x0012A7EC File Offset: 0x001289EC
		[Token(Token = "0x1400000A")]
		public event Action<int, int> OnExpChanged
		{
			[Token(Token = "0x6003860")]
			[Address(RVA = "0x769BA0", Offset = "0x7681A0", VA = "0x180769BA0")]
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
			[Token(Token = "0x6003861")]
			[Address(RVA = "0x76A180", Offset = "0x768780", VA = "0x18076A180")]
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
		// (add) Token: 0x06003862 RID: 14434 RVA: 0x0012A81C File Offset: 0x00128A1C
		// (remove) Token: 0x06003863 RID: 14435 RVA: 0x0012A84C File Offset: 0x00128A4C
		[Token(Token = "0x1400000B")]
		public event Action<int, int> OnHealthChanged
		{
			[Token(Token = "0x6003862")]
			[Address(RVA = "0x769DB0", Offset = "0x7683B0", VA = "0x180769DB0")]
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
			[Token(Token = "0x6003863")]
			[Address(RVA = "0x76A390", Offset = "0x768990", VA = "0x18076A390")]
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
		// (add) Token: 0x06003864 RID: 14436 RVA: 0x0012A87C File Offset: 0x00128A7C
		// (remove) Token: 0x06003865 RID: 14437 RVA: 0x0012A8AC File Offset: 0x00128AAC
		[Token(Token = "0x1400000C")]
		public event Action<int> OnRoundChanged
		{
			[Token(Token = "0x6003864")]
			[Address(RVA = "0x769FC0", Offset = "0x7685C0", VA = "0x180769FC0")]
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
			[Token(Token = "0x6003865")]
			[Address(RVA = "0x76A5A0", Offset = "0x768BA0", VA = "0x18076A5A0")]
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
		// (add) Token: 0x06003866 RID: 14438 RVA: 0x0012A8DC File Offset: 0x00128ADC
		// (remove) Token: 0x06003867 RID: 14439 RVA: 0x0012A90C File Offset: 0x00128B0C
		[Token(Token = "0x1400000D")]
		public event Action<bool> OnGameOver
		{
			[Token(Token = "0x6003866")]
			[Address(RVA = "0x769C50", Offset = "0x768250", VA = "0x180769C50")]
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
			[Token(Token = "0x6003867")]
			[Address(RVA = "0x76A230", Offset = "0x768830", VA = "0x18076A230")]
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

		// Token: 0x06003868 RID: 14440 RVA: 0x0012A93C File Offset: 0x00128B3C
		[Token(Token = "0x6003868")]
		[Address(RVA = "0x7687D0", Offset = "0x766DD0", VA = "0x1807687D0")]
		private void Awake()
		{
			EconomyManager.<Instance>k__BackingField = this;
			this.InitializeGameData();
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x0012A958 File Offset: 0x00128B58
		[Token(Token = "0x6003869")]
		[Address(RVA = "0x768FC0", Offset = "0x7675C0", VA = "0x180768FC0")]
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

		// Token: 0x0600386A RID: 14442 RVA: 0x0012AA0C File Offset: 0x00128C0C
		[Token(Token = "0x600386A")]
		[Address(RVA = "0x769600", Offset = "0x767C00", VA = "0x180769600")]
		public void ResetGameData()
		{
			this.InitializeGameData();
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x0012AA20 File Offset: 0x00128C20
		[Token(Token = "0x600386B")]
		[Address(RVA = "0x7696D0", Offset = "0x767CD0", VA = "0x1807696D0")]
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

		// Token: 0x0600386C RID: 14444 RVA: 0x0012AA9C File Offset: 0x00128C9C
		[Token(Token = "0x600386C")]
		[Address(RVA = "0x768AC0", Offset = "0x7670C0", VA = "0x180768AC0")]
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

		// Token: 0x0600386D RID: 14445 RVA: 0x0012AB24 File Offset: 0x00128D24
		[Token(Token = "0x600386D")]
		[Address(RVA = "0x769610", Offset = "0x767C10", VA = "0x180769610")]
		public void SellPlant(int plantCost)
		{
			if (plantCost > 0)
			{
				this.EarnGold(plantCost);
				return;
			}
			Debug.LogWarning(string.Format("[EconomyManager] 植物费用必须大于0: {0}", "[EconomyManager] 植物费用必须大于0: {0}"));
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x0012AB54 File Offset: 0x00128D54
		[Token(Token = "0x600386E")]
		[Address(RVA = "0x7689B0", Offset = "0x766FB0", VA = "0x1807689B0")]
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

		// Token: 0x0600386F RID: 14447 RVA: 0x0012AB9C File Offset: 0x00128D9C
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x768A50", Offset = "0x767050", VA = "0x180768A50")]
		private int CalculateInterest()
		{
			if (Board.Instance.theSun < 40)
			{
				ulong num;
				num += num;
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x0012ABC4 File Offset: 0x00128DC4
		[Token(Token = "0x6003870")]
		[Address(RVA = "0x769500", Offset = "0x767B00", VA = "0x180769500")]
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

		// Token: 0x06003871 RID: 14449 RVA: 0x0012AC44 File Offset: 0x00128E44
		[Token(Token = "0x6003871")]
		[Address(RVA = "0x768DA0", Offset = "0x7673A0", VA = "0x180768DA0")]
		private int GetRequiredExp(int level)
		{
			if (level < 10)
			{
				return 0;
			}
			return 0;
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x0012AC5C File Offset: 0x00128E5C
		[Token(Token = "0x6003872")]
		[Address(RVA = "0x768520", Offset = "0x766B20", VA = "0x180768520")]
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
			string text = string.Format("[EconomyManager] 经验值必须大于0: {0}", "[EconomyManager] 已达到最高等级: {0}");
			Debug.LogWarning(text);
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x0012AD10 File Offset: 0x00128F10
		[Token(Token = "0x6003873")]
		[Address(RVA = "0x768830", Offset = "0x766E30", VA = "0x180768830")]
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

		// Token: 0x06003874 RID: 14452 RVA: 0x0012AD34 File Offset: 0x00128F34
		[Token(Token = "0x6003874")]
		[Address(RVA = "0x768E20", Offset = "0x767420", VA = "0x180768E20")]
		public int GetUpgradeCost()
		{
			if (this.currentLevel < 10)
			{
				return this.currentLevel;
			}
			return 999;
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0012AD58 File Offset: 0x00128F58
		[Token(Token = "0x6003875")]
		[Address(RVA = "0x768870", Offset = "0x766E70", VA = "0x180768870")]
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

		// Token: 0x06003876 RID: 14454 RVA: 0x0012ADAC File Offset: 0x00128FAC
		[Token(Token = "0x6003876")]
		[Address(RVA = "0x7699D0", Offset = "0x767FD0", VA = "0x1807699D0")]
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

		// Token: 0x06003877 RID: 14455 RVA: 0x0012AE20 File Offset: 0x00129020
		[Token(Token = "0x6003877")]
		[Address(RVA = "0x768E40", Offset = "0x767440", VA = "0x180768E40")]
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

		// Token: 0x06003878 RID: 14456 RVA: 0x0012AE88 File Offset: 0x00129088
		[Token(Token = "0x6003878")]
		[Address(RVA = "0x769280", Offset = "0x767880", VA = "0x180769280")]
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

		// Token: 0x06003879 RID: 14457 RVA: 0x0012AF0C File Offset: 0x0012910C
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x769460", Offset = "0x767A60", VA = "0x180769460")]
		public void OnBattleWin()
		{
			int num = this.winStreak;
			num++;
			this.winStreak = num;
			Debug.Log(string.Format("[EconomyManager] 战斗胜利! 连胜: {0}", num));
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x0012AF3C File Offset: 0x0012913C
		[Token(Token = "0x600387A")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public EconomyManager()
		{
		}

		// Token: 0x04002A55 RID: 10837
		[Token(Token = "0x4002A55")]
		private const int initialGold = 3;

		// Token: 0x04002A56 RID: 10838
		[Token(Token = "0x4002A56")]
		private const int baseIncome = 5;

		// Token: 0x04002A57 RID: 10839
		[Token(Token = "0x4002A57")]
		private const int winReward = 1;

		// Token: 0x04002A58 RID: 10840
		[Token(Token = "0x4002A58")]
		private const int refreshCost = 2;

		// Token: 0x04002A59 RID: 10841
		[Token(Token = "0x4002A59")]
		private const int expCost = 4;

		// Token: 0x04002A5A RID: 10842
		[Token(Token = "0x4002A5A")]
		private const int maxInterest = 4;

		// Token: 0x04002A5B RID: 10843
		[Token(Token = "0x4002A5B")]
		private const int initialLevel = 3;

		// Token: 0x04002A5C RID: 10844
		[Token(Token = "0x4002A5C")]
		private const int initialExp = 0;

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		public const int maxLevel = 10;

		// Token: 0x04002A5E RID: 10846
		[Token(Token = "0x4002A5E")]
		private const int initialHealth = 100;

		// Token: 0x04002A5F RID: 10847
		[Token(Token = "0x4002A5F")]
		private const int maxHealth = 100;

		// Token: 0x04002A60 RID: 10848
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A60")]
		private int currentLevel;

		// Token: 0x04002A61 RID: 10849
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002A61")]
		private int currentExp;

		// Token: 0x04002A62 RID: 10850
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A62")]
		private int currentHealth;

		// Token: 0x04002A63 RID: 10851
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002A63")]
		private int winStreak;

		// Token: 0x04002A64 RID: 10852
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002A64")]
		private int currentRound;
	}
}
