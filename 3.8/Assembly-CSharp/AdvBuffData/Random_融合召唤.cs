using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D17 RID: 3351
	[Token(Token = "0x2000D17")]
	public class Random_融合召唤 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x00161EB8 File Offset: 0x001600B8
		[Token(Token = "0x170007DE")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045F9")]
			[Address(RVA = "0x84BCF0", Offset = "0x84A2F0", VA = "0x18084BCF0", Slot = "12")]
			get
			{
				return AdvBuff.Random_融合召唤;
			}
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00161ECC File Offset: 0x001600CC
		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x84BB60", Offset = "0x84A160", VA = "0x18084BB60", Slot = "13")]
		public override string GetDescription()
		{
			return "融合召唤：使用手套将一个植物移动到其他同星级同类型的植物上时，会将该植物提升1级";
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00161EE0 File Offset: 0x001600E0
		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x84BB90", Offset = "0x84A190", VA = "0x18084BB90", Slot = "17")]
		public override void OnSelect(Board board)
		{
			if (Random_融合召唤.<>c.<>9__3_0 == 0)
			{
				Action<object> action;
				Random_融合召唤.<>c.<>9__3_0 = action;
			}
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00161EFC File Offset: 0x001600FC
		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x84A4D0", Offset = "0x848AD0", VA = "0x18084A4D0", Slot = "15")]
		public override void OnBoardStart(Board board)
		{
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00161F0C File Offset: 0x0016010C
		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x84BCB0", Offset = "0x84A2B0", VA = "0x18084BCB0")]
		public Random_融合召唤()
		{
		}
	}
}
