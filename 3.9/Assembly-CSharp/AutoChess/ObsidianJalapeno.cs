using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ABF RID: 2751
	[Token(Token = "0x2000ABF")]
	public class ObsidianJalapeno : PlantData
	{
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600387C RID: 14460 RVA: 0x0012CA7C File Offset: 0x0012AC7C
		[Token(Token = "0x1700030B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600387C")]
			[Address(RVA = "0x7D49E0", Offset = "0x7D2FE0", VA = "0x1807D49E0", Slot = "4")]
			get
			{
				return PlantType.ObsidianJalapeno;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x0012CA90 File Offset: 0x0012AC90
		[Token(Token = "0x1700030C")]
		public override string Title
		{
			[Token(Token = "0x600387D")]
			[Address(RVA = "0x7D4B60", Offset = "0x7D3160", VA = "0x1807D4B60", Slot = "5")]
			get
			{
				return "黑曜护体";
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x0012CAA4 File Offset: 0x0012ACA4
		[Token(Token = "0x1700030D")]
		public override string Description
		{
			[Token(Token = "0x600387E")]
			[Address(RVA = "0x7D49B0", Offset = "0x7D2FB0", VA = "0x1807D49B0", Slot = "6")]
			get
			{
				return "在场时记录全场植物的治疗量，爆炸时基于治疗量造成额外伤害并治疗全体植物";
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x0012CAB8 File Offset: 0x0012ACB8
		[Token(Token = "0x1700030E")]
		public override int Cost
		{
			[Token(Token = "0x600387F")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x0012CAC8 File Offset: 0x0012ACC8
		[Token(Token = "0x1700030F")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003880")]
			[Address(RVA = "0x7D49F0", Offset = "0x7D2FF0", VA = "0x1807D49F0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0012CB0C File Offset: 0x0012AD0C
		[Token(Token = "0x6003881")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ObsidianJalapeno()
		{
		}
	}
}
