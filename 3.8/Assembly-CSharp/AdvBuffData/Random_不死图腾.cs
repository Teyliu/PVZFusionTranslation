using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000CFE RID: 3326
	[Token(Token = "0x2000CFE")]
	public class Random_不死图腾 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x00161564 File Offset: 0x0015F764
		[Token(Token = "0x170007D0")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045A8")]
			[Address(RVA = "0x84A2D0", Offset = "0x8488D0", VA = "0x18084A2D0", Slot = "12")]
			get
			{
				return AdvBuff.Random_不死图腾;
			}
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00161578 File Offset: 0x0015F778
		[Token(Token = "0x60045A9")]
		[Address(RVA = "0x84A260", Offset = "0x848860", VA = "0x18084A260", Slot = "13")]
		public override string GetDescription()
		{
			return "不死图腾：下一次僵尸进家时，无视僵尸进家，持续3秒，并强制击退全场僵尸至底线";
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x0016158C File Offset: 0x0015F78C
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x84A290", Offset = "0x848890", VA = "0x18084A290")]
		public Random_不死图腾()
		{
		}
	}
}
