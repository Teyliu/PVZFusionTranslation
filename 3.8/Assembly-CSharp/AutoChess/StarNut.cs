using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A7B RID: 2683
	[Token(Token = "0x2000A7B")]
	public class StarNut : PlantData
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x001275C4 File Offset: 0x001257C4
		[Token(Token = "0x170002AF")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003720")]
			[Address(RVA = "0x7788B0", Offset = "0x776EB0", VA = "0x1807788B0", Slot = "4")]
			get
			{
				return PlantType.StarNut;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x001275D8 File Offset: 0x001257D8
		[Token(Token = "0x170002B0")]
		public override string Title
		{
			[Token(Token = "0x6003721")]
			[Address(RVA = "0x778A30", Offset = "0x777030", VA = "0x180778A30", Slot = "5")]
			get
			{
				return "博弈论";
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06003722 RID: 14114 RVA: 0x001275EC File Offset: 0x001257EC
		[Token(Token = "0x170002B1")]
		public override string Description
		{
			[Token(Token = "0x6003722")]
			[Address(RVA = "0x778880", Offset = "0x776E80", VA = "0x180778880", Slot = "6")]
			get
			{
				return "随时间提供更多护盾，我方小队伤害提高";
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x00127600 File Offset: 0x00125800
		[Token(Token = "0x170002B2")]
		public override int Cost
		{
			[Token(Token = "0x6003723")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x00127610 File Offset: 0x00125810
		[Token(Token = "0x170002B3")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003724")]
			[Address(RVA = "0x7788C0", Offset = "0x776EC0", VA = "0x1807788C0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00127654 File Offset: 0x00125854
		[Token(Token = "0x6003725")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public StarNut()
		{
		}
	}
}
