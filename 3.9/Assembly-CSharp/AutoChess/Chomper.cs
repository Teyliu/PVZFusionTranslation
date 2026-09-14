using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB4 RID: 2740
	[Token(Token = "0x2000AB4")]
	public class Chomper : PlantData
	{
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x0012C39C File Offset: 0x0012A59C
		[Token(Token = "0x170002D4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600383A")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "4")]
			get
			{
				return PlantType.Chomper;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600383B RID: 14395 RVA: 0x0012C3AC File Offset: 0x0012A5AC
		[Token(Token = "0x170002D5")]
		public override string Title
		{
			[Token(Token = "0x600383B")]
			[Address(RVA = "0x7CEDF0", Offset = "0x7CD3F0", VA = "0x1807CEDF0", Slot = "5")]
			get
			{
				return "大嘴一咬，福祸自招";
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x0012C3C0 File Offset: 0x0012A5C0
		[Token(Token = "0x170002D6")]
		public override string Description
		{
			[Token(Token = "0x600383C")]
			[Address(RVA = "0x7CECA0", Offset = "0x7CD2A0", VA = "0x1807CECA0", Slot = "6")]
			get
			{
				return "吞噬僵尸可时战神行动提前";
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600383D RID: 14397 RVA: 0x0012C3D4 File Offset: 0x0012A5D4
		[Token(Token = "0x170002D7")]
		public override int Cost
		{
			[Token(Token = "0x600383D")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600383E RID: 14398 RVA: 0x0012C3E4 File Offset: 0x0012A5E4
		[Token(Token = "0x170002D8")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600383E")]
			[Address(RVA = "0x7CECD0", Offset = "0x7CD2D0", VA = "0x1807CECD0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x0012C420 File Offset: 0x0012A620
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Chomper()
		{
		}
	}
}
