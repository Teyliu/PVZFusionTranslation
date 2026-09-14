using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB9 RID: 2745
	[Token(Token = "0x2000AB9")]
	public class GoldCabbage : PlantData
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06003858 RID: 14424 RVA: 0x0012C6B4 File Offset: 0x0012A8B4
		[Token(Token = "0x170002ED")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003858")]
			[Address(RVA = "0x7D2080", Offset = "0x7D0680", VA = "0x1807D2080", Slot = "4")]
			get
			{
				return PlantType.GoldCabbage;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x0012C6C8 File Offset: 0x0012A8C8
		[Token(Token = "0x170002EE")]
		public override string Title
		{
			[Token(Token = "0x6003859")]
			[Address(RVA = "0x7D2200", Offset = "0x7D0800", VA = "0x1807D2200", Slot = "5")]
			get
			{
				return "菜菜与共";
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600385A RID: 14426 RVA: 0x0012C6DC File Offset: 0x0012A8DC
		[Token(Token = "0x170002EF")]
		public override string Description
		{
			[Token(Token = "0x600385A")]
			[Address(RVA = "0x7D2050", Offset = "0x7D0650", VA = "0x1807D2050", Slot = "6")]
			get
			{
				return "命中目标后为我方小队叠加增益，大招造成额外伤害";
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600385B RID: 14427 RVA: 0x0012C6F0 File Offset: 0x0012A8F0
		[Token(Token = "0x170002F0")]
		public override int Cost
		{
			[Token(Token = "0x600385B")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600385C RID: 14428 RVA: 0x0012C700 File Offset: 0x0012A900
		[Token(Token = "0x170002F1")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600385C")]
			[Address(RVA = "0x7D2090", Offset = "0x7D0690", VA = "0x1807D2090", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0012C744 File Offset: 0x0012A944
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public GoldCabbage()
		{
		}
	}
}
