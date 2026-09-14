using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C7E RID: 3198
	[Token(Token = "0x2000C7E")]
	public class ObsidianSpike : BaseConfig
	{
		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x00159F3C File Offset: 0x0015813C
		[Token(Token = "0x17000684")]
		public override string Role
		{
			[Token(Token = "0x6004304")]
			[Address(RVA = "0x834A00", Offset = "0x833000", VA = "0x180834A00", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x00159F50 File Offset: 0x00158150
		[Token(Token = "0x17000685")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004305")]
			[Address(RVA = "0x8349F0", Offset = "0x832FF0", VA = "0x1808349F0", Slot = "4")]
			get
			{
				return PlantType.ObsidianSpike;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x00159F64 File Offset: 0x00158164
		[Token(Token = "0x17000686")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004306")]
			[Address(RVA = "0x834740", Offset = "0x832D40", VA = "0x180834740", Slot = "5")]
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

		// Token: 0x06004307 RID: 17159 RVA: 0x00159FBC File Offset: 0x001581BC
		[Token(Token = "0x6004307")]
		[Address(RVA = "0x8345D0", Offset = "0x832BD0", VA = "0x1808345D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 10f, num2 != 0, num);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00159FFC File Offset: 0x001581FC
		[Token(Token = "0x6004308")]
		[Address(RVA = "0x834500", Offset = "0x832B00", VA = "0x180834500")]
		private void OtherUpdate(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x0015A020 File Offset: 0x00158220
		[Token(Token = "0x6004309")]
		[Address(RVA = "0x8342C0", Offset = "0x8328C0", VA = "0x1808342C0")]
		private List<Vector2Int> GetClockwiseSpiralPositions(Vector2Int center, int count)
		{
			List<Vector2Int> list = new List();
			uint num;
			ulong num2;
			ulong num3;
			ulong num4;
			Vector2Int[] array = new Vector2Int[] { num, num2, num3, num4 };
			int size = list._size;
			list.Add(center);
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

		// Token: 0x0600430A RID: 17162 RVA: 0x0015A0C8 File Offset: 0x001582C8
		[Token(Token = "0x600430A")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ObsidianSpike()
		{
		}

		// Token: 0x02000C7F RID: 3199
		[Token(Token = "0x2000C7F")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x0600430B RID: 17163 RVA: 0x0015A0DC File Offset: 0x001582DC
			[Token(Token = "0x17000687")]
			public override string Title
			{
				[Token(Token = "0x600430B")]
				[Address(RVA = "0x8467A0", Offset = "0x844DA0", VA = "0x1808467A0", Slot = "5")]
				get
				{
					return "强化：增生";
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x0600430C RID: 17164 RVA: 0x0015A0F0 File Offset: 0x001582F0
			[Token(Token = "0x17000688")]
			public override string Description
			{
				[Token(Token = "0x600430C")]
				[Address(RVA = "0x846080", Offset = "0x844680", VA = "0x180846080", Slot = "6")]
				get
				{
					return "获得两株地刺王在周围，地刺王拥有相当于玄钢地刺王100%的独立伤害增幅和100%的速度增幅，基础攻击力为玄钢地刺王的75%，地刺王的属性根据场地上冰火植物数量来决定";
				}
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x0600430D RID: 17165 RVA: 0x0015A104 File Offset: 0x00158304
			[Token(Token = "0x17000689")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600430D")]
				[Address(RVA = "0x8349F0", Offset = "0x832FF0", VA = "0x1808349F0", Slot = "4")]
				get
				{
					return PlantType.ObsidianSpike;
				}
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x0600430E RID: 17166 RVA: 0x0015A118 File Offset: 0x00158318
			[Token(Token = "0x1700068A")]
			public override float AppearWeight
			{
				[Token(Token = "0x600430E")]
				[Address(RVA = "0x845090", Offset = "0x843690", VA = "0x180845090", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x0600430F RID: 17167 RVA: 0x0015A12C File Offset: 0x0015832C
			[Token(Token = "0x1700068B")]
			public override int MaxCount
			{
				[Token(Token = "0x600430F")]
				[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
				get
				{
					return 4;
				}
			}

			// Token: 0x06004310 RID: 17168 RVA: 0x0015A13C File Offset: 0x0015833C
			[Token(Token = "0x6004310")]
			[Address(RVA = "0x845C30", Offset = "0x844230", VA = "0x180845C30", Slot = "7")]
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

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x06004311 RID: 17169 RVA: 0x0015A168 File Offset: 0x00158368
			[Token(Token = "0x1700068C")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004311")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004312 RID: 17170 RVA: 0x0015A178 File Offset: 0x00158378
			[Token(Token = "0x6004312")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C81 RID: 3201
		[Token(Token = "0x2000C81")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x06004316 RID: 17174 RVA: 0x0015A18C File Offset: 0x0015838C
			[Token(Token = "0x1700068D")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004316")]
				[Address(RVA = "0x8349F0", Offset = "0x832FF0", VA = "0x1808349F0", Slot = "4")]
				get
				{
					return PlantType.ObsidianSpike;
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x06004317 RID: 17175 RVA: 0x0015A1A0 File Offset: 0x001583A0
			[Token(Token = "0x1700068E")]
			public override string Title
			{
				[Token(Token = "0x6004317")]
				[Address(RVA = "0x83A4C0", Offset = "0x838AC0", VA = "0x18083A4C0", Slot = "5")]
				get
				{
					return "质变：流血";
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x06004318 RID: 17176 RVA: 0x0015A1B4 File Offset: 0x001583B4
			[Token(Token = "0x1700068F")]
			public override string Description
			{
				[Token(Token = "0x6004318")]
				[Address(RVA = "0x83A2F0", Offset = "0x8388F0", VA = "0x18083A2F0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12014];
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06004319 RID: 17177 RVA: 0x0015A1D8 File Offset: 0x001583D8
			[Token(Token = "0x17000690")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004319")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x0600431A RID: 17178 RVA: 0x0015A1E8 File Offset: 0x001583E8
			[Token(Token = "0x17000691")]
			public override int MaxCount
			{
				[Token(Token = "0x600431A")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x0600431B RID: 17179 RVA: 0x0015A1F8 File Offset: 0x001583F8
			[Token(Token = "0x17000692")]
			public override float AppearWeight
			{
				[Token(Token = "0x600431B")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600431C RID: 17180 RVA: 0x0015A20C File Offset: 0x0015840C
			[Token(Token = "0x600431C")]
			[Address(RVA = "0x839CD0", Offset = "0x8382D0", VA = "0x180839CD0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12014));
			}

			// Token: 0x0600431D RID: 17181 RVA: 0x0015A234 File Offset: 0x00158434
			[Token(Token = "0x600431D")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
