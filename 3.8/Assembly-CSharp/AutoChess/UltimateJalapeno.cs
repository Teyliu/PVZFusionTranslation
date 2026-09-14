using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A8F RID: 2703
	[Token(Token = "0x2000A8F")]
	public class UltimateJalapeno : PlantData
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x00128224 File Offset: 0x00126424
		[Token(Token = "0x17000313")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003798")]
			[Address(RVA = "0x781910", Offset = "0x77FF10", VA = "0x180781910", Slot = "4")]
			get
			{
				return PlantType.UltimateJalapeno;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06003799 RID: 14233 RVA: 0x00128238 File Offset: 0x00126438
		[Token(Token = "0x17000314")]
		public override string Title
		{
			[Token(Token = "0x6003799")]
			[Address(RVA = "0x781A90", Offset = "0x780090", VA = "0x180781A90", Slot = "5")]
			get
			{
				return "斩将祭旗";
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x0012824C File Offset: 0x0012644C
		[Token(Token = "0x17000315")]
		public override string Description
		{
			[Token(Token = "0x600379A")]
			[Address(RVA = "0x7818E0", Offset = "0x77FEE0", VA = "0x1807818E0", Slot = "6")]
			get
			{
				return "全场植物按百分比分摊伤害，我方小队幸运一击伤害提高，新增固定时间获得充能";
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600379B RID: 14235 RVA: 0x00128260 File Offset: 0x00126460
		[Token(Token = "0x17000316")]
		public override int Cost
		{
			[Token(Token = "0x600379B")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x00128270 File Offset: 0x00126470
		[Token(Token = "0x17000317")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600379C")]
			[Address(RVA = "0x781920", Offset = "0x77FF20", VA = "0x180781920", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x001282B4 File Offset: 0x001264B4
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateJalapeno()
		{
		}
	}
}
