using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ADD RID: 2781
	[Token(Token = "0x2000ADD")]
	public class BambooDragon : PlantData
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x0012DCEC File Offset: 0x0012BEEC
		[Token(Token = "0x170003A1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003930")]
			[Address(RVA = "0x7CE4C0", Offset = "0x7CCAC0", VA = "0x1807CE4C0", Slot = "4")]
			get
			{
				return PlantType.BambooDragon;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x0012DD00 File Offset: 0x0012BF00
		[Token(Token = "0x170003A2")]
		public override string Title
		{
			[Token(Token = "0x6003931")]
			[Address(RVA = "0x7CE5F0", Offset = "0x7CCBF0", VA = "0x1807CE5F0", Slot = "5")]
			get
			{
				return "神威";
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x0012DD14 File Offset: 0x0012BF14
		[Token(Token = "0x170003A3")]
		public override string Description
		{
			[Token(Token = "0x6003932")]
			[Address(RVA = "0x7CE490", Offset = "0x7CCA90", VA = "0x1807CE490", Slot = "6")]
			get
			{
				return "小飞龙的召唤频率增加";
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x0012DD28 File Offset: 0x0012BF28
		[Token(Token = "0x170003A4")]
		public override int Cost
		{
			[Token(Token = "0x6003933")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06003934 RID: 14644 RVA: 0x0012DD38 File Offset: 0x0012BF38
		[Token(Token = "0x170003A5")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003934")]
			[Address(RVA = "0x7CE4D0", Offset = "0x7CCAD0", VA = "0x1807CE4D0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x0012DD74 File Offset: 0x0012BF74
		[Token(Token = "0x6003935")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public BambooDragon()
		{
		}
	}
}
