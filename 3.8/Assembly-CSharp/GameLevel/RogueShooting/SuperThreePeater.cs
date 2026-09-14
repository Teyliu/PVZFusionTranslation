using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C74 RID: 3188
	[Token(Token = "0x2000C74")]
	public class SuperThreePeater : BaseConfig
	{
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060042C3 RID: 17091 RVA: 0x001597C4 File Offset: 0x001579C4
		[Token(Token = "0x17000658")]
		public override string Role
		{
			[Token(Token = "0x60042C3")]
			[Address(RVA = "0x83AFD0", Offset = "0x8395D0", VA = "0x18083AFD0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x001597D8 File Offset: 0x001579D8
		[Token(Token = "0x17000659")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60042C4")]
			[Address(RVA = "0x83A420", Offset = "0x838A20", VA = "0x18083A420", Slot = "4")]
			get
			{
				return PlantType.SuperThreePeater;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060042C5 RID: 17093 RVA: 0x001597EC File Offset: 0x001579EC
		[Token(Token = "0x1700065A")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60042C5")]
			[Address(RVA = "0x83AE40", Offset = "0x839440", VA = "0x18083AE40", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				SuperThreePeater.UniqueUpgrade uniqueUpgrade = new SuperThreePeater.UniqueUpgrade();
				int size = list._size;
				SuperThreePeater.SuperBuff superBuff = new SuperThreePeater.SuperBuff();
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x0015982C File Offset: 0x00157A2C
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x83ADE0", Offset = "0x8393E0", VA = "0x18083ADE0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00159844 File Offset: 0x00157A44
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SuperThreePeater()
		{
		}

		// Token: 0x02000C75 RID: 3189
		[Token(Token = "0x2000C75")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x060042C8 RID: 17096 RVA: 0x00159858 File Offset: 0x00157A58
			[Token(Token = "0x1700065B")]
			public override bool Passive
			{
				[Token(Token = "0x60042C8")]
				[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x060042C9 RID: 17097 RVA: 0x00159868 File Offset: 0x00157A68
			[Token(Token = "0x1700065C")]
			public override string Title
			{
				[Token(Token = "0x60042C9")]
				[Address(RVA = "0x8468F0", Offset = "0x844EF0", VA = "0x1808468F0", Slot = "5")]
				get
				{
					return "强化：红温";
				}
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x060042CA RID: 17098 RVA: 0x0015987C File Offset: 0x00157A7C
			[Token(Token = "0x1700065D")]
			public override string Description
			{
				[Token(Token = "0x60042CA")]
				[Address(RVA = "0x846510", Offset = "0x844B10", VA = "0x180846510", Slot = "6")]
				get
				{
					return "红温伤害增幅提高60%";
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x060042CB RID: 17099 RVA: 0x00159890 File Offset: 0x00157A90
			[Token(Token = "0x1700065E")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60042CB")]
				[Address(RVA = "0x83A420", Offset = "0x838A20", VA = "0x18083A420", Slot = "4")]
				get
				{
					return PlantType.SuperThreePeater;
				}
			}

			// Token: 0x060042CC RID: 17100 RVA: 0x001598A4 File Offset: 0x00157AA4
			[Token(Token = "0x60042CC")]
			[Address(RVA = "0x845410", Offset = "0x843A10", VA = "0x180845410", Slot = "7")]
			public override void OnGet()
			{
				TravelData data = TravelMgr.Instance.data;
				float jalaMore = data.jalaMore;
				data.jalaMore = jalaMore;
			}

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x060042CD RID: 17101 RVA: 0x001598D4 File Offset: 0x00157AD4
			[Token(Token = "0x1700065F")]
			public override Quality Rarity
			{
				[Token(Token = "0x60042CD")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060042CE RID: 17102 RVA: 0x001598E4 File Offset: 0x00157AE4
			[Token(Token = "0x60042CE")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C76 RID: 3190
		[Token(Token = "0x2000C76")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x060042CF RID: 17103 RVA: 0x001598F8 File Offset: 0x00157AF8
			[Token(Token = "0x17000660")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60042CF")]
				[Address(RVA = "0x83A420", Offset = "0x838A20", VA = "0x18083A420", Slot = "4")]
				get
				{
					return PlantType.SuperThreePeater;
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x060042D0 RID: 17104 RVA: 0x0015990C File Offset: 0x00157B0C
			[Token(Token = "0x17000661")]
			public override string Title
			{
				[Token(Token = "0x60042D0")]
				[Address(RVA = "0x83A5E0", Offset = "0x838BE0", VA = "0x18083A5E0", Slot = "5")]
				get
				{
					return "质变：百步穿杨";
				}
			}

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x060042D1 RID: 17105 RVA: 0x00159920 File Offset: 0x00157B20
			[Token(Token = "0x17000662")]
			public override string Description
			{
				[Token(Token = "0x60042D1")]
				[Address(RVA = "0x83A2A0", Offset = "0x8388A0", VA = "0x18083A2A0", Slot = "6")]
				get
				{
					return base.PlantName + "变为五线射手，子弹可无限穿透";
				}
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x060042D2 RID: 17106 RVA: 0x00159940 File Offset: 0x00157B40
			[Token(Token = "0x17000663")]
			public override Quality Rarity
			{
				[Token(Token = "0x60042D2")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x060042D3 RID: 17107 RVA: 0x00159950 File Offset: 0x00157B50
			[Token(Token = "0x17000664")]
			public override float AppearWeight
			{
				[Token(Token = "0x60042D3")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x060042D4 RID: 17108 RVA: 0x00159964 File Offset: 0x00157B64
			[Token(Token = "0x17000665")]
			public override int MaxCount
			{
				[Token(Token = "0x60042D4")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x060042D5 RID: 17109 RVA: 0x00159974 File Offset: 0x00157B74
			[Token(Token = "0x60042D5")]
			[Address(RVA = "0x839AF0", Offset = "0x8380F0", VA = "0x180839AF0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12008));
			}

			// Token: 0x060042D6 RID: 17110 RVA: 0x0015999C File Offset: 0x00157B9C
			[Token(Token = "0x60042D6")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
