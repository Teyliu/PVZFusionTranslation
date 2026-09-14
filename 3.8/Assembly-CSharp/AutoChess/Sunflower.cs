using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A6F RID: 2671
	[Token(Token = "0x2000A6F")]
	public class Sunflower : PlantData
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x00126E68 File Offset: 0x00125068
		[Token(Token = "0x17000273")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036D8")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "4")]
			get
			{
				return PlantType.SunFlower;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060036D9 RID: 14041 RVA: 0x00126E78 File Offset: 0x00125078
		[Token(Token = "0x17000274")]
		public override string Title
		{
			[Token(Token = "0x60036D9")]
			[Address(RVA = "0x778BB0", Offset = "0x7771B0", VA = "0x180778BB0", Slot = "5")]
			get
			{
				return "利益交换";
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00126E8C File Offset: 0x0012508C
		[Token(Token = "0x17000275")]
		public override string Description
		{
			[Token(Token = "0x60036DA")]
			[Address(RVA = "0x778A60", Offset = "0x777060", VA = "0x180778A60", Slot = "6")]
			get
			{
				return "使我方植物死亡时掉落阳光";
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x00126EA0 File Offset: 0x001250A0
		[Token(Token = "0x17000276")]
		public override int Cost
		{
			[Token(Token = "0x60036DB")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x00126EB0 File Offset: 0x001250B0
		[Token(Token = "0x17000277")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036DC")]
			[Address(RVA = "0x778A90", Offset = "0x777090", VA = "0x180778A90", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00126EEC File Offset: 0x001250EC
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Sunflower()
		{
		}
	}
}
