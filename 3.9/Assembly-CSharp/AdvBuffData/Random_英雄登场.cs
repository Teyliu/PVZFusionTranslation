using System;
using Cpp2IlInjected;

namespace AdvBuffData
{
	// Token: 0x02000DCA RID: 3530
	[Token(Token = "0x2000DCA")]
	public class Random_英雄登场 : BaseBuff<AdvBuff>
	{
		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x0016BB40 File Offset: 0x00169D40
		[Token(Token = "0x1700093D")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004957")]
			[Address(RVA = "0x88C8C0", Offset = "0x88AEC0", VA = "0x18088C8C0", Slot = "12")]
			get
			{
				return AdvBuff.Random_英雄登场;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x0016BB54 File Offset: 0x00169D54
		[Token(Token = "0x1700093E")]
		public override string Description
		{
			[Token(Token = "0x6004958")]
			[Address(RVA = "0x8B22B0", Offset = "0x8B08B0", VA = "0x1808B22B0", Slot = "13")]
			get
			{
				return "英雄登场：获得一个超级寒冰机枪射手，他额外具有1500%伤害、血量加成，1000%速度加成，并获得一个极寒冰豆";
			}
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x0016BB68 File Offset: 0x00169D68
		[Token(Token = "0x6004959")]
		[Address(RVA = "0x8B20C0", Offset = "0x8B06C0", VA = "0x1808B20C0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action<Plant> <>9__4_ = Random_英雄登场.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				Action<Plant> action;
				Random_英雄登场.<>c.<>9__4_0 = action;
			}
			DroppedCard droppedCard;
			droppedCard.plantAction = <>9__4_;
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x0016BB94 File Offset: 0x00169D94
		[Token(Token = "0x600495A")]
		[Address(RVA = "0x8B2270", Offset = "0x8B0870", VA = "0x1808B2270")]
		public Random_英雄登场()
		{
		}
	}
}
