using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A7C RID: 2684
	[Token(Token = "0x2000A7C")]
	public class EndoFlame : PlantData
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06003726 RID: 14118 RVA: 0x00127668 File Offset: 0x00125868
		[Token(Token = "0x170002B4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003726")]
			[Address(RVA = "0x76AB70", Offset = "0x769170", VA = "0x18076AB70", Slot = "4")]
			get
			{
				return PlantType.EndoFlame;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x0012767C File Offset: 0x0012587C
		[Token(Token = "0x170002B5")]
		public override string Title
		{
			[Token(Token = "0x6003727")]
			[Address(RVA = "0x76ACF0", Offset = "0x7692F0", VA = "0x18076ACF0", Slot = "5")]
			get
			{
				return "高效肥料";
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x00127690 File Offset: 0x00125890
		[Token(Token = "0x170002B6")]
		public override string Description
		{
			[Token(Token = "0x6003728")]
			[Address(RVA = "0x76AB40", Offset = "0x769140", VA = "0x18076AB40", Slot = "6")]
			get
			{
				return "不再因为生成肥料而消失，但有冷却时间";
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x001276A4 File Offset: 0x001258A4
		[Token(Token = "0x170002B7")]
		public override int Cost
		{
			[Token(Token = "0x6003729")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x001276B4 File Offset: 0x001258B4
		[Token(Token = "0x170002B8")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600372A")]
			[Address(RVA = "0x76AB80", Offset = "0x769180", VA = "0x18076AB80", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x001276F8 File Offset: 0x001258F8
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public EndoFlame()
		{
		}
	}
}
