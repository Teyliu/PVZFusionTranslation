using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A67 RID: 2663
	[Token(Token = "0x2000A67")]
	public class WallNut : PlantData
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x00126990 File Offset: 0x00124B90
		[Token(Token = "0x1700024B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036A8")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "4")]
			get
			{
				return PlantType.WallNut;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x001269A0 File Offset: 0x00124BA0
		[Token(Token = "0x1700024C")]
		public override string Title
		{
			[Token(Token = "0x60036A9")]
			[Address(RVA = "0x7823E0", Offset = "0x7809E0", VA = "0x1807823E0", Slot = "5")]
			get
			{
				return "本坚果保护你！";
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x001269B4 File Offset: 0x00124BB4
		[Token(Token = "0x1700024D")]
		public override string Description
		{
			[Token(Token = "0x60036AA")]
			[Address(RVA = "0x782290", Offset = "0x780890", VA = "0x180782290", Slot = "6")]
			get
			{
				return "持续为周围3x3低血量植物提供护盾";
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x001269C8 File Offset: 0x00124BC8
		[Token(Token = "0x1700024E")]
		public override int Cost
		{
			[Token(Token = "0x60036AB")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x001269D8 File Offset: 0x00124BD8
		[Token(Token = "0x1700024F")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036AC")]
			[Address(RVA = "0x7822C0", Offset = "0x7808C0", VA = "0x1807822C0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00126A14 File Offset: 0x00124C14
		[Token(Token = "0x60036AD")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public WallNut()
		{
		}
	}
}
