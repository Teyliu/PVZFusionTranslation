using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D94 RID: 3476
	[Token(Token = "0x2000D94")]
	public class LaserUmbrella : BaseConfig
	{
		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x00169F40 File Offset: 0x00168140
		[Token(Token = "0x170008C3")]
		public override string Role
		{
			[Token(Token = "0x600485E")]
			[Address(RVA = "0x8AED90", Offset = "0x8AD390", VA = "0x1808AED90", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x00169F54 File Offset: 0x00168154
		[Token(Token = "0x170008C4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600485F")]
			[Address(RVA = "0x7D30C0", Offset = "0x7D16C0", VA = "0x1807D30C0", Slot = "4")]
			get
			{
				return PlantType.LaserUmbrella;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x00169F68 File Offset: 0x00168168
		[Token(Token = "0x170008C5")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004860")]
			[Address(RVA = "0x8AEAE0", Offset = "0x8AD0E0", VA = "0x1808AEAE0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				LaserUmbrella.ExplodeBuff explodeBuff = new LaserUmbrella.ExplodeBuff();
				int size3 = list._size;
				LaserUmbrella.SuperBuff superBuff = new LaserUmbrella.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x00169FC0 File Offset: 0x001681C0
		[Token(Token = "0x6004861")]
		[Address(RVA = "0x8AEA40", Offset = "0x8AD040", VA = "0x1808AEA40", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00169FE8 File Offset: 0x001681E8
		[Token(Token = "0x6004862")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public LaserUmbrella()
		{
		}

		// Token: 0x02000D95 RID: 3477
		[Token(Token = "0x2000D95")]
		private class ExplodeBuff : BaseBuff
		{
			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x06004863 RID: 18531 RVA: 0x00169FFC File Offset: 0x001681FC
			[Token(Token = "0x170008C6")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004863")]
				[Address(RVA = "0x7D30C0", Offset = "0x7D16C0", VA = "0x1807D30C0", Slot = "4")]
				get
				{
					return PlantType.LaserUmbrella;
				}
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06004864 RID: 18532 RVA: 0x0016A010 File Offset: 0x00168210
			[Token(Token = "0x170008C7")]
			public override string Title
			{
				[Token(Token = "0x6004864")]
				[Address(RVA = "0x8ABAD0", Offset = "0x8AA0D0", VA = "0x1808ABAD0", Slot = "5")]
				get
				{
					return "强化：能量";
				}
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06004865 RID: 18533 RVA: 0x0016A024 File Offset: 0x00168224
			[Token(Token = "0x170008C8")]
			public override string Description
			{
				[Token(Token = "0x6004865")]
				[Address(RVA = "0x8ABAA0", Offset = "0x8AA0A0", VA = "0x1808ABAA0", Slot = "6")]
				get
				{
					return "能量上限+5000，能量恢复效率+300%，每次攻击额外附带等同于当前能量25%的伤害";
				}
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x06004866 RID: 18534 RVA: 0x0016A038 File Offset: 0x00168238
			[Token(Token = "0x170008C9")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004866")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x06004867 RID: 18535 RVA: 0x0016A048 File Offset: 0x00168248
			[Token(Token = "0x170008CA")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004867")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x06004868 RID: 18536 RVA: 0x0016A05C File Offset: 0x0016825C
			[Token(Token = "0x170008CB")]
			public override int MaxCount
			{
				[Token(Token = "0x6004868")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x06004869 RID: 18537 RVA: 0x0016A06C File Offset: 0x0016826C
			[Token(Token = "0x6004869")]
			[Address(RVA = "0x8AB940", Offset = "0x8A9F40", VA = "0x1808AB940", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (!(plant != num) || base.Plant != 0)
				{
				}
			}

			// Token: 0x0600486A RID: 18538 RVA: 0x0016A098 File Offset: 0x00168298
			[Token(Token = "0x600486A")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public ExplodeBuff()
			{
			}
		}

		// Token: 0x02000D96 RID: 3478
		[Token(Token = "0x2000D96")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x0600486B RID: 18539 RVA: 0x0016A0AC File Offset: 0x001682AC
			[Token(Token = "0x170008CC")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600486B")]
				[Address(RVA = "0x7D30C0", Offset = "0x7D16C0", VA = "0x1807D30C0", Slot = "4")]
				get
				{
					return PlantType.LaserUmbrella;
				}
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x0600486C RID: 18540 RVA: 0x0016A0C0 File Offset: 0x001682C0
			[Token(Token = "0x170008CD")]
			public override string Title
			{
				[Token(Token = "0x600486C")]
				[Address(RVA = "0x8B7420", Offset = "0x8B5A20", VA = "0x1808B7420", Slot = "5")]
				get
				{
					return "质变：光能盾牌";
				}
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x0600486D RID: 18541 RVA: 0x0016A0D4 File Offset: 0x001682D4
			[Token(Token = "0x170008CE")]
			public override string Description
			{
				[Token(Token = "0x600486D")]
				[Address(RVA = "0x8B6A00", Offset = "0x8B5000", VA = "0x1808B6A00", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12006];
				}
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x0600486E RID: 18542 RVA: 0x0016A0F8 File Offset: 0x001682F8
			[Token(Token = "0x170008CF")]
			public override Quality Rarity
			{
				[Token(Token = "0x600486E")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x0600486F RID: 18543 RVA: 0x0016A108 File Offset: 0x00168308
			[Token(Token = "0x170008D0")]
			public override int MaxCount
			{
				[Token(Token = "0x600486F")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06004870 RID: 18544 RVA: 0x0016A118 File Offset: 0x00168318
			[Token(Token = "0x170008D1")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004870")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004871 RID: 18545 RVA: 0x0016A12C File Offset: 0x0016832C
			[Token(Token = "0x6004871")]
			[Address(RVA = "0x8B6320", Offset = "0x8B4920", VA = "0x1808B6320", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12006));
			}

			// Token: 0x06004872 RID: 18546 RVA: 0x0016A154 File Offset: 0x00168354
			[Token(Token = "0x6004872")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
