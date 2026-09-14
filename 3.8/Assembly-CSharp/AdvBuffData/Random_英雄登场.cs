using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000D02 RID: 3330
	[Token(Token = "0x2000D02")]
	public class Random_英雄登场 : BaseBuff<AdvBuff>
	{
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x001616CC File Offset: 0x0015F8CC
		[Token(Token = "0x170007D3")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x60045B6")]
			[Address(RVA = "0x84B8F0", Offset = "0x849EF0", VA = "0x18084B8F0", Slot = "12")]
			get
			{
				return AdvBuff.Random_英雄登场;
			}
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x001616E0 File Offset: 0x0015F8E0
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x84B6D0", Offset = "0x849CD0", VA = "0x18084B6D0", Slot = "13")]
		public override string GetDescription()
		{
			return "英雄登场：获得一个超级寒冰机枪射手，他额外具有1500%伤害、血量加成，1000%速度加成，并获得一个极寒冰豆";
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x001616F4 File Offset: 0x0015F8F4
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x84B700", Offset = "0x849D00", VA = "0x18084B700", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action<Plant> <>9__3_ = Random_英雄登场.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Action<Plant> action;
				Random_英雄登场.<>c.<>9__3_0 = action;
			}
			DroppedCard droppedCard;
			droppedCard.plantAction = <>9__3_;
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00161720 File Offset: 0x0015F920
		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x84B8B0", Offset = "0x849EB0", VA = "0x18084B8B0")]
		public Random_英雄登场()
		{
		}
	}
}
