using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D89 RID: 3465
	[Token(Token = "0x2000D89")]
	public class UltimateWinterMelon : BaseConfig
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x00169908 File Offset: 0x00167B08
		[Token(Token = "0x170008A0")]
		public override string Role
		{
			[Token(Token = "0x6004823")]
			[Address(RVA = "0x8C4A40", Offset = "0x8C3040", VA = "0x1808C4A40", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x0016991C File Offset: 0x00167B1C
		[Token(Token = "0x170008A1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004824")]
			[Address(RVA = "0x8C4A30", Offset = "0x8C3030", VA = "0x1808C4A30", Slot = "4")]
			get
			{
				return PlantType.UltimateWinterMelon;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x00169930 File Offset: 0x00167B30
		[Token(Token = "0x170008A2")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004825")]
			[Address(RVA = "0x8C4810", Offset = "0x8C2E10", VA = "0x1808C4810", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateWinterMelon.UniqueUpgrade uniqueUpgrade = new UltimateWinterMelon.UniqueUpgrade();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x00169978 File Offset: 0x00167B78
		[Token(Token = "0x6004826")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x00169988 File Offset: 0x00167B88
		[Token(Token = "0x6004827")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateWinterMelon()
		{
		}

		// Token: 0x02000D8A RID: 3466
		[Token(Token = "0x2000D8A")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06004828 RID: 18472 RVA: 0x0016999C File Offset: 0x00167B9C
			[Token(Token = "0x170008A3")]
			public override string Title
			{
				[Token(Token = "0x6004828")]
				[Address(RVA = "0x8C6E10", Offset = "0x8C5410", VA = "0x1808C6E10", Slot = "5")]
				get
				{
					return "强化：散射";
				}
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06004829 RID: 18473 RVA: 0x001699B0 File Offset: 0x00167BB0
			[Token(Token = "0x170008A4")]
			public override string Description
			{
				[Token(Token = "0x6004829")]
				[Address(RVA = "0x8C66D0", Offset = "0x8C4CD0", VA = "0x1808C66D0", Slot = "6")]
				get
				{
					return base.PlantName + "的发射数量+1";
				}
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x0600482A RID: 18474 RVA: 0x001699D0 File Offset: 0x00167BD0
			[Token(Token = "0x170008A5")]
			public override float AppearWeight
			{
				[Token(Token = "0x600482A")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x0600482B RID: 18475 RVA: 0x001699E4 File Offset: 0x00167BE4
			[Token(Token = "0x170008A6")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600482B")]
				[Address(RVA = "0x8C4A30", Offset = "0x8C3030", VA = "0x1808C4A30", Slot = "4")]
				get
				{
					return PlantType.UltimateWinterMelon;
				}
			}

			// Token: 0x0600482C RID: 18476 RVA: 0x001699F8 File Offset: 0x00167BF8
			[Token(Token = "0x600482C")]
			[Address(RVA = "0x8C5DC0", Offset = "0x8C43C0", VA = "0x1808C5DC0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x0600482D RID: 18477 RVA: 0x00169A18 File Offset: 0x00167C18
			[Token(Token = "0x170008A7")]
			public override Quality Rarity
			{
				[Token(Token = "0x600482D")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600482E RID: 18478 RVA: 0x00169A28 File Offset: 0x00167C28
			[Token(Token = "0x600482E")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
