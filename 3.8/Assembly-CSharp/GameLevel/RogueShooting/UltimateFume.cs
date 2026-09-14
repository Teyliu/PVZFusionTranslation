using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C4B RID: 3147
	[Token(Token = "0x2000C4B")]
	public class UltimateFume : BaseConfig
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x00157D48 File Offset: 0x00155F48
		[Token(Token = "0x170005C4")]
		public override string Role
		{
			[Token(Token = "0x60041D8")]
			[Address(RVA = "0x841FF0", Offset = "0x8405F0", VA = "0x180841FF0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x00157D5C File Offset: 0x00155F5C
		[Token(Token = "0x170005C5")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041D9")]
			[Address(RVA = "0x82E580", Offset = "0x82CB80", VA = "0x18082E580", Slot = "4")]
			get
			{
				return PlantType.UltimateFume;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x00157D70 File Offset: 0x00155F70
		[Token(Token = "0x170005C6")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041DA")]
			[Address(RVA = "0x841CC0", Offset = "0x8402C0", VA = "0x180841CC0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				StarUpBuff starUpBuff;
				starUpBuff.targetType = (PlantType)((ulong)904L);
				int size3 = list._size;
				UltimateFume.UniqueUpgrade uniqueUpgrade = new UltimateFume.UniqueUpgrade();
				int size4 = list._size;
				UltimateFume.BuffUpgrade buffUpgrade = new UltimateFume.BuffUpgrade();
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x00157DE0 File Offset: 0x00155FE0
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x841290", Offset = "0x83F890", VA = "0x180841290", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 3f, num2 != 0, num);
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x00157E08 File Offset: 0x00156008
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateFume()
		{
		}

		// Token: 0x02000C4C RID: 3148
		[Token(Token = "0x2000C4C")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170005C7 RID: 1479
			// (get) Token: 0x060041DD RID: 16861 RVA: 0x00157E1C File Offset: 0x0015601C
			[Token(Token = "0x170005C7")]
			public override string Title
			{
				[Token(Token = "0x60041DD")]
				[Address(RVA = "0x846A40", Offset = "0x845040", VA = "0x180846A40", Slot = "5")]
				get
				{
					return "强化：冰刺";
				}
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x060041DE RID: 16862 RVA: 0x00157E30 File Offset: 0x00156030
			[Token(Token = "0x170005C8")]
			public override string Description
			{
				[Token(Token = "0x60041DE")]
				[Address(RVA = "0x8462E0", Offset = "0x8448E0", VA = "0x1808462E0", Slot = "6")]
				get
				{
					return base.PlantName + "每次攻击额外发射一枚黑冰刺";
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x060041DF RID: 16863 RVA: 0x00157E50 File Offset: 0x00156050
			[Token(Token = "0x170005C9")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60041DF")]
				[Address(RVA = "0x82E580", Offset = "0x82CB80", VA = "0x18082E580", Slot = "4")]
				get
				{
					return PlantType.UltimateFume;
				}
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x060041E0 RID: 16864 RVA: 0x00157E64 File Offset: 0x00156064
			[Token(Token = "0x170005CA")]
			public override float AppearWeight
			{
				[Token(Token = "0x60041E0")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x060041E1 RID: 16865 RVA: 0x00157E78 File Offset: 0x00156078
			[Token(Token = "0x170005CB")]
			public override int MaxCount
			{
				[Token(Token = "0x60041E1")]
				[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x060041E2 RID: 16866 RVA: 0x00157E88 File Offset: 0x00156088
			[Token(Token = "0x60041E2")]
			[Address(RVA = "0x845300", Offset = "0x843900", VA = "0x180845300", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = UltimateFume.UniqueUpgrade.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					UltimateFume.UniqueUpgrade.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x060041E3 RID: 16867 RVA: 0x00157EB4 File Offset: 0x001560B4
			[Token(Token = "0x170005CC")]
			public override Quality Rarity
			{
				[Token(Token = "0x60041E3")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060041E4 RID: 16868 RVA: 0x00157EC4 File Offset: 0x001560C4
			[Token(Token = "0x60041E4")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C4E RID: 3150
		[Token(Token = "0x2000C4E")]
		private class BuffUpgrade : BaseBuff
		{
			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x060041E8 RID: 16872 RVA: 0x00157ED8 File Offset: 0x001560D8
			[Token(Token = "0x170005CD")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60041E8")]
				[Address(RVA = "0x82E580", Offset = "0x82CB80", VA = "0x18082E580", Slot = "4")]
				get
				{
					return PlantType.UltimateFume;
				}
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x060041E9 RID: 16873 RVA: 0x00157EEC File Offset: 0x001560EC
			[Token(Token = "0x170005CE")]
			public override string Title
			{
				[Token(Token = "0x60041E9")]
				[Address(RVA = "0x82E590", Offset = "0x82CB90", VA = "0x18082E590", Slot = "5")]
				get
				{
					return "质变：凛风刺骨";
				}
			}

			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x060041EA RID: 16874 RVA: 0x00157F00 File Offset: 0x00156100
			[Token(Token = "0x170005CF")]
			public override string Description
			{
				[Token(Token = "0x60041EA")]
				[Address(RVA = "0x82E550", Offset = "0x82CB50", VA = "0x18082E550", Slot = "6")]
				get
				{
					return "获得旅行词条：凛风刺骨";
				}
			}

			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x060041EB RID: 16875 RVA: 0x00157F14 File Offset: 0x00156114
			[Token(Token = "0x170005D0")]
			public override Quality Rarity
			{
				[Token(Token = "0x60041EB")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x060041EC RID: 16876 RVA: 0x00157F24 File Offset: 0x00156124
			[Token(Token = "0x170005D1")]
			public override int MaxCount
			{
				[Token(Token = "0x60041EC")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x060041ED RID: 16877 RVA: 0x00157F34 File Offset: 0x00156134
			[Token(Token = "0x170005D2")]
			public override float AppearWeight
			{
				[Token(Token = "0x60041ED")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060041EE RID: 16878 RVA: 0x00157F48 File Offset: 0x00156148
			[Token(Token = "0x60041EE")]
			[Address(RVA = "0x82E4F0", Offset = "0x82CAF0", VA = "0x18082E4F0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				int num = 0;
				instance.GetUltiBuff((UltiBuff)((uint)4), num != 0);
			}

			// Token: 0x060041EF RID: 16879 RVA: 0x00157F70 File Offset: 0x00156170
			[Token(Token = "0x60041EF")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public BuffUpgrade()
			{
			}
		}
	}
}
