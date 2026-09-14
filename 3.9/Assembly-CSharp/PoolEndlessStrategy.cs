using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x0200098F RID: 2447
[Token(Token = "0x200098F")]
public class PoolEndlessStrategy : BaseLevelStrategy
{
	// Token: 0x06003284 RID: 12932 RVA: 0x001090C8 File Offset: 0x001072C8
	[Token(Token = "0x6003284")]
	[Address(RVA = "0x71C7A0", Offset = "0x71ADA0", VA = "0x18071C7A0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.PoolEndless;
	}

	// Token: 0x06003285 RID: 12933 RVA: 0x001090DC File Offset: 0x001072DC
	[Token(Token = "0x6003285")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003286 RID: 12934 RVA: 0x001090EC File Offset: 0x001072EC
	[Token(Token = "0x6003286")]
	[Address(RVA = "0x71C7B0", Offset = "0x71ADB0", VA = "0x18071C7B0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		SaveInfo instance = SaveInfo.Instance;
		int level = (int)this.GetLevel();
		SurvivalData survivalData = instance.GetSurvivalData(level, -1);
		if (survivalData != 0)
		{
			SaveBoardData boardData = survivalData.boardData;
			if (boardData.isBoardSaved)
			{
				int theCurrentSurvivalRound = boardData.theCurrentSurvivalRound;
				if (theCurrentSurvivalRound != 1)
				{
					return EndlessData.GetSandZombieTypes(theCurrentSurvivalRound);
				}
			}
		}
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06003287 RID: 12935 RVA: 0x00109174 File Offset: 0x00107374
	[Token(Token = "0x6003287")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06003288 RID: 12936 RVA: 0x00109184 File Offset: 0x00107384
	[Token(Token = "0x6003288")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003289 RID: 12937 RVA: 0x00109194 File Offset: 0x00107394
	[Token(Token = "0x6003289")]
	[Address(RVA = "0x71C710", Offset = "0x71AD10", VA = "0x18071C710", Slot = "30")]
	public override string GetLevelName()
	{
		int theCurrentSurvivalRound = Board.Instance.theCurrentSurvivalRound;
		return string.Format("星辉无尽：危机泳池-第{0}轮", theCurrentSurvivalRound);
	}

	// Token: 0x0600328A RID: 12938 RVA: 0x001091C0 File Offset: 0x001073C0
	[Token(Token = "0x600328A")]
	[Address(RVA = "0x71CB20", Offset = "0x71B120", VA = "0x18071CB20", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.theCurrentSurvivalRound = (int)((ulong)1L);
		board.boardTag.isEndless = true;
		board.theSurvivalMaxRound = (int)((ulong)2147483647L);
		SaveInfo instance = SaveInfo.Instance;
		int level = (int)this.GetLevel();
		SurvivalData survivalData = instance.GetSurvivalData(level, -1);
		if (survivalData != 0 && survivalData.boardData.isBoardSaved)
		{
			BoardConfig config = board.config;
		}
	}

	// Token: 0x0600328B RID: 12939 RVA: 0x0010922C File Offset: 0x0010742C
	[Token(Token = "0x600328B")]
	[Address(RVA = "0x71CA10", Offset = "0x71B010", VA = "0x18071CA10", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		SaveInfo instance = SaveInfo.Instance;
		int level = (int)this.GetLevel();
		SurvivalData survivalData = instance.GetSurvivalData(level, -1);
		if (survivalData != 0 && survivalData.boardData.isBoardSaved)
		{
			SaveMgr.LoadBoard((int)this.GetLevel(), -1);
		}
	}

	// Token: 0x0600328C RID: 12940 RVA: 0x00109274 File Offset: 0x00107474
	[Token(Token = "0x600328C")]
	[Address(RVA = "0x71CC20", Offset = "0x71B220", VA = "0x18071CC20")]
	private bool TryGetData([Out] SurvivalData data)
	{
		SaveInfo instance = SaveInfo.Instance;
		int level = (int)this.GetLevel();
		SurvivalData survivalData = instance.GetSurvivalData(level, -1);
		bool flag;
		return flag;
	}

	// Token: 0x0600328D RID: 12941 RVA: 0x001092A4 File Offset: 0x001074A4
	[Token(Token = "0x600328D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PoolEndlessStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
