using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ACC RID: 2764
	[Token(Token = "0x2000ACC")]
	public class ChomperPumpkin : PlantData
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x0012D280 File Offset: 0x0012B480
		[Token(Token = "0x1700034C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038CA")]
			[Address(RVA = "0x7CEB40", Offset = "0x7CD140", VA = "0x1807CEB40", Slot = "4")]
			get
			{
				return PlantType.ChomperPumpkin;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0012D294 File Offset: 0x0012B494
		[Token(Token = "0x1700034D")]
		public override string Title
		{
			[Token(Token = "0x60038CB")]
			[Address(RVA = "0x7CEC70", Offset = "0x7CD270", VA = "0x1807CEC70", Slot = "5")]
			get
			{
				return "护你左右";
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060038CC RID: 14540 RVA: 0x0012D2A8 File Offset: 0x0012B4A8
		[Token(Token = "0x1700034E")]
		public override string Description
		{
			[Token(Token = "0x60038CC")]
			[Address(RVA = "0x7CEB10", Offset = "0x7CD110", VA = "0x1807CEB10", Slot = "6")]
			get
			{
				return "出场自带点数，点数上限增加";
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x0012D2BC File Offset: 0x0012B4BC
		[Token(Token = "0x1700034F")]
		public override int Cost
		{
			[Token(Token = "0x60038CD")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x0012D2CC File Offset: 0x0012B4CC
		[Token(Token = "0x17000350")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038CE")]
			[Address(RVA = "0x7CEB50", Offset = "0x7CD150", VA = "0x1807CEB50", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x0012D308 File Offset: 0x0012B508
		[Token(Token = "0x60038CF")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ChomperPumpkin()
		{
		}
	}
}
