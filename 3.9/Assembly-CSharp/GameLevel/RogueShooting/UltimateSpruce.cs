using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DA2 RID: 3490
	[Token(Token = "0x2000DA2")]
	public class UltimateSpruce : BaseConfig
	{
		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x0016A62C File Offset: 0x0016882C
		[Token(Token = "0x170008F3")]
		public override string Role
		{
			[Token(Token = "0x60048AC")]
			[Address(RVA = "0x8C4080", Offset = "0x8C2680", VA = "0x1808C4080", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060048AD RID: 18605 RVA: 0x0016A640 File Offset: 0x00168840
		[Token(Token = "0x170008F4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60048AD")]
			[Address(RVA = "0x7E8CC0", Offset = "0x7E72C0", VA = "0x1807E8CC0", Slot = "4")]
			get
			{
				return PlantType.UltimateSpruce;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x0016A654 File Offset: 0x00168854
		[Token(Token = "0x170008F5")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60048AE")]
			[Address(RVA = "0x8C3DD0", Offset = "0x8C23D0", VA = "0x1808C3DD0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateSpruce.UniqueBuff uniqueBuff = new UltimateSpruce.UniqueBuff();
				int size3 = list._size;
				UltimateSpruce.SuperBuff superBuff = new UltimateSpruce.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x0016A6AC File Offset: 0x001688AC
		[Token(Token = "0x60048AF")]
		[Address(RVA = "0x8A98D0", Offset = "0x8A7ED0", VA = "0x1808A98D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x0016A6D4 File Offset: 0x001688D4
		[Token(Token = "0x60048B0")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateSpruce()
		{
		}

		// Token: 0x02000DA3 RID: 3491
		[Token(Token = "0x2000DA3")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x060048B1 RID: 18609 RVA: 0x0016A6E8 File Offset: 0x001688E8
			[Token(Token = "0x170008F6")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60048B1")]
				[Address(RVA = "0x7E8CC0", Offset = "0x7E72C0", VA = "0x1807E8CC0", Slot = "4")]
				get
				{
					return PlantType.UltimateSpruce;
				}
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x060048B2 RID: 18610 RVA: 0x0016A6FC File Offset: 0x001688FC
			[Token(Token = "0x170008F7")]
			public override string Title
			{
				[Token(Token = "0x60048B2")]
				[Address(RVA = "0x8C5550", Offset = "0x8C3B50", VA = "0x1808C5550", Slot = "5")]
				get
				{
					return "强化：延时";
				}
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x060048B3 RID: 18611 RVA: 0x0016A710 File Offset: 0x00168910
			[Token(Token = "0x170008F8")]
			public override string Description
			{
				[Token(Token = "0x60048B3")]
				[Address(RVA = "0x8C5340", Offset = "0x8C3940", VA = "0x1808C5340", Slot = "6")]
				get
				{
					return "子弹飞行时间+1秒，每飞行1秒，造成的伤害增加10%";
				}
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x060048B4 RID: 18612 RVA: 0x0016A724 File Offset: 0x00168924
			[Token(Token = "0x170008F9")]
			public override Quality Rarity
			{
				[Token(Token = "0x60048B4")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x060048B5 RID: 18613 RVA: 0x0016A734 File Offset: 0x00168934
			[Token(Token = "0x170008FA")]
			public override float AppearWeight
			{
				[Token(Token = "0x60048B5")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060048B6 RID: 18614 RVA: 0x0016A748 File Offset: 0x00168948
			[Token(Token = "0x60048B6")]
			[Address(RVA = "0x8C4CC0", Offset = "0x8C32C0", VA = "0x1808C4CC0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = UltimateSpruce.UniqueBuff.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					UltimateSpruce.UniqueBuff.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x060048B7 RID: 18615 RVA: 0x0016A774 File Offset: 0x00168974
			[Token(Token = "0x60048B7")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueBuff()
			{
			}
		}

		// Token: 0x02000DA5 RID: 3493
		[Token(Token = "0x2000DA5")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x060048BB RID: 18619 RVA: 0x0016A788 File Offset: 0x00168988
			[Token(Token = "0x170008FB")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60048BB")]
				[Address(RVA = "0x7E8CC0", Offset = "0x7E72C0", VA = "0x1807E8CC0", Slot = "4")]
				get
				{
					return PlantType.UltimateSpruce;
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x060048BC RID: 18620 RVA: 0x0016A79C File Offset: 0x0016899C
			[Token(Token = "0x170008FC")]
			public override string Title
			{
				[Token(Token = "0x60048BC")]
				[Address(RVA = "0x8B7180", Offset = "0x8B5780", VA = "0x1808B7180", Slot = "5")]
				get
				{
					return "质变：固甲摧锋";
				}
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x060048BD RID: 18621 RVA: 0x0016A7B0 File Offset: 0x001689B0
			[Token(Token = "0x170008FD")]
			public override string Description
			{
				[Token(Token = "0x60048BD")]
				[Address(RVA = "0x8B6A80", Offset = "0x8B5080", VA = "0x1808B6A80", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12019];
				}
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x060048BE RID: 18622 RVA: 0x0016A7D4 File Offset: 0x001689D4
			[Token(Token = "0x170008FE")]
			public override Quality Rarity
			{
				[Token(Token = "0x60048BE")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x060048BF RID: 18623 RVA: 0x0016A7E4 File Offset: 0x001689E4
			[Token(Token = "0x170008FF")]
			public override int MaxCount
			{
				[Token(Token = "0x60048BF")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x060048C0 RID: 18624 RVA: 0x0016A7F4 File Offset: 0x001689F4
			[Token(Token = "0x17000900")]
			public override float AppearWeight
			{
				[Token(Token = "0x60048C0")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060048C1 RID: 18625 RVA: 0x0016A808 File Offset: 0x00168A08
			[Token(Token = "0x60048C1")]
			[Address(RVA = "0x8B63E0", Offset = "0x8B49E0", VA = "0x1808B63E0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12019));
			}

			// Token: 0x060048C2 RID: 18626 RVA: 0x0016A830 File Offset: 0x00168A30
			[Token(Token = "0x60048C2")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
