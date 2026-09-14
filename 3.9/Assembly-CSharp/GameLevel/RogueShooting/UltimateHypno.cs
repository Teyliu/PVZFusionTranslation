using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D34 RID: 3380
	[Token(Token = "0x2000D34")]
	public class UltimateHypno : BaseConfig
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x00165FA4 File Offset: 0x001641A4
		[Token(Token = "0x17000778")]
		public override string Role
		{
			[Token(Token = "0x6004640")]
			[Address(RVA = "0x8C2B00", Offset = "0x8C1100", VA = "0x1808C2B00", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06004641 RID: 17985 RVA: 0x00165FB8 File Offset: 0x001641B8
		[Token(Token = "0x17000779")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004641")]
			[Address(RVA = "0x8A8BF0", Offset = "0x8A71F0", VA = "0x1808A8BF0", Slot = "4")]
			get
			{
				return PlantType.UltimateHypno;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06004642 RID: 17986 RVA: 0x00165FCC File Offset: 0x001641CC
		[Token(Token = "0x1700077A")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004642")]
			[Address(RVA = "0x8C27D0", Offset = "0x8C0DD0", VA = "0x1808C27D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateHypno.MindContolledBuff mindContolledBuff = new UltimateHypno.MindContolledBuff();
				int size3 = list._size;
				UltimateHypno.HypnoEffect hypnoEffect = new UltimateHypno.HypnoEffect();
				int size4 = list._size;
				UltimateHypno.BombEffect bombEffect = new UltimateHypno.BombEffect();
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00166034 File Offset: 0x00164234
		[Token(Token = "0x6004643")]
		[Address(RVA = "0x8C2720", Offset = "0x8C0D20", VA = "0x1808C2720", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00166058 File Offset: 0x00164258
		[Token(Token = "0x6004644")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateHypno()
		{
		}

		// Token: 0x02000D35 RID: 3381
		[Token(Token = "0x2000D35")]
		private class MindContolledBuff : BaseBuff
		{
			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x06004645 RID: 17989 RVA: 0x0016606C File Offset: 0x0016426C
			[Token(Token = "0x1700077B")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004645")]
				[Address(RVA = "0x8A8BF0", Offset = "0x8A71F0", VA = "0x1808A8BF0", Slot = "4")]
				get
				{
					return PlantType.UltimateHypno;
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06004646 RID: 17990 RVA: 0x00166080 File Offset: 0x00164280
			[Token(Token = "0x1700077C")]
			public override string Title
			{
				[Token(Token = "0x6004646")]
				[Address(RVA = "0x8AFE30", Offset = "0x8AE430", VA = "0x1808AFE30", Slot = "5")]
				get
				{
					return "强化：魅惑";
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06004647 RID: 17991 RVA: 0x00166094 File Offset: 0x00164294
			[Token(Token = "0x1700077D")]
			public override string Description
			{
				[Token(Token = "0x6004647")]
				[Address(RVA = "0x8AFE00", Offset = "0x8AE400", VA = "0x1808AFE00", Slot = "6")]
				get
				{
					return "魅惑概率提高7.5%";
				}
			}

			// Token: 0x06004648 RID: 17992 RVA: 0x001660A8 File Offset: 0x001642A8
			[Token(Token = "0x6004648")]
			[Address(RVA = "0x8AFD70", Offset = "0x8AE370", VA = "0x1808AFD70", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06004649 RID: 17993 RVA: 0x001660C8 File Offset: 0x001642C8
			[Token(Token = "0x1700077E")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004649")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600464A RID: 17994 RVA: 0x001660D8 File Offset: 0x001642D8
			[Token(Token = "0x600464A")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public MindContolledBuff()
			{
			}
		}

		// Token: 0x02000D36 RID: 3382
		[Token(Token = "0x2000D36")]
		private class HypnoEffect : BaseBuff
		{
			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x0600464B RID: 17995 RVA: 0x001660EC File Offset: 0x001642EC
			[Token(Token = "0x1700077F")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600464B")]
				[Address(RVA = "0x8A8BF0", Offset = "0x8A71F0", VA = "0x1808A8BF0", Slot = "4")]
				get
				{
					return PlantType.UltimateHypno;
				}
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x0600464C RID: 17996 RVA: 0x00166100 File Offset: 0x00164300
			[Token(Token = "0x17000780")]
			public override string Title
			{
				[Token(Token = "0x600464C")]
				[Address(RVA = "0x8AD890", Offset = "0x8ABE90", VA = "0x1808AD890", Slot = "5")]
				get
				{
					return "质变：普度众生";
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x0600464D RID: 17997 RVA: 0x00166114 File Offset: 0x00164314
			[Token(Token = "0x17000781")]
			public override string Description
			{
				[Token(Token = "0x600464D")]
				[Address(RVA = "0x8AD860", Offset = "0x8ABE60", VA = "0x1808AD860", Slot = "6")]
				get
				{
					return "获得词条：普度众生";
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x0600464E RID: 17998 RVA: 0x00166128 File Offset: 0x00164328
			[Token(Token = "0x17000782")]
			public override Quality Rarity
			{
				[Token(Token = "0x600464E")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x0600464F RID: 17999 RVA: 0x00166138 File Offset: 0x00164338
			[Token(Token = "0x17000783")]
			public override int MaxCount
			{
				[Token(Token = "0x600464F")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06004650 RID: 18000 RVA: 0x00166148 File Offset: 0x00164348
			[Token(Token = "0x17000784")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004650")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004651 RID: 18001 RVA: 0x0016615C File Offset: 0x0016435C
			[Token(Token = "0x6004651")]
			[Address(RVA = "0x8AD800", Offset = "0x8ABE00", VA = "0x1808AD800", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				int num = 0;
				instance.GetUltiBuff((UltiBuff)((uint)18), num != 0);
			}

			// Token: 0x06004652 RID: 18002 RVA: 0x00166184 File Offset: 0x00164384
			[Token(Token = "0x6004652")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public HypnoEffect()
			{
			}
		}

		// Token: 0x02000D37 RID: 3383
		[Token(Token = "0x2000D37")]
		private class BombEffect : BaseBuff
		{
			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06004653 RID: 18003 RVA: 0x00166198 File Offset: 0x00164398
			[Token(Token = "0x17000785")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004653")]
				[Address(RVA = "0x8A8BF0", Offset = "0x8A71F0", VA = "0x1808A8BF0", Slot = "4")]
				get
				{
					return PlantType.UltimateHypno;
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06004654 RID: 18004 RVA: 0x001661AC File Offset: 0x001643AC
			[Token(Token = "0x17000786")]
			public override string Title
			{
				[Token(Token = "0x6004654")]
				[Address(RVA = "0x8A8C00", Offset = "0x8A7200", VA = "0x1808A8C00", Slot = "5")]
				get
				{
					return "质变：定时炸弹";
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06004655 RID: 18005 RVA: 0x001661C0 File Offset: 0x001643C0
			[Token(Token = "0x17000787")]
			public override string Description
			{
				[Token(Token = "0x6004655")]
				[Address(RVA = "0x8A8BC0", Offset = "0x8A71C0", VA = "0x1808A8BC0", Slot = "6")]
				get
				{
					return "获得词条：定时炸弹";
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x06004656 RID: 18006 RVA: 0x001661D4 File Offset: 0x001643D4
			[Token(Token = "0x17000788")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004656")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06004657 RID: 18007 RVA: 0x001661E4 File Offset: 0x001643E4
			[Token(Token = "0x17000789")]
			public override int MaxCount
			{
				[Token(Token = "0x6004657")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06004658 RID: 18008 RVA: 0x001661F4 File Offset: 0x001643F4
			[Token(Token = "0x1700078A")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004658")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004659 RID: 18009 RVA: 0x00166208 File Offset: 0x00164408
			[Token(Token = "0x6004659")]
			[Address(RVA = "0x8A8B50", Offset = "0x8A7150", VA = "0x1808A8B50", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)2009));
			}

			// Token: 0x0600465A RID: 18010 RVA: 0x00166230 File Offset: 0x00164430
			[Token(Token = "0x600465A")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public BombEffect()
			{
			}
		}
	}
}
