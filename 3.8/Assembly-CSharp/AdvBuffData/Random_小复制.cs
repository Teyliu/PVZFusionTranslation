using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D14 RID: 3348
	[Token(Token = "0x2000D14")]
	public class Random_小复制 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060045EF RID: 17903 RVA: 0x00161DA8 File Offset: 0x0015FFA8
		[Token(Token = "0x170007DC")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045EF")]
			[Address(RVA = "0x84AB50", Offset = "0x849150", VA = "0x18084AB50", Slot = "12")]
			get
			{
				return AdvBuff.Random_小复制;
			}
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00161DBC File Offset: 0x0015FFBC
		[Token(Token = "0x60045F0")]
		[Address(RVA = "0x84AA70", Offset = "0x849070", VA = "0x18084AA70", Slot = "13")]
		public override string GetDescription()
		{
			return "小复制：立即获得5张模仿者卡牌";
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00161DD0 File Offset: 0x0015FFD0
		[Token(Token = "0x60045F1")]
		[Address(RVA = "0x84AAA0", Offset = "0x8490A0", VA = "0x18084AAA0", Slot = "17")]
		public override void OnSelect(Board board)
		{
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00161DE0 File Offset: 0x0015FFE0
		[Token(Token = "0x60045F2")]
		[Address(RVA = "0x84AB10", Offset = "0x849110", VA = "0x18084AB10")]
		public Random_小复制()
		{
		}
	}
}
