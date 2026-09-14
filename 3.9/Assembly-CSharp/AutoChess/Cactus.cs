using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AAB RID: 2731
	[Token(Token = "0x2000AAB")]
	public class Cactus : PlantData
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x0012BE28 File Offset: 0x0012A028
		[Token(Token = "0x170002A7")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003804")]
			[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "4")]
			get
			{
				return PlantType.Cactus;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x0012BE38 File Offset: 0x0012A038
		[Token(Token = "0x170002A8")]
		public override string Title
		{
			[Token(Token = "0x6003805")]
			[Address(RVA = "0x7CE770", Offset = "0x7CCD70", VA = "0x1807CE770", Slot = "5")]
			get
			{
				return "玉石俱焚";
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06003806 RID: 14342 RVA: 0x0012BE4C File Offset: 0x0012A04C
		[Token(Token = "0x170002A9")]
		public override string Description
		{
			[Token(Token = "0x6003806")]
			[Address(RVA = "0x7CE620", Offset = "0x7CCC20", VA = "0x1807CE620", Slot = "6")]
			get
			{
				return "我方植物损失生命值时，仙人掌可积攒充能层数，以释放大招攻击敌人";
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x0012BE60 File Offset: 0x0012A060
		[Token(Token = "0x170002AA")]
		public override int Cost
		{
			[Token(Token = "0x6003807")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x0012BE70 File Offset: 0x0012A070
		[Token(Token = "0x170002AB")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003808")]
			[Address(RVA = "0x7CE650", Offset = "0x7CCC50", VA = "0x1807CE650", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x0012BEAC File Offset: 0x0012A0AC
		[Token(Token = "0x6003809")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Cactus()
		{
		}
	}
}
