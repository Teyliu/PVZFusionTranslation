using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AE1 RID: 2785
	[Token(Token = "0x2000AE1")]
	public class UltimateCannon : PlantData
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0012DF5C File Offset: 0x0012C15C
		[Token(Token = "0x170003B5")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x7E7FF0", Offset = "0x7E65F0", VA = "0x1807E7FF0", Slot = "4")]
			get
			{
				return PlantType.UltimateCannon;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0012DF70 File Offset: 0x0012C170
		[Token(Token = "0x170003B6")]
		public override string Title
		{
			[Token(Token = "0x6003949")]
			[Address(RVA = "0x7E8120", Offset = "0x7E6720", VA = "0x1807E8120", Slot = "5")]
			get
			{
				return "爱与黄金";
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x0012DF84 File Offset: 0x0012C184
		[Token(Token = "0x170003B7")]
		public override string Description
		{
			[Token(Token = "0x600394A")]
			[Address(RVA = "0x7E7FC0", Offset = "0x7E65C0", VA = "0x1807E7FC0", Slot = "6")]
			get
			{
				return "进入战斗时获得追忆，并强化所有投手植物的角色赋能效果，获得词条绝对力量";
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x0012DF98 File Offset: 0x0012C198
		[Token(Token = "0x170003B8")]
		public override int Cost
		{
			[Token(Token = "0x600394B")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x0012DFA8 File Offset: 0x0012C1A8
		[Token(Token = "0x170003B9")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600394C")]
			[Address(RVA = "0x7E8000", Offset = "0x7E6600", VA = "0x1807E8000", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x0012DFE4 File Offset: 0x0012C1E4
		[Token(Token = "0x600394D")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateCannon()
		{
		}
	}
}
