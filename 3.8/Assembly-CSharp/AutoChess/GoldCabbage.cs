using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A79 RID: 2681
	[Token(Token = "0x2000A79")]
	public class GoldCabbage : PlantData
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x00127484 File Offset: 0x00125684
		[Token(Token = "0x170002A5")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003714")]
			[Address(RVA = "0x76B240", Offset = "0x769840", VA = "0x18076B240", Slot = "4")]
			get
			{
				return PlantType.GoldCabbage;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x00127498 File Offset: 0x00125698
		[Token(Token = "0x170002A6")]
		public override string Title
		{
			[Token(Token = "0x6003715")]
			[Address(RVA = "0x76B3C0", Offset = "0x7699C0", VA = "0x18076B3C0", Slot = "5")]
			get
			{
				return "菜菜与共";
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x001274AC File Offset: 0x001256AC
		[Token(Token = "0x170002A7")]
		public override string Description
		{
			[Token(Token = "0x6003716")]
			[Address(RVA = "0x76B210", Offset = "0x769810", VA = "0x18076B210", Slot = "6")]
			get
			{
				return "命中目标后为我方小队叠加增益，大招造成额外伤害";
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06003717 RID: 14103 RVA: 0x001274C0 File Offset: 0x001256C0
		[Token(Token = "0x170002A8")]
		public override int Cost
		{
			[Token(Token = "0x6003717")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x001274D0 File Offset: 0x001256D0
		[Token(Token = "0x170002A9")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003718")]
			[Address(RVA = "0x76B250", Offset = "0x769850", VA = "0x18076B250", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00127514 File Offset: 0x00125714
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public GoldCabbage()
		{
		}
	}
}
