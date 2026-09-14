using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C97 RID: 3223
	[Token(Token = "0x2000C97")]
	public class AbyssSwordStar : BaseConfig
	{
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x0015B258 File Offset: 0x00159458
		[Token(Token = "0x170006C9")]
		public override string Role
		{
			[Token(Token = "0x6004386")]
			[Address(RVA = "0x82DEF0", Offset = "0x82C4F0", VA = "0x18082DEF0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x0015B26C File Offset: 0x0015946C
		[Token(Token = "0x170006CA")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004387")]
			[Address(RVA = "0x53B920", Offset = "0x539F20", VA = "0x18053B920", Slot = "4")]
			get
			{
				return PlantType.AbyssSwordStar;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x0015B280 File Offset: 0x00159480
		[Token(Token = "0x170006CB")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004388")]
			[Address(RVA = "0x82DCD0", Offset = "0x82C2D0", VA = "0x18082DCD0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				AbyssSwordStar.UniqueUpgrade uniqueUpgrade = new AbyssSwordStar.UniqueUpgrade();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x0015B2C8 File Offset: 0x001594C8
		[Token(Token = "0x6004389")]
		[Address(RVA = "0x82DC80", Offset = "0x82C280", VA = "0x18082DC80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 0.75f, num2 != 0, num);
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x0015B2F0 File Offset: 0x001594F0
		[Token(Token = "0x600438A")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public AbyssSwordStar()
		{
		}

		// Token: 0x02000C98 RID: 3224
		[Token(Token = "0x2000C98")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x0600438B RID: 17291 RVA: 0x0015B304 File Offset: 0x00159504
			[Token(Token = "0x170006CC")]
			public override string Title
			{
				[Token(Token = "0x600438B")]
				[Address(RVA = "0x846710", Offset = "0x844D10", VA = "0x180846710", Slot = "5")]
				get
				{
					return "强化：大剑";
				}
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x0600438C RID: 17292 RVA: 0x0015B318 File Offset: 0x00159518
			[Token(Token = "0x170006CD")]
			public override string Description
			{
				[Token(Token = "0x600438C")]
				[Address(RVA = "0x8461F0", Offset = "0x8447F0", VA = "0x1808461F0", Slot = "6")]
				get
				{
					return base.PlantName + "大剑数量+11";
				}
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x0600438D RID: 17293 RVA: 0x0015B338 File Offset: 0x00159538
			[Token(Token = "0x170006CE")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600438D")]
				[Address(RVA = "0x53B920", Offset = "0x539F20", VA = "0x18053B920", Slot = "4")]
				get
				{
					return PlantType.AbyssSwordStar;
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x0600438E RID: 17294 RVA: 0x0015B34C File Offset: 0x0015954C
			[Token(Token = "0x170006CF")]
			public override float AppearWeight
			{
				[Token(Token = "0x600438E")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600438F RID: 17295 RVA: 0x0015B360 File Offset: 0x00159560
			[Token(Token = "0x600438F")]
			[Address(RVA = "0x8457C0", Offset = "0x843DC0", VA = "0x1808457C0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x06004390 RID: 17296 RVA: 0x0015B380 File Offset: 0x00159580
			[Token(Token = "0x170006D0")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004390")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004391 RID: 17297 RVA: 0x0015B390 File Offset: 0x00159590
			[Token(Token = "0x6004391")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
