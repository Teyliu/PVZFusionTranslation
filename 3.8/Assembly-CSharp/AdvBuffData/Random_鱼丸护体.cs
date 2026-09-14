using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000CF9 RID: 3321
	[Token(Token = "0x2000CF9")]
	public class Random_鱼丸护体 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x00161278 File Offset: 0x0015F478
		[Token(Token = "0x170007CD")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004595")]
			[Address(RVA = "0x84C650", Offset = "0x84AC50", VA = "0x18084C650", Slot = "12")]
			get
			{
				return AdvBuff.Random_鱼丸护体;
			}
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x0016128C File Offset: 0x0015F48C
		[Token(Token = "0x6004596")]
		[Address(RVA = "0x84C360", Offset = "0x84A960", VA = "0x18084C360", Slot = "13")]
		public override string GetDescription()
		{
			return "鱼丸护体：立即获得2个超级机械保龄球卡牌，该植物拥有100万初始血量";
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x001612A0 File Offset: 0x0015F4A0
		[Token(Token = "0x6004597")]
		[Address(RVA = "0x84C390", Offset = "0x84A990", VA = "0x18084C390", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action<Plant> <>9__3_ = Random_鱼丸护体.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Action<Plant> action;
				Random_鱼丸护体.<>c.<>9__3_0 = action;
			}
			DroppedCard droppedCard;
			droppedCard.plantAction = <>9__3_;
			Action<Plant> action2;
			if (Random_鱼丸护体.<>c.<>9__3_1 == 0)
			{
				Random_鱼丸护体.<>c.<>9__3_1 = action2;
			}
			DroppedCard droppedCard2;
			droppedCard2.plantAction = action2;
			throw new NullReferenceException();
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x001612E4 File Offset: 0x0015F4E4
		[Token(Token = "0x6004598")]
		[Address(RVA = "0x84C610", Offset = "0x84AC10", VA = "0x18084C610")]
		public Random_鱼丸护体()
		{
		}
	}
}
