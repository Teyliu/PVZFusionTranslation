using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000A80")]
	public class LanternPumpkin : PlantData
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x001278F0 File Offset: 0x00125AF0
		[Token(Token = "0x170002C8")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600373E")]
			[Address(RVA = "0x76BF60", Offset = "0x76A560", VA = "0x18076BF60", Slot = "4")]
			get
			{
				return PlantType.LanternPumpkin;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600373F RID: 14143 RVA: 0x00127904 File Offset: 0x00125B04
		[Token(Token = "0x170002C9")]
		public override string Title
		{
			[Token(Token = "0x600373F")]
			[Address(RVA = "0x76C090", Offset = "0x76A690", VA = "0x18076C090", Slot = "5")]
			get
			{
				return "龙灵在天";
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06003740 RID: 14144 RVA: 0x00127918 File Offset: 0x00125B18
		[Token(Token = "0x170002CA")]
		public override string Description
		{
			[Token(Token = "0x6003740")]
			[Address(RVA = "0x76BF30", Offset = "0x76A530", VA = "0x18076BF30", Slot = "6")]
			get
			{
				return "使队友获得龙灵，队友攻击时，获得基于光照等级的护盾";
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06003741 RID: 14145 RVA: 0x0012792C File Offset: 0x00125B2C
		[Token(Token = "0x170002CB")]
		public override int Cost
		{
			[Token(Token = "0x6003741")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x0012793C File Offset: 0x00125B3C
		[Token(Token = "0x170002CC")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003742")]
			[Address(RVA = "0x76BF70", Offset = "0x76A570", VA = "0x18076BF70", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00127978 File Offset: 0x00125B78
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public LanternPumpkin()
		{
		}
	}
}
