using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CD2 RID: 3282
	[Token(Token = "0x2000CD2")]
	public class UltimateGatling : BaseConfig
	{
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x00162544 File Offset: 0x00160744
		[Token(Token = "0x1700061D")]
		public override string Role
		{
			[Token(Token = "0x600440F")]
			[Address(RVA = "0x8C2070", Offset = "0x8C0670", VA = "0x1808C2070", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x00162558 File Offset: 0x00160758
		[Token(Token = "0x1700061E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004410")]
			[Address(RVA = "0x8A9EE0", Offset = "0x8A84E0", VA = "0x1808A9EE0", Slot = "4")]
			get
			{
				return PlantType.UltimateGatling;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x0016256C File Offset: 0x0016076C
		[Token(Token = "0x1700061F")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004411")]
			[Address(RVA = "0x8C1D40", Offset = "0x8C0340", VA = "0x1808C1D40", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateGatling.UniqueUpgrade uniqueUpgrade = new UltimateGatling.UniqueUpgrade();
				int size3 = list._size;
				UltimateGatling.SuperForceUpgrade superForceUpgrade = new UltimateGatling.SuperForceUpgrade();
				int size4 = list._size;
				UltimateGatling.CherryCurse cherryCurse = new UltimateGatling.CherryCurse();
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x001625D4 File Offset: 0x001607D4
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x8A98D0", Offset = "0x8A7ED0", VA = "0x1808A98D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x001625FC File Offset: 0x001607FC
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateGatling()
		{
		}

		// Token: 0x02000CD3 RID: 3283
		[Token(Token = "0x2000CD3")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06004414 RID: 17428 RVA: 0x00162610 File Offset: 0x00160810
			[Token(Token = "0x17000620")]
			public override string Title
			{
				[Token(Token = "0x6004414")]
				[Address(RVA = "0x8C6FF0", Offset = "0x8C55F0", VA = "0x1808C6FF0", Slot = "5")]
				get
				{
					return "强化：弹道";
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06004415 RID: 17429 RVA: 0x00162624 File Offset: 0x00160824
			[Token(Token = "0x17000621")]
			public override string Description
			{
				[Token(Token = "0x6004415")]
				[Address(RVA = "0x8C6B40", Offset = "0x8C5140", VA = "0x1808C6B40", Slot = "6")]
				get
				{
					return base.PlantName + "每次攻击多发射一发子弹";
				}
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x06004416 RID: 17430 RVA: 0x00162644 File Offset: 0x00160844
			[Token(Token = "0x17000622")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004416")]
				[Address(RVA = "0x8A9EE0", Offset = "0x8A84E0", VA = "0x1808A9EE0", Slot = "4")]
				get
				{
					return PlantType.UltimateGatling;
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x06004417 RID: 17431 RVA: 0x00162658 File Offset: 0x00160858
			[Token(Token = "0x17000623")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004417")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x06004418 RID: 17432 RVA: 0x00162668 File Offset: 0x00160868
			[Token(Token = "0x17000624")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004418")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004419 RID: 17433 RVA: 0x0016267C File Offset: 0x0016087C
			[Token(Token = "0x6004419")]
			[Address(RVA = "0x8C6160", Offset = "0x8C4760", VA = "0x1808C6160", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x0600441A RID: 17434 RVA: 0x001626AC File Offset: 0x001608AC
			[Token(Token = "0x600441A")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000CD4 RID: 3284
		[Token(Token = "0x2000CD4")]
		private class SuperForceUpgrade : BaseBuff
		{
			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x0600441B RID: 17435 RVA: 0x001626C0 File Offset: 0x001608C0
			[Token(Token = "0x17000625")]
			public override string Title
			{
				[Token(Token = "0x600441B")]
				[Address(RVA = "0x8B7760", Offset = "0x8B5D60", VA = "0x1808B7760", Slot = "5")]
				get
				{
					return "质变：力量";
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x0600441C RID: 17436 RVA: 0x001626D4 File Offset: 0x001608D4
			[Token(Token = "0x17000626")]
			public override string Description
			{
				[Token(Token = "0x600441C")]
				[Address(RVA = "0x8B7730", Offset = "0x8B5D30", VA = "0x1808B7730", Slot = "6")]
				get
				{
					return "获得词条力大砖飞：植物造成的樱桃爆炸伤害x3";
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x0600441D RID: 17437 RVA: 0x001626E8 File Offset: 0x001608E8
			[Token(Token = "0x17000627")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600441D")]
				[Address(RVA = "0x8A9EE0", Offset = "0x8A84E0", VA = "0x1808A9EE0", Slot = "4")]
				get
				{
					return PlantType.UltimateGatling;
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x0600441E RID: 17438 RVA: 0x001626FC File Offset: 0x001608FC
			[Token(Token = "0x17000628")]
			public override Quality Rarity
			{
				[Token(Token = "0x600441E")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x0600441F RID: 17439 RVA: 0x0016270C File Offset: 0x0016090C
			[Token(Token = "0x17000629")]
			public override float AppearWeight
			{
				[Token(Token = "0x600441F")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06004420 RID: 17440 RVA: 0x00162720 File Offset: 0x00160920
			[Token(Token = "0x1700062A")]
			public override int MaxCount
			{
				[Token(Token = "0x6004420")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x06004421 RID: 17441 RVA: 0x00162730 File Offset: 0x00160930
			[Token(Token = "0x6004421")]
			[Address(RVA = "0x8B76D0", Offset = "0x8B5CD0", VA = "0x1808B76D0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				int num = 0;
				instance.GetUltiBuff((UltiBuff)((uint)2), num != 0);
			}

			// Token: 0x06004422 RID: 17442 RVA: 0x00162758 File Offset: 0x00160958
			[Token(Token = "0x6004422")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperForceUpgrade()
			{
			}
		}

		// Token: 0x02000CD5 RID: 3285
		[Token(Token = "0x2000CD5")]
		private class CherryCurse : CurseBuff
		{
			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x06004423 RID: 17443 RVA: 0x0016276C File Offset: 0x0016096C
			[Token(Token = "0x1700062B")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004423")]
				[Address(RVA = "0x8A9EE0", Offset = "0x8A84E0", VA = "0x1808A9EE0", Slot = "4")]
				get
				{
					return PlantType.UltimateGatling;
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x06004424 RID: 17444 RVA: 0x00162780 File Offset: 0x00160980
			[Token(Token = "0x1700062C")]
			public override string Title
			{
				[Token(Token = "0x6004424")]
				[Address(RVA = "0x8A9EF0", Offset = "0x8A84F0", VA = "0x1808A9EF0", Slot = "5")]
				get
				{
					return "诅咒：争强好胜";
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x06004425 RID: 17445 RVA: 0x00162794 File Offset: 0x00160994
			[Token(Token = "0x1700062D")]
			public override string Description
			{
				[Token(Token = "0x6004425")]
				[Address(RVA = "0x8A9E60", Offset = "0x8A8460", VA = "0x1808A9E60", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)14002];
				}
			}

			// Token: 0x06004426 RID: 17446 RVA: 0x001627B8 File Offset: 0x001609B8
			[Token(Token = "0x6004426")]
			[Address(RVA = "0x8A9DD0", Offset = "0x8A83D0", VA = "0x1808A9DD0", Slot = "7")]
			public override void OnGet()
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}

			// Token: 0x06004427 RID: 17447 RVA: 0x001627D8 File Offset: 0x001609D8
			[Token(Token = "0x6004427")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public CherryCurse()
			{
			}
		}
	}
}
