using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D19 RID: 3353
	[Token(Token = "0x2000D19")]
	public class IFVIronPuff : BaseConfig
	{
		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x00165020 File Offset: 0x00163220
		[Token(Token = "0x17000719")]
		public override string Role
		{
			[Token(Token = "0x60045A7")]
			[Address(RVA = "0x8AE340", Offset = "0x8AC940", VA = "0x1808AE340", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x00165034 File Offset: 0x00163234
		[Token(Token = "0x1700071A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60045A8")]
			[Address(RVA = "0x8ACF60", Offset = "0x8AB560", VA = "0x1808ACF60", Slot = "4")]
			get
			{
				return PlantType.IFVIronPuff;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x00165048 File Offset: 0x00163248
		[Token(Token = "0x1700071B")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60045A9")]
			[Address(RVA = "0x8AE090", Offset = "0x8AC690", VA = "0x1808AE090", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				IFVIronPuff.PierceBuff pierceBuff = new IFVIronPuff.PierceBuff();
				int size3 = list._size;
				IFVIronPuff.HeadShotBuff headShotBuff = new IFVIronPuff.HeadShotBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x001650A0 File Offset: 0x001632A0
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x8AE040", Offset = "0x8AC640", VA = "0x1808AE040", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x001650B8 File Offset: 0x001632B8
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public IFVIronPuff()
		{
		}

		// Token: 0x02000D1A RID: 3354
		[Token(Token = "0x2000D1A")]
		private class PierceBuff : BaseBuff
		{
			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x060045AC RID: 17836 RVA: 0x001650CC File Offset: 0x001632CC
			[Token(Token = "0x1700071C")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60045AC")]
				[Address(RVA = "0x8ACF60", Offset = "0x8AB560", VA = "0x1808ACF60", Slot = "4")]
				get
				{
					return PlantType.IFVIronPuff;
				}
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x060045AD RID: 17837 RVA: 0x001650E0 File Offset: 0x001632E0
			[Token(Token = "0x1700071D")]
			public override string Title
			{
				[Token(Token = "0x60045AD")]
				[Address(RVA = "0x8B11F0", Offset = "0x8AF7F0", VA = "0x1808B11F0", Slot = "5")]
				get
				{
					return "强化：贯穿";
				}
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x060045AE RID: 17838 RVA: 0x001650F4 File Offset: 0x001632F4
			[Token(Token = "0x1700071E")]
			public override string Description
			{
				[Token(Token = "0x60045AE")]
				[Address(RVA = "0x8B1190", Offset = "0x8AF790", VA = "0x1808B1190", Slot = "6")]
				get
				{
					return "狙击穿透+2";
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x060045AF RID: 17839 RVA: 0x00165108 File Offset: 0x00163308
			[Token(Token = "0x1700071F")]
			public override float AppearWeight
			{
				[Token(Token = "0x60045AF")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060045B0 RID: 17840 RVA: 0x0016511C File Offset: 0x0016331C
			[Token(Token = "0x60045B0")]
			[Address(RVA = "0x8B1020", Offset = "0x8AF620", VA = "0x1808B1020", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = IFVIronPuff.PierceBuff.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					IFVIronPuff.PierceBuff.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x060045B1 RID: 17841 RVA: 0x00165148 File Offset: 0x00163348
			[Token(Token = "0x17000720")]
			public override Quality Rarity
			{
				[Token(Token = "0x60045B1")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060045B2 RID: 17842 RVA: 0x00165158 File Offset: 0x00163358
			[Token(Token = "0x60045B2")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public PierceBuff()
			{
			}
		}

		// Token: 0x02000D1C RID: 3356
		[Token(Token = "0x2000D1C")]
		private class HeadShotBuff : BaseBuff
		{
			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x060045B6 RID: 17846 RVA: 0x0016516C File Offset: 0x0016336C
			[Token(Token = "0x17000721")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60045B6")]
				[Address(RVA = "0x8ACF60", Offset = "0x8AB560", VA = "0x1808ACF60", Slot = "4")]
				get
				{
					return PlantType.IFVIronPuff;
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x060045B7 RID: 17847 RVA: 0x00165180 File Offset: 0x00163380
			[Token(Token = "0x17000722")]
			public override string Title
			{
				[Token(Token = "0x60045B7")]
				[Address(RVA = "0x8ACF70", Offset = "0x8AB570", VA = "0x1808ACF70", Slot = "5")]
				get
				{
					return "质变：反弹";
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x060045B8 RID: 17848 RVA: 0x00165194 File Offset: 0x00163394
			[Token(Token = "0x17000723")]
			public override string Description
			{
				[Token(Token = "0x60045B8")]
				[Address(RVA = "0x8ACEE0", Offset = "0x8AB4E0", VA = "0x1808ACEE0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12011];
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x060045B9 RID: 17849 RVA: 0x001651B8 File Offset: 0x001633B8
			[Token(Token = "0x17000724")]
			public override Quality Rarity
			{
				[Token(Token = "0x60045B9")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x060045BA RID: 17850 RVA: 0x001651C8 File Offset: 0x001633C8
			[Token(Token = "0x17000725")]
			public override int MaxCount
			{
				[Token(Token = "0x60045BA")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x060045BB RID: 17851 RVA: 0x001651D8 File Offset: 0x001633D8
			[Token(Token = "0x17000726")]
			public override float AppearWeight
			{
				[Token(Token = "0x60045BB")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060045BC RID: 17852 RVA: 0x001651EC File Offset: 0x001633EC
			[Token(Token = "0x60045BC")]
			[Address(RVA = "0x8ACE80", Offset = "0x8AB480", VA = "0x1808ACE80", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12011));
			}

			// Token: 0x060045BD RID: 17853 RVA: 0x00165214 File Offset: 0x00163414
			[Token(Token = "0x60045BD")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public HeadShotBuff()
			{
			}
		}
	}
}
