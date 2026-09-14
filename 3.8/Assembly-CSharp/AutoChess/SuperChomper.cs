using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x2000A84")]
	public class SuperChomper : PlantData
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x00127B60 File Offset: 0x00125D60
		[Token(Token = "0x170002DC")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003756")]
			[Address(RVA = "0x3A7750", Offset = "0x3A5D50", VA = "0x1803A7750", Slot = "4")]
			get
			{
				return PlantType.SuperChomper;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x00127B74 File Offset: 0x00125D74
		[Token(Token = "0x170002DD")]
		public override string Title
		{
			[Token(Token = "0x6003757")]
			[Address(RVA = "0x778EB0", Offset = "0x7774B0", VA = "0x180778EB0", Slot = "5")]
			get
			{
				return "弱者斩杀";
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x00127B88 File Offset: 0x00125D88
		[Token(Token = "0x170002DE")]
		public override string Description
		{
			[Token(Token = "0x6003758")]
			[Address(RVA = "0x778D60", Offset = "0x777360", VA = "0x180778D60", Slot = "6")]
			get
			{
				return "超级大嘴花的攻击力提高，斩杀线也提高";
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06003759 RID: 14169 RVA: 0x00127B9C File Offset: 0x00125D9C
		[Token(Token = "0x170002DF")]
		public override int Cost
		{
			[Token(Token = "0x6003759")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x00127BAC File Offset: 0x00125DAC
		[Token(Token = "0x170002E0")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600375A")]
			[Address(RVA = "0x778D90", Offset = "0x777390", VA = "0x180778D90", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00127BE8 File Offset: 0x00125DE8
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public SuperChomper()
		{
		}
	}
}
