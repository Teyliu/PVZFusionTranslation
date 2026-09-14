using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CCA RID: 3274
	[Token(Token = "0x2000CCA")]
	public class EmeraleBlover : BaseConfig
	{
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x0015D060 File Offset: 0x0015B260
		[Token(Token = "0x17000779")]
		public override string Role
		{
			[Token(Token = "0x60044A3")]
			[Address(RVA = "0x830D10", Offset = "0x82F310", VA = "0x180830D10", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x0015D074 File Offset: 0x0015B274
		[Token(Token = "0x1700077A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044A4")]
			[Address(RVA = "0x76A860", Offset = "0x768E60", VA = "0x18076A860", Slot = "4")]
			get
			{
				return PlantType.EmeraldUmbrella;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x0015D088 File Offset: 0x0015B288
		[Token(Token = "0x1700077B")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044A5")]
			[Address(RVA = "0x830C00", Offset = "0x82F200", VA = "0x180830C00", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x0015D0B8 File Offset: 0x0015B2B8
		[Token(Token = "0x60044A6")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x0015D0C8 File Offset: 0x0015B2C8
		[Token(Token = "0x60044A7")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public EmeraleBlover()
		{
		}
	}
}
