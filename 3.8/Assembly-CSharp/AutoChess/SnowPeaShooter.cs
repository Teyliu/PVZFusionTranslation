using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A7A RID: 2682
	[Token(Token = "0x2000A7A")]
	public class SnowPeaShooter : PlantData
	{
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x00127528 File Offset: 0x00125728
		[Token(Token = "0x170002AA")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600371A")]
			[Address(RVA = "0x7785A0", Offset = "0x776BA0", VA = "0x1807785A0", Slot = "4")]
			get
			{
				return PlantType.SnowPeaShooter;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x0012753C File Offset: 0x0012573C
		[Token(Token = "0x170002AB")]
		public override string Title
		{
			[Token(Token = "0x600371B")]
			[Address(RVA = "0x7786D0", Offset = "0x776CD0", VA = "0x1807786D0", Slot = "5")]
			get
			{
				return "傲雪残梅";
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x00127550 File Offset: 0x00125750
		[Token(Token = "0x170002AC")]
		public override string Description
		{
			[Token(Token = "0x600371C")]
			[Address(RVA = "0x778570", Offset = "0x776B70", VA = "0x180778570", Slot = "6")]
			get
			{
				return "羁绊的充能速度提高，我方小队的伤害和射速提高";
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x00127564 File Offset: 0x00125764
		[Token(Token = "0x170002AD")]
		public override int Cost
		{
			[Token(Token = "0x600371D")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x00127574 File Offset: 0x00125774
		[Token(Token = "0x170002AE")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600371E")]
			[Address(RVA = "0x7785B0", Offset = "0x776BB0", VA = "0x1807785B0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x001275B0 File Offset: 0x001257B0
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public SnowPeaShooter()
		{
		}
	}
}
