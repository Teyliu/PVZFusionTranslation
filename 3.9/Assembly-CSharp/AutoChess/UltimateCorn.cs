using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ADA RID: 2778
	[Token(Token = "0x2000ADA")]
	public class UltimateCorn : PlantData
	{
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x0012DB18 File Offset: 0x0012BD18
		[Token(Token = "0x17000392")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600391E")]
			[Address(RVA = "0x7E8310", Offset = "0x7E6910", VA = "0x1807E8310", Slot = "4")]
			get
			{
				return PlantType.UltimateCorn;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x0012DB2C File Offset: 0x0012BD2C
		[Token(Token = "0x17000393")]
		public override string Title
		{
			[Token(Token = "0x600391F")]
			[Address(RVA = "0x7E8440", Offset = "0x7E6A40", VA = "0x1807E8440", Slot = "5")]
			get
			{
				return "黑洞领域";
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x0012DB40 File Offset: 0x0012BD40
		[Token(Token = "0x17000394")]
		public override string Description
		{
			[Token(Token = "0x6003920")]
			[Address(RVA = "0x7E82E0", Offset = "0x7E68E0", VA = "0x1807E82E0", Slot = "6")]
			get
			{
				return "黑洞爆炸会延后战斗结束倒计时";
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06003921 RID: 14625 RVA: 0x0012DB54 File Offset: 0x0012BD54
		[Token(Token = "0x17000395")]
		public override int Cost
		{
			[Token(Token = "0x6003921")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x0012DB64 File Offset: 0x0012BD64
		[Token(Token = "0x17000396")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003922")]
			[Address(RVA = "0x7E8320", Offset = "0x7E6920", VA = "0x1807E8320", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x0012DBA0 File Offset: 0x0012BDA0
		[Token(Token = "0x6003923")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateCorn()
		{
		}
	}
}
