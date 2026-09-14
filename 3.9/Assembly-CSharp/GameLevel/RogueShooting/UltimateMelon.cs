using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D7B RID: 3451
	[Token(Token = "0x2000D7B")]
	public class UltimateMelon : BaseConfig
	{
		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x00168F74 File Offset: 0x00167174
		[Token(Token = "0x1700086B")]
		public override string Role
		{
			[Token(Token = "0x60047D0")]
			[Address(RVA = "0x8C3170", Offset = "0x8C1770", VA = "0x1808C3170", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x00168F88 File Offset: 0x00167188
		[Token(Token = "0x1700086C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60047D1")]
			[Address(RVA = "0x7E8B30", Offset = "0x7E7130", VA = "0x1807E8B30", Slot = "4")]
			get
			{
				return PlantType.UltimateMelon;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x00168F9C File Offset: 0x0016719C
		[Token(Token = "0x1700086D")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60047D2")]
			[Address(RVA = "0x8C2EC0", Offset = "0x8C14C0", VA = "0x1808C2EC0", Slot = "5")]
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

		// Token: 0x060047D3 RID: 18387 RVA: 0x00168FF4 File Offset: 0x001671F4
		[Token(Token = "0x60047D3")]
		[Address(RVA = "0x8C2E70", Offset = "0x8C1470", VA = "0x1808C2E70", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 5f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00169028 File Offset: 0x00167228
		[Token(Token = "0x60047D4")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateMelon()
		{
		}

		// Token: 0x02000D7C RID: 3452
		[Token(Token = "0x2000D7C")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x060047D5 RID: 18389 RVA: 0x0016903C File Offset: 0x0016723C
			[Token(Token = "0x1700086E")]
			public override string Title
			{
				[Token(Token = "0x60047D5")]
				[Address(RVA = "0x8C6C90", Offset = "0x8C5290", VA = "0x1808C6C90", Slot = "5")]
				get
				{
					return "强化：散射";
				}
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x060047D6 RID: 18390 RVA: 0x00169050 File Offset: 0x00167250
			[Token(Token = "0x1700086F")]
			public override string Description
			{
				[Token(Token = "0x60047D6")]
				[Address(RVA = "0x8C6A20", Offset = "0x8C5020", VA = "0x1808C6A20", Slot = "6")]
				get
				{
					return base.PlantName + "连射、散射概率增加12%";
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x060047D7 RID: 18391 RVA: 0x00169070 File Offset: 0x00167270
			[Token(Token = "0x17000870")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60047D7")]
				[Address(RVA = "0x7E8B30", Offset = "0x7E7130", VA = "0x1807E8B30", Slot = "4")]
				get
				{
					return PlantType.UltimateMelon;
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x060047D8 RID: 18392 RVA: 0x00169084 File Offset: 0x00167284
			[Token(Token = "0x17000871")]
			public override float AppearWeight
			{
				[Token(Token = "0x60047D8")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x060047D9 RID: 18393 RVA: 0x00169098 File Offset: 0x00167298
			[Token(Token = "0x17000872")]
			public override int MaxCount
			{
				[Token(Token = "0x60047D9")]
				[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
				get
				{
					return 5;
				}
			}

			// Token: 0x060047DA RID: 18394 RVA: 0x001690A8 File Offset: 0x001672A8
			[Token(Token = "0x60047DA")]
			[Address(RVA = "0x8C64E0", Offset = "0x8C4AE0", VA = "0x1808C64E0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x060047DB RID: 18395 RVA: 0x001690C8 File Offset: 0x001672C8
			[Token(Token = "0x17000873")]
			public override Quality Rarity
			{
				[Token(Token = "0x60047DB")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060047DC RID: 18396 RVA: 0x001690D8 File Offset: 0x001672D8
			[Token(Token = "0x60047DC")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D7D RID: 3453
		[Token(Token = "0x2000D7D")]
		private class SuperUpgrade : BaseBuff
		{
			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x060047DD RID: 18397 RVA: 0x001690EC File Offset: 0x001672EC
			[Token(Token = "0x17000874")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60047DD")]
				[Address(RVA = "0x7E8B30", Offset = "0x7E7130", VA = "0x1807E8B30", Slot = "4")]
				get
				{
					return PlantType.UltimateMelon;
				}
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x060047DE RID: 18398 RVA: 0x00169100 File Offset: 0x00167300
			[Token(Token = "0x17000875")]
			public override string Title
			{
				[Token(Token = "0x60047DE")]
				[Address(RVA = "0x8B8710", Offset = "0x8B6D10", VA = "0x1808B8710", Slot = "5")]
				get
				{
					return "质变：蒜毒骤发";
				}
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x060047DF RID: 18399 RVA: 0x00169114 File Offset: 0x00167314
			[Token(Token = "0x17000876")]
			public override string Description
			{
				[Token(Token = "0x60047DF")]
				[Address(RVA = "0x8B8650", Offset = "0x8B6C50", VA = "0x1808B8650", Slot = "6")]
				get
				{
					return "获得2级词条：蒜毒骤发";
				}
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x060047E0 RID: 18400 RVA: 0x00169128 File Offset: 0x00167328
			[Token(Token = "0x17000877")]
			public override Quality Rarity
			{
				[Token(Token = "0x60047E0")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x060047E1 RID: 18401 RVA: 0x00169138 File Offset: 0x00167338
			[Token(Token = "0x17000878")]
			public override int MaxCount
			{
				[Token(Token = "0x60047E1")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x060047E2 RID: 18402 RVA: 0x00169148 File Offset: 0x00167348
			[Token(Token = "0x17000879")]
			public override float AppearWeight
			{
				[Token(Token = "0x60047E2")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x060047E3 RID: 18403 RVA: 0x0016915C File Offset: 0x0016735C
			[Token(Token = "0x1700087A")]
			public override bool CanAppear
			{
				[Token(Token = "0x60047E3")]
				[Address(RVA = "0x8B68E0", Offset = "0x8B4EE0", VA = "0x1808B68E0", Slot = "9")]
				get
				{
					return Lawnf.TravelUltimate((UltiBuff)((uint)13));
				}
			}

			// Token: 0x060047E4 RID: 18404 RVA: 0x00169174 File Offset: 0x00167374
			[Token(Token = "0x60047E4")]
			[Address(RVA = "0x8B83E0", Offset = "0x8B69E0", VA = "0x1808B83E0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetUltiBuff((UltiBuff)((uint)13), true);
			}

			// Token: 0x060047E5 RID: 18405 RVA: 0x00169198 File Offset: 0x00167398
			[Token(Token = "0x60047E5")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperUpgrade()
			{
			}
		}
	}
}
