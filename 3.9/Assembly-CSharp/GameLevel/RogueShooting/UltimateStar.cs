using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D65 RID: 3429
	[Token(Token = "0x2000D65")]
	public class UltimateStar : BaseConfig
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x001682D4 File Offset: 0x001664D4
		[Token(Token = "0x17000821")]
		public override string Role
		{
			[Token(Token = "0x6004757")]
			[Address(RVA = "0x8C4620", Offset = "0x8C2C20", VA = "0x1808C4620", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x001682E8 File Offset: 0x001664E8
		[Token(Token = "0x17000822")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004758")]
			[Address(RVA = "0x7E8E50", Offset = "0x7E7450", VA = "0x1807E8E50", Slot = "4")]
			get
			{
				return PlantType.UltimateStar;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x001682FC File Offset: 0x001664FC
		[Token(Token = "0x17000823")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004759")]
			[Address(RVA = "0x8C4260", Offset = "0x8C2860", VA = "0x1808C4260", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateStar.UniqueUpgrade uniqueUpgrade = new UltimateStar.UniqueUpgrade();
				int size3 = list._size;
				int size4 = list._size;
				UltimateStar.SuperBuff superBuff = new UltimateStar.SuperBuff();
				int size5 = list._size;
				UltimateStar.StarCurse starCurse = new UltimateStar.StarCurse();
				int size6 = list._size;
				return list;
			}
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x00168370 File Offset: 0x00166570
		[Token(Token = "0x600475A")]
		[Address(RVA = "0x8C2400", Offset = "0x8C0A00", VA = "0x1808C2400", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 6f, num2 != 0, num);
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x00168398 File Offset: 0x00166598
		[Token(Token = "0x600475B")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateStar()
		{
		}

		// Token: 0x02000D66 RID: 3430
		[Token(Token = "0x2000D66")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000824 RID: 2084
			// (get) Token: 0x0600475C RID: 18268 RVA: 0x001683AC File Offset: 0x001665AC
			[Token(Token = "0x17000824")]
			public override string Title
			{
				[Token(Token = "0x600475C")]
				[Address(RVA = "0x8C6DB0", Offset = "0x8C53B0", VA = "0x1808C6DB0", Slot = "5")]
				get
				{
					return "强化：多功能";
				}
			}

			// Token: 0x17000825 RID: 2085
			// (get) Token: 0x0600475D RID: 18269 RVA: 0x001683C0 File Offset: 0x001665C0
			[Token(Token = "0x17000825")]
			public override string Description
			{
				[Token(Token = "0x600475D")]
				[Address(RVA = "0x8C6B90", Offset = "0x8C5190", VA = "0x1808C6B90", Slot = "6")]
				get
				{
					return base.PlantName + "每轮攻击额外发射一轮多功能杨桃子弹";
				}
			}

			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x0600475E RID: 18270 RVA: 0x001683E0 File Offset: 0x001665E0
			[Token(Token = "0x17000826")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600475E")]
				[Address(RVA = "0x7E8E50", Offset = "0x7E7450", VA = "0x1807E8E50", Slot = "4")]
				get
				{
					return PlantType.UltimateStar;
				}
			}

			// Token: 0x0600475F RID: 18271 RVA: 0x001683F4 File Offset: 0x001665F4
			[Token(Token = "0x600475F")]
			[Address(RVA = "0x8C5820", Offset = "0x8C3E20", VA = "0x1808C5820", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__6_ = UltimateStar.UniqueUpgrade.<>c.<>9__6_0;
				if (<>9__6_ == 0)
				{
					Action<Plant> action;
					UltimateStar.UniqueUpgrade.<>c.<>9__6_0 = action;
				}
				base.SafeModify(<>9__6_);
			}

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x06004760 RID: 18272 RVA: 0x00168420 File Offset: 0x00166620
			[Token(Token = "0x17000827")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004760")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x06004761 RID: 18273 RVA: 0x00168434 File Offset: 0x00166634
			[Token(Token = "0x17000828")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004761")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004762 RID: 18274 RVA: 0x00168444 File Offset: 0x00166644
			[Token(Token = "0x6004762")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D68 RID: 3432
		[Token(Token = "0x2000D68")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x06004766 RID: 18278 RVA: 0x00168458 File Offset: 0x00166658
			[Token(Token = "0x17000829")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004766")]
				[Address(RVA = "0x7E8E50", Offset = "0x7E7450", VA = "0x1807E8E50", Slot = "4")]
				get
				{
					return PlantType.UltimateStar;
				}
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x06004767 RID: 18279 RVA: 0x0016846C File Offset: 0x0016666C
			[Token(Token = "0x1700082A")]
			public override string Title
			{
				[Token(Token = "0x6004767")]
				[Address(RVA = "0x8B7240", Offset = "0x8B5840", VA = "0x1808B7240", Slot = "5")]
				get
				{
					return "质变：幸运星";
				}
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x06004768 RID: 18280 RVA: 0x00168480 File Offset: 0x00166680
			[Token(Token = "0x1700082B")]
			public override string Description
			{
				[Token(Token = "0x6004768")]
				[Address(RVA = "0x8B6D60", Offset = "0x8B5360", VA = "0x1808B6D60", Slot = "6")]
				get
				{
					return "大帝每60秒将会进行一次抽奖，死亡后重新计时，奖励品质会被幸运影响";
				}
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x06004769 RID: 18281 RVA: 0x00168494 File Offset: 0x00166694
			[Token(Token = "0x1700082C")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004769")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x0600476A RID: 18282 RVA: 0x001684A4 File Offset: 0x001666A4
			[Token(Token = "0x1700082D")]
			public override int MaxCount
			{
				[Token(Token = "0x600476A")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x0600476B RID: 18283 RVA: 0x001684B4 File Offset: 0x001666B4
			[Token(Token = "0x1700082E")]
			public override float AppearWeight
			{
				[Token(Token = "0x600476B")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600476C RID: 18284 RVA: 0x001684C8 File Offset: 0x001666C8
			[Token(Token = "0x600476C")]
			[Address(RVA = "0x8B60A0", Offset = "0x8B46A0", VA = "0x1808B60A0", Slot = "7")]
			public override void OnGet()
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}

			// Token: 0x0600476D RID: 18285 RVA: 0x001684EC File Offset: 0x001666EC
			[Token(Token = "0x600476D")]
			[Address(RVA = "0x8B60A0", Offset = "0x8B46A0", VA = "0x1808B60A0")]
			private void AwardUpdate()
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}

			// Token: 0x0600476E RID: 18286 RVA: 0x00168510 File Offset: 0x00166710
			[Token(Token = "0x600476E")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}

		// Token: 0x02000D6A RID: 3434
		[Token(Token = "0x2000D6A")]
		private class StarCurse : CurseBuff
		{
			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x06004771 RID: 18289 RVA: 0x00168524 File Offset: 0x00166724
			[Token(Token = "0x1700082F")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004771")]
				[Address(RVA = "0x7E8E50", Offset = "0x7E7450", VA = "0x1807E8E50", Slot = "4")]
				get
				{
					return PlantType.UltimateStar;
				}
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x06004772 RID: 18290 RVA: 0x00168538 File Offset: 0x00166738
			[Token(Token = "0x17000830")]
			public override string Title
			{
				[Token(Token = "0x6004772")]
				[Address(RVA = "0x8B5EA0", Offset = "0x8B44A0", VA = "0x1808B5EA0", Slot = "5")]
				get
				{
					return "诅咒：壹肆叁柒";
				}
			}

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x06004773 RID: 18291 RVA: 0x0016854C File Offset: 0x0016674C
			[Token(Token = "0x17000831")]
			public override string Description
			{
				[Token(Token = "0x6004773")]
				[Address(RVA = "0x8B5E20", Offset = "0x8B4420", VA = "0x1808B5E20", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)14000];
				}
			}

			// Token: 0x06004774 RID: 18292 RVA: 0x00168570 File Offset: 0x00166770
			[Token(Token = "0x6004774")]
			[Address(RVA = "0x8B5DC0", Offset = "0x8B43C0", VA = "0x1808B5DC0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)14000));
			}

			// Token: 0x06004775 RID: 18293 RVA: 0x00168598 File Offset: 0x00166798
			[Token(Token = "0x6004775")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public StarCurse()
			{
			}
		}
	}
}
