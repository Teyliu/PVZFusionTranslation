using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ABA RID: 2746
	[Token(Token = "0x2000ABA")]
	public class SnowPeaShooter : PlantData
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600385E RID: 14430 RVA: 0x0012C758 File Offset: 0x0012A958
		[Token(Token = "0x170002F2")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600385E")]
			[Address(RVA = "0x7DF440", Offset = "0x7DDA40", VA = "0x1807DF440", Slot = "4")]
			get
			{
				return PlantType.SnowPeaShooter;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600385F RID: 14431 RVA: 0x0012C76C File Offset: 0x0012A96C
		[Token(Token = "0x170002F3")]
		public override string Title
		{
			[Token(Token = "0x600385F")]
			[Address(RVA = "0x7DF570", Offset = "0x7DDB70", VA = "0x1807DF570", Slot = "5")]
			get
			{
				return "傲雪残梅";
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06003860 RID: 14432 RVA: 0x0012C780 File Offset: 0x0012A980
		[Token(Token = "0x170002F4")]
		public override string Description
		{
			[Token(Token = "0x6003860")]
			[Address(RVA = "0x7DF410", Offset = "0x7DDA10", VA = "0x1807DF410", Slot = "6")]
			get
			{
				return "羁绊的充能速度提高，我方小队的伤害和射速提高";
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x0012C794 File Offset: 0x0012A994
		[Token(Token = "0x170002F5")]
		public override int Cost
		{
			[Token(Token = "0x6003861")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06003862 RID: 14434 RVA: 0x0012C7A4 File Offset: 0x0012A9A4
		[Token(Token = "0x170002F6")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003862")]
			[Address(RVA = "0x7DF450", Offset = "0x7DDA50", VA = "0x1807DF450", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x0012C7E0 File Offset: 0x0012A9E0
		[Token(Token = "0x6003863")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public SnowPeaShooter()
		{
		}
	}
}
