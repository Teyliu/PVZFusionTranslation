using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000CA2")]
	public class UltimateMelon : BaseConfig
	{
		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x0015BA0C File Offset: 0x00159C0C
		[Token(Token = "0x170006F0")]
		public override string Role
		{
			[Token(Token = "0x60043C3")]
			[Address(RVA = "0x8433D0", Offset = "0x8419D0", VA = "0x1808433D0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x0015BA20 File Offset: 0x00159C20
		[Token(Token = "0x170006F1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043C4")]
			[Address(RVA = "0x781C80", Offset = "0x780280", VA = "0x180781C80", Slot = "4")]
			get
			{
				return PlantType.UltimateMelon;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x0015BA34 File Offset: 0x00159C34
		[Token(Token = "0x170006F2")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043C5")]
			[Address(RVA = "0x843120", Offset = "0x841720", VA = "0x180843120", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateMelon.UniqueUpgrade uniqueUpgrade = new UltimateMelon.UniqueUpgrade();
				int size3 = list._size;
				UltimateMelon.SuperUpgrade superUpgrade = new UltimateMelon.SuperUpgrade();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x0015BA8C File Offset: 0x00159C8C
		[Token(Token = "0x60043C6")]
		[Address(RVA = "0x8430D0", Offset = "0x8416D0", VA = "0x1808430D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 5f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x0015BAC0 File Offset: 0x00159CC0
		[Token(Token = "0x60043C7")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateMelon()
		{
		}

		// Token: 0x02000CA3 RID: 3235
		[Token(Token = "0x2000CA3")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x060043C8 RID: 17352 RVA: 0x0015BAD4 File Offset: 0x00159CD4
			[Token(Token = "0x170006F3")]
			public override string Title
			{
				[Token(Token = "0x60043C8")]
				[Address(RVA = "0x8466E0", Offset = "0x844CE0", VA = "0x1808466E0", Slot = "5")]
				get
				{
					return "强化：散射";
				}
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x060043C9 RID: 17353 RVA: 0x0015BAE8 File Offset: 0x00159CE8
			[Token(Token = "0x170006F4")]
			public override string Description
			{
				[Token(Token = "0x60043C9")]
				[Address(RVA = "0x846470", Offset = "0x844A70", VA = "0x180846470", Slot = "6")]
				get
				{
					return base.PlantName + "连射、散射概率增加12%";
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x060043CA RID: 17354 RVA: 0x0015BB08 File Offset: 0x00159D08
			[Token(Token = "0x170006F5")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60043CA")]
				[Address(RVA = "0x781C80", Offset = "0x780280", VA = "0x180781C80", Slot = "4")]
				get
				{
					return PlantType.UltimateMelon;
				}
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x060043CB RID: 17355 RVA: 0x0015BB1C File Offset: 0x00159D1C
			[Token(Token = "0x170006F6")]
			public override float AppearWeight
			{
				[Token(Token = "0x60043CB")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x060043CC RID: 17356 RVA: 0x0015BB30 File Offset: 0x00159D30
			[Token(Token = "0x170006F7")]
			public override int MaxCount
			{
				[Token(Token = "0x60043CC")]
				[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
				get
				{
					return 5;
				}
			}

			// Token: 0x060043CD RID: 17357 RVA: 0x0015BB40 File Offset: 0x00159D40
			[Token(Token = "0x60043CD")]
			[Address(RVA = "0x845FB0", Offset = "0x8445B0", VA = "0x180845FB0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x060043CE RID: 17358 RVA: 0x0015BB60 File Offset: 0x00159D60
			[Token(Token = "0x170006F8")]
			public override Quality Rarity
			{
				[Token(Token = "0x60043CE")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060043CF RID: 17359 RVA: 0x0015BB70 File Offset: 0x00159D70
			[Token(Token = "0x60043CF")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000CA4 RID: 3236
		[Token(Token = "0x2000CA4")]
		private class SuperUpgrade : BaseBuff
		{
			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x060043D0 RID: 17360 RVA: 0x0015BB84 File Offset: 0x00159D84
			[Token(Token = "0x170006F9")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60043D0")]
				[Address(RVA = "0x781C80", Offset = "0x780280", VA = "0x180781C80", Slot = "4")]
				get
				{
					return PlantType.UltimateMelon;
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x060043D1 RID: 17361 RVA: 0x0015BB98 File Offset: 0x00159D98
			[Token(Token = "0x170006FA")]
			public override string Title
			{
				[Token(Token = "0x60043D1")]
				[Address(RVA = "0x83B530", Offset = "0x839B30", VA = "0x18083B530", Slot = "5")]
				get
				{
					return "质变：蒜毒骤发";
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x060043D2 RID: 17362 RVA: 0x0015BBAC File Offset: 0x00159DAC
			[Token(Token = "0x170006FB")]
			public override string Description
			{
				[Token(Token = "0x60043D2")]
				[Address(RVA = "0x83B4D0", Offset = "0x839AD0", VA = "0x18083B4D0", Slot = "6")]
				get
				{
					return "获得2级词条：蒜毒骤发";
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x060043D3 RID: 17363 RVA: 0x0015BBC0 File Offset: 0x00159DC0
			[Token(Token = "0x170006FC")]
			public override Quality Rarity
			{
				[Token(Token = "0x60043D3")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x060043D4 RID: 17364 RVA: 0x0015BBD0 File Offset: 0x00159DD0
			[Token(Token = "0x170006FD")]
			public override int MaxCount
			{
				[Token(Token = "0x60043D4")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x060043D5 RID: 17365 RVA: 0x0015BBE0 File Offset: 0x00159DE0
			[Token(Token = "0x170006FE")]
			public override float AppearWeight
			{
				[Token(Token = "0x60043D5")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x060043D6 RID: 17366 RVA: 0x0015BBF4 File Offset: 0x00159DF4
			[Token(Token = "0x170006FF")]
			public override bool CanAppear
			{
				[Token(Token = "0x60043D6")]
				[Address(RVA = "0x839E10", Offset = "0x838410", VA = "0x180839E10", Slot = "9")]
				get
				{
					return Lawnf.TravelUltimate((UltiBuff)((uint)13));
				}
			}

			// Token: 0x060043D7 RID: 17367 RVA: 0x0015BC0C File Offset: 0x00159E0C
			[Token(Token = "0x60043D7")]
			[Address(RVA = "0x83B440", Offset = "0x839A40", VA = "0x18083B440", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetUltiBuff((UltiBuff)((uint)13), true);
			}

			// Token: 0x060043D8 RID: 17368 RVA: 0x0015BC30 File Offset: 0x00159E30
			[Token(Token = "0x60043D8")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperUpgrade()
			{
			}
		}
	}
}
