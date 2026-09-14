using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AA8 RID: 2728
	[Token(Token = "0x2000AA8")]
	public class ElectricOnion : PlantData
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x0012BC58 File Offset: 0x00129E58
		[Token(Token = "0x17000298")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037F2")]
			[Address(RVA = "0x71E0C0", Offset = "0x71C6C0", VA = "0x18071E0C0", Slot = "4")]
			get
			{
				return PlantType.ElectricOnion;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x0012BC68 File Offset: 0x00129E68
		[Token(Token = "0x17000299")]
		public override string Title
		{
			[Token(Token = "0x60037F3")]
			[Address(RVA = "0x7D1640", Offset = "0x7CFC40", VA = "0x1807D1640", Slot = "5")]
			get
			{
				return "高能射线";
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060037F4 RID: 14324 RVA: 0x0012BC7C File Offset: 0x00129E7C
		[Token(Token = "0x1700029A")]
		public override string Description
		{
			[Token(Token = "0x60037F4")]
			[Address(RVA = "0x7D14F0", Offset = "0x7CFAF0", VA = "0x1807D14F0", Slot = "6")]
			get
			{
				return "子弹可弹射更多次数，并使目标陷入可叠加的感电";
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x0012BC90 File Offset: 0x00129E90
		[Token(Token = "0x1700029B")]
		public override int Cost
		{
			[Token(Token = "0x60037F5")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060037F6 RID: 14326 RVA: 0x0012BCA0 File Offset: 0x00129EA0
		[Token(Token = "0x1700029C")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037F6")]
			[Address(RVA = "0x7D1520", Offset = "0x7CFB20", VA = "0x1807D1520", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x0012BCDC File Offset: 0x00129EDC
		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ElectricOnion()
		{
		}
	}
}
