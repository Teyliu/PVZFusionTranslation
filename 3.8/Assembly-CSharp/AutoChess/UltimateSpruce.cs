using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A8D RID: 2701
	[Token(Token = "0x2000A8D")]
	public class UltimateSpruce : PlantData
	{
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x001280EC File Offset: 0x001262EC
		[Token(Token = "0x17000309")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600378C")]
			[Address(RVA = "0x781E10", Offset = "0x780410", VA = "0x180781E10", Slot = "4")]
			get
			{
				return PlantType.UltimateSpruce;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600378D RID: 14221 RVA: 0x00128100 File Offset: 0x00126300
		[Token(Token = "0x1700030A")]
		public override string Title
		{
			[Token(Token = "0x600378D")]
			[Address(RVA = "0x781F40", Offset = "0x780540", VA = "0x180781F40", Slot = "5")]
			get
			{
				return "冰雪之志";
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x00128114 File Offset: 0x00126314
		[Token(Token = "0x1700030B")]
		public override string Description
		{
			[Token(Token = "0x600378E")]
			[Address(RVA = "0x781DE0", Offset = "0x7803E0", VA = "0x180781DE0", Slot = "6")]
			get
			{
				return "究极云杉会提供更多护盾，并提高拥有大量护盾目标的攻击力";
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x00128128 File Offset: 0x00126328
		[Token(Token = "0x1700030C")]
		public override int Cost
		{
			[Token(Token = "0x600378F")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x00128138 File Offset: 0x00126338
		[Token(Token = "0x1700030D")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003790")]
			[Address(RVA = "0x781E20", Offset = "0x780420", VA = "0x180781E20", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00128174 File Offset: 0x00126374
		[Token(Token = "0x6003791")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateSpruce()
		{
		}
	}
}
