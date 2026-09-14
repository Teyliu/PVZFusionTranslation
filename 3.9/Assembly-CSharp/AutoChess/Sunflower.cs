using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AAF RID: 2735
	[Token(Token = "0x2000AAF")]
	public class Sunflower : PlantData
	{
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x0012C098 File Offset: 0x0012A298
		[Token(Token = "0x170002BB")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600381C")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "4")]
			get
			{
				return PlantType.SunFlower;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x0012C0A8 File Offset: 0x0012A2A8
		[Token(Token = "0x170002BC")]
		public override string Title
		{
			[Token(Token = "0x600381D")]
			[Address(RVA = "0x7DFA50", Offset = "0x7DE050", VA = "0x1807DFA50", Slot = "5")]
			get
			{
				return "利益交换";
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600381E RID: 14366 RVA: 0x0012C0BC File Offset: 0x0012A2BC
		[Token(Token = "0x170002BD")]
		public override string Description
		{
			[Token(Token = "0x600381E")]
			[Address(RVA = "0x7DF900", Offset = "0x7DDF00", VA = "0x1807DF900", Slot = "6")]
			get
			{
				return "使我方植物死亡时掉落阳光";
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x0012C0D0 File Offset: 0x0012A2D0
		[Token(Token = "0x170002BE")]
		public override int Cost
		{
			[Token(Token = "0x600381F")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06003820 RID: 14368 RVA: 0x0012C0E0 File Offset: 0x0012A2E0
		[Token(Token = "0x170002BF")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003820")]
			[Address(RVA = "0x7DF930", Offset = "0x7DDF30", VA = "0x1807DF930", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x0012C11C File Offset: 0x0012A31C
		[Token(Token = "0x6003821")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Sunflower()
		{
		}
	}
}
