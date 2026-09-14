using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AAA RID: 2730
	[Token(Token = "0x2000AAA")]
	public class Garlic : PlantData
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060037FE RID: 14334 RVA: 0x0012BD88 File Offset: 0x00129F88
		[Token(Token = "0x170002A2")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037FE")]
			[Address(RVA = "0x71BFF0", Offset = "0x71A5F0", VA = "0x18071BFF0", Slot = "4")]
			get
			{
				return PlantType.Garlic;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x0012BD98 File Offset: 0x00129F98
		[Token(Token = "0x170002A3")]
		public override string Title
		{
			[Token(Token = "0x60037FF")]
			[Address(RVA = "0x7D1E90", Offset = "0x7D0490", VA = "0x1807D1E90", Slot = "5")]
			get
			{
				return "蒜毒骤发";
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06003800 RID: 14336 RVA: 0x0012BDAC File Offset: 0x00129FAC
		[Token(Token = "0x170002A4")]
		public override string Description
		{
			[Token(Token = "0x6003800")]
			[Address(RVA = "0x7D1CF0", Offset = "0x7D02F0", VA = "0x1807D1CF0", Slot = "6")]
			get
			{
				return "被敌人啃食时，令敌人进入中毒效果";
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x0012BDC0 File Offset: 0x00129FC0
		[Token(Token = "0x170002A5")]
		public override int Cost
		{
			[Token(Token = "0x6003801")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x0012BDD0 File Offset: 0x00129FD0
		[Token(Token = "0x170002A6")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003802")]
			[Address(RVA = "0x7D1D20", Offset = "0x7D0320", VA = "0x1807D1D20", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x0012BE14 File Offset: 0x0012A014
		[Token(Token = "0x6003803")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Garlic()
		{
		}
	}
}
