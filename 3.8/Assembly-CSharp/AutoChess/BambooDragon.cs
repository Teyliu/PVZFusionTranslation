using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A9D RID: 2717
	[Token(Token = "0x2000A9D")]
	public class BambooDragon : PlantData
	{
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x00128ABC File Offset: 0x00126CBC
		[Token(Token = "0x17000359")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037EC")]
			[Address(RVA = "0x767680", Offset = "0x765C80", VA = "0x180767680", Slot = "4")]
			get
			{
				return PlantType.BambooDragon;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x00128AD0 File Offset: 0x00126CD0
		[Token(Token = "0x1700035A")]
		public override string Title
		{
			[Token(Token = "0x60037ED")]
			[Address(RVA = "0x7677B0", Offset = "0x765DB0", VA = "0x1807677B0", Slot = "5")]
			get
			{
				return "神威";
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060037EE RID: 14318 RVA: 0x00128AE4 File Offset: 0x00126CE4
		[Token(Token = "0x1700035B")]
		public override string Description
		{
			[Token(Token = "0x60037EE")]
			[Address(RVA = "0x767650", Offset = "0x765C50", VA = "0x180767650", Slot = "6")]
			get
			{
				return "小飞龙的召唤频率增加";
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x00128AF8 File Offset: 0x00126CF8
		[Token(Token = "0x1700035C")]
		public override int Cost
		{
			[Token(Token = "0x60037EF")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x00128B08 File Offset: 0x00126D08
		[Token(Token = "0x1700035D")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037F0")]
			[Address(RVA = "0x767690", Offset = "0x765C90", VA = "0x180767690", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00128B44 File Offset: 0x00126D44
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public BambooDragon()
		{
		}
	}
}
