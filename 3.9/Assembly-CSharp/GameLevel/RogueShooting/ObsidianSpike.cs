using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D52 RID: 3410
	[Token(Token = "0x2000D52")]
	public class ObsidianSpike : BaseConfig
	{
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x00167340 File Offset: 0x00165540
		[Token(Token = "0x170007ED")]
		public override string Role
		{
			[Token(Token = "0x60046F4")]
			[Address(RVA = "0x8B07C0", Offset = "0x8AEDC0", VA = "0x1808B07C0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x00167354 File Offset: 0x00165554
		[Token(Token = "0x170007EE")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60046F5")]
			[Address(RVA = "0x8B07B0", Offset = "0x8AEDB0", VA = "0x1808B07B0", Slot = "4")]
			get
			{
				return PlantType.ObsidianSpike;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x00167368 File Offset: 0x00165568
		[Token(Token = "0x170007EF")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60046F6")]
			[Address(RVA = "0x8B0500", Offset = "0x8AEB00", VA = "0x1808B0500", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				ObsidianSpike.UniqueUpgrade uniqueUpgrade = new ObsidianSpike.UniqueUpgrade();
				int size3 = list._size;
				ObsidianSpike.SuperBuff superBuff = new ObsidianSpike.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x001673C0 File Offset: 0x001655C0
		[Token(Token = "0x60046F7")]
		[Address(RVA = "0x8B0390", Offset = "0x8AE990", VA = "0x1808B0390", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 10f, num2 != 0, num);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x00167400 File Offset: 0x00165600
		[Token(Token = "0x60046F8")]
		[Address(RVA = "0x8B02C0", Offset = "0x8AE8C0", VA = "0x1808B02C0")]
		private void OtherUpdate(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x00167424 File Offset: 0x00165624
		[Token(Token = "0x60046F9")]
		[Address(RVA = "0x8B0080", Offset = "0x8AE680", VA = "0x1808B0080")]
		private List<Vector2Int> GetClockwiseSpiralPositions(Vector2Int center, int count)
		{
			List<Vector2Int> list = new List();
			uint num;
			ulong num2;
			ulong num3;
			ulong num4;
			Vector2Int[] array = new Vector2Int[] { num, num2, num3, num4 };
			int size = list._size;
			list._size = (int)num4;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			if (num > (uint)0)
			{
				Vector2Int vector2Int = array[num5];
				vector2Int += center;
				num7++;
			}
			num5++;
			if (num7 < (int)num)
			{
				num5++;
			}
			num6++;
			num += (uint)1;
			return list;
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x001674C4 File Offset: 0x001656C4
		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ObsidianSpike()
		{
		}

		// Token: 0x02000D53 RID: 3411
		[Token(Token = "0x2000D53")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x060046FB RID: 18171 RVA: 0x001674D8 File Offset: 0x001656D8
			[Token(Token = "0x170007F0")]
			public override string Title
			{
				[Token(Token = "0x60046FB")]
				[Address(RVA = "0x8C6D50", Offset = "0x8C5350", VA = "0x1808C6D50", Slot = "5")]
				get
				{
					return "强化：增生";
				}
			}

			// Token: 0x170007F1 RID: 2033
			// (get) Token: 0x060046FC RID: 18172 RVA: 0x001674EC File Offset: 0x001656EC
			[Token(Token = "0x170007F1")]
			public override string Description
			{
				[Token(Token = "0x60046FC")]
				[Address(RVA = "0x8C65B0", Offset = "0x8C4BB0", VA = "0x1808C65B0", Slot = "6")]
				get
				{
					return "获得两株地刺王在周围，地刺王拥有相当于玄钢地刺王100%的独立伤害增幅和100%的速度增幅，基础攻击力为玄钢地刺王的75%，地刺王的属性根据场地上冰火植物数量来决定";
				}
			}

			// Token: 0x170007F2 RID: 2034
			// (get) Token: 0x060046FD RID: 18173 RVA: 0x00167500 File Offset: 0x00165700
			[Token(Token = "0x170007F2")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60046FD")]
				[Address(RVA = "0x8B07B0", Offset = "0x8AEDB0", VA = "0x1808B07B0", Slot = "4")]
				get
				{
					return PlantType.ObsidianSpike;
				}
			}

			// Token: 0x170007F3 RID: 2035
			// (get) Token: 0x060046FE RID: 18174 RVA: 0x00167514 File Offset: 0x00165714
			[Token(Token = "0x170007F3")]
			public override float AppearWeight
			{
				[Token(Token = "0x60046FE")]
				[Address(RVA = "0x8C52B0", Offset = "0x8C38B0", VA = "0x1808C52B0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007F4 RID: 2036
			// (get) Token: 0x060046FF RID: 18175 RVA: 0x00167528 File Offset: 0x00165728
			[Token(Token = "0x170007F4")]
			public override int MaxCount
			{
				[Token(Token = "0x60046FF")]
				[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
				get
				{
					return 4;
				}
			}

			// Token: 0x06004700 RID: 18176 RVA: 0x00167538 File Offset: 0x00165738
			[Token(Token = "0x6004700")]
			[Address(RVA = "0x8C6050", Offset = "0x8C4650", VA = "0x1808C6050", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = ObsidianSpike.UniqueUpgrade.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					ObsidianSpike.UniqueUpgrade.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x170007F5 RID: 2037
			// (get) Token: 0x06004701 RID: 18177 RVA: 0x00167564 File Offset: 0x00165764
			[Token(Token = "0x170007F5")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004701")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004702 RID: 18178 RVA: 0x00167574 File Offset: 0x00165774
			[Token(Token = "0x6004702")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D55 RID: 3413
		[Token(Token = "0x2000D55")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170007F6 RID: 2038
			// (get) Token: 0x06004706 RID: 18182 RVA: 0x00167588 File Offset: 0x00165788
			[Token(Token = "0x170007F6")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004706")]
				[Address(RVA = "0x8B07B0", Offset = "0x8AEDB0", VA = "0x1808B07B0", Slot = "4")]
				get
				{
					return PlantType.ObsidianSpike;
				}
			}

			// Token: 0x170007F7 RID: 2039
			// (get) Token: 0x06004707 RID: 18183 RVA: 0x0016759C File Offset: 0x0016579C
			[Token(Token = "0x170007F7")]
			public override string Title
			{
				[Token(Token = "0x6004707")]
				[Address(RVA = "0x8B7270", Offset = "0x8B5870", VA = "0x1808B7270", Slot = "5")]
				get
				{
					return "质变：流血";
				}
			}

			// Token: 0x170007F8 RID: 2040
			// (get) Token: 0x06004708 RID: 18184 RVA: 0x001675B0 File Offset: 0x001657B0
			[Token(Token = "0x170007F8")]
			public override string Description
			{
				[Token(Token = "0x6004708")]
				[Address(RVA = "0x8B7040", Offset = "0x8B5640", VA = "0x1808B7040", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12014];
				}
			}

			// Token: 0x170007F9 RID: 2041
			// (get) Token: 0x06004709 RID: 18185 RVA: 0x001675D4 File Offset: 0x001657D4
			[Token(Token = "0x170007F9")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004709")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170007FA RID: 2042
			// (get) Token: 0x0600470A RID: 18186 RVA: 0x001675E4 File Offset: 0x001657E4
			[Token(Token = "0x170007FA")]
			public override int MaxCount
			{
				[Token(Token = "0x600470A")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170007FB RID: 2043
			// (get) Token: 0x0600470B RID: 18187 RVA: 0x001675F4 File Offset: 0x001657F4
			[Token(Token = "0x170007FB")]
			public override float AppearWeight
			{
				[Token(Token = "0x600470B")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600470C RID: 18188 RVA: 0x00167608 File Offset: 0x00165808
			[Token(Token = "0x600470C")]
			[Address(RVA = "0x8B66E0", Offset = "0x8B4CE0", VA = "0x1808B66E0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12014));
			}

			// Token: 0x0600470D RID: 18189 RVA: 0x00167630 File Offset: 0x00165830
			[Token(Token = "0x600470D")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
