using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A7E RID: 2686
	[Token(Token = "0x2000A7E")]
	public class MelonNut : PlantData
	{
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x001277B0 File Offset: 0x001259B0
		[Token(Token = "0x170002BE")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003732")]
			[Address(RVA = "0x76C5E0", Offset = "0x76ABE0", VA = "0x18076C5E0", Slot = "4")]
			get
			{
				return PlantType.MelonNut;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x001277C4 File Offset: 0x001259C4
		[Token(Token = "0x170002BF")]
		public override string Title
		{
			[Token(Token = "0x6003733")]
			[Address(RVA = "0x76C710", Offset = "0x76AD10", VA = "0x18076C710", Slot = "5")]
			get
			{
				return "沐浴神血";
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x001277D8 File Offset: 0x001259D8
		[Token(Token = "0x170002C0")]
		public override string Description
		{
			[Token(Token = "0x6003734")]
			[Address(RVA = "0x76C5B0", Offset = "0x76ABB0", VA = "0x18076C5B0", Slot = "6")]
			get
			{
				return "释放攻击时使生命值上限永久提高，生命上限使受伤充能额外提高";
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06003735 RID: 14133 RVA: 0x001277EC File Offset: 0x001259EC
		[Token(Token = "0x170002C1")]
		public override int Cost
		{
			[Token(Token = "0x6003735")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x001277FC File Offset: 0x001259FC
		[Token(Token = "0x170002C2")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003736")]
			[Address(RVA = "0x76C5F0", Offset = "0x76ABF0", VA = "0x18076C5F0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00127838 File Offset: 0x00125A38
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public MelonNut()
		{
		}
	}
}
