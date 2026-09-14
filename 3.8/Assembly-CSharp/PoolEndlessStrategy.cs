using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000953 RID: 2387
[Token(Token = "0x2000953")]
public class PoolEndlessStrategy : BaseLevelStrategy
{
	// Token: 0x06003151 RID: 12625 RVA: 0x00104364 File Offset: 0x00102564
	[Token(Token = "0x6003151")]
	[Address(RVA = "0x6A2640", Offset = "0x6A0C40", VA = "0x1806A2640", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.PoolEndless;
	}

	// Token: 0x06003152 RID: 12626 RVA: 0x00104378 File Offset: 0x00102578
	[Token(Token = "0x6003152")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003153 RID: 12627 RVA: 0x00104388 File Offset: 0x00102588
	[Token(Token = "0x6003153")]
	[Address(RVA = "0x6A2650", Offset = "0x6A0C50", VA = "0x1806A2650", Slot = "24")]
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

	// Token: 0x06003154 RID: 12628 RVA: 0x00104410 File Offset: 0x00102610
	[Token(Token = "0x6003154")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06003155 RID: 12629 RVA: 0x00104420 File Offset: 0x00102620
	[Token(Token = "0x6003155")]
	[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003156 RID: 12630 RVA: 0x00104430 File Offset: 0x00102630
	[Token(Token = "0x6003156")]
	[Address(RVA = "0x6A25B0", Offset = "0x6A0BB0", VA = "0x1806A25B0", Slot = "30")]
	public override string GetLevelName()
	{
		int theCurrentSurvivalRound = Board.Instance.theCurrentSurvivalRound;
		return string.Format("星辉无尽：危机泳池-第{0}轮", theCurrentSurvivalRound);
	}

	// Token: 0x06003157 RID: 12631 RVA: 0x0010445C File Offset: 0x0010265C
	[Token(Token = "0x6003157")]
	[Address(RVA = "0x6A29C0", Offset = "0x6A0FC0", VA = "0x1806A29C0", Slot = "21")]
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

	// Token: 0x06003158 RID: 12632 RVA: 0x001044C8 File Offset: 0x001026C8
	[Token(Token = "0x6003158")]
	[Address(RVA = "0x6A28B0", Offset = "0x6A0EB0", VA = "0x1806A28B0", Slot = "34")]
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

	// Token: 0x06003159 RID: 12633 RVA: 0x00104510 File Offset: 0x00102710
	[Token(Token = "0x6003159")]
	[Address(RVA = "0x6A2AC0", Offset = "0x6A10C0", VA = "0x1806A2AC0")]
	private bool TryGetData([Out] SurvivalData data)
	{
		SaveInfo instance = SaveInfo.Instance;
		int level = (int)this.GetLevel();
		SurvivalData survivalData = instance.GetSurvivalData(level, -1);
		bool flag;
		return flag;
	}

	// Token: 0x0600315A RID: 12634 RVA: 0x00104540 File Offset: 0x00102740
	[Token(Token = "0x600315A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PoolEndlessStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
