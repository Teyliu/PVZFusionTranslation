using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x2000A85")]
	public class LanternUmbrella : PlantData
	{
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600375C RID: 14172 RVA: 0x00127BFC File Offset: 0x00125DFC
		[Token(Token = "0x170002E1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600375C")]
			[Address(RVA = "0x76C0F0", Offset = "0x76A6F0", VA = "0x18076C0F0", Slot = "4")]
			get
			{
				return PlantType.LanternUmbrella;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600375D RID: 14173 RVA: 0x00127C10 File Offset: 0x00125E10
		[Token(Token = "0x170002E2")]
		public override string Title
		{
			[Token(Token = "0x600375D")]
			[Address(RVA = "0x76C220", Offset = "0x76A820", VA = "0x18076C220", Slot = "5")]
			get
			{
				return "爱的礼物";
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600375E RID: 14174 RVA: 0x00127C24 File Offset: 0x00125E24
		[Token(Token = "0x170002E3")]
		public override string Description
		{
			[Token(Token = "0x600375E")]
			[Address(RVA = "0x76C0C0", Offset = "0x76A6C0", VA = "0x18076C0C0", Slot = "6")]
			get
			{
				return "格挡子弹时会使周围植物回复生命值，并使其造成的攻击力提高";
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600375F RID: 14175 RVA: 0x00127C38 File Offset: 0x00125E38
		[Token(Token = "0x170002E4")]
		public override int Cost
		{
			[Token(Token = "0x600375F")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x00127C48 File Offset: 0x00125E48
		[Token(Token = "0x170002E5")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003760")]
			[Address(RVA = "0x76C100", Offset = "0x76A700", VA = "0x18076C100", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00127C84 File Offset: 0x00125E84
		[Token(Token = "0x6003761")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public LanternUmbrella()
		{
		}
	}
}
