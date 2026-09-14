using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CB5 RID: 3253
	[Token(Token = "0x2000CB5")]
	public class LaserUmbrella : BaseConfig
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x0015C69C File Offset: 0x0015A89C
		[Token(Token = "0x17000737")]
		public override string Role
		{
			[Token(Token = "0x6004432")]
			[Address(RVA = "0x833810", Offset = "0x831E10", VA = "0x180833810", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06004433 RID: 17459 RVA: 0x0015C6B0 File Offset: 0x0015A8B0
		[Token(Token = "0x17000738")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004433")]
			[Address(RVA = "0x76C280", Offset = "0x76A880", VA = "0x18076C280", Slot = "4")]
			get
			{
				return PlantType.LaserUmbrella;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x0015C6C4 File Offset: 0x0015A8C4
		[Token(Token = "0x17000739")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004434")]
			[Address(RVA = "0x833560", Offset = "0x831B60", VA = "0x180833560", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				LaserUmbrella.ExplodeBuff explodeBuff = new LaserUmbrella.ExplodeBuff();
				int size3 = list._size;
				LaserUmbrella.SuperBuff superBuff = new LaserUmbrella.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x0015C71C File Offset: 0x0015A91C
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x8334C0", Offset = "0x831AC0", VA = "0x1808334C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x0015C744 File Offset: 0x0015A944
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public LaserUmbrella()
		{
		}

		// Token: 0x02000CB6 RID: 3254
		[Token(Token = "0x2000CB6")]
		private class ExplodeBuff : BaseBuff
		{
			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06004437 RID: 17463 RVA: 0x0015C758 File Offset: 0x0015A958
			[Token(Token = "0x1700073A")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004437")]
				[Address(RVA = "0x76C280", Offset = "0x76A880", VA = "0x18076C280", Slot = "4")]
				get
				{
					return PlantType.LaserUmbrella;
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06004438 RID: 17464 RVA: 0x0015C76C File Offset: 0x0015A96C
			[Token(Token = "0x1700073B")]
			public override string Title
			{
				[Token(Token = "0x6004438")]
				[Address(RVA = "0x830ED0", Offset = "0x82F4D0", VA = "0x180830ED0", Slot = "5")]
				get
				{
					return "强化：能量";
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06004439 RID: 17465 RVA: 0x0015C780 File Offset: 0x0015A980
			[Token(Token = "0x1700073C")]
			public override string Description
			{
				[Token(Token = "0x6004439")]
				[Address(RVA = "0x830EA0", Offset = "0x82F4A0", VA = "0x180830EA0", Slot = "6")]
				get
				{
					return "能量上限+5000，能量恢复效率+300%，每次攻击额外附带等同于当前能量25%的伤害";
				}
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x0600443A RID: 17466 RVA: 0x0015C794 File Offset: 0x0015A994
			[Token(Token = "0x1700073D")]
			public override Quality Rarity
			{
				[Token(Token = "0x600443A")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x0600443B RID: 17467 RVA: 0x0015C7A4 File Offset: 0x0015A9A4
			[Token(Token = "0x1700073E")]
			public override float AppearWeight
			{
				[Token(Token = "0x600443B")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x0600443C RID: 17468 RVA: 0x0015C7B8 File Offset: 0x0015A9B8
			[Token(Token = "0x1700073F")]
			public override int MaxCount
			{
				[Token(Token = "0x600443C")]
				[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x0600443D RID: 17469 RVA: 0x0015C7C8 File Offset: 0x0015A9C8
			[Token(Token = "0x600443D")]
			[Address(RVA = "0x830D40", Offset = "0x82F340", VA = "0x180830D40", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (!(plant != num) || base.Plant != 0)
				{
				}
			}

			// Token: 0x0600443E RID: 17470 RVA: 0x0015C7F4 File Offset: 0x0015A9F4
			[Token(Token = "0x600443E")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public ExplodeBuff()
			{
			}
		}

		// Token: 0x02000CB7 RID: 3255
		[Token(Token = "0x2000CB7")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x0600443F RID: 17471 RVA: 0x0015C808 File Offset: 0x0015AA08
			[Token(Token = "0x17000740")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600443F")]
				[Address(RVA = "0x76C280", Offset = "0x76A880", VA = "0x18076C280", Slot = "4")]
				get
				{
					return PlantType.LaserUmbrella;
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06004440 RID: 17472 RVA: 0x0015C81C File Offset: 0x0015AA1C
			[Token(Token = "0x17000741")]
			public override string Title
			{
				[Token(Token = "0x6004440")]
				[Address(RVA = "0x83A610", Offset = "0x838C10", VA = "0x18083A610", Slot = "5")]
				get
				{
					return "质变：光能盾牌";
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06004441 RID: 17473 RVA: 0x0015C830 File Offset: 0x0015AA30
			[Token(Token = "0x17000742")]
			public override string Description
			{
				[Token(Token = "0x6004441")]
				[Address(RVA = "0x839EB0", Offset = "0x8384B0", VA = "0x180839EB0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12006];
				}
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x06004442 RID: 17474 RVA: 0x0015C858 File Offset: 0x0015AA58
			[Token(Token = "0x17000743")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004442")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06004443 RID: 17475 RVA: 0x0015C868 File Offset: 0x0015AA68
			[Token(Token = "0x17000744")]
			public override int MaxCount
			{
				[Token(Token = "0x6004443")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06004444 RID: 17476 RVA: 0x0015C878 File Offset: 0x0015AA78
			[Token(Token = "0x17000745")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004444")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004445 RID: 17477 RVA: 0x0015C88C File Offset: 0x0015AA8C
			[Token(Token = "0x6004445")]
			[Address(RVA = "0x8399D0", Offset = "0x837FD0", VA = "0x1808399D0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12006));
			}

			// Token: 0x06004446 RID: 17478 RVA: 0x0015C8B4 File Offset: 0x0015AAB4
			[Token(Token = "0x6004446")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
