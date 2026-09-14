using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D99 RID: 3481
	[Token(Token = "0x2000D99")]
	public class UltimateBamboo : BaseConfig
	{
		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x0016A254 File Offset: 0x00168454
		[Token(Token = "0x170008D8")]
		public override string Role
		{
			[Token(Token = "0x600487D")]
			[Address(RVA = "0x8BFC60", Offset = "0x8BE260", VA = "0x1808BFC60", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x0016A268 File Offset: 0x00168468
		[Token(Token = "0x170008D9")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600487E")]
			[Address(RVA = "0x8AADD0", Offset = "0x8A93D0", VA = "0x1808AADD0", Slot = "4")]
			get
			{
				return PlantType.UltimateBamboo;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x0016A27C File Offset: 0x0016847C
		[Token(Token = "0x170008DA")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600487F")]
			[Address(RVA = "0x8BF9C0", Offset = "0x8BDFC0", VA = "0x1808BF9C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				UltimateBamboo.DefenceBuff defenceBuff = new UltimateBamboo.DefenceBuff();
				int size2 = list._size;
				UltimateBamboo.HealthBuff healthBuff = new UltimateBamboo.HealthBuff();
				int size3 = list._size;
				UltimateBamboo.SuperBuff superBuff = new UltimateBamboo.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x0016A2D8 File Offset: 0x001684D8
		[Token(Token = "0x6004880")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x0016A2E8 File Offset: 0x001684E8
		[Token(Token = "0x6004881")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateBamboo()
		{
		}

		// Token: 0x02000D9A RID: 3482
		[Token(Token = "0x2000D9A")]
		private class HealthBuff : BaseBuff
		{
			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x06004882 RID: 18562 RVA: 0x0016A2FC File Offset: 0x001684FC
			[Token(Token = "0x170008DB")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004882")]
				[Address(RVA = "0x8AADD0", Offset = "0x8A93D0", VA = "0x1808AADD0", Slot = "4")]
				get
				{
					return PlantType.UltimateBamboo;
				}
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x06004883 RID: 18563 RVA: 0x0016A310 File Offset: 0x00168510
			[Token(Token = "0x170008DC")]
			public override string Title
			{
				[Token(Token = "0x6004883")]
				[Address(RVA = "0x8AD250", Offset = "0x8AB850", VA = "0x1808AD250", Slot = "5")]
				get
				{
					return "强化：生命";
				}
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06004884 RID: 18564 RVA: 0x0016A324 File Offset: 0x00168524
			[Token(Token = "0x170008DD")]
			public override string Description
			{
				[Token(Token = "0x6004884")]
				[Address(RVA = "0x8AD1C0", Offset = "0x8AB7C0", VA = "0x1808AD1C0", Slot = "6")]
				get
				{
					return "生命值上限+50%";
				}
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06004885 RID: 18565 RVA: 0x0016A338 File Offset: 0x00168538
			[Token(Token = "0x170008DE")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004885")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x06004886 RID: 18566 RVA: 0x0016A348 File Offset: 0x00168548
			[Token(Token = "0x170008DF")]
			public override int MaxCount
			{
				[Token(Token = "0x6004886")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x06004887 RID: 18567 RVA: 0x0016A358 File Offset: 0x00168558
			[Token(Token = "0x170008E0")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004887")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004888 RID: 18568 RVA: 0x0016A36C File Offset: 0x0016856C
			[Token(Token = "0x6004888")]
			[Address(RVA = "0x8AD0B0", Offset = "0x8AB6B0", VA = "0x1808AD0B0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__12_ = UltimateBamboo.HealthBuff.<>c.<>9__12_0;
				if (<>9__12_ == 0)
				{
					Action<Plant> action;
					UltimateBamboo.HealthBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(<>9__12_);
			}

			// Token: 0x06004889 RID: 18569 RVA: 0x0016A398 File Offset: 0x00168598
			[Token(Token = "0x6004889")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public HealthBuff()
			{
			}
		}

		// Token: 0x02000D9C RID: 3484
		[Token(Token = "0x2000D9C")]
		private class DefenceBuff : BaseBuff
		{
			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x0600488D RID: 18573 RVA: 0x0016A3AC File Offset: 0x001685AC
			[Token(Token = "0x170008E1")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600488D")]
				[Address(RVA = "0x8AADD0", Offset = "0x8A93D0", VA = "0x1808AADD0", Slot = "4")]
				get
				{
					return PlantType.UltimateBamboo;
				}
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x0600488E RID: 18574 RVA: 0x0016A3C0 File Offset: 0x001685C0
			[Token(Token = "0x170008E2")]
			public override string Title
			{
				[Token(Token = "0x600488E")]
				[Address(RVA = "0x8AADE0", Offset = "0x8A93E0", VA = "0x1808AADE0", Slot = "5")]
				get
				{
					return "强化：坚韧";
				}
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x0600488F RID: 18575 RVA: 0x0016A3D4 File Offset: 0x001685D4
			[Token(Token = "0x170008E3")]
			public override string Description
			{
				[Token(Token = "0x600488F")]
				[Address(RVA = "0x8AADA0", Offset = "0x8A93A0", VA = "0x1808AADA0", Slot = "6")]
				get
				{
					return "坚韧增加30%\n坚韧越高，撞击僵尸后使僵尸受到的伤害越高，自身受到的伤害越低";
				}
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x06004890 RID: 18576 RVA: 0x0016A3E8 File Offset: 0x001685E8
			[Token(Token = "0x170008E4")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004890")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x06004891 RID: 18577 RVA: 0x0016A3F8 File Offset: 0x001685F8
			[Token(Token = "0x170008E5")]
			public override int MaxCount
			{
				[Token(Token = "0x6004891")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x06004892 RID: 18578 RVA: 0x0016A408 File Offset: 0x00168608
			[Token(Token = "0x170008E6")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004892")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004893 RID: 18579 RVA: 0x0016A41C File Offset: 0x0016861C
			[Token(Token = "0x6004893")]
			[Address(RVA = "0x8AAC90", Offset = "0x8A9290", VA = "0x1808AAC90", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__12_ = UltimateBamboo.DefenceBuff.<>c.<>9__12_0;
				if (<>9__12_ == 0)
				{
					Action<Plant> action;
					UltimateBamboo.DefenceBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(<>9__12_);
			}

			// Token: 0x06004894 RID: 18580 RVA: 0x0016A448 File Offset: 0x00168648
			[Token(Token = "0x6004894")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public DefenceBuff()
			{
			}
		}

		// Token: 0x02000D9E RID: 3486
		[Token(Token = "0x2000D9E")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x06004898 RID: 18584 RVA: 0x0016A45C File Offset: 0x0016865C
			[Token(Token = "0x170008E7")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004898")]
				[Address(RVA = "0x8AADD0", Offset = "0x8A93D0", VA = "0x1808AADD0", Slot = "4")]
				get
				{
					return PlantType.UltimateBamboo;
				}
			}

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x06004899 RID: 18585 RVA: 0x0016A470 File Offset: 0x00168670
			[Token(Token = "0x170008E8")]
			public override string Title
			{
				[Token(Token = "0x6004899")]
				[Address(RVA = "0x8B7210", Offset = "0x8B5810", VA = "0x1808B7210", Slot = "5")]
				get
				{
					return "质变：大运";
				}
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x0600489A RID: 18586 RVA: 0x0016A484 File Offset: 0x00168684
			[Token(Token = "0x170008E9")]
			public override string Description
			{
				[Token(Token = "0x600489A")]
				[Address(RVA = "0x8B6C30", Offset = "0x8B5230", VA = "0x1808B6C30", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12015];
				}
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x0600489B RID: 18587 RVA: 0x0016A4A8 File Offset: 0x001686A8
			[Token(Token = "0x170008EA")]
			public override Quality Rarity
			{
				[Token(Token = "0x600489B")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x0600489C RID: 18588 RVA: 0x0016A4B8 File Offset: 0x001686B8
			[Token(Token = "0x170008EB")]
			public override int MaxCount
			{
				[Token(Token = "0x600489C")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x0600489D RID: 18589 RVA: 0x0016A4C8 File Offset: 0x001686C8
			[Token(Token = "0x170008EC")]
			public override float AppearWeight
			{
				[Token(Token = "0x600489D")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600489E RID: 18590 RVA: 0x0016A4DC File Offset: 0x001686DC
			[Token(Token = "0x600489E")]
			[Address(RVA = "0x8B6210", Offset = "0x8B4810", VA = "0x1808B6210", Slot = "7")]
			public override void OnGet()
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}

			// Token: 0x0600489F RID: 18591 RVA: 0x0016A4FC File Offset: 0x001686FC
			[Token(Token = "0x600489F")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
