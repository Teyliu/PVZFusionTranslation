using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ADB RID: 2779
	[Token(Token = "0x2000ADB")]
	public class UltimateChomper : PlantData
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x0012DBB4 File Offset: 0x0012BDB4
		[Token(Token = "0x17000397")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003924")]
			[Address(RVA = "0x7E8180", Offset = "0x7E6780", VA = "0x1807E8180", Slot = "4")]
			get
			{
				return PlantType.UltimateChomper;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x0012DBC8 File Offset: 0x0012BDC8
		[Token(Token = "0x17000398")]
		public override string Title
		{
			[Token(Token = "0x6003925")]
			[Address(RVA = "0x7E82B0", Offset = "0x7E68B0", VA = "0x1807E82B0", Slot = "5")]
			get
			{
				return "幻想崩坏";
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06003926 RID: 14630 RVA: 0x0012DBDC File Offset: 0x0012BDDC
		[Token(Token = "0x17000399")]
		public override string Description
		{
			[Token(Token = "0x6003926")]
			[Address(RVA = "0x7E8150", Offset = "0x7E6750", VA = "0x1807E8150", Slot = "6")]
			get
			{
				return "每第5次攻击强制触发吞噬";
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x0012DBF0 File Offset: 0x0012BDF0
		[Token(Token = "0x1700039A")]
		public override int Cost
		{
			[Token(Token = "0x6003927")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06003928 RID: 14632 RVA: 0x0012DC00 File Offset: 0x0012BE00
		[Token(Token = "0x1700039B")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003928")]
			[Address(RVA = "0x7E8190", Offset = "0x7E6790", VA = "0x1807E8190", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0012DC3C File Offset: 0x0012BE3C
		[Token(Token = "0x6003929")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateChomper()
		{
		}
	}
}
