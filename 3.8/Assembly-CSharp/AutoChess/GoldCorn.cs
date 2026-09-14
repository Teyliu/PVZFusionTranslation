using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	public class GoldCorn : PlantData
	{
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x00127AC4 File Offset: 0x00125CC4
		[Token(Token = "0x170002D7")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003750")]
			[Address(RVA = "0x76B420", Offset = "0x769A20", VA = "0x18076B420", Slot = "4")]
			get
			{
				return PlantType.GoldCorn;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x00127AD8 File Offset: 0x00125CD8
		[Token(Token = "0x170002D8")]
		public override string Title
		{
			[Token(Token = "0x6003751")]
			[Address(RVA = "0x76B550", Offset = "0x769B50", VA = "0x18076B550", Slot = "5")]
			get
			{
				return "石破天惊";
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x00127AEC File Offset: 0x00125CEC
		[Token(Token = "0x170002D9")]
		public override string Description
		{
			[Token(Token = "0x6003752")]
			[Address(RVA = "0x76B3F0", Offset = "0x7699F0", VA = "0x18076B3F0", Slot = "6")]
			get
			{
				return "我方小队其他目标释放大招后，使玉米的大招能发射更多子弹";
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x00127B00 File Offset: 0x00125D00
		[Token(Token = "0x170002DA")]
		public override int Cost
		{
			[Token(Token = "0x6003753")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x00127B10 File Offset: 0x00125D10
		[Token(Token = "0x170002DB")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003754")]
			[Address(RVA = "0x76B430", Offset = "0x769A30", VA = "0x18076B430", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00127B4C File Offset: 0x00125D4C
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public GoldCorn()
		{
		}
	}
}
