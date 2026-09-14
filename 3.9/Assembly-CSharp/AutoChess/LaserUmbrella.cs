using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ACE RID: 2766
	[Token(Token = "0x2000ACE")]
	public class LaserUmbrella : PlantData
	{
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060038D6 RID: 14550 RVA: 0x0012D3B8 File Offset: 0x0012B5B8
		[Token(Token = "0x17000356")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038D6")]
			[Address(RVA = "0x7D30C0", Offset = "0x7D16C0", VA = "0x1807D30C0", Slot = "4")]
			get
			{
				return PlantType.LaserUmbrella;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x0012D3CC File Offset: 0x0012B5CC
		[Token(Token = "0x17000357")]
		public override string Title
		{
			[Token(Token = "0x60038D7")]
			[Address(RVA = "0x7D31F0", Offset = "0x7D17F0", VA = "0x1807D31F0", Slot = "5")]
			get
			{
				return "生生不息";
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060038D8 RID: 14552 RVA: 0x0012D3E0 File Offset: 0x0012B5E0
		[Token(Token = "0x17000358")]
		public override string Description
		{
			[Token(Token = "0x60038D8")]
			[Address(RVA = "0x7D3090", Offset = "0x7D1690", VA = "0x1807D3090", Slot = "6")]
			get
			{
				return "治疗范围增加到全屏";
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x0012D3F4 File Offset: 0x0012B5F4
		[Token(Token = "0x17000359")]
		public override int Cost
		{
			[Token(Token = "0x60038D9")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060038DA RID: 14554 RVA: 0x0012D404 File Offset: 0x0012B604
		[Token(Token = "0x1700035A")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038DA")]
			[Address(RVA = "0x7D30D0", Offset = "0x7D16D0", VA = "0x1807D30D0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0012D440 File Offset: 0x0012B640
		[Token(Token = "0x60038DB")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public LaserUmbrella()
		{
		}
	}
}
