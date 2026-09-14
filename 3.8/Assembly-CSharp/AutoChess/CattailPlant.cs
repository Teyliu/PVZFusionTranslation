using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000A88")]
	public class CattailPlant : PlantData
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600376E RID: 14190 RVA: 0x00127DD0 File Offset: 0x00125FD0
		[Token(Token = "0x170002F0")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600376E")]
			[Address(RVA = "0x767B20", Offset = "0x766120", VA = "0x180767B20", Slot = "4")]
			get
			{
				return PlantType.CattailPlant;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x00127DE4 File Offset: 0x00125FE4
		[Token(Token = "0x170002F1")]
		public override string Title
		{
			[Token(Token = "0x600376F")]
			[Address(RVA = "0x767CA0", Offset = "0x7662A0", VA = "0x180767CA0", Slot = "5")]
			get
			{
				return "饱和式提问";
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x00127DF8 File Offset: 0x00125FF8
		[Token(Token = "0x170002F2")]
		public override string Description
		{
			[Token(Token = "0x6003770")]
			[Address(RVA = "0x767AF0", Offset = "0x7660F0", VA = "0x180767AF0", Slot = "6")]
			get
			{
				return "攻击可以使敌人易伤，并触发多次射击";
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06003771 RID: 14193 RVA: 0x00127E0C File Offset: 0x0012600C
		[Token(Token = "0x170002F3")]
		public override int Cost
		{
			[Token(Token = "0x6003771")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x00127E1C File Offset: 0x0012601C
		[Token(Token = "0x170002F4")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003772")]
			[Address(RVA = "0x767B30", Offset = "0x766130", VA = "0x180767B30", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00127E60 File Offset: 0x00126060
		[Token(Token = "0x6003773")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public CattailPlant()
		{
		}
	}
}
