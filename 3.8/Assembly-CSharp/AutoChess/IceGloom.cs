using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A89 RID: 2697
	[Token(Token = "0x2000A89")]
	public class IceGloom : PlantData
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06003774 RID: 14196 RVA: 0x00127E74 File Offset: 0x00126074
		[Token(Token = "0x170002F5")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003774")]
			[Address(RVA = "0x76B920", Offset = "0x769F20", VA = "0x18076B920", Slot = "4")]
			get
			{
				return PlantType.IceGloom;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06003775 RID: 14197 RVA: 0x00127E88 File Offset: 0x00126088
		[Token(Token = "0x170002F6")]
		public override string Title
		{
			[Token(Token = "0x6003775")]
			[Address(RVA = "0x76BA50", Offset = "0x76A050", VA = "0x18076BA50", Slot = "5")]
			get
			{
				return "飞雷紫";
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x00127E9C File Offset: 0x0012609C
		[Token(Token = "0x170002F7")]
		public override string Description
		{
			[Token(Token = "0x6003776")]
			[Address(RVA = "0x76B8F0", Offset = "0x769EF0", VA = "0x18076B8F0", Slot = "6")]
			get
			{
				return "对陷入减速状态的敌人施加标记，攻击消耗标记造成额外伤害，攻击范围提高";
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06003777 RID: 14199 RVA: 0x00127EB0 File Offset: 0x001260B0
		[Token(Token = "0x170002F8")]
		public override int Cost
		{
			[Token(Token = "0x6003777")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x00127EC0 File Offset: 0x001260C0
		[Token(Token = "0x170002F9")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003778")]
			[Address(RVA = "0x76B930", Offset = "0x769F30", VA = "0x18076B930", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x00127EFC File Offset: 0x001260FC
		[Token(Token = "0x6003779")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public IceGloom()
		{
		}
	}
}
