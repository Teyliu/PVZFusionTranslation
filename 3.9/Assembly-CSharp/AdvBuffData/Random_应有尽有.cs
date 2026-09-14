using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DC7 RID: 3527
	[Token(Token = "0x2000DC7")]
	public class Random_应有尽有 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x0016BA14 File Offset: 0x00169C14
		[Token(Token = "0x17000939")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600494C")]
			[Address(RVA = "0x88CB50", Offset = "0x88B150", VA = "0x18088CB50", Slot = "12")]
			get
			{
				return AdvBuff.Random_应有尽有;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x0016BA28 File Offset: 0x00169C28
		[Token(Token = "0x1700093A")]
		public override string Description
		{
			[Token(Token = "0x600494D")]
			[Address(RVA = "0x8B1920", Offset = "0x8AFF20", VA = "0x1808B1920", Slot = "13")]
			get
			{
				return "应有尽有：获得一个南瓜箱子，里面装有非常多的究极植物";
			}
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x0016BA3C File Offset: 0x00169C3C
		[Token(Token = "0x600494E")]
		[Address(RVA = "0x8B1770", Offset = "0x8AFD70", VA = "0x1808B1770", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action<Plant> <>9__4_ = Random_应有尽有.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				Action<Plant> action;
				Random_应有尽有.<>c.<>9__4_0 = action;
			}
			DroppedCard droppedCard;
			droppedCard.plantAction = <>9__4_;
			throw new NullReferenceException();
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x0016BA68 File Offset: 0x00169C68
		[Token(Token = "0x600494F")]
		[Address(RVA = "0x8B18E0", Offset = "0x8AFEE0", VA = "0x1808B18E0")]
		public Random_应有尽有()
		{
		}
	}
}
