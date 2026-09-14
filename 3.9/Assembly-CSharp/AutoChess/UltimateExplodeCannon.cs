using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AE2 RID: 2786
	[Token(Token = "0x2000AE2")]
	public class UltimateExplodeCannon : PlantData
	{
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x0012DFF8 File Offset: 0x0012C1F8
		[Token(Token = "0x170003BA")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600394E")]
			[Address(RVA = "0x7E84A0", Offset = "0x7E6AA0", VA = "0x1807E84A0", Slot = "4")]
			get
			{
				return PlantType.UltimateExplodeCannon;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x0012E00C File Offset: 0x0012C20C
		[Token(Token = "0x170003BB")]
		public override string Title
		{
			[Token(Token = "0x600394F")]
			[Address(RVA = "0x7E85D0", Offset = "0x7E6BD0", VA = "0x1807E85D0", Slot = "5")]
			get
			{
				return "力量会给予希望";
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x0012E020 File Offset: 0x0012C220
		[Token(Token = "0x170003BC")]
		public override string Description
		{
			[Token(Token = "0x6003950")]
			[Address(RVA = "0x7E8470", Offset = "0x7E6A70", VA = "0x1807E8470", Slot = "6")]
			get
			{
				return "每个一段时间获得一个究极红温帝果";
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x0012E034 File Offset: 0x0012C234
		[Token(Token = "0x170003BD")]
		public override int Cost
		{
			[Token(Token = "0x6003951")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x0012E044 File Offset: 0x0012C244
		[Token(Token = "0x170003BE")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003952")]
			[Address(RVA = "0x7E84B0", Offset = "0x7E6AB0", VA = "0x1807E84B0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x0012E080 File Offset: 0x0012C280
		[Token(Token = "0x6003953")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateExplodeCannon()
		{
		}
	}
}
