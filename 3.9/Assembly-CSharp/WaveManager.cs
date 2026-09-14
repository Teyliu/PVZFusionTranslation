using System;
using Cpp2IlInjected;

// Token: 0x02000A3A RID: 2618
[Token(Token = "0x2000A3A")]
public static class WaveManager
{
	// Token: 0x060035C2 RID: 13762 RVA: 0x0011DBFC File Offset: 0x0011BDFC
	[Token(Token = "0x60035C2")]
	[Address(RVA = "0x7AF970", Offset = "0x7ADF70", VA = "0x1807AF970")]
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

	// Token: 0x060035C3 RID: 13763 RVA: 0x0011DC68 File Offset: 0x0011BE68
	[Token(Token = "0x60035C3")]
	[Address(RVA = "0x7AFEB0", Offset = "0x7AE4B0", VA = "0x1807AFEB0")]
	private static int GetNewAdvantureMaxWave(int levelNumber)
	{
		ulong num;
		num += num;
		if (levelNumber <= 8)
		{
		}
		uint num2 = (uint)((ulong)num2 + num);
		num += (ulong)num2;
		num += (ulong)num2;
		num2 += (uint)levelNumber;
		num2 += (uint)levelNumber;
		num += (ulong)levelNumber;
		num += (ulong)levelNumber;
		num += (ulong)levelNumber;
		return 0;
	}

	// Token: 0x060035C4 RID: 13764 RVA: 0x0011DCA8 File Offset: 0x0011BEA8
	[Token(Token = "0x60035C4")]
	[Address(RVA = "0x7AFF20", Offset = "0x7AE520", VA = "0x1807AFF20")]
	private static int InitAdvWave(int theLevelNumber)
	{
		if (theLevelNumber - 1 <= 44)
		{
			int num = theLevelNumber - 1;
			return 0;
		}
		return 0;
	}

	// Token: 0x060035C5 RID: 13765 RVA: 0x0011DCC4 File Offset: 0x0011BEC4
	[Token(Token = "0x60035C5")]
	[Address(RVA = "0x7B0010", Offset = "0x7AE610", VA = "0x1807B0010")]
	private static int InitChallengeWave(int theLevelNumber)
	{
		if (theLevelNumber - 1 <= 173)
		{
			int num = theLevelNumber - 1;
			GameConfig config = GameAPP.config;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060035C6 RID: 13766 RVA: 0x0011DCEC File Offset: 0x0011BEEC
	[Token(Token = "0x60035C6")]
	[Address(RVA = "0x7B01E0", Offset = "0x7AE7E0", VA = "0x1807B01E0")]
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
