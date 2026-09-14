using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DDC RID: 3548
	[Token(Token = "0x2000DDC")]
	public class Random_小复制 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x0016C1FC File Offset: 0x0016A3FC
		[Token(Token = "0x1700094F")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004990")]
			[Address(RVA = "0x89EBF0", Offset = "0x89D1F0", VA = "0x18089EBF0", Slot = "12")]
			get
			{
				return AdvBuff.Random_小复制;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x0016C210 File Offset: 0x0016A410
		[Token(Token = "0x17000950")]
		public override string Description
		{
			[Token(Token = "0x6004991")]
			[Address(RVA = "0x8CFC40", Offset = "0x8CE240", VA = "0x1808CFC40", Slot = "13")]
			get
			{
				return "小复制：立即获得5张模仿者卡牌";
			}
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x0016C224 File Offset: 0x0016A424
		[Token(Token = "0x6004992")]
		[Address(RVA = "0x8CFB90", Offset = "0x8CE190", VA = "0x1808CFB90", Slot = "17")]
		public override void OnSelect(Board board)
		{
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x0016C234 File Offset: 0x0016A434
		[Token(Token = "0x6004993")]
		[Address(RVA = "0x8CFC00", Offset = "0x8CE200", VA = "0x1808CFC00")]
		public Random_小复制()
		{
		}
	}
}
