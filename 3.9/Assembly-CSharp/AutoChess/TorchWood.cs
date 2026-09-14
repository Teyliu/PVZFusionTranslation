using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB1 RID: 2737
	[Token(Token = "0x2000AB1")]
	public class TorchWood : PlantData
	{
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x0012C1C8 File Offset: 0x0012A3C8
		[Token(Token = "0x170002C5")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003828")]
			[Address(RVA = "0x715C90", Offset = "0x714290", VA = "0x180715C90", Slot = "4")]
			get
			{
				return PlantType.TorchWood;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x0012C1D8 File Offset: 0x0012A3D8
		[Token(Token = "0x170002C6")]
		public override string Title
		{
			[Token(Token = "0x6003829")]
			[Address(RVA = "0x7E5C40", Offset = "0x7E4240", VA = "0x1807E5C40", Slot = "5")]
			get
			{
				return "高温灼烧";
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600382A RID: 14378 RVA: 0x0012C1EC File Offset: 0x0012A3EC
		[Token(Token = "0x170002C7")]
		public override string Description
		{
			[Token(Token = "0x600382A")]
			[Address(RVA = "0x7E5AF0", Offset = "0x7E40F0", VA = "0x1807E5AF0", Slot = "6")]
			get
			{
				return "点燃的豌豆升至红火状态";
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x0012C200 File Offset: 0x0012A400
		[Token(Token = "0x170002C8")]
		public override int Cost
		{
			[Token(Token = "0x600382B")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x0012C210 File Offset: 0x0012A410
		[Token(Token = "0x170002C9")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600382C")]
			[Address(RVA = "0x7E5B20", Offset = "0x7E4120", VA = "0x1807E5B20", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x0012C24C File Offset: 0x0012A44C
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public TorchWood()
		{
		}
	}
}
