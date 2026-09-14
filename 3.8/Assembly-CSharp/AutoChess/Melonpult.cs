using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A69 RID: 2665
	[Token(Token = "0x2000A69")]
	public class Melonpult : PlantData
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x00126AC0 File Offset: 0x00124CC0
		[Token(Token = "0x17000255")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036B4")]
			[Address(RVA = "0x6A3410", Offset = "0x6A1A10", VA = "0x1806A3410", Slot = "4")]
			get
			{
				return PlantType.Melonpult;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x00126AD0 File Offset: 0x00124CD0
		[Token(Token = "0x17000256")]
		public override string Title
		{
			[Token(Token = "0x60036B5")]
			[Address(RVA = "0x76C890", Offset = "0x76AE90", VA = "0x18076C890", Slot = "5")]
			get
			{
				return "生瓜蛋子";
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x00126AE4 File Offset: 0x00124CE4
		[Token(Token = "0x17000257")]
		public override string Description
		{
			[Token(Token = "0x60036B6")]
			[Address(RVA = "0x76C740", Offset = "0x76AD40", VA = "0x18076C740", Slot = "6")]
			get
			{
				return "在敌人血量低于50%时额外发射子弹，并在敌人被消灭后永久提高前后台强度";
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x00126AF8 File Offset: 0x00124CF8
		[Token(Token = "0x17000258")]
		public override int Cost
		{
			[Token(Token = "0x60036B7")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x00126B08 File Offset: 0x00124D08
		[Token(Token = "0x17000259")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036B8")]
			[Address(RVA = "0x76C770", Offset = "0x76AD70", VA = "0x18076C770", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00126B44 File Offset: 0x00124D44
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Melonpult()
		{
		}
	}
}
