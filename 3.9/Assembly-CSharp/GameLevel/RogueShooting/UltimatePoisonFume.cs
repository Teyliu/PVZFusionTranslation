using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D24 RID: 3364
	[Token(Token = "0x2000D24")]
	public class UltimatePoisonFume : BaseConfig
	{
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x00165620 File Offset: 0x00163820
		[Token(Token = "0x1700073F")]
		public override string Role
		{
			[Token(Token = "0x60045E5")]
			[Address(RVA = "0x8C36F0", Offset = "0x8C1CF0", VA = "0x1808C36F0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x00165634 File Offset: 0x00163834
		[Token(Token = "0x17000740")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60045E6")]
			[Address(RVA = "0x8B7150", Offset = "0x8B5750", VA = "0x1808B7150", Slot = "4")]
			get
			{
				return PlantType.UltimatePoisonFume;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x00165648 File Offset: 0x00163848
		[Token(Token = "0x17000741")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60045E7")]
			[Address(RVA = "0x8C3440", Offset = "0x8C1A40", VA = "0x1808C3440", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimatePoisonFume.UniqueBuff uniqueBuff = new UltimatePoisonFume.UniqueBuff();
				int size3 = list._size;
				UltimatePoisonFume.SuperBuff superBuff = new UltimatePoisonFume.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x001656A0 File Offset: 0x001638A0
		[Token(Token = "0x60045E8")]
		[Address(RVA = "0x8C3400", Offset = "0x8C1A00", VA = "0x1808C3400", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), -0.75f, num2 != 0, num);
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x001656C8 File Offset: 0x001638C8
		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimatePoisonFume()
		{
		}

		// Token: 0x02000D25 RID: 3365
		[Token(Token = "0x2000D25")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x060045EA RID: 17898 RVA: 0x001656DC File Offset: 0x001638DC
			[Token(Token = "0x17000742")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60045EA")]
				[Address(RVA = "0x8B7150", Offset = "0x8B5750", VA = "0x1808B7150", Slot = "4")]
				get
				{
					return PlantType.UltimatePoisonFume;
				}
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x060045EB RID: 17899 RVA: 0x001656F0 File Offset: 0x001638F0
			[Token(Token = "0x17000743")]
			public override string Title
			{
				[Token(Token = "0x60045EB")]
				[Address(RVA = "0x8C54F0", Offset = "0x8C3AF0", VA = "0x1808C54F0", Slot = "5")]
				get
				{
					return "强化：剧毒";
				}
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x060045EC RID: 17900 RVA: 0x00165704 File Offset: 0x00163904
			[Token(Token = "0x17000744")]
			public override string Description
			{
				[Token(Token = "0x60045EC")]
				[Address(RVA = "0x8C5400", Offset = "0x8C3A00", VA = "0x1808C5400", Slot = "6")]
				get
				{
					return "子弹发射数+1";
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x060045ED RID: 17901 RVA: 0x00165718 File Offset: 0x00163918
			[Token(Token = "0x17000745")]
			public override Quality Rarity
			{
				[Token(Token = "0x60045ED")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x060045EE RID: 17902 RVA: 0x00165728 File Offset: 0x00163928
			[Token(Token = "0x17000746")]
			public override float AppearWeight
			{
				[Token(Token = "0x60045EE")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060045EF RID: 17903 RVA: 0x0016573C File Offset: 0x0016393C
			[Token(Token = "0x60045EF")]
			[Address(RVA = "0x8C5210", Offset = "0x8C3810", VA = "0x1808C5210", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x060045F0 RID: 17904 RVA: 0x0016576C File Offset: 0x0016396C
			[Token(Token = "0x60045F0")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueBuff()
			{
			}
		}

		// Token: 0x02000D26 RID: 3366
		[Token(Token = "0x2000D26")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x060045F1 RID: 17905 RVA: 0x00165780 File Offset: 0x00163980
			[Token(Token = "0x17000747")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60045F1")]
				[Address(RVA = "0x8B7150", Offset = "0x8B5750", VA = "0x1808B7150", Slot = "4")]
				get
				{
					return PlantType.UltimatePoisonFume;
				}
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x060045F2 RID: 17906 RVA: 0x00165794 File Offset: 0x00163994
			[Token(Token = "0x17000748")]
			public override string Title
			{
				[Token(Token = "0x60045F2")]
				[Address(RVA = "0x8B72A0", Offset = "0x8B58A0", VA = "0x1808B72A0", Slot = "5")]
				get
				{
					return "质变：蒜毒骤发";
				}
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x060045F3 RID: 17907 RVA: 0x001657A8 File Offset: 0x001639A8
			[Token(Token = "0x17000749")]
			public override string Description
			{
				[Token(Token = "0x60045F3")]
				[Address(RVA = "0x8B6D30", Offset = "0x8B5330", VA = "0x1808B6D30", Slot = "6")]
				get
				{
					return "获得2级词条：蒜毒骤发";
				}
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x060045F4 RID: 17908 RVA: 0x001657BC File Offset: 0x001639BC
			[Token(Token = "0x1700074A")]
			public override Quality Rarity
			{
				[Token(Token = "0x60045F4")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x060045F5 RID: 17909 RVA: 0x001657CC File Offset: 0x001639CC
			[Token(Token = "0x1700074B")]
			public override int MaxCount
			{
				[Token(Token = "0x60045F5")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x060045F6 RID: 17910 RVA: 0x001657DC File Offset: 0x001639DC
			[Token(Token = "0x1700074C")]
			public override float AppearWeight
			{
				[Token(Token = "0x60045F6")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x060045F7 RID: 17911 RVA: 0x001657F0 File Offset: 0x001639F0
			[Token(Token = "0x1700074D")]
			public override bool CanAppear
			{
				[Token(Token = "0x60045F7")]
				[Address(RVA = "0x8B68E0", Offset = "0x8B4EE0", VA = "0x1808B68E0", Slot = "9")]
				get
				{
					return Lawnf.TravelUltimate((UltiBuff)((uint)13));
				}
			}

			// Token: 0x060045F8 RID: 17912 RVA: 0x00165808 File Offset: 0x00163A08
			[Token(Token = "0x60045F8")]
			[Address(RVA = "0x8B6680", Offset = "0x8B4C80", VA = "0x1808B6680", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetUltiBuff((UltiBuff)((uint)13), true);
			}

			// Token: 0x060045F9 RID: 17913 RVA: 0x0016582C File Offset: 0x00163A2C
			[Token(Token = "0x60045F9")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
