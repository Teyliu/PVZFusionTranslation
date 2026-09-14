using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB0 RID: 2736
	[Token(Token = "0x2000AB0")]
	public class ThreePeater : PlantData
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x0012C130 File Offset: 0x0012A330
		[Token(Token = "0x170002C0")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003822")]
			[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "4")]
			get
			{
				return PlantType.ThreePeater;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06003823 RID: 14371 RVA: 0x0012C140 File Offset: 0x0012A340
		[Token(Token = "0x170002C1")]
		public override string Title
		{
			[Token(Token = "0x6003823")]
			[Address(RVA = "0x7E5AC0", Offset = "0x7E40C0", VA = "0x1807E5AC0", Slot = "5")]
			get
			{
				return "三重打击";
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06003824 RID: 14372 RVA: 0x0012C154 File Offset: 0x0012A354
		[Token(Token = "0x170002C2")]
		public override string Description
		{
			[Token(Token = "0x6003824")]
			[Address(RVA = "0x7E5970", Offset = "0x7E3F70", VA = "0x1807E5970", Slot = "6")]
			get
			{
				return "每次发射的豆量提高";
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x0012C168 File Offset: 0x0012A368
		[Token(Token = "0x170002C3")]
		public override int Cost
		{
			[Token(Token = "0x6003825")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x0012C178 File Offset: 0x0012A378
		[Token(Token = "0x170002C4")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003826")]
			[Address(RVA = "0x7E59A0", Offset = "0x7E3FA0", VA = "0x1807E59A0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x0012C1B4 File Offset: 0x0012A3B4
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ThreePeater()
		{
		}
	}
}
