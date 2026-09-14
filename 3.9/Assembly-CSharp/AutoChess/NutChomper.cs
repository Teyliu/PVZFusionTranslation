using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB7 RID: 2743
	[Token(Token = "0x2000AB7")]
	public class NutChomper : PlantData
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600384C RID: 14412 RVA: 0x0012C56C File Offset: 0x0012A76C
		[Token(Token = "0x170002E3")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600384C")]
			[Address(RVA = "0x3F8A60", Offset = "0x3F7060", VA = "0x1803F8A60", Slot = "4")]
			get
			{
				return PlantType.NutChomper;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x0012C580 File Offset: 0x0012A780
		[Token(Token = "0x170002E4")]
		public override string Title
		{
			[Token(Token = "0x600384D")]
			[Address(RVA = "0x7D4980", Offset = "0x7D2F80", VA = "0x1807D4980", Slot = "5")]
			get
			{
				return "破甲尖刺";
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600384E RID: 14414 RVA: 0x0012C594 File Offset: 0x0012A794
		[Token(Token = "0x170002E5")]
		public override string Description
		{
			[Token(Token = "0x600384E")]
			[Address(RVA = "0x7D47E0", Offset = "0x7D2DE0", VA = "0x1807D47E0", Slot = "6")]
			get
			{
				return "攻击会同时削减僵尸的护甲";
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x0012C5A8 File Offset: 0x0012A7A8
		[Token(Token = "0x170002E6")]
		public override int Cost
		{
			[Token(Token = "0x600384F")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x0012C5B8 File Offset: 0x0012A7B8
		[Token(Token = "0x170002E7")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003850")]
			[Address(RVA = "0x7D4810", Offset = "0x7D2E10", VA = "0x1807D4810", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x0012C5FC File Offset: 0x0012A7FC
		[Token(Token = "0x6003851")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public NutChomper()
		{
		}
	}
}
