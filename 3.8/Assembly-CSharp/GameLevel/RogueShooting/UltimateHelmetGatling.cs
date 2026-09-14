using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C18 RID: 3096
	[Token(Token = "0x2000C18")]
	public class UltimateHelmetGatling : BaseConfig
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x00155B74 File Offset: 0x00153D74
		[Token(Token = "0x170004FF")]
		public override string Role
		{
			[Token(Token = "0x60040A5")]
			[Address(RVA = "0x842950", Offset = "0x840F50", VA = "0x180842950", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060040A6 RID: 16550 RVA: 0x00155B88 File Offset: 0x00153D88
		[Token(Token = "0x17000500")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60040A6")]
			[Address(RVA = "0x781780", Offset = "0x77FD80", VA = "0x180781780", Slot = "4")]
			get
			{
				return PlantType.UltimateHelmetGatling;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060040A7 RID: 16551 RVA: 0x00155B9C File Offset: 0x00153D9C
		[Token(Token = "0x17000501")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60040A7")]
			[Address(RVA = "0x8426A0", Offset = "0x840CA0", VA = "0x1808426A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateHelmetGatling.UniqueUpgrade uniqueUpgrade = new UltimateHelmetGatling.UniqueUpgrade();
				int size3 = list._size;
				UltimateHelmetGatling.SuperBuff superBuff = new UltimateHelmetGatling.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00155BF4 File Offset: 0x00153DF4
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x842660", Offset = "0x840C60", VA = "0x180842660", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 6f, num2 != 0, num);
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00155C1C File Offset: 0x00153E1C
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateHelmetGatling()
		{
		}

		// Token: 0x02000C19 RID: 3097
		[Token(Token = "0x2000C19")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000502 RID: 1282
			// (get) Token: 0x060040AA RID: 16554 RVA: 0x00155C30 File Offset: 0x00153E30
			[Token(Token = "0x17000502")]
			public override string Title
			{
				[Token(Token = "0x60040AA")]
				[Address(RVA = "0x846680", Offset = "0x844C80", VA = "0x180846680", Slot = "5")]
				get
				{
					return "强化：射击";
				}
			}

			// Token: 0x17000503 RID: 1283
			// (get) Token: 0x060040AB RID: 16555 RVA: 0x00155C44 File Offset: 0x00153E44
			[Token(Token = "0x17000503")]
			public override string Description
			{
				[Token(Token = "0x60040AB")]
				[Address(RVA = "0x846100", Offset = "0x844700", VA = "0x180846100", Slot = "6")]
				get
				{
					return base.PlantName + "保底时大招所需射击子弹数-10";
				}
			}

			// Token: 0x17000504 RID: 1284
			// (get) Token: 0x060040AC RID: 16556 RVA: 0x00155C64 File Offset: 0x00153E64
			[Token(Token = "0x17000504")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60040AC")]
				[Address(RVA = "0x781780", Offset = "0x77FD80", VA = "0x180781780", Slot = "4")]
				get
				{
					return PlantType.UltimateHelmetGatling;
				}
			}

			// Token: 0x17000505 RID: 1285
			// (get) Token: 0x060040AD RID: 16557 RVA: 0x00155C78 File Offset: 0x00153E78
			[Token(Token = "0x17000505")]
			public override float AppearWeight
			{
				[Token(Token = "0x60040AD")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060040AE RID: 16558 RVA: 0x00155C8C File Offset: 0x00153E8C
			[Token(Token = "0x60040AE")]
			[Address(RVA = "0x845510", Offset = "0x843B10", VA = "0x180845510", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000506 RID: 1286
			// (get) Token: 0x060040AF RID: 16559 RVA: 0x00155CAC File Offset: 0x00153EAC
			[Token(Token = "0x17000506")]
			public override Quality Rarity
			{
				[Token(Token = "0x60040AF")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060040B0 RID: 16560 RVA: 0x00155CBC File Offset: 0x00153EBC
			[Token(Token = "0x60040B0")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C1A RID: 3098
		[Token(Token = "0x2000C1A")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000507 RID: 1287
			// (get) Token: 0x060040B1 RID: 16561 RVA: 0x00155CD0 File Offset: 0x00153ED0
			[Token(Token = "0x17000507")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60040B1")]
				[Address(RVA = "0x781780", Offset = "0x77FD80", VA = "0x180781780", Slot = "4")]
				get
				{
					return PlantType.UltimateHelmetGatling;
				}
			}

			// Token: 0x17000508 RID: 1288
			// (get) Token: 0x060040B2 RID: 16562 RVA: 0x00155CE4 File Offset: 0x00153EE4
			[Token(Token = "0x17000508")]
			public override string Title
			{
				[Token(Token = "0x60040B2")]
				[Address(RVA = "0x83A670", Offset = "0x838C70", VA = "0x18083A670", Slot = "5")]
				get
				{
					return "质变：致密";
				}
			}

			// Token: 0x17000509 RID: 1289
			// (get) Token: 0x060040B3 RID: 16563 RVA: 0x00155CF8 File Offset: 0x00153EF8
			[Token(Token = "0x17000509")]
			public override string Description
			{
				[Token(Token = "0x60040B3")]
				[Address(RVA = "0x839F60", Offset = "0x838560", VA = "0x180839F60", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12013];
				}
			}

			// Token: 0x1700050A RID: 1290
			// (get) Token: 0x060040B4 RID: 16564 RVA: 0x00155D1C File Offset: 0x00153F1C
			[Token(Token = "0x1700050A")]
			public override Quality Rarity
			{
				[Token(Token = "0x60040B4")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700050B RID: 1291
			// (get) Token: 0x060040B5 RID: 16565 RVA: 0x00155D2C File Offset: 0x00153F2C
			[Token(Token = "0x1700050B")]
			public override int MaxCount
			{
				[Token(Token = "0x60040B5")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700050C RID: 1292
			// (get) Token: 0x060040B6 RID: 16566 RVA: 0x00155D3C File Offset: 0x00153F3C
			[Token(Token = "0x1700050C")]
			public override float AppearWeight
			{
				[Token(Token = "0x60040B6")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060040B7 RID: 16567 RVA: 0x00155D50 File Offset: 0x00153F50
			[Token(Token = "0x60040B7")]
			[Address(RVA = "0x839A30", Offset = "0x838030", VA = "0x180839A30", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12013));
			}

			// Token: 0x060040B8 RID: 16568 RVA: 0x00155D78 File Offset: 0x00153F78
			[Token(Token = "0x60040B8")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
