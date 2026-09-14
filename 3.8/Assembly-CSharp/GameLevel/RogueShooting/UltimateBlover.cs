using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CC7 RID: 3271
	[Token(Token = "0x2000CC7")]
	public class UltimateBlover : BaseConfig
	{
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x0015CF40 File Offset: 0x0015B140
		[Token(Token = "0x17000772")]
		public override string Role
		{
			[Token(Token = "0x6004495")]
			[Address(RVA = "0x840A90", Offset = "0x83F090", VA = "0x180840A90", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x0015CF54 File Offset: 0x0015B154
		[Token(Token = "0x17000773")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004496")]
			[Address(RVA = "0x840A80", Offset = "0x83F080", VA = "0x180840A80", Slot = "4")]
			get
			{
				return PlantType.UltimateBlover;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x0015CF68 File Offset: 0x0015B168
		[Token(Token = "0x17000774")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004497")]
			[Address(RVA = "0x840970", Offset = "0x83EF70", VA = "0x180840970", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UltimateBlover.UniqueBuff uniqueBuff = new UltimateBlover.UniqueBuff();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x0015CF9C File Offset: 0x0015B19C
		[Token(Token = "0x6004498")]
		[Address(RVA = "0x8408D0", Offset = "0x83EED0", VA = "0x1808408D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'UltimateStarBlover' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(UltimateStarBlover).TypeHandle;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x0015CFC0 File Offset: 0x0015B1C0
		[Token(Token = "0x6004499")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateBlover()
		{
		}

		// Token: 0x02000CC8 RID: 3272
		[Token(Token = "0x2000CC8")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x0600449A RID: 17562 RVA: 0x0015CFD4 File Offset: 0x0015B1D4
			[Token(Token = "0x17000775")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600449A")]
				[Address(RVA = "0x840A80", Offset = "0x83F080", VA = "0x180840A80", Slot = "4")]
				get
				{
					return PlantType.UltimateBlover;
				}
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x0600449B RID: 17563 RVA: 0x0015CFE8 File Offset: 0x0015B1E8
			[Token(Token = "0x17000776")]
			public override string Title
			{
				[Token(Token = "0x600449B")]
				[Address(RVA = "0x845240", Offset = "0x843840", VA = "0x180845240", Slot = "5")]
				get
				{
					return "强化：数量";
				}
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x0600449C RID: 17564 RVA: 0x0015CFFC File Offset: 0x0015B1FC
			[Token(Token = "0x17000777")]
			public override string Description
			{
				[Token(Token = "0x600449C")]
				[Address(RVA = "0x845180", Offset = "0x843780", VA = "0x180845180", Slot = "6")]
				get
				{
					return "存储子弹数量上限增加30";
				}
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x0600449D RID: 17565 RVA: 0x0015D010 File Offset: 0x0015B210
			[Token(Token = "0x17000778")]
			public override Quality Rarity
			{
				[Token(Token = "0x600449D")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600449E RID: 17566 RVA: 0x0015D020 File Offset: 0x0015B220
			[Token(Token = "0x600449E")]
			[Address(RVA = "0x844BB0", Offset = "0x8431B0", VA = "0x180844BB0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = UltimateBlover.UniqueBuff.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					UltimateBlover.UniqueBuff.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x0600449F RID: 17567 RVA: 0x0015D04C File Offset: 0x0015B24C
			[Token(Token = "0x600449F")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueBuff()
			{
			}
		}
	}
}
