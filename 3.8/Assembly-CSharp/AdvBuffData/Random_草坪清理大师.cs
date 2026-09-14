using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D12 RID: 3346
	[Token(Token = "0x2000D12")]
	public class Random_草坪清理大师 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x00161CE4 File Offset: 0x0015FEE4
		[Token(Token = "0x170007DA")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045E8")]
			[Address(RVA = "0x84BB50", Offset = "0x84A150", VA = "0x18084BB50", Slot = "12")]
			get
			{
				return AdvBuff.Random_草坪清理大师;
			}
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00161CF8 File Offset: 0x0015FEF8
		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x84B900", Offset = "0x849F00", VA = "0x18084B900", Slot = "13")]
		public override string GetDescription()
		{
			return "草坪清理大师：释放当前小推车，并重新获得一列小推车";
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00161D0C File Offset: 0x0015FF0C
		[Token(Token = "0x60045EA")]
		[Address(RVA = "0x84B930", Offset = "0x849F30", VA = "0x18084B930", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ulong num3;
			do
			{
				int num = 0;
				List<Mower> mowerArray = board.mowerArray;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
				}
			}
			while (num3 != (ulong)0L);
			InitBoard.Instance.InitMower();
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00161D58 File Offset: 0x0015FF58
		[Token(Token = "0x60045EB")]
		[Address(RVA = "0x84BB10", Offset = "0x84A110", VA = "0x18084BB10")]
		public Random_草坪清理大师()
		{
		}
	}
}
