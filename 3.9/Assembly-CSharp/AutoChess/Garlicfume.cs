using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB5 RID: 2741
	[Token(Token = "0x2000AB5")]
	public class Garlicfume : PlantData
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06003840 RID: 14400 RVA: 0x0012C434 File Offset: 0x0012A634
		[Token(Token = "0x170002D9")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003840")]
			[Address(RVA = "0x7D1EF0", Offset = "0x7D04F0", VA = "0x1807D1EF0", Slot = "4")]
			get
			{
				return PlantType.GarlicFume;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x0012C448 File Offset: 0x0012A648
		[Token(Token = "0x170002DA")]
		public override string Title
		{
			[Token(Token = "0x6003841")]
			[Address(RVA = "0x7D2020", Offset = "0x7D0620", VA = "0x1807D2020", Slot = "5")]
			get
			{
				return "浓墨的喷";
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06003842 RID: 14402 RVA: 0x0012C45C File Offset: 0x0012A65C
		[Token(Token = "0x170002DB")]
		public override string Description
		{
			[Token(Token = "0x6003842")]
			[Address(RVA = "0x7D1EC0", Offset = "0x7D04C0", VA = "0x1807D1EC0", Slot = "6")]
			get
			{
				return "攻击会使蒜毒伤害立即结算一次";
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06003843 RID: 14403 RVA: 0x0012C470 File Offset: 0x0012A670
		[Token(Token = "0x170002DC")]
		public override int Cost
		{
			[Token(Token = "0x6003843")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06003844 RID: 14404 RVA: 0x0012C480 File Offset: 0x0012A680
		[Token(Token = "0x170002DD")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003844")]
			[Address(RVA = "0x7D1F00", Offset = "0x7D0500", VA = "0x1807D1F00", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0012C4BC File Offset: 0x0012A6BC
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Garlicfume()
		{
		}
	}
}
