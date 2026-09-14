using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A72 RID: 2674
	[Token(Token = "0x2000A72")]
	public class GoldMelon : PlantData
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x00127030 File Offset: 0x00125230
		[Token(Token = "0x17000282")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036EA")]
			[Address(RVA = "0x76B790", Offset = "0x769D90", VA = "0x18076B790", Slot = "4")]
			get
			{
				return PlantType.GoldMelon;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x00127044 File Offset: 0x00125244
		[Token(Token = "0x17000283")]
		public override string Title
		{
			[Token(Token = "0x60036EB")]
			[Address(RVA = "0x76B8C0", Offset = "0x769EC0", VA = "0x18076B8C0", Slot = "5")]
			get
			{
				return "金瓜如梦";
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x00127058 File Offset: 0x00125258
		[Token(Token = "0x17000284")]
		public override string Description
		{
			[Token(Token = "0x60036EC")]
			[Address(RVA = "0x76B760", Offset = "0x769D60", VA = "0x18076B760", Slot = "6")]
			get
			{
				return "攻击力随攻速增加而增加";
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x0012706C File Offset: 0x0012526C
		[Token(Token = "0x17000285")]
		public override int Cost
		{
			[Token(Token = "0x60036ED")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x0012707C File Offset: 0x0012527C
		[Token(Token = "0x17000286")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036EE")]
			[Address(RVA = "0x76B7A0", Offset = "0x769DA0", VA = "0x18076B7A0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x001270B8 File Offset: 0x001252B8
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public GoldMelon()
		{
		}
	}
}
