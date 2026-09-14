using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC1 RID: 2753
	[Token(Token = "0x2000AC1")]
	public class ThreeMine : PlantData
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x0012CBBC File Offset: 0x0012ADBC
		[Token(Token = "0x17000315")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003888")]
			[Address(RVA = "0x7E5810", Offset = "0x7E3E10", VA = "0x1807E5810", Slot = "4")]
			get
			{
				return PlantType.ThreeMine;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x0012CBD0 File Offset: 0x0012ADD0
		[Token(Token = "0x17000316")]
		public override string Title
		{
			[Token(Token = "0x6003889")]
			[Address(RVA = "0x7E5940", Offset = "0x7E3F40", VA = "0x1807E5940", Slot = "5")]
			get
			{
				return "贪婪之手";
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x0012CBE4 File Offset: 0x0012ADE4
		[Token(Token = "0x17000317")]
		public override string Description
		{
			[Token(Token = "0x600388A")]
			[Address(RVA = "0x7E57E0", Offset = "0x7E3DE0", VA = "0x1807E57E0", Slot = "6")]
			get
			{
				return "可以按星级为前台驯海游侠提供的羁绊增益";
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x0012CBF8 File Offset: 0x0012ADF8
		[Token(Token = "0x17000318")]
		public override int Cost
		{
			[Token(Token = "0x600388B")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x0012CC08 File Offset: 0x0012AE08
		[Token(Token = "0x17000319")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600388C")]
			[Address(RVA = "0x7E5820", Offset = "0x7E3E20", VA = "0x1807E5820", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x0012CC44 File Offset: 0x0012AE44
		[Token(Token = "0x600388D")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ThreeMine()
		{
		}
	}
}
