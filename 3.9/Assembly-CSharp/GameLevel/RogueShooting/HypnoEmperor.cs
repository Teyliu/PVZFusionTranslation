using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D2D RID: 3373
	[Token(Token = "0x2000D2D")]
	public class HypnoEmperor : BaseConfig
	{
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x00165BD0 File Offset: 0x00163DD0
		[Token(Token = "0x17000765")]
		public override string Role
		{
			[Token(Token = "0x600461D")]
			[Address(RVA = "0x8ADD80", Offset = "0x8AC380", VA = "0x1808ADD80", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600461E RID: 17950 RVA: 0x00165BE4 File Offset: 0x00163DE4
		[Token(Token = "0x17000766")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600461E")]
			[Address(RVA = "0x8AAC50", Offset = "0x8A9250", VA = "0x1808AAC50", Slot = "4")]
			get
			{
				return PlantType.HypnoEmperor;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x00165BF8 File Offset: 0x00163DF8
		[Token(Token = "0x17000767")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600461F")]
			[Address(RVA = "0x8ADAD0", Offset = "0x8AC0D0", VA = "0x1808ADAD0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				HypnoEmperor.CountBuff countBuff = new HypnoEmperor.CountBuff();
				int size3 = list._size;
				HypnoEmperor.SuperBuff superBuff = new HypnoEmperor.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00165C50 File Offset: 0x00163E50
		[Token(Token = "0x6004620")]
		[Address(RVA = "0x8AD8C0", Offset = "0x8ABEC0", VA = "0x1808AD8C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			TravelMgr instance = TravelMgr.Instance;
			int num = 0;
			instance.GetNormalBuff((AdvBuff)num);
			TravelMgr instance2 = TravelMgr.Instance;
			if (HypnoEmperor.<>c.<>9__6_0 == 0 || plant != 0)
			{
				if (plant != 0)
				{
				}
				Action<Zombie> action;
				HypnoEmperor.<>c.<>9__6_0 = action;
			}
			throw new NullReferenceException();
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00165C98 File Offset: 0x00163E98
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public HypnoEmperor()
		{
		}

		// Token: 0x02000D2E RID: 3374
		[Token(Token = "0x2000D2E")]
		private class CountBuff : BaseBuff
		{
			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06004622 RID: 17954 RVA: 0x00165CAC File Offset: 0x00163EAC
			[Token(Token = "0x17000768")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004622")]
				[Address(RVA = "0x8AAC50", Offset = "0x8A9250", VA = "0x1808AAC50", Slot = "4")]
				get
				{
					return PlantType.HypnoEmperor;
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06004623 RID: 17955 RVA: 0x00165CC0 File Offset: 0x00163EC0
			[Token(Token = "0x17000769")]
			public override string Title
			{
				[Token(Token = "0x6004623")]
				[Address(RVA = "0x8AAC60", Offset = "0x8A9260", VA = "0x1808AAC60", Slot = "5")]
				get
				{
					return "强化：数量";
				}
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x06004624 RID: 17956 RVA: 0x00165CD4 File Offset: 0x00163ED4
			[Token(Token = "0x1700076A")]
			public override string Description
			{
				[Token(Token = "0x6004624")]
				[Address(RVA = "0x8AAC20", Offset = "0x8A9220", VA = "0x1808AAC20", Slot = "6")]
				get
				{
					return "每次召唤多生成一只僵尸";
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x06004625 RID: 17957 RVA: 0x00165CE8 File Offset: 0x00163EE8
			[Token(Token = "0x1700076B")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004625")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06004626 RID: 17958 RVA: 0x00165CF8 File Offset: 0x00163EF8
			[Token(Token = "0x1700076C")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004626")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004627 RID: 17959 RVA: 0x00165D0C File Offset: 0x00163F0C
			[Token(Token = "0x6004627")]
			[Address(RVA = "0x8AAB00", Offset = "0x8A9100", VA = "0x1808AAB00", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = HypnoEmperor.CountBuff.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					HypnoEmperor.CountBuff.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x06004628 RID: 17960 RVA: 0x00165D38 File Offset: 0x00163F38
			[Token(Token = "0x6004628")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public CountBuff()
			{
			}
		}

		// Token: 0x02000D30 RID: 3376
		[Token(Token = "0x2000D30")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x0600462C RID: 17964 RVA: 0x00165D4C File Offset: 0x00163F4C
			[Token(Token = "0x1700076D")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600462C")]
				[Address(RVA = "0x8AAC50", Offset = "0x8A9250", VA = "0x1808AAC50", Slot = "4")]
				get
				{
					return PlantType.HypnoEmperor;
				}
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x0600462D RID: 17965 RVA: 0x00165D60 File Offset: 0x00163F60
			[Token(Token = "0x1700076E")]
			public override string Title
			{
				[Token(Token = "0x600462D")]
				[Address(RVA = "0x8B71E0", Offset = "0x8B57E0", VA = "0x1808B71E0", Slot = "5")]
				get
				{
					return "质变：精英";
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x0600462E RID: 17966 RVA: 0x00165D74 File Offset: 0x00163F74
			[Token(Token = "0x1700076F")]
			public override string Description
			{
				[Token(Token = "0x600462E")]
				[Address(RVA = "0x8B6CB0", Offset = "0x8B52B0", VA = "0x1808B6CB0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12012];
				}
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x0600462F RID: 17967 RVA: 0x00165D98 File Offset: 0x00163F98
			[Token(Token = "0x17000770")]
			public override Quality Rarity
			{
				[Token(Token = "0x600462F")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x06004630 RID: 17968 RVA: 0x00165DA8 File Offset: 0x00163FA8
			[Token(Token = "0x17000771")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004630")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004631 RID: 17969 RVA: 0x00165DBC File Offset: 0x00163FBC
			[Token(Token = "0x6004631")]
			[Address(RVA = "0x8B65C0", Offset = "0x8B4BC0", VA = "0x1808B65C0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12012));
			}

			// Token: 0x06004632 RID: 17970 RVA: 0x00165DE4 File Offset: 0x00163FE4
			[Token(Token = "0x6004632")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
