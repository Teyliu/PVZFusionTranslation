using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DC1 RID: 3521
	[Token(Token = "0x2000DC1")]
	public class Random_鱼丸护体 : BaseBuff<AdvBuff>
	{
		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x0016B6A8 File Offset: 0x001698A8
		[Token(Token = "0x17000931")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004935")]
			[Address(RVA = "0x88CD90", Offset = "0x88B390", VA = "0x18088CD90", Slot = "12")]
			get
			{
				return AdvBuff.Random_鱼丸护体;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x0016B6BC File Offset: 0x001698BC
		[Token(Token = "0x17000932")]
		public override string Description
		{
			[Token(Token = "0x6004936")]
			[Address(RVA = "0x8B2C70", Offset = "0x8B1270", VA = "0x1808B2C70", Slot = "13")]
			get
			{
				return "鱼丸护体：立即获得3个超级机械保龄球卡牌，该植物拥有64万初始血量";
			}
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x0016B6D0 File Offset: 0x001698D0
		[Token(Token = "0x6004937")]
		[Address(RVA = "0x8B2890", Offset = "0x8B0E90", VA = "0x1808B2890", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action<Plant> <>9__4_ = Random_鱼丸护体.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				Action<Plant> action;
				Random_鱼丸护体.<>c.<>9__4_0 = action;
			}
			DroppedCard droppedCard;
			droppedCard.plantAction = <>9__4_;
			Action<Plant> action2;
			if (Random_鱼丸护体.<>c.<>9__4_1 == 0)
			{
				Random_鱼丸护体.<>c.<>9__4_1 = action2;
			}
			DroppedCard droppedCard2;
			droppedCard2.plantAction = action2;
			Action<Plant> action3;
			if (Random_鱼丸护体.<>c.<>9__4_2 == 0)
			{
				Random_鱼丸护体.<>c.<>9__4_2 = action3;
			}
			DroppedCard droppedCard3;
			droppedCard3.plantAction = action3;
			throw new NullReferenceException();
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x0016B72C File Offset: 0x0016992C
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x8B2C30", Offset = "0x8B1230", VA = "0x1808B2C30")]
		public Random_鱼丸护体()
		{
		}
	}
}
