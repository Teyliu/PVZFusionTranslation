using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD7 RID: 2775
	[Token(Token = "0x2000AD7")]
	public class UltimateBigChomper : PlantData
	{
		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x0012D944 File Offset: 0x0012BB44
		[Token(Token = "0x17000383")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600390C")]
			[Address(RVA = "0x7E7B40", Offset = "0x7E6140", VA = "0x1807E7B40", Slot = "4")]
			get
			{
				return PlantType.UltimateBigChomper;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x0012D958 File Offset: 0x0012BB58
		[Token(Token = "0x17000384")]
		public override string Title
		{
			[Token(Token = "0x600390D")]
			[Address(RVA = "0x7E7C70", Offset = "0x7E6270", VA = "0x1807E7C70", Slot = "5")]
			get
			{
				return "流量为王";
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x0012D96C File Offset: 0x0012BB6C
		[Token(Token = "0x17000385")]
		public override string Description
		{
			[Token(Token = "0x600390E")]
			[Address(RVA = "0x7E7B10", Offset = "0x7E6110", VA = "0x1807E7B10", Slot = "6")]
			get
			{
				return "开启晶矿可以获得强化";
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x0012D980 File Offset: 0x0012BB80
		[Token(Token = "0x17000386")]
		public override int Cost
		{
			[Token(Token = "0x600390F")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06003910 RID: 14608 RVA: 0x0012D990 File Offset: 0x0012BB90
		[Token(Token = "0x17000387")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003910")]
			[Address(RVA = "0x7E7B50", Offset = "0x7E6150", VA = "0x1807E7B50", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x0012D9CC File Offset: 0x0012BBCC
		[Token(Token = "0x6003911")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateBigChomper()
		{
		}
	}
}
