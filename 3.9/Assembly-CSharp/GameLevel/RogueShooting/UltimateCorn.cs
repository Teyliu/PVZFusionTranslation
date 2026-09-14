using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D8D RID: 3469
	[Token(Token = "0x2000D8D")]
	public class UltimateCorn : BaseConfig
	{
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x00169B70 File Offset: 0x00167D70
		[Token(Token = "0x170008AE")]
		public override string Role
		{
			[Token(Token = "0x6004839")]
			[Address(RVA = "0x8C16C0", Offset = "0x8BFCC0", VA = "0x1808C16C0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x00169B84 File Offset: 0x00167D84
		[Token(Token = "0x170008AF")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600483A")]
			[Address(RVA = "0x7E8310", Offset = "0x7E6910", VA = "0x1807E8310", Slot = "4")]
			get
			{
				return PlantType.UltimateCorn;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x00169B98 File Offset: 0x00167D98
		[Token(Token = "0x170008B0")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600483B")]
			[Address(RVA = "0x8C14A0", Offset = "0x8BFAA0", VA = "0x1808C14A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				UltimateCorn.ExtraDamageBuff extraDamageBuff = new UltimateCorn.ExtraDamageBuff();
				int size2 = list._size;
				UltimateCorn.SuperBuff superBuff = new UltimateCorn.SuperBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x00169BE4 File Offset: 0x00167DE4
		[Token(Token = "0x600483C")]
		[Address(RVA = "0x8C1380", Offset = "0x8BF980", VA = "0x1808C1380", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(3f);
			TravelMgr instance = TravelMgr.Instance;
			int num = 0;
			instance.GetUltiBuff((UltiBuff)((uint)30), num != 0);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x00169C30 File Offset: 0x00167E30
		[Token(Token = "0x600483D")]
		[Address(RVA = "0x8C12D0", Offset = "0x8BF8D0", VA = "0x1808C12D0")]
		private void Butter(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x00169C54 File Offset: 0x00167E54
		[Token(Token = "0x600483E")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateCorn()
		{
		}

		// Token: 0x02000D8E RID: 3470
		[Token(Token = "0x2000D8E")]
		private class ExtraDamageBuff : BaseBuff
		{
			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x0600483F RID: 18495 RVA: 0x00169C68 File Offset: 0x00167E68
			[Token(Token = "0x170008B1")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600483F")]
				[Address(RVA = "0x7E8310", Offset = "0x7E6910", VA = "0x1807E8310", Slot = "4")]
				get
				{
					return PlantType.UltimateCorn;
				}
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06004840 RID: 18496 RVA: 0x00169C7C File Offset: 0x00167E7C
			[Token(Token = "0x170008B2")]
			public override string Title
			{
				[Token(Token = "0x6004840")]
				[Address(RVA = "0x8ABC70", Offset = "0x8AA270", VA = "0x1808ABC70", Slot = "5")]
				get
				{
					return "强化：撕裂";
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06004841 RID: 18497 RVA: 0x00169C90 File Offset: 0x00167E90
			[Token(Token = "0x170008B3")]
			public override string Description
			{
				[Token(Token = "0x6004841")]
				[Address(RVA = "0x8ABC40", Offset = "0x8AA240", VA = "0x1808ABC40", Slot = "6")]
				get
				{
					return "黑洞会对附近的僵尸造成伤害，每拥有一个该词条，伤害比例增加100%";
				}
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06004842 RID: 18498 RVA: 0x00169CA4 File Offset: 0x00167EA4
			[Token(Token = "0x170008B4")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004842")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x06004843 RID: 18499 RVA: 0x00169CB4 File Offset: 0x00167EB4
			[Token(Token = "0x170008B5")]
			public override int MaxCount
			{
				[Token(Token = "0x6004843")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x06004844 RID: 18500 RVA: 0x00169CC4 File Offset: 0x00167EC4
			[Token(Token = "0x170008B6")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004844")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004845 RID: 18501 RVA: 0x00169CD8 File Offset: 0x00167ED8
			[Token(Token = "0x6004845")]
			[Address(RVA = "0x8ABB30", Offset = "0x8AA130", VA = "0x1808ABB30", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> action;
				if (UltimateCorn.ExtraDamageBuff.<>c.<>9__12_0 == 0)
				{
					UltimateCorn.ExtraDamageBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(action);
			}

			// Token: 0x06004846 RID: 18502 RVA: 0x00169D04 File Offset: 0x00167F04
			[Token(Token = "0x6004846")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public ExtraDamageBuff()
			{
			}
		}

		// Token: 0x02000D90 RID: 3472
		[Token(Token = "0x2000D90")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x0600484A RID: 18506 RVA: 0x00169D18 File Offset: 0x00167F18
			[Token(Token = "0x170008B7")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600484A")]
				[Address(RVA = "0x7E8310", Offset = "0x7E6910", VA = "0x1807E8310", Slot = "4")]
				get
				{
					return PlantType.UltimateCorn;
				}
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x0600484B RID: 18507 RVA: 0x00169D2C File Offset: 0x00167F2C
			[Token(Token = "0x170008B8")]
			public override string Title
			{
				[Token(Token = "0x600484B")]
				[Address(RVA = "0x8B7450", Offset = "0x8B5A50", VA = "0x1808B7450", Slot = "5")]
				get
				{
					return "质变：引力";
				}
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x0600484C RID: 18508 RVA: 0x00169D40 File Offset: 0x00167F40
			[Token(Token = "0x170008B9")]
			public override string Description
			{
				[Token(Token = "0x600484C")]
				[Address(RVA = "0x8B6980", Offset = "0x8B4F80", VA = "0x1808B6980", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12007];
				}
			}

			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x0600484D RID: 18509 RVA: 0x00169D64 File Offset: 0x00167F64
			[Token(Token = "0x170008BA")]
			public override Quality Rarity
			{
				[Token(Token = "0x600484D")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x0600484E RID: 18510 RVA: 0x00169D74 File Offset: 0x00167F74
			[Token(Token = "0x170008BB")]
			public override int MaxCount
			{
				[Token(Token = "0x600484E")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x0600484F RID: 18511 RVA: 0x00169D84 File Offset: 0x00167F84
			[Token(Token = "0x170008BC")]
			public override float AppearWeight
			{
				[Token(Token = "0x600484F")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004850 RID: 18512 RVA: 0x00169D98 File Offset: 0x00167F98
			[Token(Token = "0x6004850")]
			[Address(RVA = "0x8B6740", Offset = "0x8B4D40", VA = "0x1808B6740", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12007));
			}

			// Token: 0x06004851 RID: 18513 RVA: 0x00169DC0 File Offset: 0x00167FC0
			[Token(Token = "0x6004851")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
