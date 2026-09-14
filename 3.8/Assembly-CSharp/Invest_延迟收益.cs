using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200005C RID: 92
[Token(Token = "0x200005C")]
public class Invest_延迟收益 : InvestBuffData
{
	// Token: 0x06000187 RID: 391 RVA: 0x00005E08 File Offset: 0x00004008
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x3A7750", Offset = "0x3A5D50", VA = "0x1803A7750", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.延迟收益;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00005E1C File Offset: 0x0000401C
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x3AB840", Offset = "0x3A9E40", VA = "0x1803AB840", Slot = "13")]
	public override string GetDescription()
	{
		return "在关卡进度后50%时，植物攻击力增加120%";
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00005E30 File Offset: 0x00004030
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x3AB870", Offset = "0x3A9E70", VA = "0x1803AB870", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		Action action = delegate
		{
			int num;
			do
			{
				Board board2 = board;
				int theMaxWave = board2.theMaxWave;
				if (board2.theWave <= theMaxWave)
				{
					break;
				}
				List<Plant> allPlants = Lawnf.GetAllPlants();
				num = 0;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
		};
		EventManager.AddListenerOnce(GameEvent.BoardWaveAdd, action);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00005E64 File Offset: 0x00004064
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00005E74 File Offset: 0x00004074
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x3AB950", Offset = "0x3A9F50", VA = "0x1803AB950", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = board.theMaxWave;
		num -= board;
		if (board.theWave > num)
		{
		}
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00005EA0 File Offset: 0x000040A0
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_延迟收益()
	{
	}
}
