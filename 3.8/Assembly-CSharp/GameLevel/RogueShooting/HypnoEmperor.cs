using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C59 RID: 3161
	[Token(Token = "0x2000C59")]
	public class HypnoEmperor : BaseConfig
	{
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600422D RID: 16941 RVA: 0x00158648 File Offset: 0x00156848
		[Token(Token = "0x170005FC")]
		public override string Role
		{
			[Token(Token = "0x600422D")]
			[Address(RVA = "0x832790", Offset = "0x830D90", VA = "0x180832790", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x0015865C File Offset: 0x0015685C
		[Token(Token = "0x170005FD")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600422E")]
			[Address(RVA = "0x830040", Offset = "0x82E640", VA = "0x180830040", Slot = "4")]
			get
			{
				return PlantType.HypnoEmperor;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x00158670 File Offset: 0x00156870
		[Token(Token = "0x170005FE")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600422F")]
			[Address(RVA = "0x8324E0", Offset = "0x830AE0", VA = "0x1808324E0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				HypnoEmperor.CountBuff countBuff = new HypnoEmperor.CountBuff();
				int size3 = list._size;
				HypnoEmperor.SuperBuff superBuff = new HypnoEmperor.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x001586C8 File Offset: 0x001568C8
		[Token(Token = "0x6004230")]
		[Address(RVA = "0x8322D0", Offset = "0x8308D0", VA = "0x1808322D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			TravelMgr instance = TravelMgr.Instance;
			int num = 0;
			instance.GetNormalBuff((AdvBuff)num);
			TravelMgr instance2 = TravelMgr.Instance;
			if (HypnoEmperor.<>c.<>9__6_0 == 0 || plant != 0)
			{
				if (plant != 0)
				{
				}
				Action<Zombie> action;
				HypnoEmperor.<>c.<>9__6_0 = action;
			}
			throw new NullReferenceException();
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x00158710 File Offset: 0x00156910
		[Token(Token = "0x6004231")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public HypnoEmperor()
		{
		}

		// Token: 0x02000C5A RID: 3162
		[Token(Token = "0x2000C5A")]
		private class CountBuff : BaseBuff
		{
			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x06004232 RID: 16946 RVA: 0x00158724 File Offset: 0x00156924
			[Token(Token = "0x170005FF")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004232")]
				[Address(RVA = "0x830040", Offset = "0x82E640", VA = "0x180830040", Slot = "4")]
				get
				{
					return PlantType.HypnoEmperor;
				}
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x06004233 RID: 16947 RVA: 0x00158738 File Offset: 0x00156938
			[Token(Token = "0x17000600")]
			public override string Title
			{
				[Token(Token = "0x6004233")]
				[Address(RVA = "0x830050", Offset = "0x82E650", VA = "0x180830050", Slot = "5")]
				get
				{
					return "强化：数量";
				}
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x06004234 RID: 16948 RVA: 0x0015874C File Offset: 0x0015694C
			[Token(Token = "0x17000601")]
			public override string Description
			{
				[Token(Token = "0x6004234")]
				[Address(RVA = "0x830010", Offset = "0x82E610", VA = "0x180830010", Slot = "6")]
				get
				{
					return "每次召唤多生成一只僵尸";
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x06004235 RID: 16949 RVA: 0x00158760 File Offset: 0x00156960
			[Token(Token = "0x17000602")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004235")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x06004236 RID: 16950 RVA: 0x00158770 File Offset: 0x00156970
			[Token(Token = "0x17000603")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004236")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004237 RID: 16951 RVA: 0x00158784 File Offset: 0x00156984
			[Token(Token = "0x6004237")]
			[Address(RVA = "0x82FEF0", Offset = "0x82E4F0", VA = "0x18082FEF0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = HypnoEmperor.CountBuff.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					HypnoEmperor.CountBuff.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x06004238 RID: 16952 RVA: 0x001587B0 File Offset: 0x001569B0
			[Token(Token = "0x6004238")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public CountBuff()
			{
			}
		}

		// Token: 0x02000C5C RID: 3164
		[Token(Token = "0x2000C5C")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x0600423C RID: 16956 RVA: 0x001587C4 File Offset: 0x001569C4
			[Token(Token = "0x17000604")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600423C")]
				[Address(RVA = "0x830040", Offset = "0x82E640", VA = "0x180830040", Slot = "4")]
				get
				{
					return PlantType.HypnoEmperor;
				}
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x0600423D RID: 16957 RVA: 0x001587D8 File Offset: 0x001569D8
			[Token(Token = "0x17000605")]
			public override string Title
			{
				[Token(Token = "0x600423D")]
				[Address(RVA = "0x83A430", Offset = "0x838A30", VA = "0x18083A430", Slot = "5")]
				get
				{
					return "质变：精英";
				}
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x0600423E RID: 16958 RVA: 0x001587EC File Offset: 0x001569EC
			[Token(Token = "0x17000606")]
			public override string Description
			{
				[Token(Token = "0x600423E")]
				[Address(RVA = "0x83A060", Offset = "0x838660", VA = "0x18083A060", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12012];
				}
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x0600423F RID: 16959 RVA: 0x00158810 File Offset: 0x00156A10
			[Token(Token = "0x17000607")]
			public override Quality Rarity
			{
				[Token(Token = "0x600423F")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x06004240 RID: 16960 RVA: 0x00158820 File Offset: 0x00156A20
			[Token(Token = "0x17000608")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004240")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004241 RID: 16961 RVA: 0x00158834 File Offset: 0x00156A34
			[Token(Token = "0x6004241")]
			[Address(RVA = "0x839BB0", Offset = "0x8381B0", VA = "0x180839BB0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12012));
			}

			// Token: 0x06004242 RID: 16962 RVA: 0x0015885C File Offset: 0x00156A5C
			[Token(Token = "0x6004242")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
