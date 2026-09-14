using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A73 RID: 2675
	[Token(Token = "0x2000A73")]
	public class Cornpult : PlantData
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x001270CC File Offset: 0x001252CC
		[Token(Token = "0x17000287")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036F0")]
			[Address(RVA = "0x6A1A60", Offset = "0x6A0060", VA = "0x1806A1A60", Slot = "4")]
			get
			{
				return PlantType.Cornpult;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060036F1 RID: 14065 RVA: 0x001270DC File Offset: 0x001252DC
		[Token(Token = "0x17000288")]
		public override string Title
		{
			[Token(Token = "0x60036F1")]
			[Address(RVA = "0x768360", Offset = "0x766960", VA = "0x180768360", Slot = "5")]
			get
			{
				return "黄油投手";
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x001270F0 File Offset: 0x001252F0
		[Token(Token = "0x17000289")]
		public override string Description
		{
			[Token(Token = "0x60036F2")]
			[Address(RVA = "0x7681C0", Offset = "0x7667C0", VA = "0x1807681C0", Slot = "6")]
			get
			{
				return "黄油概率提高，被黄油命中的僵尸会成为追踪子弹的集火目标";
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x00127104 File Offset: 0x00125304
		[Token(Token = "0x1700028A")]
		public override int Cost
		{
			[Token(Token = "0x60036F3")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060036F4 RID: 14068 RVA: 0x00127114 File Offset: 0x00125314
		[Token(Token = "0x1700028B")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036F4")]
			[Address(RVA = "0x7681F0", Offset = "0x7667F0", VA = "0x1807681F0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00127158 File Offset: 0x00125358
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Cornpult()
		{
		}
	}
}
