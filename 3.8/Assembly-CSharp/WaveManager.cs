using System;
using Cpp2IlInjected;

// Token: 0x020009FE RID: 2558
[Token(Token = "0x20009FE")]
public static class WaveManager
{
	// Token: 0x0600348D RID: 13453 RVA: 0x00118CFC File Offset: 0x00116EFC
	[Token(Token = "0x600348D")]
	[Address(RVA = "0x748FB0", Offset = "0x7475B0", VA = "0x180748FB0")]
	public static int GetMaxWave(LevelType levelType, int level)
	{
		bool flag;
		if (flag || levelType > LevelType.StarAdvanture)
		{
			throw new NullReferenceException();
		}
		if (level - 1 <= 44)
		{
			int num = level - 1;
		}
		if (level - 1 <= 173)
		{
			int num2 = level - 1;
			GameConfig config = GameAPP.config;
			return WaveManager.InitSurvivalWave(level);
		}
		return TowerData.GetWave(level);
	}

	// Token: 0x0600348E RID: 13454 RVA: 0x00118D68 File Offset: 0x00116F68
	[Token(Token = "0x600348E")]
	[Address(RVA = "0x7494F0", Offset = "0x747AF0", VA = "0x1807494F0")]
	private static int GetNewAdvantureMaxWave(int levelNumber)
	{
		ulong num;
		num += num;
		if (levelNumber <= 8)
		{
		}
		if (levelNumber != 8)
		{
		}
		if (levelNumber != 8)
		{
		}
		if (levelNumber != 8)
		{
		}
		if (levelNumber != 8)
		{
		}
		if (levelNumber != 8)
		{
		}
		if (levelNumber != 8)
		{
		}
		if (levelNumber != 8)
		{
		}
		if (levelNumber - 1 <= 44)
		{
			int num2 = levelNumber - 1;
			return 0;
		}
		return 0;
	}

	// Token: 0x0600348F RID: 13455 RVA: 0x00118DA8 File Offset: 0x00116FA8
	[Token(Token = "0x600348F")]
	[Address(RVA = "0x749560", Offset = "0x747B60", VA = "0x180749560")]
	private static int InitAdvWave(int theLevelNumber)
	{
		if (theLevelNumber - 1 <= 44)
		{
			int num = theLevelNumber - 1;
			return 0;
		}
		return 0;
	}

	// Token: 0x06003490 RID: 13456 RVA: 0x00118DC4 File Offset: 0x00116FC4
	[Token(Token = "0x6003490")]
	[Address(RVA = "0x749650", Offset = "0x747C50", VA = "0x180749650")]
	private static int InitChallengeWave(int theLevelNumber)
	{
		if (theLevelNumber - 1 <= 173)
		{
			int num = theLevelNumber - 1;
			GameConfig config = GameAPP.config;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06003491 RID: 13457 RVA: 0x00118DEC File Offset: 0x00116FEC
	[Token(Token = "0x6003491")]
	[Address(RVA = "0x749820", Offset = "0x747E20", VA = "0x180749820")]
	private static int InitSurvivalWave(int theLevelNumber)
	{
		if (theLevelNumber - 1 <= 37)
		{
			int num = theLevelNumber - 1;
		}
		Board.Instance.theSurvivalMaxRound = (int)((ulong)5L);
		Board.Instance.theSurvivalMaxRound = (int)((ulong)5L);
		Board.Instance.theSurvivalMaxRound = (int)((ulong)22L);
		Board.Instance.theSurvivalMaxRound = (int)((ulong)2147483647L);
		Board instance = Board.Instance;
		Board.Instance.theSurvivalMaxRound = (int)((ulong)7L);
		Board.Instance.theSurvivalMaxRound = (int)((ulong)16L);
		int theCurrentSurvivalRound = Board.Instance.theCurrentSurvivalRound;
		if (theCurrentSurvivalRound > 8)
		{
			while (theCurrentSurvivalRound == 12)
			{
			}
		}
		while (theCurrentSurvivalRound == 4)
		{
		}
		Board.Instance.theSurvivalMaxRound = (int)((ulong)2147483647L);
		Board.Instance.theSurvivalMaxRound = (int)((ulong)21L);
		throw new NullReferenceException();
	}
}
