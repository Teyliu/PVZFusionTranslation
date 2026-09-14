using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CAA RID: 3242
	[Token(Token = "0x2000CAA")]
	public class UltimateWinterMelon : BaseConfig
	{
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x0015BFFC File Offset: 0x0015A1FC
		[Token(Token = "0x17000714")]
		public override string Role
		{
			[Token(Token = "0x60043F7")]
			[Address(RVA = "0x844920", Offset = "0x842F20", VA = "0x180844920", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x0015C010 File Offset: 0x0015A210
		[Token(Token = "0x17000715")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043F8")]
			[Address(RVA = "0x844910", Offset = "0x842F10", VA = "0x180844910", Slot = "4")]
			get
			{
				return PlantType.UltimateWinterMelon;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x0015C024 File Offset: 0x0015A224
		[Token(Token = "0x17000716")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043F9")]
			[Address(RVA = "0x8446F0", Offset = "0x842CF0", VA = "0x1808446F0", Slot = "5")]
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

		// Token: 0x060043FA RID: 17402 RVA: 0x0015C06C File Offset: 0x0015A26C
		[Token(Token = "0x60043FA")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x0015C07C File Offset: 0x0015A27C
		[Token(Token = "0x60043FB")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateWinterMelon()
		{
		}

		// Token: 0x02000CAB RID: 3243
		[Token(Token = "0x2000CAB")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x060043FC RID: 17404 RVA: 0x0015C090 File Offset: 0x0015A290
			[Token(Token = "0x17000717")]
			public override string Title
			{
				[Token(Token = "0x60043FC")]
				[Address(RVA = "0x846860", Offset = "0x844E60", VA = "0x180846860", Slot = "5")]
				get
				{
					return "强化：散射";
				}
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x060043FD RID: 17405 RVA: 0x0015C0A4 File Offset: 0x0015A2A4
			[Token(Token = "0x17000718")]
			public override string Description
			{
				[Token(Token = "0x60043FD")]
				[Address(RVA = "0x846150", Offset = "0x844750", VA = "0x180846150", Slot = "6")]
				get
				{
					return base.PlantName + "的发射数量+1";
				}
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x060043FE RID: 17406 RVA: 0x0015C0C4 File Offset: 0x0015A2C4
			[Token(Token = "0x17000719")]
			public override float AppearWeight
			{
				[Token(Token = "0x60043FE")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x060043FF RID: 17407 RVA: 0x0015C0D8 File Offset: 0x0015A2D8
			[Token(Token = "0x1700071A")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60043FF")]
				[Address(RVA = "0x844910", Offset = "0x842F10", VA = "0x180844910", Slot = "4")]
				get
				{
					return PlantType.UltimateWinterMelon;
				}
			}

			// Token: 0x06004400 RID: 17408 RVA: 0x0015C0EC File Offset: 0x0015A2EC
			[Token(Token = "0x6004400")]
			[Address(RVA = "0x845A30", Offset = "0x844030", VA = "0x180845A30", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06004401 RID: 17409 RVA: 0x0015C10C File Offset: 0x0015A30C
			[Token(Token = "0x1700071B")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004401")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004402 RID: 17410 RVA: 0x0015C11C File Offset: 0x0015A31C
			[Token(Token = "0x6004402")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
