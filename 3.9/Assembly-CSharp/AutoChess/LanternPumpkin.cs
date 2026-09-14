using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC0 RID: 2752
	[Token(Token = "0x2000AC0")]
	public class LanternPumpkin : PlantData
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x0012CB20 File Offset: 0x0012AD20
		[Token(Token = "0x17000310")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003882")]
			[Address(RVA = "0x7D2DA0", Offset = "0x7D13A0", VA = "0x1807D2DA0", Slot = "4")]
			get
			{
				return PlantType.LanternPumpkin;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x0012CB34 File Offset: 0x0012AD34
		[Token(Token = "0x17000311")]
		public override string Title
		{
			[Token(Token = "0x6003883")]
			[Address(RVA = "0x7D2ED0", Offset = "0x7D14D0", VA = "0x1807D2ED0", Slot = "5")]
			get
			{
				return "龙灵在天";
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x0012CB48 File Offset: 0x0012AD48
		[Token(Token = "0x17000312")]
		public override string Description
		{
			[Token(Token = "0x6003884")]
			[Address(RVA = "0x7D2D70", Offset = "0x7D1370", VA = "0x1807D2D70", Slot = "6")]
			get
			{
				return "使队友获得龙灵，队友攻击时，获得基于光照等级的护盾";
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x0012CB5C File Offset: 0x0012AD5C
		[Token(Token = "0x17000313")]
		public override int Cost
		{
			[Token(Token = "0x6003885")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x0012CB6C File Offset: 0x0012AD6C
		[Token(Token = "0x17000314")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003886")]
			[Address(RVA = "0x7D2DB0", Offset = "0x7D13B0", VA = "0x1807D2DB0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x0012CBA8 File Offset: 0x0012ADA8
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public LanternPumpkin()
		{
		}
	}
}
