using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A6E RID: 2670
	[Token(Token = "0x2000A6E")]
	public class StarFruit : PlantData
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x00126DD0 File Offset: 0x00124FD0
		[Token(Token = "0x1700026E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036D2")]
			[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "4")]
			get
			{
				return PlantType.StarFruit;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x00126DE0 File Offset: 0x00124FE0
		[Token(Token = "0x1700026F")]
		public override string Title
		{
			[Token(Token = "0x60036D3")]
			[Address(RVA = "0x778850", Offset = "0x776E50", VA = "0x180778850", Slot = "5")]
			get
			{
				return "大捷！大捷！";
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x00126DF4 File Offset: 0x00124FF4
		[Token(Token = "0x17000270")]
		public override string Description
		{
			[Token(Token = "0x60036D4")]
			[Address(RVA = "0x778700", Offset = "0x776D00", VA = "0x180778700", Slot = "6")]
			get
			{
				return "发射的子弹附带追踪效果";
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x00126E08 File Offset: 0x00125008
		[Token(Token = "0x17000271")]
		public override int Cost
		{
			[Token(Token = "0x60036D5")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x00126E18 File Offset: 0x00125018
		[Token(Token = "0x17000272")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036D6")]
			[Address(RVA = "0x778730", Offset = "0x776D30", VA = "0x180778730", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00126E54 File Offset: 0x00125054
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public StarFruit()
		{
		}
	}
}
