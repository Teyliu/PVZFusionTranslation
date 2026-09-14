using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D28 RID: 3368
	[Token(Token = "0x2000D28")]
	public class UltimateGloom : BaseConfig
	{
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060045FF RID: 17919 RVA: 0x001658D0 File Offset: 0x00163AD0
		[Token(Token = "0x17000751")]
		public override string Role
		{
			[Token(Token = "0x60045FF")]
			[Address(RVA = "0x8C23D0", Offset = "0x8C09D0", VA = "0x1808C23D0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x001658E4 File Offset: 0x00163AE4
		[Token(Token = "0x17000752")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004600")]
			[Address(RVA = "0x8AAEA0", Offset = "0x8A94A0", VA = "0x1808AAEA0", Slot = "4")]
			get
			{
				return PlantType.UltimateGloom;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06004601 RID: 17921 RVA: 0x001658F8 File Offset: 0x00163AF8
		[Token(Token = "0x17000753")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004601")]
			[Address(RVA = "0x8C20A0", Offset = "0x8C06A0", VA = "0x1808C20A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateGloom.UniqueUpgrade uniqueUpgrade = new UltimateGloom.UniqueUpgrade();
				int size3 = list._size;
				UltimateGloom.DoomBuff doomBuff = new UltimateGloom.DoomBuff();
				int size4 = list._size;
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x0016595C File Offset: 0x00163B5C
		[Token(Token = "0x6004602")]
		[Address(RVA = "0x8C0FB0", Offset = "0x8BF5B0", VA = "0x1808C0FB0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 3f, num2 != 0, num);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00165984 File Offset: 0x00163B84
		[Token(Token = "0x6004603")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateGloom()
		{
		}

		// Token: 0x02000D29 RID: 3369
		[Token(Token = "0x2000D29")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06004604 RID: 17924 RVA: 0x00165998 File Offset: 0x00163B98
			[Token(Token = "0x17000754")]
			public override string Title
			{
				[Token(Token = "0x6004604")]
				[Address(RVA = "0x8C6C60", Offset = "0x8C5260", VA = "0x1808C6C60", Slot = "5")]
				get
				{
					return "强化：半径";
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06004605 RID: 17925 RVA: 0x001659AC File Offset: 0x00163BAC
			[Token(Token = "0x17000755")]
			public override string Description
			{
				[Token(Token = "0x6004605")]
				[Address(RVA = "0x8C67C0", Offset = "0x8C4DC0", VA = "0x1808C67C0", Slot = "6")]
				get
				{
					return base.PlantName + "伤害半径+0.5";
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06004606 RID: 17926 RVA: 0x001659CC File Offset: 0x00163BCC
			[Token(Token = "0x17000756")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004606")]
				[Address(RVA = "0x8AAEA0", Offset = "0x8A94A0", VA = "0x1808AAEA0", Slot = "4")]
				get
				{
					return PlantType.UltimateGloom;
				}
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06004607 RID: 17927 RVA: 0x001659E0 File Offset: 0x00163BE0
			[Token(Token = "0x17000757")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004607")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004608 RID: 17928 RVA: 0x001659F4 File Offset: 0x00163BF4
			[Token(Token = "0x6004608")]
			[Address(RVA = "0x8C5C40", Offset = "0x8C4240", VA = "0x1808C5C40", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06004609 RID: 17929 RVA: 0x00165A14 File Offset: 0x00163C14
			[Token(Token = "0x17000758")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004609")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600460A RID: 17930 RVA: 0x00165A24 File Offset: 0x00163C24
			[Token(Token = "0x600460A")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D2A RID: 3370
		[Token(Token = "0x2000D2A")]
		private class DoomBuff : BaseBuff
		{
			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x0600460B RID: 17931 RVA: 0x00165A38 File Offset: 0x00163C38
			[Token(Token = "0x17000759")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600460B")]
				[Address(RVA = "0x8AAEA0", Offset = "0x8A94A0", VA = "0x1808AAEA0", Slot = "4")]
				get
				{
					return PlantType.UltimateGloom;
				}
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x0600460C RID: 17932 RVA: 0x00165A4C File Offset: 0x00163C4C
			[Token(Token = "0x1700075A")]
			public override string Title
			{
				[Token(Token = "0x600460C")]
				[Address(RVA = "0x8AAEB0", Offset = "0x8A94B0", VA = "0x1808AAEB0", Slot = "5")]
				get
				{
					return "质变：湮灭";
				}
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x0600460D RID: 17933 RVA: 0x00165A60 File Offset: 0x00163C60
			[Token(Token = "0x1700075B")]
			public override string Description
			{
				[Token(Token = "0x600460D")]
				[Address(RVA = "0x8AAE70", Offset = "0x8A9470", VA = "0x1808AAE70", Slot = "6")]
				get
				{
					return "获得词条：真-万籁俱寂";
				}
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x0600460E RID: 17934 RVA: 0x00165A74 File Offset: 0x00163C74
			[Token(Token = "0x1700075C")]
			public override Quality Rarity
			{
				[Token(Token = "0x600460E")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x0600460F RID: 17935 RVA: 0x00165A84 File Offset: 0x00163C84
			[Token(Token = "0x1700075D")]
			public override int MaxCount
			{
				[Token(Token = "0x600460F")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06004610 RID: 17936 RVA: 0x00165A94 File Offset: 0x00163C94
			[Token(Token = "0x1700075E")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004610")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004611 RID: 17937 RVA: 0x00165AA8 File Offset: 0x00163CA8
			[Token(Token = "0x6004611")]
			[Address(RVA = "0x8AAE10", Offset = "0x8A9410", VA = "0x1808AAE10", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12005));
			}

			// Token: 0x06004612 RID: 17938 RVA: 0x00165AD0 File Offset: 0x00163CD0
			[Token(Token = "0x6004612")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public DoomBuff()
			{
			}
		}
	}
}
