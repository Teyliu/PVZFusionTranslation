using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB3 RID: 2739
	[Token(Token = "0x2000AB3")]
	public class Cornpult : PlantData
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x0012C2FC File Offset: 0x0012A4FC
		[Token(Token = "0x170002CF")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003834")]
			[Address(RVA = "0x71BBC0", Offset = "0x71A1C0", VA = "0x18071BBC0", Slot = "4")]
			get
			{
				return PlantType.Cornpult;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x0012C30C File Offset: 0x0012A50C
		[Token(Token = "0x170002D0")]
		public override string Title
		{
			[Token(Token = "0x6003835")]
			[Address(RVA = "0x7CF1A0", Offset = "0x7CD7A0", VA = "0x1807CF1A0", Slot = "5")]
			get
			{
				return "黄油投手";
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x0012C320 File Offset: 0x0012A520
		[Token(Token = "0x170002D1")]
		public override string Description
		{
			[Token(Token = "0x6003836")]
			[Address(RVA = "0x7CF000", Offset = "0x7CD600", VA = "0x1807CF000", Slot = "6")]
			get
			{
				return "黄油概率提高，被黄油命中的僵尸会成为追踪子弹的集火目标";
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x0012C334 File Offset: 0x0012A534
		[Token(Token = "0x170002D2")]
		public override int Cost
		{
			[Token(Token = "0x6003837")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06003838 RID: 14392 RVA: 0x0012C344 File Offset: 0x0012A544
		[Token(Token = "0x170002D3")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003838")]
			[Address(RVA = "0x7CF030", Offset = "0x7CD630", VA = "0x1807CF030", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x0012C388 File Offset: 0x0012A588
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Cornpult()
		{
		}
	}
}
