using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AA2 RID: 2722
	[Token(Token = "0x2000AA2")]
	public class UltimateExplodeCannon : PlantData
	{
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x00128DC8 File Offset: 0x00126FC8
		[Token(Token = "0x17000372")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600380A")]
			[Address(RVA = "0x7815F0", Offset = "0x77FBF0", VA = "0x1807815F0", Slot = "4")]
			get
			{
				return PlantType.UltimateExplodeCannon;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x00128DDC File Offset: 0x00126FDC
		[Token(Token = "0x17000373")]
		public override string Title
		{
			[Token(Token = "0x600380B")]
			[Address(RVA = "0x781720", Offset = "0x77FD20", VA = "0x180781720", Slot = "5")]
			get
			{
				return "力量会给予希望";
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600380C RID: 14348 RVA: 0x00128DF0 File Offset: 0x00126FF0
		[Token(Token = "0x17000374")]
		public override string Description
		{
			[Token(Token = "0x600380C")]
			[Address(RVA = "0x7815C0", Offset = "0x77FBC0", VA = "0x1807815C0", Slot = "6")]
			get
			{
				return "每个一段时间获得一个究极红温帝果";
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x00128E04 File Offset: 0x00127004
		[Token(Token = "0x17000375")]
		public override int Cost
		{
			[Token(Token = "0x600380D")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x00128E14 File Offset: 0x00127014
		[Token(Token = "0x17000376")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600380E")]
			[Address(RVA = "0x781600", Offset = "0x77FC00", VA = "0x180781600", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00128E50 File Offset: 0x00127050
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateExplodeCannon()
		{
		}
	}
}
