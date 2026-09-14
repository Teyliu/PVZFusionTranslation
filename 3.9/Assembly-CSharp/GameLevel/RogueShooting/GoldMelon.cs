using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D83 RID: 3459
	[Token(Token = "0x2000D83")]
	public class GoldMelon : BaseConfig
	{
		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06004804 RID: 18436 RVA: 0x0016951C File Offset: 0x0016771C
		[Token(Token = "0x1700088F")]
		public override string Role
		{
			[Token(Token = "0x6004804")]
			[Address(RVA = "0x8ACE50", Offset = "0x8AB450", VA = "0x1808ACE50", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x00169530 File Offset: 0x00167730
		[Token(Token = "0x17000890")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004805")]
			[Address(RVA = "0x7D25D0", Offset = "0x7D0BD0", VA = "0x1807D25D0", Slot = "4")]
			get
			{
				return PlantType.GoldMelon;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06004806 RID: 18438 RVA: 0x00169544 File Offset: 0x00167744
		[Token(Token = "0x17000891")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004806")]
			[Address(RVA = "0x8ACBA0", Offset = "0x8AB1A0", VA = "0x1808ACBA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				GoldMelon.UniqueUpgrage uniqueUpgrage = new GoldMelon.UniqueUpgrage();
				int size3 = list._size;
				GoldMelon.SuperUpgrade superUpgrade = new GoldMelon.SuperUpgrade();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x0016959C File Offset: 0x0016779C
		[Token(Token = "0x6004807")]
		[Address(RVA = "0x8AC930", Offset = "0x8AAF30", VA = "0x1808AC930", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x001695BC File Offset: 0x001677BC
		[Token(Token = "0x6004808")]
		[Address(RVA = "0x8ACA00", Offset = "0x8AB000", VA = "0x1808ACA00")]
		private void ShootGiveMoney(object obj)
		{
			if (obj != 0)
			{
				int num = 0;
				if (obj != 0)
				{
					num++;
					if (num < num)
					{
						ShootingManager instance = ShootingManager.Instance;
						int num2 = 0;
						int num3 = 0;
						Quality randomQuality = instance.GetRandomQuality(num3 != 0, num2 != 0);
						if (randomQuality == Quality.Default || randomQuality == Quality.Default || randomQuality == Quality.Default || randomQuality == Quality.silver)
						{
						}
						CreateItem instance2 = CreateItem.Instance;
						num++;
					}
				}
			}
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x00169618 File Offset: 0x00167818
		[Token(Token = "0x6004809")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public GoldMelon()
		{
		}

		// Token: 0x02000D84 RID: 3460
		[Token(Token = "0x2000D84")]
		private class UniqueUpgrage : BaseBuff
		{
			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x0600480A RID: 18442 RVA: 0x0016962C File Offset: 0x0016782C
			[Token(Token = "0x17000892")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600480A")]
				[Address(RVA = "0x7D25D0", Offset = "0x7D0BD0", VA = "0x1807D25D0", Slot = "4")]
				get
				{
					return PlantType.GoldMelon;
				}
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x0600480B RID: 18443 RVA: 0x00169640 File Offset: 0x00167840
			[Token(Token = "0x17000893")]
			public override string Title
			{
				[Token(Token = "0x600480B")]
				[Address(RVA = "0x8C71C0", Offset = "0x8C57C0", VA = "0x1808C71C0", Slot = "5")]
				get
				{
					return "强化：财富";
				}
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x0600480C RID: 18444 RVA: 0x00169654 File Offset: 0x00167854
			[Token(Token = "0x17000894")]
			public override string Description
			{
				[Token(Token = "0x600480C")]
				[Address(RVA = "0x8C7190", Offset = "0x8C5790", VA = "0x1808C7190", Slot = "6")]
				get
				{
					return "每次攻击多掉落一枚钱币";
				}
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x0600480D RID: 18445 RVA: 0x00169668 File Offset: 0x00167868
			[Token(Token = "0x17000895")]
			public override Quality Rarity
			{
				[Token(Token = "0x600480D")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x0600480E RID: 18446 RVA: 0x00169678 File Offset: 0x00167878
			[Token(Token = "0x17000896")]
			public override float AppearWeight
			{
				[Token(Token = "0x600480E")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600480F RID: 18447 RVA: 0x0016968C File Offset: 0x0016788C
			[Token(Token = "0x600480F")]
			[Address(RVA = "0x8C7080", Offset = "0x8C5680", VA = "0x1808C7080", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = GoldMelon.UniqueUpgrage.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					GoldMelon.UniqueUpgrage.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x06004810 RID: 18448 RVA: 0x001696B8 File Offset: 0x001678B8
			[Token(Token = "0x6004810")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrage()
			{
			}
		}

		// Token: 0x02000D86 RID: 3462
		[Token(Token = "0x2000D86")]
		private class SuperUpgrade : BaseBuff
		{
			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06004814 RID: 18452 RVA: 0x001696CC File Offset: 0x001678CC
			[Token(Token = "0x17000897")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004814")]
				[Address(RVA = "0x7D25D0", Offset = "0x7D0BD0", VA = "0x1807D25D0", Slot = "4")]
				get
				{
					return PlantType.GoldMelon;
				}
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06004815 RID: 18453 RVA: 0x001696E0 File Offset: 0x001678E0
			[Token(Token = "0x17000898")]
			public override string Title
			{
				[Token(Token = "0x6004815")]
				[Address(RVA = "0x8B8680", Offset = "0x8B6C80", VA = "0x1808B8680", Slot = "5")]
				get
				{
					return "质变：人人有份";
				}
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06004816 RID: 18454 RVA: 0x001696F4 File Offset: 0x001678F4
			[Token(Token = "0x17000899")]
			public override string Description
			{
				[Token(Token = "0x6004816")]
				[Address(RVA = "0x8B8550", Offset = "0x8B6B50", VA = "0x1808B8550", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12018];
				}
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x06004817 RID: 18455 RVA: 0x00169718 File Offset: 0x00167918
			[Token(Token = "0x1700089A")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004817")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06004818 RID: 18456 RVA: 0x00169728 File Offset: 0x00167928
			[Token(Token = "0x1700089B")]
			public override int MaxCount
			{
				[Token(Token = "0x6004818")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06004819 RID: 18457 RVA: 0x00169738 File Offset: 0x00167938
			[Token(Token = "0x1700089C")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004819")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600481A RID: 18458 RVA: 0x0016974C File Offset: 0x0016794C
			[Token(Token = "0x600481A")]
			[Address(RVA = "0x8B8380", Offset = "0x8B6980", VA = "0x1808B8380", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12018));
			}

			// Token: 0x0600481B RID: 18459 RVA: 0x00169774 File Offset: 0x00167974
			[Token(Token = "0x600481B")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperUpgrade()
			{
			}
		}
	}
}
