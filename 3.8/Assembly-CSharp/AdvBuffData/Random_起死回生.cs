using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D13 RID: 3347
	[Token(Token = "0x2000D13")]
	public class Random_起死回生 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x00161D6C File Offset: 0x0015FF6C
		[Token(Token = "0x170007DB")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045EC")]
			[Address(RVA = "0x84BFB0", Offset = "0x84A5B0", VA = "0x18084BFB0", Slot = "12")]
			get
			{
				return AdvBuff.Random_起死回生;
			}
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00161D80 File Offset: 0x0015FF80
		[Token(Token = "0x60045ED")]
		[Address(RVA = "0x84BF40", Offset = "0x84A540", VA = "0x18084BF40", Slot = "13")]
		public override string GetDescription()
		{
			return "起死回生：在僵尸进家的1.5秒内击杀这个僵尸，则不会使游戏失败";
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00161D94 File Offset: 0x0015FF94
		[Token(Token = "0x60045EE")]
		[Address(RVA = "0x84BF70", Offset = "0x84A570", VA = "0x18084BF70")]
		public Random_起死回生()
		{
		}
	}
}
