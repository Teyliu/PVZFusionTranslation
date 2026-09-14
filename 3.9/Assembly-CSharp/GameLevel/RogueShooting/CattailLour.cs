using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D40 RID: 3392
	[Token(Token = "0x2000D40")]
	public class CattailLour : BaseConfig
	{
		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x001666E0 File Offset: 0x001648E0
		[Token(Token = "0x170007A3")]
		public override string Role
		{
			[Token(Token = "0x6004684")]
			[Address(RVA = "0x8A9BC0", Offset = "0x8A81C0", VA = "0x1808A9BC0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06004685 RID: 18053 RVA: 0x001666F4 File Offset: 0x001648F4
		[Token(Token = "0x170007A4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004685")]
			[Address(RVA = "0x7CE7D0", Offset = "0x7CCDD0", VA = "0x1807CE7D0", Slot = "4")]
			get
			{
				return PlantType.CattailLour;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x00166708 File Offset: 0x00164908
		[Token(Token = "0x170007A5")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004686")]
			[Address(RVA = "0x8A9910", Offset = "0x8A7F10", VA = "0x1808A9910", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				CattailLour.FlySupply flySupply = new CattailLour.FlySupply();
				int size3 = list._size;
				CattailLour.SuperBuff superBuff = new CattailLour.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x00166760 File Offset: 0x00164960
		[Token(Token = "0x6004687")]
		[Address(RVA = "0x8A98D0", Offset = "0x8A7ED0", VA = "0x1808A98D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x00166788 File Offset: 0x00164988
		[Token(Token = "0x6004688")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public CattailLour()
		{
		}

		// Token: 0x02000D41 RID: 3393
		[Token(Token = "0x2000D41")]
		private class FlySupply : BaseBuff
		{
			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06004689 RID: 18057 RVA: 0x0016679C File Offset: 0x0016499C
			[Token(Token = "0x170007A6")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004689")]
				[Address(RVA = "0x7CE7D0", Offset = "0x7CCDD0", VA = "0x1807CE7D0", Slot = "4")]
				get
				{
					return PlantType.CattailLour;
				}
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x0600468A RID: 18058 RVA: 0x001667B0 File Offset: 0x001649B0
			[Token(Token = "0x170007A7")]
			public override string Title
			{
				[Token(Token = "0x600468A")]
				[Address(RVA = "0x8AC250", Offset = "0x8AA850", VA = "0x1808AC250", Slot = "5")]
				get
				{
					return "强化：小队";
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x0600468B RID: 18059 RVA: 0x001667C4 File Offset: 0x001649C4
			[Token(Token = "0x170007A8")]
			public override string Description
			{
				[Token(Token = "0x600468B")]
				[Address(RVA = "0x8AC220", Offset = "0x8AA820", VA = "0x1808AC220", Slot = "6")]
				get
				{
					return "每3秒自动生成一个僚机，攻速加成可缩短这个间隔";
				}
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x0600468C RID: 18060 RVA: 0x001667D8 File Offset: 0x001649D8
			[Token(Token = "0x170007A9")]
			public override Quality Rarity
			{
				[Token(Token = "0x600468C")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600468D RID: 18061 RVA: 0x001667E8 File Offset: 0x001649E8
			[Token(Token = "0x600468D")]
			[Address(RVA = "0x8AC180", Offset = "0x8AA780", VA = "0x1808AC180", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
					base.Plant.attributeCountdown = 0.5f;
				}
			}

			// Token: 0x0600468E RID: 18062 RVA: 0x00166828 File Offset: 0x00164A28
			[Token(Token = "0x600468E")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public FlySupply()
			{
			}
		}

		// Token: 0x02000D42 RID: 3394
		[Token(Token = "0x2000D42")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x0600468F RID: 18063 RVA: 0x0016683C File Offset: 0x00164A3C
			[Token(Token = "0x170007AA")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600468F")]
				[Address(RVA = "0x7CE7D0", Offset = "0x7CCDD0", VA = "0x1807CE7D0", Slot = "4")]
				get
				{
					return PlantType.CattailLour;
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06004690 RID: 18064 RVA: 0x00166850 File Offset: 0x00164A50
			[Token(Token = "0x170007AB")]
			public override string Title
			{
				[Token(Token = "0x6004690")]
				[Address(RVA = "0x8B7360", Offset = "0x8B5960", VA = "0x1808B7360", Slot = "5")]
				get
				{
					return "质变：弹药";
				}
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x06004691 RID: 18065 RVA: 0x00166864 File Offset: 0x00164A64
			[Token(Token = "0x170007AC")]
			public override string Description
			{
				[Token(Token = "0x6004691")]
				[Address(RVA = "0x8B6B00", Offset = "0x8B5100", VA = "0x1808B6B00", Slot = "6")]
				get
				{
					return "获得词条：特制弹药、一针见血";
				}
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x06004692 RID: 18066 RVA: 0x00166878 File Offset: 0x00164A78
			[Token(Token = "0x170007AD")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004692")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x06004693 RID: 18067 RVA: 0x00166888 File Offset: 0x00164A88
			[Token(Token = "0x170007AE")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004693")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x06004694 RID: 18068 RVA: 0x0016689C File Offset: 0x00164A9C
			[Token(Token = "0x170007AF")]
			public override int MaxCount
			{
				[Token(Token = "0x6004694")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x06004695 RID: 18069 RVA: 0x001668AC File Offset: 0x00164AAC
			[Token(Token = "0x6004695")]
			[Address(RVA = "0x8B6860", Offset = "0x8B4E60", VA = "0x1808B6860", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)16));
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)17));
			}

			// Token: 0x06004696 RID: 18070 RVA: 0x001668E0 File Offset: 0x00164AE0
			[Token(Token = "0x6004696")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
