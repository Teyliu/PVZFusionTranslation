using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB2 RID: 2738
	[Token(Token = "0x2000AB2")]
	public class GoldMelon : PlantData
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x0012C260 File Offset: 0x0012A460
		[Token(Token = "0x170002CA")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600382E")]
			[Address(RVA = "0x7D25D0", Offset = "0x7D0BD0", VA = "0x1807D25D0", Slot = "4")]
			get
			{
				return PlantType.GoldMelon;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x0012C274 File Offset: 0x0012A474
		[Token(Token = "0x170002CB")]
		public override string Title
		{
			[Token(Token = "0x600382F")]
			[Address(RVA = "0x7D2700", Offset = "0x7D0D00", VA = "0x1807D2700", Slot = "5")]
			get
			{
				return "金瓜如梦";
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x0012C288 File Offset: 0x0012A488
		[Token(Token = "0x170002CC")]
		public override string Description
		{
			[Token(Token = "0x6003830")]
			[Address(RVA = "0x7D25A0", Offset = "0x7D0BA0", VA = "0x1807D25A0", Slot = "6")]
			get
			{
				return "攻击力随攻速增加而增加";
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x0012C29C File Offset: 0x0012A49C
		[Token(Token = "0x170002CD")]
		public override int Cost
		{
			[Token(Token = "0x6003831")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x0012C2AC File Offset: 0x0012A4AC
		[Token(Token = "0x170002CE")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003832")]
			[Address(RVA = "0x7D25E0", Offset = "0x7D0BE0", VA = "0x1807D25E0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x0012C2E8 File Offset: 0x0012A4E8
		[Token(Token = "0x6003833")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public GoldMelon()
		{
		}
	}
}
