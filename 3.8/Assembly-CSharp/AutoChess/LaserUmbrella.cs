using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A8E RID: 2702
	[Token(Token = "0x2000A8E")]
	public class LaserUmbrella : PlantData
	{
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x00128188 File Offset: 0x00126388
		[Token(Token = "0x1700030E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003792")]
			[Address(RVA = "0x76C280", Offset = "0x76A880", VA = "0x18076C280", Slot = "4")]
			get
			{
				return PlantType.LaserUmbrella;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06003793 RID: 14227 RVA: 0x0012819C File Offset: 0x0012639C
		[Token(Token = "0x1700030F")]
		public override string Title
		{
			[Token(Token = "0x6003793")]
			[Address(RVA = "0x76C3B0", Offset = "0x76A9B0", VA = "0x18076C3B0", Slot = "5")]
			get
			{
				return "生生不息";
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x001281B0 File Offset: 0x001263B0
		[Token(Token = "0x17000310")]
		public override string Description
		{
			[Token(Token = "0x6003794")]
			[Address(RVA = "0x76C250", Offset = "0x76A850", VA = "0x18076C250", Slot = "6")]
			get
			{
				return "治疗范围增加到全屏";
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x001281C4 File Offset: 0x001263C4
		[Token(Token = "0x17000311")]
		public override int Cost
		{
			[Token(Token = "0x6003795")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x001281D4 File Offset: 0x001263D4
		[Token(Token = "0x17000312")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003796")]
			[Address(RVA = "0x76C290", Offset = "0x76A890", VA = "0x18076C290", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x00128210 File Offset: 0x00126410
		[Token(Token = "0x6003797")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public LaserUmbrella()
		{
		}
	}
}
