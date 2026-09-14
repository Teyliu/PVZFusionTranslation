using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DD4 RID: 3540
	[Token(Token = "0x2000DD4")]
	public class Random_力场护盾 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x0016BF54 File Offset: 0x0016A154
		[Token(Token = "0x17000945")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004977")]
			[Address(RVA = "0x8A00B0", Offset = "0x89E6B0", VA = "0x1808A00B0", Slot = "12")]
			get
			{
				return AdvBuff.Random_力场护盾;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x0016BF68 File Offset: 0x0016A168
		[Token(Token = "0x17000946")]
		public override string Description
		{
			[Token(Token = "0x6004978")]
			[Address(RVA = "0x8CF900", Offset = "0x8CDF00", VA = "0x1808CF900", Slot = "13")]
			get
			{
				return "力场护盾：全场植物每秒获得50+2%最大生命值的护盾";
			}
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x0016BF7C File Offset: 0x0016A17C
		[Token(Token = "0x6004979")]
		[Address(RVA = "0x8CF810", Offset = "0x8CDE10", VA = "0x1808CF810", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x0016BF9C File Offset: 0x0016A19C
		[Token(Token = "0x600497A")]
		[Address(RVA = "0x8CF7F0", Offset = "0x8CDDF0", VA = "0x1808CF7F0", Slot = "15")]
		public override void OnBoardStart(Board board)
		{
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0016BFAC File Offset: 0x0016A1AC
		[Token(Token = "0x600497B")]
		[Address(RVA = "0x8CF8C0", Offset = "0x8CDEC0", VA = "0x1808CF8C0")]
		public Random_力场护盾()
		{
		}
	}
}
