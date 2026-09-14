using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using RhythmGame;
using UnityEngine;

// Token: 0x02000269 RID: 617
[Token(Token = "0x2000269")]
[Serializable]
public class BoardStatistics
{
	// Token: 0x06000B1A RID: 2842 RVA: 0x0003FDF0 File Offset: 0x0003DFF0
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x8A16D0", Offset = "0x89FCD0", VA = "0x1808A16D0")]
	public BoardStatistics(Board board)
	{
		Dictionary<ZombieType, int> dictionary = new Dictionary();
		this.zombiesKilledByType = dictionary;
		Dictionary<PlantType, PlantStatisticsDetail> dictionary2 = new Dictionary();
		this.plantDetails = dictionary2;
		base..ctor();
		this.board = board;
		int num = 0;
		this.gameResult = (GameResult)num;
		long time = GameAPP.GetTime();
		this.startTimeTicks = time;
		this.endTimeTicks = time;
		this.gameDuration = (float)num;
		this.sunProduced = num;
		this.finalMoney = num;
		this.moneyConsumed = num;
		this.zombiesMindControlled = num;
		Dictionary<ZombieType, int> dictionary3 = new Dictionary();
		this.zombiesKilledByType = dictionary3;
		this.totalZombieDamage = (float)num;
		this.plantsDeath = num;
		Dictionary<PlantType, PlantStatisticsDetail> dictionary4 = new Dictionary();
		this.plantDetails = dictionary4;
		this.currentWave = num;
		this.mowerUsedCount = num;
		this.comboManager = num;
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x0003FEAC File Offset: 0x0003E0AC
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x8A14D0", Offset = "0x89FAD0", VA = "0x1808A14D0")]
	public void Repair(Board board)
	{
		this.board = board;
		Dictionary<ZombieType, int> dictionary = new Dictionary();
		this.zombiesKilledByType = dictionary;
		Dictionary<PlantType, PlantStatisticsDetail> dictionary2 = new Dictionary();
		this.plantDetails = dictionary2;
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x0003FEDC File Offset: 0x0003E0DC
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x8A15A0", Offset = "0x89FBA0", VA = "0x1808A15A0")]
	public void Reset()
	{
		int num = 0;
		this.gameResult = (GameResult)num;
		long time = GameAPP.GetTime();
		this.startTimeTicks = time;
		this.endTimeTicks = time;
		this.gameDuration = (float)num;
		this.sunProduced = num;
		this.finalMoney = num;
		this.moneyConsumed = num;
		this.zombiesMindControlled = num;
		Dictionary<ZombieType, int> dictionary = new Dictionary();
		this.zombiesKilledByType = dictionary;
		this.totalZombieDamage = (float)num;
		this.plantsDeath = num;
		Dictionary<PlantType, PlantStatisticsDetail> dictionary2 = new Dictionary();
		this.plantDetails = dictionary2;
		this.currentWave = num;
		this.mowerUsedCount = num;
		this.comboManager = num;
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x0003FF6C File Offset: 0x0003E16C
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x8A12A0", Offset = "0x89F8A0", VA = "0x1808A12A0")]
	public void GameOver(GameResult result)
	{
		ulong num;
		do
		{
			long time = GameAPP.GetTime();
			this.endTimeTicks = time;
			this.gameResult = result;
			int theWave = this.board.theWave;
			this.currentWave = theWave;
			int theMaxWave = this.board.theMaxWave;
			this.maxWave = theMaxWave;
			if (this.plantDetails == (ulong)0L)
			{
				Dictionary<PlantType, PlantStatisticsDetail> dictionary = new Dictionary();
				this.plantDetails = dictionary;
			}
			Dictionary<PlantType, PlantStatisticsDetail> dictionary2 = this.plantDetails;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x0400071F RID: 1823
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071F")]
	[Header("游戏基本信息")]
	private Board board;

	// Token: 0x04000720 RID: 1824
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000720")]
	public GameResult gameResult;

	// Token: 0x04000721 RID: 1825
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000721")]
	public long startTimeTicks;

	// Token: 0x04000722 RID: 1826
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000722")]
	public long endTimeTicks;

	// Token: 0x04000723 RID: 1827
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000723")]
	public float gameDuration;

	// Token: 0x04000724 RID: 1828
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000724")]
	[Header("资源统计")]
	public int finalSun;

	// Token: 0x04000725 RID: 1829
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000725")]
	public int sunProduced;

	// Token: 0x04000726 RID: 1830
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000726")]
	public int sunConsumed;

	// Token: 0x04000727 RID: 1831
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000727")]
	public int finalMoney;

	// Token: 0x04000728 RID: 1832
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000728")]
	public int moneyEarned;

	// Token: 0x04000729 RID: 1833
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000729")]
	public int moneyConsumed;

	// Token: 0x0400072A RID: 1834
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400072A")]
	[Header("战斗统计")]
	public int zombiesKilled;

	// Token: 0x0400072B RID: 1835
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400072B")]
	public int zombiesMindControlled;

	// Token: 0x0400072C RID: 1836
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400072C")]
	public Dictionary<ZombieType, int> zombiesKilledByType;

	// Token: 0x0400072D RID: 1837
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400072D")]
	public float totalZombieDamage;

	// Token: 0x0400072E RID: 1838
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400072E")]
	[Header("植物统计")]
	public int plantsPlanted;

	// Token: 0x0400072F RID: 1839
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400072F")]
	public int plantsDeath;

	// Token: 0x04000730 RID: 1840
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000730")]
	public int plantsShoveled;

	// Token: 0x04000731 RID: 1841
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000731")]
	public Dictionary<PlantType, PlantStatisticsDetail> plantDetails;

	// Token: 0x04000732 RID: 1842
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000732")]
	[Header("波次统计")]
	public int currentWave;

	// Token: 0x04000733 RID: 1843
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000733")]
	public int maxWave;

	// Token: 0x04000734 RID: 1844
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000734")]
	[Header("扣分项")]
	public int mowerUsedCount;

	// Token: 0x04000735 RID: 1845
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000735")]
	public ComboManager comboManager;
}
