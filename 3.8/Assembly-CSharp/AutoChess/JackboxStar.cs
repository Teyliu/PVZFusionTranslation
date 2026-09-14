using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x2000A86")]
	public class JackboxStar : PlantData
	{
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x00127C98 File Offset: 0x00125E98
		[Token(Token = "0x170002E6")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003762")]
			[Address(RVA = "0x76BC40", Offset = "0x76A240", VA = "0x18076BC40", Slot = "4")]
			get
			{
				return PlantType.JackboxStar;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06003763 RID: 14179 RVA: 0x00127CAC File Offset: 0x00125EAC
		[Token(Token = "0x170002E7")]
		public override string Title
		{
			[Token(Token = "0x6003763")]
			[Address(RVA = "0x76BD70", Offset = "0x76A370", VA = "0x18076BD70", Slot = "5")]
			get
			{
				return "冷月寒光";
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06003764 RID: 14180 RVA: 0x00127CC0 File Offset: 0x00125EC0
		[Token(Token = "0x170002E8")]
		public override string Description
		{
			[Token(Token = "0x6003764")]
			[Address(RVA = "0x76BC10", Offset = "0x76A210", VA = "0x18076BC10", Slot = "6")]
			get
			{
				return "消耗自身生命值和周围3x3植物血量生命值攻击敌人，击中敌人会回复自身生命值";
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x00127CD4 File Offset: 0x00125ED4
		[Token(Token = "0x170002E9")]
		public override int Cost
		{
			[Token(Token = "0x6003765")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06003766 RID: 14182 RVA: 0x00127CE4 File Offset: 0x00125EE4
		[Token(Token = "0x170002EA")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003766")]
			[Address(RVA = "0x76BC50", Offset = "0x76A250", VA = "0x18076BC50", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00127D20 File Offset: 0x00125F20
		[Token(Token = "0x6003767")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public JackboxStar()
		{
		}
	}
}
