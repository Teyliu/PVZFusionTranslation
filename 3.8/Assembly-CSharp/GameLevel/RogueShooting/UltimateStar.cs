using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C91 RID: 3217
	[Token(Token = "0x2000C91")]
	public class UltimateStar : BaseConfig
	{
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x0015AF54 File Offset: 0x00159154
		[Token(Token = "0x170006B8")]
		public override string Role
		{
			[Token(Token = "0x6004367")]
			[Address(RVA = "0x844500", Offset = "0x842B00", VA = "0x180844500", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x0015AF68 File Offset: 0x00159168
		[Token(Token = "0x170006B9")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004368")]
			[Address(RVA = "0x781FA0", Offset = "0x7805A0", VA = "0x180781FA0", Slot = "4")]
			get
			{
				return PlantType.UltimateStar;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x0015AF7C File Offset: 0x0015917C
		[Token(Token = "0x170006BA")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004369")]
			[Address(RVA = "0x8441D0", Offset = "0x8427D0", VA = "0x1808441D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateStar.UniqueUpgrade uniqueUpgrade = new UltimateStar.UniqueUpgrade();
				int size3 = list._size;
				StarUpBuff starUpBuff;
				starUpBuff.targetType = (PlantType)((ulong)909L);
				int size4 = list._size;
				UltimateStar.SuperBuff superBuff = new UltimateStar.SuperBuff();
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x0015AFEC File Offset: 0x001591EC
		[Token(Token = "0x600436A")]
		[Address(RVA = "0x842660", Offset = "0x840C60", VA = "0x180842660", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 6f, num2 != 0, num);
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x0015B014 File Offset: 0x00159214
		[Token(Token = "0x600436B")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateStar()
		{
		}

		// Token: 0x02000C92 RID: 3218
		[Token(Token = "0x2000C92")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x0600436C RID: 17260 RVA: 0x0015B028 File Offset: 0x00159228
			[Token(Token = "0x170006BB")]
			public override string Title
			{
				[Token(Token = "0x600436C")]
				[Address(RVA = "0x846800", Offset = "0x844E00", VA = "0x180846800", Slot = "5")]
				get
				{
					return "强化：多功能";
				}
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x0600436D RID: 17261 RVA: 0x0015B03C File Offset: 0x0015923C
			[Token(Token = "0x170006BC")]
			public override string Description
			{
				[Token(Token = "0x600436D")]
				[Address(RVA = "0x8465E0", Offset = "0x844BE0", VA = "0x1808465E0", Slot = "6")]
				get
				{
					return base.PlantName + "每轮攻击额外发射一轮多功能杨桃子弹";
				}
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x0600436E RID: 17262 RVA: 0x0015B05C File Offset: 0x0015925C
			[Token(Token = "0x170006BD")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600436E")]
				[Address(RVA = "0x781FA0", Offset = "0x7805A0", VA = "0x180781FA0", Slot = "4")]
				get
				{
					return PlantType.UltimateStar;
				}
			}

			// Token: 0x0600436F RID: 17263 RVA: 0x0015B070 File Offset: 0x00159270
			[Token(Token = "0x600436F")]
			[Address(RVA = "0x8455A0", Offset = "0x843BA0", VA = "0x1808455A0", Slot = "7")]
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

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x06004370 RID: 17264 RVA: 0x0015B09C File Offset: 0x0015929C
			[Token(Token = "0x170006BE")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004370")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x06004371 RID: 17265 RVA: 0x0015B0B0 File Offset: 0x001592B0
			[Token(Token = "0x170006BF")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004371")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004372 RID: 17266 RVA: 0x0015B0C0 File Offset: 0x001592C0
			[Token(Token = "0x6004372")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C94 RID: 3220
		[Token(Token = "0x2000C94")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x06004376 RID: 17270 RVA: 0x0015B0D4 File Offset: 0x001592D4
			[Token(Token = "0x170006C0")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004376")]
				[Address(RVA = "0x781FA0", Offset = "0x7805A0", VA = "0x180781FA0", Slot = "4")]
				get
				{
					return PlantType.UltimateStar;
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x06004377 RID: 17271 RVA: 0x0015B0E8 File Offset: 0x001592E8
			[Token(Token = "0x170006C1")]
			public override string Title
			{
				[Token(Token = "0x6004377")]
				[Address(RVA = "0x83A490", Offset = "0x838A90", VA = "0x18083A490", Slot = "5")]
				get
				{
					return "质变：幸运星";
				}
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x06004378 RID: 17272 RVA: 0x0015B0FC File Offset: 0x001592FC
			[Token(Token = "0x170006C2")]
			public override string Description
			{
				[Token(Token = "0x6004378")]
				[Address(RVA = "0x83A110", Offset = "0x838710", VA = "0x18083A110", Slot = "6")]
				get
				{
					return "大帝每60秒将会进行一次抽奖，死亡后重新计时，奖励品质会被幸运影响";
				}
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x06004379 RID: 17273 RVA: 0x0015B110 File Offset: 0x00159310
			[Token(Token = "0x170006C3")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004379")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x0600437A RID: 17274 RVA: 0x0015B120 File Offset: 0x00159320
			[Token(Token = "0x170006C4")]
			public override int MaxCount
			{
				[Token(Token = "0x600437A")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x0600437B RID: 17275 RVA: 0x0015B130 File Offset: 0x00159330
			[Token(Token = "0x170006C5")]
			public override float AppearWeight
			{
				[Token(Token = "0x600437B")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600437C RID: 17276 RVA: 0x0015B144 File Offset: 0x00159344
			[Token(Token = "0x600437C")]
			[Address(RVA = "0x8397B0", Offset = "0x837DB0", VA = "0x1808397B0", Slot = "7")]
			public override void OnGet()
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}

			// Token: 0x0600437D RID: 17277 RVA: 0x0015B168 File Offset: 0x00159368
			[Token(Token = "0x600437D")]
			[Address(RVA = "0x8397B0", Offset = "0x837DB0", VA = "0x1808397B0")]
			private void AwardUpdate()
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}

			// Token: 0x0600437E RID: 17278 RVA: 0x0015B18C File Offset: 0x0015938C
			[Token(Token = "0x600437E")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
