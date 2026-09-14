using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	public class ThreePeater : PlantData
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x00126F00 File Offset: 0x00125100
		[Token(Token = "0x17000278")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036DE")]
			[Address(RVA = "0x69AA70", Offset = "0x699070", VA = "0x18069AA70", Slot = "4")]
			get
			{
				return PlantType.ThreePeater;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060036DF RID: 14047 RVA: 0x00126F10 File Offset: 0x00125110
		[Token(Token = "0x17000279")]
		public override string Title
		{
			[Token(Token = "0x60036DF")]
			[Address(RVA = "0x77EC20", Offset = "0x77D220", VA = "0x18077EC20", Slot = "5")]
			get
			{
				return "三重打击";
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x00126F24 File Offset: 0x00125124
		[Token(Token = "0x1700027A")]
		public override string Description
		{
			[Token(Token = "0x60036E0")]
			[Address(RVA = "0x77EAD0", Offset = "0x77D0D0", VA = "0x18077EAD0", Slot = "6")]
			get
			{
				return "每次发射的豆量提高";
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060036E1 RID: 14049 RVA: 0x00126F38 File Offset: 0x00125138
		[Token(Token = "0x1700027B")]
		public override int Cost
		{
			[Token(Token = "0x60036E1")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x00126F48 File Offset: 0x00125148
		[Token(Token = "0x1700027C")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036E2")]
			[Address(RVA = "0x77EB00", Offset = "0x77D100", VA = "0x18077EB00", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00126F84 File Offset: 0x00125184
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ThreePeater()
		{
		}
	}
}
