using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC4 RID: 2756
	[Token(Token = "0x2000AC4")]
	public class SuperChomper : PlantData
	{
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x0012CD90 File Offset: 0x0012AF90
		[Token(Token = "0x17000324")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600389A")]
			[Address(RVA = "0x3F3540", Offset = "0x3F1B40", VA = "0x1803F3540", Slot = "4")]
			get
			{
				return PlantType.SuperChomper;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600389B RID: 14491 RVA: 0x0012CDA4 File Offset: 0x0012AFA4
		[Token(Token = "0x17000325")]
		public override string Title
		{
			[Token(Token = "0x600389B")]
			[Address(RVA = "0x7DFD50", Offset = "0x7DE350", VA = "0x1807DFD50", Slot = "5")]
			get
			{
				return "弱者斩杀";
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x0012CDB8 File Offset: 0x0012AFB8
		[Token(Token = "0x17000326")]
		public override string Description
		{
			[Token(Token = "0x600389C")]
			[Address(RVA = "0x7DFC00", Offset = "0x7DE200", VA = "0x1807DFC00", Slot = "6")]
			get
			{
				return "超级大嘴花的攻击力提高，斩杀线也提高";
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600389D RID: 14493 RVA: 0x0012CDCC File Offset: 0x0012AFCC
		[Token(Token = "0x17000327")]
		public override int Cost
		{
			[Token(Token = "0x600389D")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x0012CDDC File Offset: 0x0012AFDC
		[Token(Token = "0x17000328")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600389E")]
			[Address(RVA = "0x7DFC30", Offset = "0x7DE230", VA = "0x1807DFC30", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x0012CE18 File Offset: 0x0012B018
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public SuperChomper()
		{
		}
	}
}
