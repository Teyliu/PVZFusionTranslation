using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C1C RID: 3100
	[Token(Token = "0x2000C1C")]
	public class UltimateLanternSplit : BaseConfig
	{
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x00155E44 File Offset: 0x00154044
		[Token(Token = "0x17000510")]
		public override string Role
		{
			[Token(Token = "0x60040BE")]
			[Address(RVA = "0x8430A0", Offset = "0x8416A0", VA = "0x1808430A0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x00155E58 File Offset: 0x00154058
		[Token(Token = "0x17000511")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60040BF")]
			[Address(RVA = "0x781AF0", Offset = "0x7800F0", VA = "0x180781AF0", Slot = "4")]
			get
			{
				return PlantType.UltimateLanternSplit;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x00155E6C File Offset: 0x0015406C
		[Token(Token = "0x17000512")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60040C0")]
			[Address(RVA = "0x842DF0", Offset = "0x8413F0", VA = "0x180842DF0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateLanternSplit.UniqueUpgrade uniqueUpgrade = new UltimateLanternSplit.UniqueUpgrade();
				int size3 = list._size;
				UltimateLanternSplit.SuperBuff superBuff = new UltimateLanternSplit.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00155EC4 File Offset: 0x001540C4
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x842D90", Offset = "0x841390", VA = "0x180842D90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			float attributeFloat = plant.attributeFloat;
			plant.attributeFloat = attributeFloat;
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00155EE8 File Offset: 0x001540E8
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateLanternSplit()
		{
		}

		// Token: 0x02000C1D RID: 3101
		[Token(Token = "0x2000C1D")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x060040C3 RID: 16579 RVA: 0x00155EFC File Offset: 0x001540FC
			[Token(Token = "0x17000513")]
			public override string Title
			{
				[Token(Token = "0x60040C3")]
				[Address(RVA = "0x8469B0", Offset = "0x844FB0", VA = "0x1808469B0", Slot = "5")]
				get
				{
					return "强化：天网";
				}
			}

			// Token: 0x17000514 RID: 1300
			// (get) Token: 0x060040C4 RID: 16580 RVA: 0x00155F10 File Offset: 0x00154110
			[Token(Token = "0x17000514")]
			public override string Description
			{
				[Token(Token = "0x60040C4")]
				[Address(RVA = "0x8461A0", Offset = "0x8447A0", VA = "0x1808461A0", Slot = "6")]
				get
				{
					return base.PlantName + "在前方生成一束天网攻击僵尸";
				}
			}

			// Token: 0x17000515 RID: 1301
			// (get) Token: 0x060040C5 RID: 16581 RVA: 0x00155F30 File Offset: 0x00154130
			[Token(Token = "0x17000515")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60040C5")]
				[Address(RVA = "0x781AF0", Offset = "0x7800F0", VA = "0x180781AF0", Slot = "4")]
				get
				{
					return PlantType.UltimateLanternSplit;
				}
			}

			// Token: 0x17000516 RID: 1302
			// (get) Token: 0x060040C6 RID: 16582 RVA: 0x00155F44 File Offset: 0x00154144
			[Token(Token = "0x17000516")]
			public override float AppearWeight
			{
				[Token(Token = "0x60040C6")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000517 RID: 1303
			// (get) Token: 0x060040C7 RID: 16583 RVA: 0x00155F58 File Offset: 0x00154158
			[Token(Token = "0x17000517")]
			public override int MaxCount
			{
				[Token(Token = "0x60040C7")]
				[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x060040C8 RID: 16584 RVA: 0x00155F68 File Offset: 0x00154168
			[Token(Token = "0x60040C8")]
			[Address(RVA = "0x845DD0", Offset = "0x8443D0", VA = "0x180845DD0", Slot = "7")]
			public override void OnGet()
			{
				int num = 0;
				if (ShootingManager.Instance.TryGetPlant((PlantType)((uint)984), num))
				{
				}
			}

			// Token: 0x17000518 RID: 1304
			// (get) Token: 0x060040C9 RID: 16585 RVA: 0x00155F94 File Offset: 0x00154194
			[Token(Token = "0x17000518")]
			public override Quality Rarity
			{
				[Token(Token = "0x60040C9")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060040CA RID: 16586 RVA: 0x00155FA4 File Offset: 0x001541A4
			[Token(Token = "0x60040CA")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C1E RID: 3102
		[Token(Token = "0x2000C1E")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000519 RID: 1305
			// (get) Token: 0x060040CB RID: 16587 RVA: 0x00155FB8 File Offset: 0x001541B8
			[Token(Token = "0x17000519")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60040CB")]
				[Address(RVA = "0x781AF0", Offset = "0x7800F0", VA = "0x180781AF0", Slot = "4")]
				get
				{
					return PlantType.UltimateLanternSplit;
				}
			}

			// Token: 0x1700051A RID: 1306
			// (get) Token: 0x060040CC RID: 16588 RVA: 0x00155FCC File Offset: 0x001541CC
			[Token(Token = "0x1700051A")]
			public override string Title
			{
				[Token(Token = "0x60040CC")]
				[Address(RVA = "0x83A550", Offset = "0x838B50", VA = "0x18083A550", Slot = "5")]
				get
				{
					return "质变：湮灭之核";
				}
			}

			// Token: 0x1700051B RID: 1307
			// (get) Token: 0x060040CD RID: 16589 RVA: 0x00155FE0 File Offset: 0x001541E0
			[Token(Token = "0x1700051B")]
			public override string Description
			{
				[Token(Token = "0x60040CD")]
				[Address(RVA = "0x83A370", Offset = "0x838970", VA = "0x18083A370", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12010];
				}
			}

			// Token: 0x1700051C RID: 1308
			// (get) Token: 0x060040CE RID: 16590 RVA: 0x00156004 File Offset: 0x00154204
			[Token(Token = "0x1700051C")]
			public override Quality Rarity
			{
				[Token(Token = "0x60040CE")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700051D RID: 1309
			// (get) Token: 0x060040CF RID: 16591 RVA: 0x00156014 File Offset: 0x00154214
			[Token(Token = "0x1700051D")]
			public override float AppearWeight
			{
				[Token(Token = "0x60040CF")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700051E RID: 1310
			// (get) Token: 0x060040D0 RID: 16592 RVA: 0x00156028 File Offset: 0x00154228
			[Token(Token = "0x1700051E")]
			public override int MaxCount
			{
				[Token(Token = "0x60040D0")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x060040D1 RID: 16593 RVA: 0x00156038 File Offset: 0x00154238
			[Token(Token = "0x60040D1")]
			[Address(RVA = "0x839B50", Offset = "0x838150", VA = "0x180839B50", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12010));
			}

			// Token: 0x060040D2 RID: 16594 RVA: 0x00156060 File Offset: 0x00154260
			[Token(Token = "0x60040D2")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
