using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A77 RID: 2679
	[Token(Token = "0x2000A77")]
	public class NutChomper : PlantData
	{
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x0012733C File Offset: 0x0012553C
		[Token(Token = "0x1700029B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003708")]
			[Address(RVA = "0x3A7340", Offset = "0x3A5940", VA = "0x1803A7340", Slot = "4")]
			get
			{
				return PlantType.NutChomper;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x00127350 File Offset: 0x00125550
		[Token(Token = "0x1700029C")]
		public override string Title
		{
			[Token(Token = "0x6003709")]
			[Address(RVA = "0x76DB40", Offset = "0x76C140", VA = "0x18076DB40", Slot = "5")]
			get
			{
				return "破甲尖刺";
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x00127364 File Offset: 0x00125564
		[Token(Token = "0x1700029D")]
		public override string Description
		{
			[Token(Token = "0x600370A")]
			[Address(RVA = "0x76D9A0", Offset = "0x76BFA0", VA = "0x18076D9A0", Slot = "6")]
			get
			{
				return "攻击会同时削减僵尸的护甲";
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x00127378 File Offset: 0x00125578
		[Token(Token = "0x1700029E")]
		public override int Cost
		{
			[Token(Token = "0x600370B")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x00127388 File Offset: 0x00125588
		[Token(Token = "0x1700029F")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600370C")]
			[Address(RVA = "0x76D9D0", Offset = "0x76BFD0", VA = "0x18076D9D0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x001273CC File Offset: 0x001255CC
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public NutChomper()
		{
		}
	}
}
