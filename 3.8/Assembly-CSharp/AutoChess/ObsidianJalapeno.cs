using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A7F RID: 2687
	[Token(Token = "0x2000A7F")]
	public class ObsidianJalapeno : PlantData
	{
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x0012784C File Offset: 0x00125A4C
		[Token(Token = "0x170002C3")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003738")]
			[Address(RVA = "0x76DBA0", Offset = "0x76C1A0", VA = "0x18076DBA0", Slot = "4")]
			get
			{
				return PlantType.ObsidianJalapeno;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x00127860 File Offset: 0x00125A60
		[Token(Token = "0x170002C4")]
		public override string Title
		{
			[Token(Token = "0x6003739")]
			[Address(RVA = "0x76DD20", Offset = "0x76C320", VA = "0x18076DD20", Slot = "5")]
			get
			{
				return "黑曜护体";
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600373A RID: 14138 RVA: 0x00127874 File Offset: 0x00125A74
		[Token(Token = "0x170002C5")]
		public override string Description
		{
			[Token(Token = "0x600373A")]
			[Address(RVA = "0x76DB70", Offset = "0x76C170", VA = "0x18076DB70", Slot = "6")]
			get
			{
				return "在场时记录全场植物的治疗量，爆炸时基于治疗量造成额外伤害并治疗全体植物";
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x00127888 File Offset: 0x00125A88
		[Token(Token = "0x170002C6")]
		public override int Cost
		{
			[Token(Token = "0x600373B")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x00127898 File Offset: 0x00125A98
		[Token(Token = "0x170002C7")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600373C")]
			[Address(RVA = "0x76DBB0", Offset = "0x76C1B0", VA = "0x18076DBB0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x001278DC File Offset: 0x00125ADC
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ObsidianJalapeno()
		{
		}
	}
}
