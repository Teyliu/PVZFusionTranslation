using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CBA RID: 3258
	[Token(Token = "0x2000CBA")]
	public class UltimateBamboo : BaseConfig
	{
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x0015C9E8 File Offset: 0x0015ABE8
		[Token(Token = "0x1700074C")]
		public override string Role
		{
			[Token(Token = "0x6004451")]
			[Address(RVA = "0x840050", Offset = "0x83E650", VA = "0x180840050", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x0015C9FC File Offset: 0x0015ABFC
		[Token(Token = "0x1700074D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004452")]
			[Address(RVA = "0x8301C0", Offset = "0x82E7C0", VA = "0x1808301C0", Slot = "4")]
			get
			{
				return PlantType.UltimateBamboo;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x0015CA10 File Offset: 0x0015AC10
		[Token(Token = "0x1700074E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004453")]
			[Address(RVA = "0x83FDB0", Offset = "0x83E3B0", VA = "0x18083FDB0", Slot = "5")]
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

		// Token: 0x06004454 RID: 17492 RVA: 0x0015CA6C File Offset: 0x0015AC6C
		[Token(Token = "0x6004454")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x0015CA7C File Offset: 0x0015AC7C
		[Token(Token = "0x6004455")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateBamboo()
		{
		}

		// Token: 0x02000CBB RID: 3259
		[Token(Token = "0x2000CBB")]
		private class HealthBuff : BaseBuff
		{
			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x06004456 RID: 17494 RVA: 0x0015CA90 File Offset: 0x0015AC90
			[Token(Token = "0x1700074F")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004456")]
				[Address(RVA = "0x8301C0", Offset = "0x82E7C0", VA = "0x1808301C0", Slot = "4")]
				get
				{
					return PlantType.UltimateBamboo;
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x06004457 RID: 17495 RVA: 0x0015CAA4 File Offset: 0x0015ACA4
			[Token(Token = "0x17000750")]
			public override string Title
			{
				[Token(Token = "0x6004457")]
				[Address(RVA = "0x831C50", Offset = "0x830250", VA = "0x180831C50", Slot = "5")]
				get
				{
					return "强化：生命";
				}
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x06004458 RID: 17496 RVA: 0x0015CAB8 File Offset: 0x0015ACB8
			[Token(Token = "0x17000751")]
			public override string Description
			{
				[Token(Token = "0x6004458")]
				[Address(RVA = "0x831C20", Offset = "0x830220", VA = "0x180831C20", Slot = "6")]
				get
				{
					return "生命值上限+50%";
				}
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x06004459 RID: 17497 RVA: 0x0015CACC File Offset: 0x0015ACCC
			[Token(Token = "0x17000752")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004459")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x0600445A RID: 17498 RVA: 0x0015CADC File Offset: 0x0015ACDC
			[Token(Token = "0x17000753")]
			public override int MaxCount
			{
				[Token(Token = "0x600445A")]
				[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x0600445B RID: 17499 RVA: 0x0015CAEC File Offset: 0x0015ACEC
			[Token(Token = "0x17000754")]
			public override float AppearWeight
			{
				[Token(Token = "0x600445B")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600445C RID: 17500 RVA: 0x0015CB00 File Offset: 0x0015AD00
			[Token(Token = "0x600445C")]
			[Address(RVA = "0x831B10", Offset = "0x830110", VA = "0x180831B10", Slot = "7")]
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

			// Token: 0x0600445D RID: 17501 RVA: 0x0015CB2C File Offset: 0x0015AD2C
			[Token(Token = "0x600445D")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public HealthBuff()
			{
			}
		}

		// Token: 0x02000CBD RID: 3261
		[Token(Token = "0x2000CBD")]
		private class DefenceBuff : BaseBuff
		{
			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06004461 RID: 17505 RVA: 0x0015CB40 File Offset: 0x0015AD40
			[Token(Token = "0x17000755")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004461")]
				[Address(RVA = "0x8301C0", Offset = "0x82E7C0", VA = "0x1808301C0", Slot = "4")]
				get
				{
					return PlantType.UltimateBamboo;
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06004462 RID: 17506 RVA: 0x0015CB54 File Offset: 0x0015AD54
			[Token(Token = "0x17000756")]
			public override string Title
			{
				[Token(Token = "0x6004462")]
				[Address(RVA = "0x8301D0", Offset = "0x82E7D0", VA = "0x1808301D0", Slot = "5")]
				get
				{
					return "强化：坚韧";
				}
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06004463 RID: 17507 RVA: 0x0015CB68 File Offset: 0x0015AD68
			[Token(Token = "0x17000757")]
			public override string Description
			{
				[Token(Token = "0x6004463")]
				[Address(RVA = "0x830190", Offset = "0x82E790", VA = "0x180830190", Slot = "6")]
				get
				{
					return "坚韧增加30%\n坚韧越高，撞击僵尸后使僵尸受到的伤害越高，自身受到的伤害越低";
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06004464 RID: 17508 RVA: 0x0015CB7C File Offset: 0x0015AD7C
			[Token(Token = "0x17000758")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004464")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06004465 RID: 17509 RVA: 0x0015CB8C File Offset: 0x0015AD8C
			[Token(Token = "0x17000759")]
			public override int MaxCount
			{
				[Token(Token = "0x6004465")]
				[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06004466 RID: 17510 RVA: 0x0015CB9C File Offset: 0x0015AD9C
			[Token(Token = "0x1700075A")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004466")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004467 RID: 17511 RVA: 0x0015CBB0 File Offset: 0x0015ADB0
			[Token(Token = "0x6004467")]
			[Address(RVA = "0x830080", Offset = "0x82E680", VA = "0x180830080", Slot = "7")]
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

			// Token: 0x06004468 RID: 17512 RVA: 0x0015CBDC File Offset: 0x0015ADDC
			[Token(Token = "0x6004468")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public DefenceBuff()
			{
			}
		}

		// Token: 0x02000CBF RID: 3263
		[Token(Token = "0x2000CBF")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x0600446C RID: 17516 RVA: 0x0015CBF0 File Offset: 0x0015ADF0
			[Token(Token = "0x1700075B")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600446C")]
				[Address(RVA = "0x8301C0", Offset = "0x82E7C0", VA = "0x1808301C0", Slot = "4")]
				get
				{
					return PlantType.UltimateBamboo;
				}
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x0600446D RID: 17517 RVA: 0x0015CC04 File Offset: 0x0015AE04
			[Token(Token = "0x1700075C")]
			public override string Title
			{
				[Token(Token = "0x600446D")]
				[Address(RVA = "0x83A460", Offset = "0x838A60", VA = "0x18083A460", Slot = "5")]
				get
				{
					return "质变：大运";
				}
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x0600446E RID: 17518 RVA: 0x0015CC18 File Offset: 0x0015AE18
			[Token(Token = "0x1700075D")]
			public override string Description
			{
				[Token(Token = "0x600446E")]
				[Address(RVA = "0x839FE0", Offset = "0x8385E0", VA = "0x180839FE0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12015];
				}
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x0600446F RID: 17519 RVA: 0x0015CC3C File Offset: 0x0015AE3C
			[Token(Token = "0x1700075E")]
			public override Quality Rarity
			{
				[Token(Token = "0x600446F")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x06004470 RID: 17520 RVA: 0x0015CC4C File Offset: 0x0015AE4C
			[Token(Token = "0x1700075F")]
			public override int MaxCount
			{
				[Token(Token = "0x6004470")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x06004471 RID: 17521 RVA: 0x0015CC5C File Offset: 0x0015AE5C
			[Token(Token = "0x17000760")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004471")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004472 RID: 17522 RVA: 0x0015CC70 File Offset: 0x0015AE70
			[Token(Token = "0x6004472")]
			[Address(RVA = "0x8398C0", Offset = "0x837EC0", VA = "0x1808398C0", Slot = "7")]
			public override void OnGet()
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}

			// Token: 0x06004473 RID: 17523 RVA: 0x0015CC90 File Offset: 0x0015AE90
			[Token(Token = "0x6004473")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
