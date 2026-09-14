using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CD7 RID: 3287
	[Token(Token = "0x2000CD7")]
	public class UltimateHelmetGatling : BaseConfig
	{
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x001627EC File Offset: 0x001609EC
		[Token(Token = "0x1700062E")]
		public override string Role
		{
			[Token(Token = "0x600442A")]
			[Address(RVA = "0x8C26F0", Offset = "0x8C0CF0", VA = "0x1808C26F0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x00162800 File Offset: 0x00160A00
		[Token(Token = "0x1700062F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600442B")]
			[Address(RVA = "0x7E8630", Offset = "0x7E6C30", VA = "0x1807E8630", Slot = "4")]
			get
			{
				return PlantType.UltimateHelmetGatling;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600442C RID: 17452 RVA: 0x00162814 File Offset: 0x00160A14
		[Token(Token = "0x17000630")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600442C")]
			[Address(RVA = "0x8C2440", Offset = "0x8C0A40", VA = "0x1808C2440", Slot = "5")]
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

		// Token: 0x0600442D RID: 17453 RVA: 0x0016286C File Offset: 0x00160A6C
		[Token(Token = "0x600442D")]
		[Address(RVA = "0x8C2400", Offset = "0x8C0A00", VA = "0x1808C2400", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 6f, num2 != 0, num);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x00162894 File Offset: 0x00160A94
		[Token(Token = "0x600442E")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateHelmetGatling()
		{
		}

		// Token: 0x02000CD8 RID: 3288
		[Token(Token = "0x2000CD8")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x0600442F RID: 17455 RVA: 0x001628A8 File Offset: 0x00160AA8
			[Token(Token = "0x17000631")]
			public override string Title
			{
				[Token(Token = "0x600442F")]
				[Address(RVA = "0x8C6C30", Offset = "0x8C5230", VA = "0x1808C6C30", Slot = "5")]
				get
				{
					return "强化：射击";
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x06004430 RID: 17456 RVA: 0x001628BC File Offset: 0x00160ABC
			[Token(Token = "0x17000632")]
			public override string Description
			{
				[Token(Token = "0x6004430")]
				[Address(RVA = "0x8C6680", Offset = "0x8C4C80", VA = "0x1808C6680", Slot = "6")]
				get
				{
					return base.PlantName + "保底时大招所需射击子弹数-10";
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x06004431 RID: 17457 RVA: 0x001628DC File Offset: 0x00160ADC
			[Token(Token = "0x17000633")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004431")]
				[Address(RVA = "0x7E8630", Offset = "0x7E6C30", VA = "0x1807E8630", Slot = "4")]
				get
				{
					return PlantType.UltimateHelmetGatling;
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x06004432 RID: 17458 RVA: 0x001628F0 File Offset: 0x00160AF0
			[Token(Token = "0x17000634")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004432")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004433 RID: 17459 RVA: 0x00162904 File Offset: 0x00160B04
			[Token(Token = "0x6004433")]
			[Address(RVA = "0x8C5790", Offset = "0x8C3D90", VA = "0x1808C5790", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06004434 RID: 17460 RVA: 0x00162924 File Offset: 0x00160B24
			[Token(Token = "0x17000635")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004434")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004435 RID: 17461 RVA: 0x00162934 File Offset: 0x00160B34
			[Token(Token = "0x6004435")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000CD9 RID: 3289
		[Token(Token = "0x2000CD9")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06004436 RID: 17462 RVA: 0x00162948 File Offset: 0x00160B48
			[Token(Token = "0x17000636")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004436")]
				[Address(RVA = "0x7E8630", Offset = "0x7E6C30", VA = "0x1807E8630", Slot = "4")]
				get
				{
					return PlantType.UltimateHelmetGatling;
				}
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x06004437 RID: 17463 RVA: 0x0016295C File Offset: 0x00160B5C
			[Token(Token = "0x17000637")]
			public override string Title
			{
				[Token(Token = "0x6004437")]
				[Address(RVA = "0x8B7480", Offset = "0x8B5A80", VA = "0x1808B7480", Slot = "5")]
				get
				{
					return "质变：致密";
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x06004438 RID: 17464 RVA: 0x00162970 File Offset: 0x00160B70
			[Token(Token = "0x17000638")]
			public override string Description
			{
				[Token(Token = "0x6004438")]
				[Address(RVA = "0x8B6BB0", Offset = "0x8B51B0", VA = "0x1808B6BB0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12013];
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x06004439 RID: 17465 RVA: 0x00162994 File Offset: 0x00160B94
			[Token(Token = "0x17000639")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004439")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x0600443A RID: 17466 RVA: 0x001629A4 File Offset: 0x00160BA4
			[Token(Token = "0x1700063A")]
			public override int MaxCount
			{
				[Token(Token = "0x600443A")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x0600443B RID: 17467 RVA: 0x001629B4 File Offset: 0x00160BB4
			[Token(Token = "0x1700063B")]
			public override float AppearWeight
			{
				[Token(Token = "0x600443B")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600443C RID: 17468 RVA: 0x001629C8 File Offset: 0x00160BC8
			[Token(Token = "0x600443C")]
			[Address(RVA = "0x8B6380", Offset = "0x8B4980", VA = "0x1808B6380", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12013));
			}

			// Token: 0x0600443D RID: 17469 RVA: 0x001629F0 File Offset: 0x00160BF0
			[Token(Token = "0x600443D")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
