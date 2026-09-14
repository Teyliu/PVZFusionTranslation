using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D6C RID: 3436
	[Token(Token = "0x2000D6C")]
	public class AbyssSwordStar : BaseConfig
	{
		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x00168648 File Offset: 0x00166848
		[Token(Token = "0x17000835")]
		public override string Role
		{
			[Token(Token = "0x600477B")]
			[Address(RVA = "0x8A83F0", Offset = "0x8A69F0", VA = "0x1808A83F0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x0016865C File Offset: 0x0016685C
		[Token(Token = "0x17000836")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600477C")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "4")]
			get
			{
				return PlantType.AbyssSwordStar;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x00168670 File Offset: 0x00166870
		[Token(Token = "0x17000837")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600477D")]
			[Address(RVA = "0x8A8140", Offset = "0x8A6740", VA = "0x1808A8140", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				AbyssSwordStar.UniqueUpgrade uniqueUpgrade = new AbyssSwordStar.UniqueUpgrade();
				int size3 = list._size;
				AbyssSwordStar.SuperBuff superBuff = new AbyssSwordStar.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x001686C8 File Offset: 0x001668C8
		[Token(Token = "0x600477E")]
		[Address(RVA = "0x8A8100", Offset = "0x8A6700", VA = "0x1808A8100", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 0.75f, num2 != 0, num);
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x001686F0 File Offset: 0x001668F0
		[Token(Token = "0x600477F")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public AbyssSwordStar()
		{
		}

		// Token: 0x02000D6D RID: 3437
		[Token(Token = "0x2000D6D")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x06004780 RID: 18304 RVA: 0x00168704 File Offset: 0x00166904
			[Token(Token = "0x17000838")]
			public override string Title
			{
				[Token(Token = "0x6004780")]
				[Address(RVA = "0x8C6CC0", Offset = "0x8C52C0", VA = "0x1808C6CC0", Slot = "5")]
				get
				{
					return "强化：大剑";
				}
			}

			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x06004781 RID: 18305 RVA: 0x00168718 File Offset: 0x00166918
			[Token(Token = "0x17000839")]
			public override string Description
			{
				[Token(Token = "0x6004781")]
				[Address(RVA = "0x8C6770", Offset = "0x8C4D70", VA = "0x1808C6770", Slot = "6")]
				get
				{
					return base.PlantName + "大剑数量+11";
				}
			}

			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x06004782 RID: 18306 RVA: 0x00168738 File Offset: 0x00166938
			[Token(Token = "0x1700083A")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004782")]
				[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "4")]
				get
				{
					return PlantType.AbyssSwordStar;
				}
			}

			// Token: 0x1700083B RID: 2107
			// (get) Token: 0x06004783 RID: 18307 RVA: 0x0016874C File Offset: 0x0016694C
			[Token(Token = "0x1700083B")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004783")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004784 RID: 18308 RVA: 0x00168760 File Offset: 0x00166960
			[Token(Token = "0x6004784")]
			[Address(RVA = "0x8C5A40", Offset = "0x8C4040", VA = "0x1808C5A40", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x06004785 RID: 18309 RVA: 0x00168780 File Offset: 0x00166980
			[Token(Token = "0x1700083C")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004785")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004786 RID: 18310 RVA: 0x00168790 File Offset: 0x00166990
			[Token(Token = "0x6004786")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D6E RID: 3438
		[Token(Token = "0x2000D6E")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x1700083D RID: 2109
			// (get) Token: 0x06004787 RID: 18311 RVA: 0x001687A4 File Offset: 0x001669A4
			[Token(Token = "0x1700083D")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004787")]
				[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "4")]
				get
				{
					return PlantType.AbyssSwordStar;
				}
			}

			// Token: 0x1700083E RID: 2110
			// (get) Token: 0x06004788 RID: 18312 RVA: 0x001687B8 File Offset: 0x001669B8
			[Token(Token = "0x1700083E")]
			public override string Title
			{
				[Token(Token = "0x6004788")]
				[Address(RVA = "0x8B71B0", Offset = "0x8B57B0", VA = "0x1808B71B0", Slot = "5")]
				get
				{
					return "质变：万剑归宗";
				}
			}

			// Token: 0x1700083F RID: 2111
			// (get) Token: 0x06004789 RID: 18313 RVA: 0x001687CC File Offset: 0x001669CC
			[Token(Token = "0x1700083F")]
			public override string Description
			{
				[Token(Token = "0x6004789")]
				[Address(RVA = "0x8B6EF0", Offset = "0x8B54F0", VA = "0x1808B6EF0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12021];
				}
			}

			// Token: 0x17000840 RID: 2112
			// (get) Token: 0x0600478A RID: 18314 RVA: 0x001687F0 File Offset: 0x001669F0
			[Token(Token = "0x17000840")]
			public override Quality Rarity
			{
				[Token(Token = "0x600478A")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000841 RID: 2113
			// (get) Token: 0x0600478B RID: 18315 RVA: 0x00168800 File Offset: 0x00166A00
			[Token(Token = "0x17000841")]
			public override int MaxCount
			{
				[Token(Token = "0x600478B")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x0600478C RID: 18316 RVA: 0x00168810 File Offset: 0x00166A10
			[Token(Token = "0x17000842")]
			public override float AppearWeight
			{
				[Token(Token = "0x600478C")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600478D RID: 18317 RVA: 0x00168824 File Offset: 0x00166A24
			[Token(Token = "0x600478D")]
			[Address(RVA = "0x8B67A0", Offset = "0x8B4DA0", VA = "0x1808B67A0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12021));
			}

			// Token: 0x0600478E RID: 18318 RVA: 0x0016884C File Offset: 0x00166A4C
			[Token(Token = "0x600478E")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
