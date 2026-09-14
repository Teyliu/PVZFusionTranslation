using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AAD RID: 2733
	[Token(Token = "0x2000AAD")]
	public class Plantern : PlantData
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x0012BF60 File Offset: 0x0012A160
		[Token(Token = "0x170002B1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003810")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "4")]
			get
			{
				return PlantType.Plantern;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x0012BF70 File Offset: 0x0012A170
		[Token(Token = "0x170002B2")]
		public override string Title
		{
			[Token(Token = "0x6003811")]
			[Address(RVA = "0x7D7170", Offset = "0x7D5770", VA = "0x1807D7170", Slot = "5")]
			get
			{
				return "燎烟古方";
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06003812 RID: 14354 RVA: 0x0012BF84 File Offset: 0x0012A184
		[Token(Token = "0x170002B3")]
		public override string Description
		{
			[Token(Token = "0x6003812")]
			[Address(RVA = "0x7D6FD0", Offset = "0x7D55D0", VA = "0x1807D6FD0", Slot = "6")]
			get
			{
				return "我方小队攻击敌人后，治疗我方低生命值目标";
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x0012BF98 File Offset: 0x0012A198
		[Token(Token = "0x170002B4")]
		public override int Cost
		{
			[Token(Token = "0x6003813")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x0012BFA8 File Offset: 0x0012A1A8
		[Token(Token = "0x170002B5")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003814")]
			[Address(RVA = "0x7D7000", Offset = "0x7D5600", VA = "0x1807D7000", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x0012BFEC File Offset: 0x0012A1EC
		[Token(Token = "0x6003815")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Plantern()
		{
		}
	}
}
