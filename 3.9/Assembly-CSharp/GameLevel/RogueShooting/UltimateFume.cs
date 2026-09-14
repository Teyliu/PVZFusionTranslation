using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D1F RID: 3359
	[Token(Token = "0x2000D1F")]
	public class UltimateFume : BaseConfig
	{
		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x00165354 File Offset: 0x00163554
		[Token(Token = "0x1700072D")]
		public override string Role
		{
			[Token(Token = "0x60045C8")]
			[Address(RVA = "0x8C1D10", Offset = "0x8C0310", VA = "0x1808C1D10", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060045C9 RID: 17865 RVA: 0x00165368 File Offset: 0x00163568
		[Token(Token = "0x1700072E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60045C9")]
			[Address(RVA = "0x8A8CC0", Offset = "0x8A72C0", VA = "0x1808A8CC0", Slot = "4")]
			get
			{
				return PlantType.UltimateFume;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x0016537C File Offset: 0x0016357C
		[Token(Token = "0x1700072F")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60045CA")]
			[Address(RVA = "0x8C19E0", Offset = "0x8BFFE0", VA = "0x1808C19E0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				UltimateFume.UniqueUpgrade uniqueUpgrade = new UltimateFume.UniqueUpgrade();
				int size4 = list._size;
				UltimateFume.BuffUpgrade buffUpgrade = new UltimateFume.BuffUpgrade();
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x001653E0 File Offset: 0x001635E0
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x8C0FB0", Offset = "0x8BF5B0", VA = "0x1808C0FB0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 3f, num2 != 0, num);
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x00165408 File Offset: 0x00163608
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateFume()
		{
		}

		// Token: 0x02000D20 RID: 3360
		[Token(Token = "0x2000D20")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x060045CD RID: 17869 RVA: 0x0016541C File Offset: 0x0016361C
			[Token(Token = "0x17000730")]
			public override string Title
			{
				[Token(Token = "0x60045CD")]
				[Address(RVA = "0x8C7050", Offset = "0x8C5650", VA = "0x1808C7050", Slot = "5")]
				get
				{
					return "强化：冰刺";
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x060045CE RID: 17870 RVA: 0x00165430 File Offset: 0x00163630
			[Token(Token = "0x17000731")]
			public override string Description
			{
				[Token(Token = "0x60045CE")]
				[Address(RVA = "0x8C6860", Offset = "0x8C4E60", VA = "0x1808C6860", Slot = "6")]
				get
				{
					return base.PlantName + "每次攻击额外发射一枚黑冰刺";
				}
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x060045CF RID: 17871 RVA: 0x00165450 File Offset: 0x00163650
			[Token(Token = "0x17000732")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60045CF")]
				[Address(RVA = "0x8A8CC0", Offset = "0x8A72C0", VA = "0x1808A8CC0", Slot = "4")]
				get
				{
					return PlantType.UltimateFume;
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x060045D0 RID: 17872 RVA: 0x00165464 File Offset: 0x00163664
			[Token(Token = "0x17000733")]
			public override float AppearWeight
			{
				[Token(Token = "0x60045D0")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x060045D1 RID: 17873 RVA: 0x00165478 File Offset: 0x00163678
			[Token(Token = "0x17000734")]
			public override int MaxCount
			{
				[Token(Token = "0x60045D1")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x060045D2 RID: 17874 RVA: 0x00165488 File Offset: 0x00163688
			[Token(Token = "0x60045D2")]
			[Address(RVA = "0x8C5580", Offset = "0x8C3B80", VA = "0x1808C5580", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = UltimateFume.UniqueUpgrade.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					UltimateFume.UniqueUpgrade.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x060045D3 RID: 17875 RVA: 0x001654B4 File Offset: 0x001636B4
			[Token(Token = "0x17000735")]
			public override Quality Rarity
			{
				[Token(Token = "0x60045D3")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060045D4 RID: 17876 RVA: 0x001654C4 File Offset: 0x001636C4
			[Token(Token = "0x60045D4")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D22 RID: 3362
		[Token(Token = "0x2000D22")]
		private class BuffUpgrade : BaseBuff
		{
			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x060045D8 RID: 17880 RVA: 0x001654D8 File Offset: 0x001636D8
			[Token(Token = "0x17000736")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60045D8")]
				[Address(RVA = "0x8A8CC0", Offset = "0x8A72C0", VA = "0x1808A8CC0", Slot = "4")]
				get
				{
					return PlantType.UltimateFume;
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x060045D9 RID: 17881 RVA: 0x001654EC File Offset: 0x001636EC
			[Token(Token = "0x17000737")]
			public override string Title
			{
				[Token(Token = "0x60045D9")]
				[Address(RVA = "0x8A8CD0", Offset = "0x8A72D0", VA = "0x1808A8CD0", Slot = "5")]
				get
				{
					return "质变：凛风刺骨";
				}
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x060045DA RID: 17882 RVA: 0x00165500 File Offset: 0x00163700
			[Token(Token = "0x17000738")]
			public override string Description
			{
				[Token(Token = "0x60045DA")]
				[Address(RVA = "0x8A8C90", Offset = "0x8A7290", VA = "0x1808A8C90", Slot = "6")]
				get
				{
					return "获得旅行词条：凛风刺骨";
				}
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x060045DB RID: 17883 RVA: 0x00165514 File Offset: 0x00163714
			[Token(Token = "0x17000739")]
			public override Quality Rarity
			{
				[Token(Token = "0x60045DB")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x060045DC RID: 17884 RVA: 0x00165524 File Offset: 0x00163724
			[Token(Token = "0x1700073A")]
			public override int MaxCount
			{
				[Token(Token = "0x60045DC")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x060045DD RID: 17885 RVA: 0x00165534 File Offset: 0x00163734
			[Token(Token = "0x1700073B")]
			public override float AppearWeight
			{
				[Token(Token = "0x60045DD")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060045DE RID: 17886 RVA: 0x00165548 File Offset: 0x00163748
			[Token(Token = "0x60045DE")]
			[Address(RVA = "0x8A8C30", Offset = "0x8A7230", VA = "0x1808A8C30", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				int num = 0;
				instance.GetUltiBuff((UltiBuff)((uint)4), num != 0);
			}

			// Token: 0x060045DF RID: 17887 RVA: 0x00165570 File Offset: 0x00163770
			[Token(Token = "0x60045DF")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public BuffUpgrade()
			{
			}
		}
	}
}
