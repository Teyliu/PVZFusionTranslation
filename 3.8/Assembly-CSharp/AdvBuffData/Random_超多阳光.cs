using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000CF8 RID: 3320
	[Token(Token = "0x2000CF8")]
	public class Random_超多阳光 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x0016121C File Offset: 0x0015F41C
		[Token(Token = "0x170007CC")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004591")]
			[Address(RVA = "0x84C070", Offset = "0x84A670", VA = "0x18084C070", Slot = "12")]
			get
			{
				return AdvBuff.Random_超多阳光;
			}
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x00161230 File Offset: 0x0015F430
		[Token(Token = "0x6004592")]
		[Address(RVA = "0x84BFC0", Offset = "0x84A5C0", VA = "0x18084BFC0", Slot = "13")]
		public override string GetDescription()
		{
			return "超多阳光：立即获得10万阳光，并使阳光上限增加10万";
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00161244 File Offset: 0x0015F444
		[Token(Token = "0x6004593")]
		[Address(RVA = "0x84BFF0", Offset = "0x84A5F0", VA = "0x18084BFF0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ulong num;
			board.GetSun(100000f, num != 0UL);
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00161264 File Offset: 0x0015F464
		[Token(Token = "0x6004594")]
		[Address(RVA = "0x84C030", Offset = "0x84A630", VA = "0x18084C030")]
		public Random_超多阳光()
		{
		}
	}
}
