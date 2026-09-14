using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000035 RID: 53
[Token(Token = "0x2000035")]
public class Invest_完美开局 : InvestBuffData
{
	// Token: 0x060000E8 RID: 232 RVA: 0x00004AF4 File Offset: 0x00002CF4
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "20")]
	public override InvestBuff GetBuffType()
	{
		return InvestBuff.完美开局;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00004B0C File Offset: 0x00002D0C
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x3AB500", Offset = "0x3A9B00", VA = "0x1803AB500", Slot = "13")]
	public override string GetDescription()
	{
		return "在关卡进度前50%时，植物攻击力增加40%";
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00004B20 File Offset: 0x00002D20
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x3AB530", Offset = "0x3A9B30", VA = "0x1803AB530", Slot = "15")]
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

	// Token: 0x060000EB RID: 235 RVA: 0x00004B54 File Offset: 0x00002D54
	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00004B64 File Offset: 0x00002D64
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x3AB610", Offset = "0x3A9C10", VA = "0x1803AB610", Slot = "18")]
	public override void ReinforcePlant(Board board, Plant plant)
	{
		int num = board.theMaxWave;
		num -= board;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00004B88 File Offset: 0x00002D88
	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x3AAD80", Offset = "0x3A9380", VA = "0x1803AAD80")]
	public Invest_完美开局()
	{
	}
}
