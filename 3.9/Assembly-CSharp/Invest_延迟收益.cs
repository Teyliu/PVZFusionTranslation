using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public class Invest_延迟收益 : InvestBuffData
{
	// Token: 0x0600019E RID: 414 RVA: 0x00006098 File Offset: 0x00004298
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x3F3540", Offset = "0x3F1B40", VA = "0x1803F3540", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.延迟收益;
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600019F RID: 415 RVA: 0x000060AC File Offset: 0x000042AC
	[Token(Token = "0x17000063")]
	public override string Description
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3F7780", Offset = "0x3F5D80", VA = "0x1803F7780", Slot = "13")]
		get
		{
			return "在关卡进度后50%时，植物攻击力增加120%";
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x000060C0 File Offset: 0x000042C0
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x3F7640", Offset = "0x3F5C40", VA = "0x1803F7640", Slot = "15")]
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

	// Token: 0x060001A1 RID: 417 RVA: 0x000060F4 File Offset: 0x000042F4
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00006104 File Offset: 0x00004304
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x3F7720", Offset = "0x3F5D20", VA = "0x1803F7720", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = board.theMaxWave;
		num -= board;
		if (board.theWave > num)
		{
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00006130 File Offset: 0x00004330
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_延迟收益()
	{
	}
}
