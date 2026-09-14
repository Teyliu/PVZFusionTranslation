using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A6B RID: 2667
	[Token(Token = "0x2000A6B")]
	public class Cactus : PlantData
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x00126BF8 File Offset: 0x00124DF8
		[Token(Token = "0x1700025F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036C0")]
			[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "4")]
			get
			{
				return PlantType.Cactus;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x00126C08 File Offset: 0x00124E08
		[Token(Token = "0x17000260")]
		public override string Title
		{
			[Token(Token = "0x60036C1")]
			[Address(RVA = "0x767930", Offset = "0x765F30", VA = "0x180767930", Slot = "5")]
			get
			{
				return "玉石俱焚";
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x00126C1C File Offset: 0x00124E1C
		[Token(Token = "0x17000261")]
		public override string Description
		{
			[Token(Token = "0x60036C2")]
			[Address(RVA = "0x7677E0", Offset = "0x765DE0", VA = "0x1807677E0", Slot = "6")]
			get
			{
				return "我方植物损失生命值时，仙人掌可积攒充能层数，以释放大招攻击敌人";
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x00126C30 File Offset: 0x00124E30
		[Token(Token = "0x17000262")]
		public override int Cost
		{
			[Token(Token = "0x60036C3")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x00126C40 File Offset: 0x00124E40
		[Token(Token = "0x17000263")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036C4")]
			[Address(RVA = "0x767810", Offset = "0x765E10", VA = "0x180767810", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x00126C7C File Offset: 0x00124E7C
		[Token(Token = "0x60036C5")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Cactus()
		{
		}
	}
}
