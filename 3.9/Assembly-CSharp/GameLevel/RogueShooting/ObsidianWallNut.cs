using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D59 RID: 3417
	[Token(Token = "0x2000D59")]
	public class ObsidianWallNut : BaseConfig
	{
		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600471A RID: 18202 RVA: 0x00167A14 File Offset: 0x00165C14
		[Token(Token = "0x170007FF")]
		public override string Role
		{
			[Token(Token = "0x600471A")]
			[Address(RVA = "0x8B0E20", Offset = "0x8AF420", VA = "0x1808B0E20", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600471B RID: 18203 RVA: 0x00167A28 File Offset: 0x00165C28
		[Token(Token = "0x17000800")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600471B")]
			[Address(RVA = "0x8B0E10", Offset = "0x8AF410", VA = "0x1808B0E10", Slot = "4")]
			get
			{
				return PlantType.ObsidianWallNut;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600471C RID: 18204 RVA: 0x00167A3C File Offset: 0x00165C3C
		[Token(Token = "0x17000801")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600471C")]
			[Address(RVA = "0x8B0B60", Offset = "0x8AF160", VA = "0x1808B0B60", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				ObsidianWallNut.ShootCountBuff shootCountBuff = new ObsidianWallNut.ShootCountBuff();
				int size3 = list._size;
				ObsidianWallNut.ShootBuff shootBuff = new ObsidianWallNut.ShootBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x00167A94 File Offset: 0x00165C94
		[Token(Token = "0x600471D")]
		[Address(RVA = "0x8B0970", Offset = "0x8AEF70", VA = "0x1808B0970", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)6));
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x00167AC8 File Offset: 0x00165CC8
		[Token(Token = "0x600471E")]
		[Address(RVA = "0x8B0A90", Offset = "0x8AF090", VA = "0x1808B0A90")]
		private void UniqueUpdate(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x00167AE8 File Offset: 0x00165CE8
		[Token(Token = "0x600471F")]
		[Address(RVA = "0x8B08B0", Offset = "0x8AEEB0", VA = "0x1808B08B0")]
		private void CreateLoonNut(Plant plant, int count)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x00167B0C File Offset: 0x00165D0C
		[Token(Token = "0x6004720")]
		[Address(RVA = "0x8B07F0", Offset = "0x8AEDF0", VA = "0x1808B07F0")]
		private void CreateLoonNut2(Plant plant, int count)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x00167B30 File Offset: 0x00165D30
		[Token(Token = "0x6004721")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ObsidianWallNut()
		{
		}

		// Token: 0x02000D5A RID: 3418
		[Token(Token = "0x2000D5A")]
		private class ShootCountBuff : BaseBuff
		{
			// Token: 0x17000802 RID: 2050
			// (get) Token: 0x06004722 RID: 18210 RVA: 0x00167B44 File Offset: 0x00165D44
			[Token(Token = "0x17000802")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004722")]
				[Address(RVA = "0x8B0E10", Offset = "0x8AF410", VA = "0x1808B0E10", Slot = "4")]
				get
				{
					return PlantType.ObsidianWallNut;
				}
			}

			// Token: 0x17000803 RID: 2051
			// (get) Token: 0x06004723 RID: 18211 RVA: 0x00167B58 File Offset: 0x00165D58
			[Token(Token = "0x17000803")]
			public override string Title
			{
				[Token(Token = "0x6004723")]
				[Address(RVA = "0x8B3A40", Offset = "0x8B2040", VA = "0x1808B3A40", Slot = "5")]
				get
				{
					return "强化：保龄球";
				}
			}

			// Token: 0x17000804 RID: 2052
			// (get) Token: 0x06004724 RID: 18212 RVA: 0x00167B6C File Offset: 0x00165D6C
			[Token(Token = "0x17000804")]
			public override string Description
			{
				[Token(Token = "0x6004724")]
				[Address(RVA = "0x8B3A10", Offset = "0x8B2010", VA = "0x1808B3A10", Slot = "6")]
				get
				{
					return "保龄球发射数量+1";
				}
			}

			// Token: 0x17000805 RID: 2053
			// (get) Token: 0x06004725 RID: 18213 RVA: 0x00167B80 File Offset: 0x00165D80
			[Token(Token = "0x17000805")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004725")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004726 RID: 18214 RVA: 0x00167B94 File Offset: 0x00165D94
			[Token(Token = "0x6004726")]
			[Address(RVA = "0x8B39A0", Offset = "0x8B1FA0", VA = "0x1808B39A0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000806 RID: 2054
			// (get) Token: 0x06004727 RID: 18215 RVA: 0x00167BB4 File Offset: 0x00165DB4
			[Token(Token = "0x17000806")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004727")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004728 RID: 18216 RVA: 0x00167BC4 File Offset: 0x00165DC4
			[Token(Token = "0x6004728")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public ShootCountBuff()
			{
			}
		}

		// Token: 0x02000D5B RID: 3419
		[Token(Token = "0x2000D5B")]
		private class ShootBuff : BaseBuff
		{
			// Token: 0x17000807 RID: 2055
			// (get) Token: 0x06004729 RID: 18217 RVA: 0x00167BD8 File Offset: 0x00165DD8
			[Token(Token = "0x17000807")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004729")]
				[Address(RVA = "0x8B0E10", Offset = "0x8AF410", VA = "0x1808B0E10", Slot = "4")]
				get
				{
					return PlantType.ObsidianWallNut;
				}
			}

			// Token: 0x17000808 RID: 2056
			// (get) Token: 0x0600472A RID: 18218 RVA: 0x00167BEC File Offset: 0x00165DEC
			[Token(Token = "0x17000808")]
			public override string Title
			{
				[Token(Token = "0x600472A")]
				[Address(RVA = "0x8B3970", Offset = "0x8B1F70", VA = "0x1808B3970", Slot = "5")]
				get
				{
					return "质变：发射";
				}
			}

			// Token: 0x17000809 RID: 2057
			// (get) Token: 0x0600472B RID: 18219 RVA: 0x00167C00 File Offset: 0x00165E00
			[Token(Token = "0x17000809")]
			public override string Description
			{
				[Token(Token = "0x600472B")]
				[Address(RVA = "0x8B3940", Offset = "0x8B1F40", VA = "0x1808B3940", Slot = "6")]
				get
				{
					return "每次攻击在每行发射一发保龄球";
				}
			}

			// Token: 0x1700080A RID: 2058
			// (get) Token: 0x0600472C RID: 18220 RVA: 0x00167C14 File Offset: 0x00165E14
			[Token(Token = "0x1700080A")]
			public override Quality Rarity
			{
				[Token(Token = "0x600472C")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700080B RID: 2059
			// (get) Token: 0x0600472D RID: 18221 RVA: 0x00167C24 File Offset: 0x00165E24
			[Token(Token = "0x1700080B")]
			public override int MaxCount
			{
				[Token(Token = "0x600472D")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x0600472E RID: 18222 RVA: 0x00167C34 File Offset: 0x00165E34
			[Token(Token = "0x1700080C")]
			public override float AppearWeight
			{
				[Token(Token = "0x600472E")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600472F RID: 18223 RVA: 0x00167C48 File Offset: 0x00165E48
			[Token(Token = "0x600472F")]
			[Address(RVA = "0x8B38C0", Offset = "0x8B1EC0", VA = "0x1808B38C0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x06004730 RID: 18224 RVA: 0x00167C68 File Offset: 0x00165E68
			[Token(Token = "0x6004730")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public ShootBuff()
			{
			}
		}
	}
}
