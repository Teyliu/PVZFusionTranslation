using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	public class Chomper : PlantData
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x0012716C File Offset: 0x0012536C
		[Token(Token = "0x1700028C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036F6")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "4")]
			get
			{
				return PlantType.Chomper;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060036F7 RID: 14071 RVA: 0x0012717C File Offset: 0x0012537C
		[Token(Token = "0x1700028D")]
		public override string Title
		{
			[Token(Token = "0x60036F7")]
			[Address(RVA = "0x767FB0", Offset = "0x7665B0", VA = "0x180767FB0", Slot = "5")]
			get
			{
				return "大嘴一咬，福祸自招";
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x00127190 File Offset: 0x00125390
		[Token(Token = "0x1700028E")]
		public override string Description
		{
			[Token(Token = "0x60036F8")]
			[Address(RVA = "0x767E60", Offset = "0x766460", VA = "0x180767E60", Slot = "6")]
			get
			{
				return "吞噬僵尸可时战神行动提前";
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060036F9 RID: 14073 RVA: 0x001271A4 File Offset: 0x001253A4
		[Token(Token = "0x1700028F")]
		public override int Cost
		{
			[Token(Token = "0x60036F9")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x001271B4 File Offset: 0x001253B4
		[Token(Token = "0x17000290")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036FA")]
			[Address(RVA = "0x767E90", Offset = "0x766490", VA = "0x180767E90", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x001271F0 File Offset: 0x001253F0
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Chomper()
		{
		}
	}
}
