using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DD6 RID: 3542
	[Token(Token = "0x2000DD6")]
	public class Random_力挽狂澜 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x0600497E RID: 18814 RVA: 0x0016C054 File Offset: 0x0016A254
		[Token(Token = "0x17000947")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600497E")]
			[Address(RVA = "0x89FB30", Offset = "0x89E130", VA = "0x18089FB30", Slot = "12")]
			get
			{
				return AdvBuff.Random_力挽狂澜;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x0016C068 File Offset: 0x0016A268
		[Token(Token = "0x17000948")]
		public override string Description
		{
			[Token(Token = "0x600497F")]
			[Address(RVA = "0x8CF970", Offset = "0x8CDF70", VA = "0x1808CF970", Slot = "13")]
			get
			{
				return "力挽狂澜：僵尸进家时不再立即失败，改为场上的植物有1/3概率死亡\n进家时，若场上植物数量小于20株则立即失败";
			}
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x0016C07C File Offset: 0x0016A27C
		[Token(Token = "0x6004980")]
		[Address(RVA = "0x8CF930", Offset = "0x8CDF30", VA = "0x1808CF930")]
		public Random_力挽狂澜()
		{
		}
	}
}
