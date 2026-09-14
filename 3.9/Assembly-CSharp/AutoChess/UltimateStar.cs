using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD1 RID: 2769
	[Token(Token = "0x2000AD1")]
	public class UltimateStar : PlantData
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060038E8 RID: 14568 RVA: 0x0012D59C File Offset: 0x0012B79C
		[Token(Token = "0x17000365")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038E8")]
			[Address(RVA = "0x7E8E50", Offset = "0x7E7450", VA = "0x1807E8E50", Slot = "4")]
			get
			{
				return PlantType.UltimateStar;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x0012D5B0 File Offset: 0x0012B7B0
		[Token(Token = "0x17000366")]
		public override string Title
		{
			[Token(Token = "0x60038E9")]
			[Address(RVA = "0x7E8F80", Offset = "0x7E7580", VA = "0x1807E8F80", Slot = "5")]
			get
			{
				return "天河本怒涛";
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x0012D5C4 File Offset: 0x0012B7C4
		[Token(Token = "0x17000367")]
		public override string Description
		{
			[Token(Token = "0x60038EA")]
			[Address(RVA = "0x7E8E20", Offset = "0x7E7420", VA = "0x1807E8E20", Slot = "6")]
			get
			{
				return "使我方小队造成的伤害提高，释放大流星时造成额外伤害";
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x0012D5D8 File Offset: 0x0012B7D8
		[Token(Token = "0x17000368")]
		public override int Cost
		{
			[Token(Token = "0x60038EB")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x0012D5E8 File Offset: 0x0012B7E8
		[Token(Token = "0x17000369")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038EC")]
			[Address(RVA = "0x7E8E60", Offset = "0x7E7460", VA = "0x1807E8E60", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x0012D624 File Offset: 0x0012B824
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateStar()
		{
		}
	}
}
