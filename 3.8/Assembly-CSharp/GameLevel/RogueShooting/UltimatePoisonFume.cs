using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C50 RID: 3152
	[Token(Token = "0x2000C50")]
	public class UltimatePoisonFume : BaseConfig
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x0015803C File Offset: 0x0015623C
		[Token(Token = "0x170005D6")]
		public override string Role
		{
			[Token(Token = "0x60041F5")]
			[Address(RVA = "0x843950", Offset = "0x841F50", VA = "0x180843950", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x00158050 File Offset: 0x00156250
		[Token(Token = "0x170005D7")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041F6")]
			[Address(RVA = "0x83A400", Offset = "0x838A00", VA = "0x18083A400", Slot = "4")]
			get
			{
				return PlantType.UltimatePoisonFume;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x00158064 File Offset: 0x00156264
		[Token(Token = "0x170005D8")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041F7")]
			[Address(RVA = "0x8436A0", Offset = "0x841CA0", VA = "0x1808436A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimatePoisonFume.UniqueBuff uniqueBuff = new UltimatePoisonFume.UniqueBuff();
				int size3 = list._size;
				UltimatePoisonFume.SuperBuff superBuff = new UltimatePoisonFume.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x001580BC File Offset: 0x001562BC
		[Token(Token = "0x60041F8")]
		[Address(RVA = "0x843660", Offset = "0x841C60", VA = "0x180843660", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), -0.75f, num2 != 0, num);
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x001580E4 File Offset: 0x001562E4
		[Token(Token = "0x60041F9")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimatePoisonFume()
		{
		}

		// Token: 0x02000C51 RID: 3153
		[Token(Token = "0x2000C51")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x060041FA RID: 16890 RVA: 0x001580F8 File Offset: 0x001562F8
			[Token(Token = "0x170005D9")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60041FA")]
				[Address(RVA = "0x83A400", Offset = "0x838A00", VA = "0x18083A400", Slot = "4")]
				get
				{
					return PlantType.UltimatePoisonFume;
				}
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x060041FB RID: 16891 RVA: 0x0015810C File Offset: 0x0015630C
			[Token(Token = "0x170005DA")]
			public override string Title
			{
				[Token(Token = "0x60041FB")]
				[Address(RVA = "0x8452A0", Offset = "0x8438A0", VA = "0x1808452A0", Slot = "5")]
				get
				{
					return "强化：剧毒";
				}
			}

			// Token: 0x170005DB RID: 1499
			// (get) Token: 0x060041FC RID: 16892 RVA: 0x00158120 File Offset: 0x00156320
			[Token(Token = "0x170005DB")]
			public override string Description
			{
				[Token(Token = "0x60041FC")]
				[Address(RVA = "0x8451B0", Offset = "0x8437B0", VA = "0x1808451B0", Slot = "6")]
				get
				{
					return "子弹发射数+1";
				}
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x060041FD RID: 16893 RVA: 0x00158134 File Offset: 0x00156334
			[Token(Token = "0x170005DC")]
			public override Quality Rarity
			{
				[Token(Token = "0x60041FD")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x060041FE RID: 16894 RVA: 0x00158144 File Offset: 0x00156344
			[Token(Token = "0x170005DD")]
			public override float AppearWeight
			{
				[Token(Token = "0x60041FE")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060041FF RID: 16895 RVA: 0x00158158 File Offset: 0x00156358
			[Token(Token = "0x60041FF")]
			[Address(RVA = "0x844FF0", Offset = "0x8435F0", VA = "0x180844FF0", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x06004200 RID: 16896 RVA: 0x00158188 File Offset: 0x00156388
			[Token(Token = "0x6004200")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueBuff()
			{
			}
		}

		// Token: 0x02000C52 RID: 3154
		[Token(Token = "0x2000C52")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x06004201 RID: 16897 RVA: 0x0015819C File Offset: 0x0015639C
			[Token(Token = "0x170005DE")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004201")]
				[Address(RVA = "0x83A400", Offset = "0x838A00", VA = "0x18083A400", Slot = "4")]
				get
				{
					return PlantType.UltimatePoisonFume;
				}
			}

			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x06004202 RID: 16898 RVA: 0x001581B0 File Offset: 0x001563B0
			[Token(Token = "0x170005DF")]
			public override string Title
			{
				[Token(Token = "0x6004202")]
				[Address(RVA = "0x83A4F0", Offset = "0x838AF0", VA = "0x18083A4F0", Slot = "5")]
				get
				{
					return "质变：蒜毒骤发";
				}
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x06004203 RID: 16899 RVA: 0x001581C4 File Offset: 0x001563C4
			[Token(Token = "0x170005E0")]
			public override string Description
			{
				[Token(Token = "0x6004203")]
				[Address(RVA = "0x83A0E0", Offset = "0x8386E0", VA = "0x18083A0E0", Slot = "6")]
				get
				{
					return "获得2级词条：蒜毒骤发";
				}
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x06004204 RID: 16900 RVA: 0x001581D8 File Offset: 0x001563D8
			[Token(Token = "0x170005E1")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004204")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x06004205 RID: 16901 RVA: 0x001581E8 File Offset: 0x001563E8
			[Token(Token = "0x170005E2")]
			public override int MaxCount
			{
				[Token(Token = "0x6004205")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x06004206 RID: 16902 RVA: 0x001581F8 File Offset: 0x001563F8
			[Token(Token = "0x170005E3")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004206")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x06004207 RID: 16903 RVA: 0x0015820C File Offset: 0x0015640C
			[Token(Token = "0x170005E4")]
			public override bool CanAppear
			{
				[Token(Token = "0x6004207")]
				[Address(RVA = "0x839E10", Offset = "0x838410", VA = "0x180839E10", Slot = "9")]
				get
				{
					return Lawnf.TravelUltimate((UltiBuff)((uint)13));
				}
			}

			// Token: 0x06004208 RID: 16904 RVA: 0x00158224 File Offset: 0x00156424
			[Token(Token = "0x6004208")]
			[Address(RVA = "0x839C70", Offset = "0x838270", VA = "0x180839C70", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetUltiBuff((UltiBuff)((uint)13), true);
			}

			// Token: 0x06004209 RID: 16905 RVA: 0x00158248 File Offset: 0x00156448
			[Token(Token = "0x6004209")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
