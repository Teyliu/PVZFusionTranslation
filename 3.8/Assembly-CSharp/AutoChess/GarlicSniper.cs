using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A95 RID: 2709
	[Token(Token = "0x2000A95")]
	public class GarlicSniper : PlantData
	{
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x001285DC File Offset: 0x001267DC
		[Token(Token = "0x17000331")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037BC")]
			[Address(RVA = "0x76AD50", Offset = "0x769350", VA = "0x18076AD50", Slot = "4")]
			get
			{
				return PlantType.GarlicSniper;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060037BD RID: 14269 RVA: 0x001285F0 File Offset: 0x001267F0
		[Token(Token = "0x17000332")]
		public override string Title
		{
			[Token(Token = "0x60037BD")]
			[Address(RVA = "0x76AE80", Offset = "0x769480", VA = "0x18076AE80", Slot = "5")]
			get
			{
				return "深海回响";
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x00128604 File Offset: 0x00126804
		[Token(Token = "0x17000333")]
		public override string Description
		{
			[Token(Token = "0x60037BE")]
			[Address(RVA = "0x76AD20", Offset = "0x769320", VA = "0x18076AD20", Slot = "6")]
			get
			{
				return "攻击后为目标叠加持续蒜毒，并使地方被攻击后对范围内敌人额外造成持续蒜毒";
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x00128618 File Offset: 0x00126818
		[Token(Token = "0x17000334")]
		public override int Cost
		{
			[Token(Token = "0x60037BF")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x00128628 File Offset: 0x00126828
		[Token(Token = "0x17000335")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037C0")]
			[Address(RVA = "0x76AD60", Offset = "0x769360", VA = "0x18076AD60", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00128664 File Offset: 0x00126864
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public GarlicSniper()
		{
		}
	}
}
