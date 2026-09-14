using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CE2 RID: 3298
	[Token(Token = "0x2000CE2")]
	public class FireSniper : BaseConfig
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x00162F74 File Offset: 0x00161174
		[Token(Token = "0x1700065F")]
		public override string Role
		{
			[Token(Token = "0x6004471")]
			[Address(RVA = "0x8AC150", Offset = "0x8AA750", VA = "0x1808AC150", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x00162F88 File Offset: 0x00161188
		[Token(Token = "0x17000660")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004472")]
			[Address(RVA = "0x8AC140", Offset = "0x8AA740", VA = "0x1808AC140", Slot = "4")]
			get
			{
				return PlantType.FireSniper;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x00162F9C File Offset: 0x0016119C
		[Token(Token = "0x17000661")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004473")]
			[Address(RVA = "0x8ABE90", Offset = "0x8AA490", VA = "0x1808ABE90", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				FireSniper.UniqueUpgrade uniqueUpgrade = new FireSniper.UniqueUpgrade();
				int size3 = list._size;
				FireSniper.SuperUpgrade superUpgrade = new FireSniper.SuperUpgrade();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00162FF4 File Offset: 0x001611F4
		[Token(Token = "0x6004474")]
		[Address(RVA = "0x8ABDF0", Offset = "0x8AA3F0", VA = "0x1808ABDF0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.thePlantAttackInterval = 1f;
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00163018 File Offset: 0x00161218
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public FireSniper()
		{
		}

		// Token: 0x02000CE3 RID: 3299
		[Token(Token = "0x2000CE3")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x06004476 RID: 17526 RVA: 0x0016302C File Offset: 0x0016122C
			[Token(Token = "0x17000662")]
			public override string Title
			{
				[Token(Token = "0x6004476")]
				[Address(RVA = "0x8C6F90", Offset = "0x8C5590", VA = "0x1808C6F90", Slot = "5")]
				get
				{
					return "强化：密集火焰";
				}
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x06004477 RID: 17527 RVA: 0x00163040 File Offset: 0x00161240
			[Token(Token = "0x17000663")]
			public override string Description
			{
				[Token(Token = "0x6004477")]
				[Address(RVA = "0x8C65E0", Offset = "0x8C4BE0", VA = "0x1808C65E0", Slot = "6")]
				get
				{
					return base.PlantName + "的火墙密度+3\n需要重新手动建立火墙";
				}
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x06004478 RID: 17528 RVA: 0x00163060 File Offset: 0x00161260
			[Token(Token = "0x17000664")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004478")]
				[Address(RVA = "0x8AC140", Offset = "0x8AA740", VA = "0x1808AC140", Slot = "4")]
				get
				{
					return PlantType.FireSniper;
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x06004479 RID: 17529 RVA: 0x00163074 File Offset: 0x00161274
			[Token(Token = "0x17000665")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004479")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600447A RID: 17530 RVA: 0x00163088 File Offset: 0x00161288
			[Token(Token = "0x600447A")]
			[Address(RVA = "0x8C61F0", Offset = "0x8C47F0", VA = "0x1808C61F0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = FireSniper.UniqueUpgrade.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					FireSniper.UniqueUpgrade.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x0600447B RID: 17531 RVA: 0x001630B4 File Offset: 0x001612B4
			[Token(Token = "0x17000666")]
			public override Quality Rarity
			{
				[Token(Token = "0x600447B")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600447C RID: 17532 RVA: 0x001630C4 File Offset: 0x001612C4
			[Token(Token = "0x600447C")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000CE5 RID: 3301
		[Token(Token = "0x2000CE5")]
		private class SuperUpgrade : BaseBuff
		{
			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x06004480 RID: 17536 RVA: 0x001630D8 File Offset: 0x001612D8
			[Token(Token = "0x17000667")]
			public override string Title
			{
				[Token(Token = "0x6004480")]
				[Address(RVA = "0x8B86E0", Offset = "0x8B6CE0", VA = "0x1808B86E0", Slot = "5")]
				get
				{
					return "质变：烈焰迸发";
				}
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x06004481 RID: 17537 RVA: 0x001630EC File Offset: 0x001612EC
			[Token(Token = "0x17000668")]
			public override string Description
			{
				[Token(Token = "0x6004481")]
				[Address(RVA = "0x8B85D0", Offset = "0x8B6BD0", VA = "0x1808B85D0", Slot = "6")]
				get
				{
					return base.PlantName + "的火墙顶点数加2";
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x06004482 RID: 17538 RVA: 0x0016310C File Offset: 0x0016130C
			[Token(Token = "0x17000669")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004482")]
				[Address(RVA = "0x8AC140", Offset = "0x8AA740", VA = "0x1808AC140", Slot = "4")]
				get
				{
					return PlantType.FireSniper;
				}
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x06004483 RID: 17539 RVA: 0x00163120 File Offset: 0x00161320
			[Token(Token = "0x1700066A")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004483")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x06004484 RID: 17540 RVA: 0x00163134 File Offset: 0x00161334
			[Token(Token = "0x1700066B")]
			public override int MaxCount
			{
				[Token(Token = "0x6004484")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x06004485 RID: 17541 RVA: 0x00163144 File Offset: 0x00161344
			[Token(Token = "0x6004485")]
			[Address(RVA = "0x8B8440", Offset = "0x8B6A40", VA = "0x1808B8440", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = FireSniper.SuperUpgrade.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					FireSniper.SuperUpgrade.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x06004486 RID: 17542 RVA: 0x00163170 File Offset: 0x00161370
			[Token(Token = "0x1700066C")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004486")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x06004487 RID: 17543 RVA: 0x00163180 File Offset: 0x00161380
			[Token(Token = "0x6004487")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperUpgrade()
			{
			}
		}
	}
}
