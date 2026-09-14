using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
public class Invest_完美开局 : InvestBuffData
{
	// Token: 0x060000FF RID: 255 RVA: 0x00004D84 File Offset: 0x00002F84
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.完美开局;
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06000100 RID: 256 RVA: 0x00004D9C File Offset: 0x00002F9C
	[Token(Token = "0x17000048")]
	public override string Description
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x3F7440", Offset = "0x3F5A40", VA = "0x1803F7440", Slot = "13")]
		get
		{
			return "在关卡进度前50%时，植物攻击力增加40%";
		}
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00004DB0 File Offset: 0x00002FB0
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x3F7300", Offset = "0x3F5900", VA = "0x1803F7300", Slot = "15")]
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

	// Token: 0x06000102 RID: 258 RVA: 0x00004DE4 File Offset: 0x00002FE4
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00004DF4 File Offset: 0x00002FF4
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3F73E0", Offset = "0x3F59E0", VA = "0x1803F73E0", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = board.theMaxWave;
		num -= board;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00004E18 File Offset: 0x00003018
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x3F6B80", Offset = "0x3F5180", VA = "0x1803F6B80")]
	public Invest_完美开局()
	{
	}
}
