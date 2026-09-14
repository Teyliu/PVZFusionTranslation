using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A6A RID: 2666
	[Token(Token = "0x2000A6A")]
	public class Garlic : PlantData
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060036BA RID: 14010 RVA: 0x00126B58 File Offset: 0x00124D58
		[Token(Token = "0x1700025A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036BA")]
			[Address(RVA = "0x6A1E90", Offset = "0x6A0490", VA = "0x1806A1E90", Slot = "4")]
			get
			{
				return PlantType.Garlic;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060036BB RID: 14011 RVA: 0x00126B68 File Offset: 0x00124D68
		[Token(Token = "0x1700025B")]
		public override string Title
		{
			[Token(Token = "0x60036BB")]
			[Address(RVA = "0x76B050", Offset = "0x769650", VA = "0x18076B050", Slot = "5")]
			get
			{
				return "蒜毒骤发";
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x00126B7C File Offset: 0x00124D7C
		[Token(Token = "0x1700025C")]
		public override string Description
		{
			[Token(Token = "0x60036BC")]
			[Address(RVA = "0x76AEB0", Offset = "0x7694B0", VA = "0x18076AEB0", Slot = "6")]
			get
			{
				return "被敌人啃食时，令敌人进入中毒效果";
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x00126B90 File Offset: 0x00124D90
		[Token(Token = "0x1700025D")]
		public override int Cost
		{
			[Token(Token = "0x60036BD")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x00126BA0 File Offset: 0x00124DA0
		[Token(Token = "0x1700025E")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036BE")]
			[Address(RVA = "0x76AEE0", Offset = "0x7694E0", VA = "0x18076AEE0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00126BE4 File Offset: 0x00124DE4
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Garlic()
		{
		}
	}
}
