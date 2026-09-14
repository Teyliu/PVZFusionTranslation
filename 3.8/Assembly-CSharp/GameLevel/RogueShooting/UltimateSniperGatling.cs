using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CC1 RID: 3265
	[Token(Token = "0x2000CC1")]
	public class UltimateSniperGatling : BaseConfig
	{
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x0015CCA4 File Offset: 0x0015AEA4
		[Token(Token = "0x17000761")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004476")]
			[Address(RVA = "0x843BA0", Offset = "0x8421A0", VA = "0x180843BA0", Slot = "4")]
			get
			{
				return PlantType.UltimateSniperGatling;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x0015CCB8 File Offset: 0x0015AEB8
		[Token(Token = "0x17000762")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004477")]
			[Address(RVA = "0x843980", Offset = "0x841F80", VA = "0x180843980", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateSniperGatling.UniqueBuff uniqueBuff = new UltimateSniperGatling.UniqueBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x0015CD00 File Offset: 0x0015AF00
		[Token(Token = "0x17000763")]
		public override string Role
		{
			[Token(Token = "0x6004478")]
			[Address(RVA = "0x843BB0", Offset = "0x8421B0", VA = "0x180843BB0", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x0015CD14 File Offset: 0x0015AF14
		[Token(Token = "0x6004479")]
		[Address(RVA = "0x843660", Offset = "0x841C60", VA = "0x180843660", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), -0.75f, num2 != 0, num);
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x0015CD3C File Offset: 0x0015AF3C
		[Token(Token = "0x600447A")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateSniperGatling()
		{
		}

		// Token: 0x02000CC2 RID: 3266
		[Token(Token = "0x2000CC2")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x0600447B RID: 17531 RVA: 0x0015CD50 File Offset: 0x0015AF50
			[Token(Token = "0x17000764")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600447B")]
				[Address(RVA = "0x843BA0", Offset = "0x8421A0", VA = "0x180843BA0", Slot = "4")]
				get
				{
					return PlantType.UltimateSniperGatling;
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x0600447C RID: 17532 RVA: 0x0015CD64 File Offset: 0x0015AF64
			[Token(Token = "0x17000765")]
			public override string Title
			{
				[Token(Token = "0x600447C")]
				[Address(RVA = "0x845210", Offset = "0x843810", VA = "0x180845210", Slot = "5")]
				get
				{
					return "强化：爆头";
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x0600447D RID: 17533 RVA: 0x0015CD78 File Offset: 0x0015AF78
			[Token(Token = "0x17000766")]
			public override string Description
			{
				[Token(Token = "0x600447D")]
				[Address(RVA = "0x8450D0", Offset = "0x8436D0", VA = "0x1808450D0", Slot = "6")]
				get
				{
					return base.PlantName + "爆头所需次数-1";
				}
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x0600447E RID: 17534 RVA: 0x0015CD98 File Offset: 0x0015AF98
			[Token(Token = "0x17000767")]
			public override Quality Rarity
			{
				[Token(Token = "0x600447E")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x0600447F RID: 17535 RVA: 0x0015CDA8 File Offset: 0x0015AFA8
			[Token(Token = "0x17000768")]
			public override float AppearWeight
			{
				[Token(Token = "0x600447F")]
				[Address(RVA = "0x845080", Offset = "0x843680", VA = "0x180845080", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06004480 RID: 17536 RVA: 0x0015CDBC File Offset: 0x0015AFBC
			[Token(Token = "0x17000769")]
			public override int MaxCount
			{
				[Token(Token = "0x6004480")]
				[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
				get
				{
					return 5;
				}
			}

			// Token: 0x06004481 RID: 17537 RVA: 0x0015CDCC File Offset: 0x0015AFCC
			[Token(Token = "0x6004481")]
			[Address(RVA = "0x844EE0", Offset = "0x8434E0", VA = "0x180844EE0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__12_ = UltimateSniperGatling.UniqueBuff.<>c.<>9__12_0;
				if (<>9__12_ == 0)
				{
					Action<Plant> action;
					UltimateSniperGatling.UniqueBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(<>9__12_);
			}

			// Token: 0x06004482 RID: 17538 RVA: 0x0015CDF8 File Offset: 0x0015AFF8
			[Token(Token = "0x6004482")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueBuff()
			{
			}
		}
	}
}
