using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D74 RID: 3444
	[Token(Token = "0x2000D74")]
	public class UltimateCabbageCannon : BaseConfig
	{
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x00168B78 File Offset: 0x00166D78
		[Token(Token = "0x17000854")]
		public override string Role
		{
			[Token(Token = "0x60047AA")]
			[Address(RVA = "0x8C0A10", Offset = "0x8BF010", VA = "0x1808C0A10", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060047AB RID: 18347 RVA: 0x00168B8C File Offset: 0x00166D8C
		[Token(Token = "0x17000855")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60047AB")]
			[Address(RVA = "0x8A9890", Offset = "0x8A7E90", VA = "0x1808A9890", Slot = "4")]
			get
			{
				return PlantType.UltimateCabbageCannon;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060047AC RID: 18348 RVA: 0x00168BA0 File Offset: 0x00166DA0
		[Token(Token = "0x17000856")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60047AC")]
			[Address(RVA = "0x8C06E0", Offset = "0x8BECE0", VA = "0x1808C06E0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateCabbageCannon.UniqueUpgrade uniqueUpgrade = new UltimateCabbageCannon.UniqueUpgrade();
				int size3 = list._size;
				UltimateCabbageCannon.SuperBuff superBuff = new UltimateCabbageCannon.SuperBuff();
				int size4 = list._size;
				UltimateCabbageCannon.CannonCurse cannonCurse = new UltimateCabbageCannon.CannonCurse();
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x00168C08 File Offset: 0x00166E08
		[Token(Token = "0x60047AD")]
		[Address(RVA = "0x8A98D0", Offset = "0x8A7ED0", VA = "0x1808A98D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x00168C30 File Offset: 0x00166E30
		[Token(Token = "0x60047AE")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateCabbageCannon()
		{
		}

		// Token: 0x02000D75 RID: 3445
		[Token(Token = "0x2000D75")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x060047AF RID: 18351 RVA: 0x00168C44 File Offset: 0x00166E44
			[Token(Token = "0x17000857")]
			public override string Title
			{
				[Token(Token = "0x60047AF")]
				[Address(RVA = "0x8C6F60", Offset = "0x8C5560", VA = "0x1808C6F60", Slot = "5")]
				get
				{
					return "强化：散射";
				}
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x060047B0 RID: 18352 RVA: 0x00168C58 File Offset: 0x00166E58
			[Token(Token = "0x17000858")]
			public override string Description
			{
				[Token(Token = "0x60047B0")]
				[Address(RVA = "0x8C69D0", Offset = "0x8C4FD0", VA = "0x1808C69D0", Slot = "6")]
				get
				{
					return base.PlantName + "最大散射数+10";
				}
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x060047B1 RID: 18353 RVA: 0x00168C78 File Offset: 0x00166E78
			[Token(Token = "0x17000859")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60047B1")]
				[Address(RVA = "0x8A9890", Offset = "0x8A7E90", VA = "0x1808A9890", Slot = "4")]
				get
				{
					return PlantType.UltimateCabbageCannon;
				}
			}

			// Token: 0x1700085A RID: 2138
			// (get) Token: 0x060047B2 RID: 18354 RVA: 0x00168C8C File Offset: 0x00166E8C
			[Token(Token = "0x1700085A")]
			public override float AppearWeight
			{
				[Token(Token = "0x60047B2")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060047B3 RID: 18355 RVA: 0x00168CA0 File Offset: 0x00166EA0
			[Token(Token = "0x60047B3")]
			[Address(RVA = "0x8C5EC0", Offset = "0x8C44C0", VA = "0x1808C5EC0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = UltimateCabbageCannon.UniqueUpgrade.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					UltimateCabbageCannon.UniqueUpgrade.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x060047B4 RID: 18356 RVA: 0x00168CCC File Offset: 0x00166ECC
			[Token(Token = "0x1700085B")]
			public override Quality Rarity
			{
				[Token(Token = "0x60047B4")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060047B5 RID: 18357 RVA: 0x00168CDC File Offset: 0x00166EDC
			[Token(Token = "0x60047B5")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D77 RID: 3447
		[Token(Token = "0x2000D77")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x060047B9 RID: 18361 RVA: 0x00168CF0 File Offset: 0x00166EF0
			[Token(Token = "0x1700085C")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60047B9")]
				[Address(RVA = "0x8A9890", Offset = "0x8A7E90", VA = "0x1808A9890", Slot = "4")]
				get
				{
					return PlantType.UltimateCabbageCannon;
				}
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x060047BA RID: 18362 RVA: 0x00168D04 File Offset: 0x00166F04
			[Token(Token = "0x1700085D")]
			public override string Title
			{
				[Token(Token = "0x60047BA")]
				[Address(RVA = "0x8B7510", Offset = "0x8B5B10", VA = "0x1808B7510", Slot = "5")]
				get
				{
					return "质变：饱和弹射";
				}
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x060047BB RID: 18363 RVA: 0x00168D18 File Offset: 0x00166F18
			[Token(Token = "0x1700085E")]
			public override string Description
			{
				[Token(Token = "0x60047BB")]
				[Address(RVA = "0x8B6900", Offset = "0x8B4F00", VA = "0x1808B6900", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12020];
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x060047BC RID: 18364 RVA: 0x00168D3C File Offset: 0x00166F3C
			[Token(Token = "0x1700085F")]
			public override Quality Rarity
			{
				[Token(Token = "0x60047BC")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x060047BD RID: 18365 RVA: 0x00168D4C File Offset: 0x00166F4C
			[Token(Token = "0x17000860")]
			public override int MaxCount
			{
				[Token(Token = "0x60047BD")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x060047BE RID: 18366 RVA: 0x00168D5C File Offset: 0x00166F5C
			[Token(Token = "0x17000861")]
			public override float AppearWeight
			{
				[Token(Token = "0x60047BE")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060047BF RID: 18367 RVA: 0x00168D70 File Offset: 0x00166F70
			[Token(Token = "0x60047BF")]
			[Address(RVA = "0x8B6500", Offset = "0x8B4B00", VA = "0x1808B6500", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12020));
			}

			// Token: 0x060047C0 RID: 18368 RVA: 0x00168D98 File Offset: 0x00166F98
			[Token(Token = "0x60047C0")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}

		// Token: 0x02000D78 RID: 3448
		[Token(Token = "0x2000D78")]
		private class CannonCurse : CurseBuff
		{
			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x060047C1 RID: 18369 RVA: 0x00168DAC File Offset: 0x00166FAC
			[Token(Token = "0x17000862")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60047C1")]
				[Address(RVA = "0x8A9890", Offset = "0x8A7E90", VA = "0x1808A9890", Slot = "4")]
				get
				{
					return PlantType.UltimateCabbageCannon;
				}
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x060047C2 RID: 18370 RVA: 0x00168DC0 File Offset: 0x00166FC0
			[Token(Token = "0x17000863")]
			public override string Title
			{
				[Token(Token = "0x60047C2")]
				[Address(RVA = "0x8A98A0", Offset = "0x8A7EA0", VA = "0x1808A98A0", Slot = "5")]
				get
				{
					return "诅咒：见者有份";
				}
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x060047C3 RID: 18371 RVA: 0x00168DD4 File Offset: 0x00166FD4
			[Token(Token = "0x17000864")]
			public override string Description
			{
				[Token(Token = "0x60047C3")]
				[Address(RVA = "0x8A9810", Offset = "0x8A7E10", VA = "0x1808A9810", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)14004];
				}
			}

			// Token: 0x060047C4 RID: 18372 RVA: 0x00168DF8 File Offset: 0x00166FF8
			[Token(Token = "0x60047C4")]
			[Address(RVA = "0x8A97B0", Offset = "0x8A7DB0", VA = "0x1808A97B0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)14004));
			}

			// Token: 0x060047C5 RID: 18373 RVA: 0x00168E20 File Offset: 0x00167020
			[Token(Token = "0x60047C5")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public CannonCurse()
			{
			}
		}
	}
}
