using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C20 RID: 3104
	[Token(Token = "0x2000C20")]
	public class DoomSniper : BaseConfig
	{
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x00156118 File Offset: 0x00154318
		[Token(Token = "0x17000522")]
		public override string Role
		{
			[Token(Token = "0x60040D8")]
			[Address(RVA = "0x830AD0", Offset = "0x82F0D0", VA = "0x180830AD0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060040D9 RID: 16601 RVA: 0x0015612C File Offset: 0x0015432C
		[Token(Token = "0x17000523")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60040D9")]
			[Address(RVA = "0x830AC0", Offset = "0x82F0C0", VA = "0x180830AC0", Slot = "4")]
			get
			{
				return PlantType.DoomSniper;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x00156140 File Offset: 0x00154340
		[Token(Token = "0x17000524")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60040DA")]
			[Address(RVA = "0x830810", Offset = "0x82EE10", VA = "0x180830810", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				DoomSniper.UniqueUpgrade uniqueUpgrade = new DoomSniper.UniqueUpgrade();
				int size3 = list._size;
				DoomSniper.HeartUpgrade heartUpgrade = new DoomSniper.HeartUpgrade();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00156198 File Offset: 0x00154398
		[Token(Token = "0x60040DB")]
		[Address(RVA = "0x8307D0", Offset = "0x82EDD0", VA = "0x1808307D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x001561B0 File Offset: 0x001543B0
		[Token(Token = "0x60040DC")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public DoomSniper()
		{
		}

		// Token: 0x02000C21 RID: 3105
		[Token(Token = "0x2000C21")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000525 RID: 1317
			// (get) Token: 0x060040DD RID: 16605 RVA: 0x001561C4 File Offset: 0x001543C4
			[Token(Token = "0x17000525")]
			public override string Title
			{
				[Token(Token = "0x60040DD")]
				[Address(RVA = "0x846950", Offset = "0x844F50", VA = "0x180846950", Slot = "5")]
				get
				{
					return "强化：死神之光";
				}
			}

			// Token: 0x17000526 RID: 1318
			// (get) Token: 0x060040DE RID: 16606 RVA: 0x001561D8 File Offset: 0x001543D8
			[Token(Token = "0x17000526")]
			public override string Description
			{
				[Token(Token = "0x60040DE")]
				[Address(RVA = "0x8463D0", Offset = "0x8449D0", VA = "0x1808463D0", Slot = "6")]
				get
				{
					return base.PlantName + "释放的毁灭菇伤害+100%";
				}
			}

			// Token: 0x17000527 RID: 1319
			// (get) Token: 0x060040DF RID: 16607 RVA: 0x001561F8 File Offset: 0x001543F8
			[Token(Token = "0x17000527")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60040DF")]
				[Address(RVA = "0x830AC0", Offset = "0x82F0C0", VA = "0x180830AC0", Slot = "4")]
				get
				{
					return PlantType.DoomSniper;
				}
			}

			// Token: 0x17000528 RID: 1320
			// (get) Token: 0x060040E0 RID: 16608 RVA: 0x0015620C File Offset: 0x0015440C
			[Token(Token = "0x17000528")]
			public override float AppearWeight
			{
				[Token(Token = "0x60040E0")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060040E1 RID: 16609 RVA: 0x00156220 File Offset: 0x00154420
			[Token(Token = "0x60040E1")]
			[Address(RVA = "0x845480", Offset = "0x843A80", VA = "0x180845480", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x17000529 RID: 1321
			// (get) Token: 0x060040E2 RID: 16610 RVA: 0x00156250 File Offset: 0x00154450
			[Token(Token = "0x17000529")]
			public override Quality Rarity
			{
				[Token(Token = "0x60040E2")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060040E3 RID: 16611 RVA: 0x00156260 File Offset: 0x00154460
			[Token(Token = "0x60040E3")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C22 RID: 3106
		[Token(Token = "0x2000C22")]
		private class HeartUpgrade : BaseBuff
		{
			// Token: 0x1700052A RID: 1322
			// (get) Token: 0x060040E4 RID: 16612 RVA: 0x00156274 File Offset: 0x00154474
			[Token(Token = "0x1700052A")]
			public override string Title
			{
				[Token(Token = "0x60040E4")]
				[Address(RVA = "0x831E40", Offset = "0x830440", VA = "0x180831E40", Slot = "5")]
				get
				{
					return "质变：神枪手";
				}
			}

			// Token: 0x1700052B RID: 1323
			// (get) Token: 0x060040E5 RID: 16613 RVA: 0x00156288 File Offset: 0x00154488
			[Token(Token = "0x1700052B")]
			public override string Description
			{
				[Token(Token = "0x60040E5")]
				[Address(RVA = "0x831DF0", Offset = "0x8303F0", VA = "0x180831DF0", Slot = "6")]
				get
				{
					return base.PlantName + "每一发子弹都会造成爆头伤害";
				}
			}

			// Token: 0x1700052C RID: 1324
			// (get) Token: 0x060040E6 RID: 16614 RVA: 0x001562A8 File Offset: 0x001544A8
			[Token(Token = "0x1700052C")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60040E6")]
				[Address(RVA = "0x830AC0", Offset = "0x82F0C0", VA = "0x180830AC0", Slot = "4")]
				get
				{
					return PlantType.DoomSniper;
				}
			}

			// Token: 0x1700052D RID: 1325
			// (get) Token: 0x060040E7 RID: 16615 RVA: 0x001562BC File Offset: 0x001544BC
			[Token(Token = "0x1700052D")]
			public override float AppearWeight
			{
				[Token(Token = "0x60040E7")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700052E RID: 1326
			// (get) Token: 0x060040E8 RID: 16616 RVA: 0x001562D0 File Offset: 0x001544D0
			[Token(Token = "0x1700052E")]
			public override int MaxCount
			{
				[Token(Token = "0x60040E8")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x060040E9 RID: 16617 RVA: 0x001562E0 File Offset: 0x001544E0
			[Token(Token = "0x60040E9")]
			[Address(RVA = "0x831D90", Offset = "0x830390", VA = "0x180831D90", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12002));
			}

			// Token: 0x1700052F RID: 1327
			// (get) Token: 0x060040EA RID: 16618 RVA: 0x00156308 File Offset: 0x00154508
			[Token(Token = "0x1700052F")]
			public override Quality Rarity
			{
				[Token(Token = "0x60040EA")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x060040EB RID: 16619 RVA: 0x00156318 File Offset: 0x00154518
			[Token(Token = "0x60040EB")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public HeartUpgrade()
			{
			}
		}
	}
}
