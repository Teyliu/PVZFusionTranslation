using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CDF RID: 3295
	[Token(Token = "0x2000CDF")]
	public class DoomSniper : BaseConfig
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x00162D60 File Offset: 0x00160F60
		[Token(Token = "0x17000651")]
		public override string Role
		{
			[Token(Token = "0x600445D")]
			[Address(RVA = "0x8AB6D0", Offset = "0x8A9CD0", VA = "0x1808AB6D0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600445E RID: 17502 RVA: 0x00162D74 File Offset: 0x00160F74
		[Token(Token = "0x17000652")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600445E")]
			[Address(RVA = "0x8AB6C0", Offset = "0x8A9CC0", VA = "0x1808AB6C0", Slot = "4")]
			get
			{
				return PlantType.DoomSniper;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x00162D88 File Offset: 0x00160F88
		[Token(Token = "0x17000653")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600445F")]
			[Address(RVA = "0x8AB410", Offset = "0x8A9A10", VA = "0x1808AB410", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				DoomSniper.UniqueUpgrade uniqueUpgrade = new DoomSniper.UniqueUpgrade();
				int size3 = list._size;
				DoomSniper.HeartUpgrade heartUpgrade = new DoomSniper.HeartUpgrade();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x00162DE0 File Offset: 0x00160FE0
		[Token(Token = "0x6004460")]
		[Address(RVA = "0x8AB3D0", Offset = "0x8A99D0", VA = "0x1808AB3D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00162DF8 File Offset: 0x00160FF8
		[Token(Token = "0x6004461")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public DoomSniper()
		{
		}

		// Token: 0x02000CE0 RID: 3296
		[Token(Token = "0x2000CE0")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x06004462 RID: 17506 RVA: 0x00162E0C File Offset: 0x0016100C
			[Token(Token = "0x17000654")]
			public override string Title
			{
				[Token(Token = "0x6004462")]
				[Address(RVA = "0x8C6F30", Offset = "0x8C5530", VA = "0x1808C6F30", Slot = "5")]
				get
				{
					return "强化：死神之光";
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x06004463 RID: 17507 RVA: 0x00162E20 File Offset: 0x00161020
			[Token(Token = "0x17000655")]
			public override string Description
			{
				[Token(Token = "0x6004463")]
				[Address(RVA = "0x8C6950", Offset = "0x8C4F50", VA = "0x1808C6950", Slot = "6")]
				get
				{
					return base.PlantName + "释放的毁灭菇伤害+100%";
				}
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x06004464 RID: 17508 RVA: 0x00162E40 File Offset: 0x00161040
			[Token(Token = "0x17000656")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004464")]
				[Address(RVA = "0x8AB6C0", Offset = "0x8A9CC0", VA = "0x1808AB6C0", Slot = "4")]
				get
				{
					return PlantType.DoomSniper;
				}
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x06004465 RID: 17509 RVA: 0x00162E54 File Offset: 0x00161054
			[Token(Token = "0x17000657")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004465")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004466 RID: 17510 RVA: 0x00162E68 File Offset: 0x00161068
			[Token(Token = "0x6004466")]
			[Address(RVA = "0x8C5700", Offset = "0x8C3D00", VA = "0x1808C5700", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x06004467 RID: 17511 RVA: 0x00162E98 File Offset: 0x00161098
			[Token(Token = "0x17000658")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004467")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004468 RID: 17512 RVA: 0x00162EA8 File Offset: 0x001610A8
			[Token(Token = "0x6004468")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000CE1 RID: 3297
		[Token(Token = "0x2000CE1")]
		private class HeartUpgrade : BaseBuff
		{
			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x06004469 RID: 17513 RVA: 0x00162EBC File Offset: 0x001610BC
			[Token(Token = "0x17000659")]
			public override string Title
			{
				[Token(Token = "0x6004469")]
				[Address(RVA = "0x8AD440", Offset = "0x8ABA40", VA = "0x1808AD440", Slot = "5")]
				get
				{
					return "质变：神枪手";
				}
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x0600446A RID: 17514 RVA: 0x00162ED0 File Offset: 0x001610D0
			[Token(Token = "0x1700065A")]
			public override string Description
			{
				[Token(Token = "0x600446A")]
				[Address(RVA = "0x8AD3F0", Offset = "0x8AB9F0", VA = "0x1808AD3F0", Slot = "6")]
				get
				{
					return base.PlantName + "每一发子弹都会造成爆头伤害";
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x0600446B RID: 17515 RVA: 0x00162EF0 File Offset: 0x001610F0
			[Token(Token = "0x1700065B")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600446B")]
				[Address(RVA = "0x8AB6C0", Offset = "0x8A9CC0", VA = "0x1808AB6C0", Slot = "4")]
				get
				{
					return PlantType.DoomSniper;
				}
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x0600446C RID: 17516 RVA: 0x00162F04 File Offset: 0x00161104
			[Token(Token = "0x1700065C")]
			public override float AppearWeight
			{
				[Token(Token = "0x600446C")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x0600446D RID: 17517 RVA: 0x00162F18 File Offset: 0x00161118
			[Token(Token = "0x1700065D")]
			public override int MaxCount
			{
				[Token(Token = "0x600446D")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x0600446E RID: 17518 RVA: 0x00162F28 File Offset: 0x00161128
			[Token(Token = "0x600446E")]
			[Address(RVA = "0x8AD390", Offset = "0x8AB990", VA = "0x1808AD390", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12002));
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x0600446F RID: 17519 RVA: 0x00162F50 File Offset: 0x00161150
			[Token(Token = "0x1700065E")]
			public override Quality Rarity
			{
				[Token(Token = "0x600446F")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x06004470 RID: 17520 RVA: 0x00162F60 File Offset: 0x00161160
			[Token(Token = "0x6004470")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public HeartUpgrade()
			{
			}
		}
	}
}
