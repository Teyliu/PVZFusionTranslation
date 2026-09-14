using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DC0 RID: 3520
	[Token(Token = "0x2000DC0")]
	public class Random_超多阳光 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x0016B64C File Offset: 0x0016984C
		[Token(Token = "0x1700092F")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004931")]
			[Address(RVA = "0x88C7A0", Offset = "0x88ADA0", VA = "0x18088C7A0", Slot = "12")]
			get
			{
				return AdvBuff.Random_超多阳光;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06004932 RID: 18738 RVA: 0x0016B660 File Offset: 0x00169860
		[Token(Token = "0x17000930")]
		public override string Description
		{
			[Token(Token = "0x6004932")]
			[Address(RVA = "0x8B2590", Offset = "0x8B0B90", VA = "0x1808B2590", Slot = "13")]
			get
			{
				return "超多阳光：立即获得10万阳光，并使阳光上限增加10万";
			}
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x0016B674 File Offset: 0x00169874
		[Token(Token = "0x6004933")]
		[Address(RVA = "0x8B2510", Offset = "0x8B0B10", VA = "0x1808B2510", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ulong num;
			board.GetSun(100000f, num != 0UL);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x0016B694 File Offset: 0x00169894
		[Token(Token = "0x6004934")]
		[Address(RVA = "0x8B2550", Offset = "0x8B0B50", VA = "0x1808B2550")]
		public Random_超多阳光()
		{
		}
	}
}
