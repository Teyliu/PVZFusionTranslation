using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000CFF RID: 3327
	[Token(Token = "0x2000CFF")]
	public class Random_应有尽有 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x001615A0 File Offset: 0x0015F7A0
		[Token(Token = "0x170007D1")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045AB")]
			[Address(RVA = "0x84AD40", Offset = "0x849340", VA = "0x18084AD40", Slot = "12")]
			get
			{
				return AdvBuff.Random_应有尽有;
			}
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x001615B4 File Offset: 0x0015F7B4
		[Token(Token = "0x60045AC")]
		[Address(RVA = "0x84AB60", Offset = "0x849160", VA = "0x18084AB60", Slot = "13")]
		public override string GetDescription()
		{
			return "应有尽有：获得一个南瓜箱子，里面装有非常多的究极植物";
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x001615C8 File Offset: 0x0015F7C8
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x84AB90", Offset = "0x849190", VA = "0x18084AB90", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action<Plant> <>9__3_ = Random_应有尽有.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Action<Plant> action;
				Random_应有尽有.<>c.<>9__3_0 = action;
			}
			DroppedCard droppedCard;
			droppedCard.plantAction = <>9__3_;
			throw new NullReferenceException();
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x001615F4 File Offset: 0x0015F7F4
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x84AD00", Offset = "0x849300", VA = "0x18084AD00")]
		public Random_应有尽有()
		{
		}
	}
}
