using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x2000A75")]
	public class Garlicfume : PlantData
	{
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x00127204 File Offset: 0x00125404
		[Token(Token = "0x17000291")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036FC")]
			[Address(RVA = "0x76B0B0", Offset = "0x7696B0", VA = "0x18076B0B0", Slot = "4")]
			get
			{
				return PlantType.GarlicFume;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x00127218 File Offset: 0x00125418
		[Token(Token = "0x17000292")]
		public override string Title
		{
			[Token(Token = "0x60036FD")]
			[Address(RVA = "0x76B1E0", Offset = "0x7697E0", VA = "0x18076B1E0", Slot = "5")]
			get
			{
				return "浓墨的喷";
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x0012722C File Offset: 0x0012542C
		[Token(Token = "0x17000293")]
		public override string Description
		{
			[Token(Token = "0x60036FE")]
			[Address(RVA = "0x76B080", Offset = "0x769680", VA = "0x18076B080", Slot = "6")]
			get
			{
				return "攻击会使蒜毒伤害立即结算一次";
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x00127240 File Offset: 0x00125440
		[Token(Token = "0x17000294")]
		public override int Cost
		{
			[Token(Token = "0x60036FF")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x00127250 File Offset: 0x00125450
		[Token(Token = "0x17000295")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003700")]
			[Address(RVA = "0x76B0C0", Offset = "0x7696C0", VA = "0x18076B0C0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x0012728C File Offset: 0x0012548C
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Garlicfume()
		{
		}
	}
}
