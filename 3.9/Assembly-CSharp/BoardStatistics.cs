using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using RhythmGame;
using UnityEngine;

// Token: 0x0200026F RID: 623
[Token(Token = "0x200026F")]
[Serializable]
public class BoardStatistics
{
	// Token: 0x06000B36 RID: 2870 RVA: 0x0003FCB0 File Offset: 0x0003DEB0
	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x931670", Offset = "0x92FC70", VA = "0x180931670")]
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

	// Token: 0x06000B37 RID: 2871 RVA: 0x0003FD6C File Offset: 0x0003DF6C
	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x931470", Offset = "0x92FA70", VA = "0x180931470")]
	public void Repair(Board board)
	{
		this.board = board;
		Dictionary<ZombieType, int> dictionary = new Dictionary();
		this.zombiesKilledByType = dictionary;
		Dictionary<PlantType, PlantStatisticsDetail> dictionary2 = new Dictionary();
		this.plantDetails = dictionary2;
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x0003FD9C File Offset: 0x0003DF9C
	[Token(Token = "0x6000B38")]
	[Address(RVA = "0x931540", Offset = "0x92FB40", VA = "0x180931540")]
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

	// Token: 0x06000B39 RID: 2873 RVA: 0x0003FE2C File Offset: 0x0003E02C
	[Token(Token = "0x6000B39")]
	[Address(RVA = "0x931240", Offset = "0x92F840", VA = "0x180931240")]
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

	// Token: 0x0400072B RID: 1835
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400072B")]
	[Header("游戏基本信息")]
	private Board board;

	// Token: 0x0400072C RID: 1836
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400072C")]
	public GameResult gameResult;

	// Token: 0x0400072D RID: 1837
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400072D")]
	public long startTimeTicks;

	// Token: 0x0400072E RID: 1838
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400072E")]
	public long endTimeTicks;

	// Token: 0x0400072F RID: 1839
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400072F")]
	public float gameDuration;

	// Token: 0x04000730 RID: 1840
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000730")]
	[Header("资源统计")]
	public int finalSun;

	// Token: 0x04000731 RID: 1841
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000731")]
	public int sunProduced;

	// Token: 0x04000732 RID: 1842
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000732")]
	public int sunConsumed;

	// Token: 0x04000733 RID: 1843
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000733")]
	public int finalMoney;

	// Token: 0x04000734 RID: 1844
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000734")]
	public int moneyEarned;

	// Token: 0x04000735 RID: 1845
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000735")]
	public int moneyConsumed;

	// Token: 0x04000736 RID: 1846
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000736")]
	[Header("战斗统计")]
	public int zombiesKilled;

	// Token: 0x04000737 RID: 1847
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000737")]
	public int zombiesMindControlled;

	// Token: 0x04000738 RID: 1848
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000738")]
	public Dictionary<ZombieType, int> zombiesKilledByType;

	// Token: 0x04000739 RID: 1849
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000739")]
	public float totalZombieDamage;

	// Token: 0x0400073A RID: 1850
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400073A")]
	[Header("植物统计")]
	public int plantsPlanted;

	// Token: 0x0400073B RID: 1851
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400073B")]
	public int plantsDeath;

	// Token: 0x0400073C RID: 1852
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400073C")]
	public int plantsShoveled;

	// Token: 0x0400073D RID: 1853
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400073D")]
	public Dictionary<PlantType, PlantStatisticsDetail> plantDetails;

	// Token: 0x0400073E RID: 1854
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400073E")]
	[Header("波次统计")]
	public int currentWave;

	// Token: 0x0400073F RID: 1855
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400073F")]
	public int maxWave;

	// Token: 0x04000740 RID: 1856
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000740")]
	[Header("扣分项")]
	public int mowerUsedCount;

	// Token: 0x04000741 RID: 1857
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000741")]
	public ComboManager comboManager;
}
