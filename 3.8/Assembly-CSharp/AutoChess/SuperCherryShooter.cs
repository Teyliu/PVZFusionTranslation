using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x2000A8B")]
	public class SuperCherryShooter : PlantData
	{
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x00127FB4 File Offset: 0x001261B4
		[Token(Token = "0x170002FF")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003780")]
			[Address(RVA = "0x3AE5A0", Offset = "0x3ACBA0", VA = "0x1803AE5A0", Slot = "4")]
			get
			{
				return PlantType.SuperCherryShooter;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x00127FC8 File Offset: 0x001261C8
		[Token(Token = "0x17000300")]
		public override string Title
		{
			[Token(Token = "0x6003781")]
			[Address(RVA = "0x778D30", Offset = "0x777330", VA = "0x180778D30", Slot = "5")]
			get
			{
				return "护你左右";
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06003782 RID: 14210 RVA: 0x00127FDC File Offset: 0x001261DC
		[Token(Token = "0x17000301")]
		public override string Description
		{
			[Token(Token = "0x6003782")]
			[Address(RVA = "0x778BE0", Offset = "0x7771E0", VA = "0x180778BE0", Slot = "6")]
			get
			{
				return "造成更高的伤害，我方小队造成的伤害提高";
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x00127FF0 File Offset: 0x001261F0
		[Token(Token = "0x17000302")]
		public override int Cost
		{
			[Token(Token = "0x6003783")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06003784 RID: 14212 RVA: 0x00128000 File Offset: 0x00126200
		[Token(Token = "0x17000303")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003784")]
			[Address(RVA = "0x778C10", Offset = "0x777210", VA = "0x180778C10", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x0012803C File Offset: 0x0012623C
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public SuperCherryShooter()
		{
		}
	}
}
