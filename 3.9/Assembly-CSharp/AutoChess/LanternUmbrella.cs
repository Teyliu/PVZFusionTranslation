using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC5 RID: 2757
	[Token(Token = "0x2000AC5")]
	public class LanternUmbrella : PlantData
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060038A0 RID: 14496 RVA: 0x0012CE2C File Offset: 0x0012B02C
		[Token(Token = "0x17000329")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038A0")]
			[Address(RVA = "0x7D2F30", Offset = "0x7D1530", VA = "0x1807D2F30", Slot = "4")]
			get
			{
				return PlantType.LanternUmbrella;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060038A1 RID: 14497 RVA: 0x0012CE40 File Offset: 0x0012B040
		[Token(Token = "0x1700032A")]
		public override string Title
		{
			[Token(Token = "0x60038A1")]
			[Address(RVA = "0x7D3060", Offset = "0x7D1660", VA = "0x1807D3060", Slot = "5")]
			get
			{
				return "爱的礼物";
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060038A2 RID: 14498 RVA: 0x0012CE54 File Offset: 0x0012B054
		[Token(Token = "0x1700032B")]
		public override string Description
		{
			[Token(Token = "0x60038A2")]
			[Address(RVA = "0x7D2F00", Offset = "0x7D1500", VA = "0x1807D2F00", Slot = "6")]
			get
			{
				return "格挡子弹时会使周围植物回复生命值，并使其造成的攻击力提高";
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x0012CE68 File Offset: 0x0012B068
		[Token(Token = "0x1700032C")]
		public override int Cost
		{
			[Token(Token = "0x60038A3")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x0012CE78 File Offset: 0x0012B078
		[Token(Token = "0x1700032D")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038A4")]
			[Address(RVA = "0x7D2F40", Offset = "0x7D1540", VA = "0x1807D2F40", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x0012CEB4 File Offset: 0x0012B0B4
		[Token(Token = "0x60038A5")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public LanternUmbrella()
		{
		}
	}
}
