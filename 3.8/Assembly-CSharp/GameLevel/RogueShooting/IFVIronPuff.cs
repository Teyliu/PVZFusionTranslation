using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C45 RID: 3141
	[Token(Token = "0x2000C45")]
	public class IFVIronPuff : BaseConfig
	{
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x001579B4 File Offset: 0x00155BB4
		[Token(Token = "0x170005B0")]
		public override string Role
		{
			[Token(Token = "0x60041B7")]
			[Address(RVA = "0x832D70", Offset = "0x831370", VA = "0x180832D70", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060041B8 RID: 16824 RVA: 0x001579C8 File Offset: 0x00155BC8
		[Token(Token = "0x170005B1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041B8")]
			[Address(RVA = "0x831AD0", Offset = "0x8300D0", VA = "0x180831AD0", Slot = "4")]
			get
			{
				return PlantType.IFVIronPuff;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x001579DC File Offset: 0x00155BDC
		[Token(Token = "0x170005B2")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041B9")]
			[Address(RVA = "0x832AC0", Offset = "0x8310C0", VA = "0x180832AC0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				IFVIronPuff.PierceBuff pierceBuff = new IFVIronPuff.PierceBuff();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				IFVIronPuff.HeadShotBuff headShotBuff = new IFVIronPuff.HeadShotBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x00157A34 File Offset: 0x00155C34
		[Token(Token = "0x60041BA")]
		[Address(RVA = "0x832A70", Offset = "0x831070", VA = "0x180832A70", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x00157A4C File Offset: 0x00155C4C
		[Token(Token = "0x60041BB")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public IFVIronPuff()
		{
		}

		// Token: 0x02000C46 RID: 3142
		[Token(Token = "0x2000C46")]
		private class PierceBuff : BaseBuff
		{
			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x060041BC RID: 16828 RVA: 0x00157A60 File Offset: 0x00155C60
			[Token(Token = "0x170005B3")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60041BC")]
				[Address(RVA = "0x831AD0", Offset = "0x8300D0", VA = "0x180831AD0", Slot = "4")]
				get
				{
					return PlantType.IFVIronPuff;
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x060041BD RID: 16829 RVA: 0x00157A74 File Offset: 0x00155C74
			[Token(Token = "0x170005B4")]
			public override string Title
			{
				[Token(Token = "0x60041BD")]
				[Address(RVA = "0x8357A0", Offset = "0x833DA0", VA = "0x1808357A0", Slot = "5")]
				get
				{
					return "强化：贯穿";
				}
			}

			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x060041BE RID: 16830 RVA: 0x00157A88 File Offset: 0x00155C88
			[Token(Token = "0x170005B5")]
			public override string Description
			{
				[Token(Token = "0x60041BE")]
				[Address(RVA = "0x835740", Offset = "0x833D40", VA = "0x180835740", Slot = "6")]
				get
				{
					return "狙击穿透+2";
				}
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x060041BF RID: 16831 RVA: 0x00157A9C File Offset: 0x00155C9C
			[Token(Token = "0x170005B6")]
			public override float AppearWeight
			{
				[Token(Token = "0x60041BF")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060041C0 RID: 16832 RVA: 0x00157AB0 File Offset: 0x00155CB0
			[Token(Token = "0x60041C0")]
			[Address(RVA = "0x8355D0", Offset = "0x833BD0", VA = "0x1808355D0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = IFVIronPuff.PierceBuff.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					IFVIronPuff.PierceBuff.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x060041C1 RID: 16833 RVA: 0x00157ADC File Offset: 0x00155CDC
			[Token(Token = "0x170005B7")]
			public override Quality Rarity
			{
				[Token(Token = "0x60041C1")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060041C2 RID: 16834 RVA: 0x00157AEC File Offset: 0x00155CEC
			[Token(Token = "0x60041C2")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public PierceBuff()
			{
			}
		}

		// Token: 0x02000C48 RID: 3144
		[Token(Token = "0x2000C48")]
		private class HeadShotBuff : BaseBuff
		{
			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x060041C6 RID: 16838 RVA: 0x00157B00 File Offset: 0x00155D00
			[Token(Token = "0x170005B8")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60041C6")]
				[Address(RVA = "0x831AD0", Offset = "0x8300D0", VA = "0x180831AD0", Slot = "4")]
				get
				{
					return PlantType.IFVIronPuff;
				}
			}

			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x060041C7 RID: 16839 RVA: 0x00157B14 File Offset: 0x00155D14
			[Token(Token = "0x170005B9")]
			public override string Title
			{
				[Token(Token = "0x60041C7")]
				[Address(RVA = "0x831AE0", Offset = "0x8300E0", VA = "0x180831AE0", Slot = "5")]
				get
				{
					return "质变：反弹";
				}
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x060041C8 RID: 16840 RVA: 0x00157B28 File Offset: 0x00155D28
			[Token(Token = "0x170005BA")]
			public override string Description
			{
				[Token(Token = "0x60041C8")]
				[Address(RVA = "0x831A50", Offset = "0x830050", VA = "0x180831A50", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12011];
				}
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x060041C9 RID: 16841 RVA: 0x00157B4C File Offset: 0x00155D4C
			[Token(Token = "0x170005BB")]
			public override Quality Rarity
			{
				[Token(Token = "0x60041C9")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x060041CA RID: 16842 RVA: 0x00157B5C File Offset: 0x00155D5C
			[Token(Token = "0x170005BC")]
			public override int MaxCount
			{
				[Token(Token = "0x60041CA")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x060041CB RID: 16843 RVA: 0x00157B6C File Offset: 0x00155D6C
			[Token(Token = "0x170005BD")]
			public override float AppearWeight
			{
				[Token(Token = "0x60041CB")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060041CC RID: 16844 RVA: 0x00157B80 File Offset: 0x00155D80
			[Token(Token = "0x60041CC")]
			[Address(RVA = "0x8319F0", Offset = "0x82FFF0", VA = "0x1808319F0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12011));
			}

			// Token: 0x060041CD RID: 16845 RVA: 0x00157BA8 File Offset: 0x00155DA8
			[Token(Token = "0x60041CD")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public HeadShotBuff()
			{
			}
		}
	}
}
