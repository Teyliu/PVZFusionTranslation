using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D0C RID: 3340
	[Token(Token = "0x2000D0C")]
	public class Random_力场护盾 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x00161AF0 File Offset: 0x0015FCF0
		[Token(Token = "0x170007D7")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045D6")]
			[Address(RVA = "0x84A5E0", Offset = "0x848BE0", VA = "0x18084A5E0", Slot = "12")]
			get
			{
				return AdvBuff.Random_力场护盾;
			}
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x00161B04 File Offset: 0x0015FD04
		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x84A4A0", Offset = "0x848AA0", VA = "0x18084A4A0", Slot = "13")]
		public override string GetDescription()
		{
			return "力场护盾：全场植物每秒获得50+2%最大生命值的护盾";
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00161B18 File Offset: 0x0015FD18
		[Token(Token = "0x60045D8")]
		[Address(RVA = "0x84A4F0", Offset = "0x848AF0", VA = "0x18084A4F0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00161B38 File Offset: 0x0015FD38
		[Token(Token = "0x60045D9")]
		[Address(RVA = "0x84A4D0", Offset = "0x848AD0", VA = "0x18084A4D0", Slot = "15")]
		public override void OnBoardStart(Board board)
		{
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00161B48 File Offset: 0x0015FD48
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0x84A5A0", Offset = "0x848BA0", VA = "0x18084A5A0")]
		public Random_力场护盾()
		{
		}
	}
}
