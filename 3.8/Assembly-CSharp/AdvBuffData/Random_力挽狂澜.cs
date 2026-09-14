using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D0E RID: 3342
	[Token(Token = "0x2000D0E")]
	public class Random_力挽狂澜 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x00161BF0 File Offset: 0x0015FDF0
		[Token(Token = "0x170007D8")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045DD")]
			[Address(RVA = "0x84A660", Offset = "0x848C60", VA = "0x18084A660", Slot = "12")]
			get
			{
				return AdvBuff.Random_力挽狂澜;
			}
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00161C04 File Offset: 0x0015FE04
		[Token(Token = "0x60045DE")]
		[Address(RVA = "0x84A5F0", Offset = "0x848BF0", VA = "0x18084A5F0", Slot = "13")]
		public override string GetDescription()
		{
			return "力挽狂澜：僵尸进家时不再立即失败，改为场上的植物有1/3概率死亡\n进家时，若场上植物数量小于20株则立即失败";
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x00161C18 File Offset: 0x0015FE18
		[Token(Token = "0x60045DF")]
		[Address(RVA = "0x84A620", Offset = "0x848C20", VA = "0x18084A620")]
		public Random_力挽狂澜()
		{
		}
	}
}
