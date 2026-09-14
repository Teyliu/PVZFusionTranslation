using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AAC RID: 2732
	[Token(Token = "0x2000AAC")]
	public class Marigold : PlantData
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x0012BEC0 File Offset: 0x0012A0C0
		[Token(Token = "0x170002AC")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600380A")]
			[Address(RVA = "0x71D2D0", Offset = "0x71B8D0", VA = "0x18071D2D0", Slot = "4")]
			get
			{
				return PlantType.Marigold;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x0012BED0 File Offset: 0x0012A0D0
		[Token(Token = "0x170002AD")]
		public override string Title
		{
			[Token(Token = "0x600380B")]
			[Address(RVA = "0x7D33C0", Offset = "0x7D19C0", VA = "0x1807D33C0", Slot = "5")]
			get
			{
				return "玉石俱焚";
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600380C RID: 14348 RVA: 0x0012BEE4 File Offset: 0x0012A0E4
		[Token(Token = "0x170002AE")]
		public override string Description
		{
			[Token(Token = "0x600380C")]
			[Address(RVA = "0x7D3220", Offset = "0x7D1820", VA = "0x1807D3220", Slot = "6")]
			get
			{
				return "可以使用金咖啡豆释放大招，为我方植物积攒能力，并使其攻击力提高";
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x0012BEF8 File Offset: 0x0012A0F8
		[Token(Token = "0x170002AF")]
		public override int Cost
		{
			[Token(Token = "0x600380D")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x0012BF08 File Offset: 0x0012A108
		[Token(Token = "0x170002B0")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600380E")]
			[Address(RVA = "0x7D3250", Offset = "0x7D1850", VA = "0x1807D3250", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x0012BF4C File Offset: 0x0012A14C
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Marigold()
		{
		}
	}
}
