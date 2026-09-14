using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A68 RID: 2664
	[Token(Token = "0x2000A68")]
	public class ElectricOnion : PlantData
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x00126A28 File Offset: 0x00124C28
		[Token(Token = "0x17000250")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036AE")]
			[Address(RVA = "0x6A3F60", Offset = "0x6A2560", VA = "0x1806A3F60", Slot = "4")]
			get
			{
				return PlantType.ElectricOnion;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x00126A38 File Offset: 0x00124C38
		[Token(Token = "0x17000251")]
		public override string Title
		{
			[Token(Token = "0x60036AF")]
			[Address(RVA = "0x76A800", Offset = "0x768E00", VA = "0x18076A800", Slot = "5")]
			get
			{
				return "高能射线";
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x00126A4C File Offset: 0x00124C4C
		[Token(Token = "0x17000252")]
		public override string Description
		{
			[Token(Token = "0x60036B0")]
			[Address(RVA = "0x76A6B0", Offset = "0x768CB0", VA = "0x18076A6B0", Slot = "6")]
			get
			{
				return "子弹可弹射更多次数，并使目标陷入可叠加的感电";
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x00126A60 File Offset: 0x00124C60
		[Token(Token = "0x17000253")]
		public override int Cost
		{
			[Token(Token = "0x60036B1")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x00126A70 File Offset: 0x00124C70
		[Token(Token = "0x17000254")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036B2")]
			[Address(RVA = "0x76A6E0", Offset = "0x768CE0", VA = "0x18076A6E0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x00126AAC File Offset: 0x00124CAC
		[Token(Token = "0x60036B3")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ElectricOnion()
		{
		}
	}
}
