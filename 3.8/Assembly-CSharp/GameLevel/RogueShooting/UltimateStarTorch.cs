using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CCB RID: 3275
	[Token(Token = "0x2000CCB")]
	public class UltimateStarTorch : BaseConfig
	{
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x0015D0DC File Offset: 0x0015B2DC
		[Token(Token = "0x1700077C")]
		public override string Role
		{
			[Token(Token = "0x60044A8")]
			[Address(RVA = "0x8441A0", Offset = "0x8427A0", VA = "0x1808441A0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x0015D0F0 File Offset: 0x0015B2F0
		[Token(Token = "0x1700077D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044A9")]
			[Address(RVA = "0x844190", Offset = "0x842790", VA = "0x180844190", Slot = "4")]
			get
			{
				return PlantType.UltimateStarTorch;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x0015D104 File Offset: 0x0015B304
		[Token(Token = "0x1700077E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044AA")]
			[Address(RVA = "0x844080", Offset = "0x842680", VA = "0x180844080", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UltimateStarTorch.UniqueBuff uniqueBuff = new UltimateStarTorch.UniqueBuff();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x0015D138 File Offset: 0x0015B338
		[Token(Token = "0x60044AB")]
		[Address(RVA = "0x844020", Offset = "0x842620", VA = "0x180844020", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			TravelMgr instance = TravelMgr.Instance;
			int num = 0;
			instance.GetUltiBuff((UltiBuff)((uint)7), num != 0);
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x0015D160 File Offset: 0x0015B360
		[Token(Token = "0x60044AC")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateStarTorch()
		{
		}

		// Token: 0x02000CCC RID: 3276
		[Token(Token = "0x2000CCC")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x060044AD RID: 17581 RVA: 0x0015D174 File Offset: 0x0015B374
			[Token(Token = "0x1700077F")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60044AD")]
				[Address(RVA = "0x844190", Offset = "0x842790", VA = "0x180844190", Slot = "4")]
				get
				{
					return PlantType.UltimateStarTorch;
				}
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x060044AE RID: 17582 RVA: 0x0015D188 File Offset: 0x0015B388
			[Token(Token = "0x17000780")]
			public override string Title
			{
				[Token(Token = "0x60044AE")]
				[Address(RVA = "0x845270", Offset = "0x843870", VA = "0x180845270", Slot = "5")]
				get
				{
					return "强化：数量";
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x060044AF RID: 17583 RVA: 0x0015D19C File Offset: 0x0015B39C
			[Token(Token = "0x17000781")]
			public override string Description
			{
				[Token(Token = "0x60044AF")]
				[Address(RVA = "0x845120", Offset = "0x843720", VA = "0x180845120", Slot = "6")]
				get
				{
					return "生成杨桃所需子弹数-10";
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x060044B0 RID: 17584 RVA: 0x0015D1B0 File Offset: 0x0015B3B0
			[Token(Token = "0x17000782")]
			public override Quality Rarity
			{
				[Token(Token = "0x60044B0")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060044B1 RID: 17585 RVA: 0x0015D1C0 File Offset: 0x0015B3C0
			[Token(Token = "0x60044B1")]
			[Address(RVA = "0x844DD0", Offset = "0x8433D0", VA = "0x180844DD0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = UltimateStarTorch.UniqueBuff.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					UltimateStarTorch.UniqueBuff.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x060044B2 RID: 17586 RVA: 0x0015D1EC File Offset: 0x0015B3EC
			[Token(Token = "0x60044B2")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueBuff()
			{
			}
		}
	}
}
