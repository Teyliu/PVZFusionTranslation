using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C3D RID: 3133
	[Token(Token = "0x2000C3D")]
	public class UltimateBigChomper : BaseConfig
	{
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x00157440 File Offset: 0x00155640
		[Token(Token = "0x17000592")]
		public override string Role
		{
			[Token(Token = "0x6004189")]
			[Address(RVA = "0x840340", Offset = "0x83E940", VA = "0x180840340", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x00157454 File Offset: 0x00155654
		[Token(Token = "0x17000593")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600418A")]
			[Address(RVA = "0x780C90", Offset = "0x77F290", VA = "0x180780C90", Slot = "4")]
			get
			{
				return PlantType.UltimateBigChomper;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x00157468 File Offset: 0x00155668
		[Token(Token = "0x17000594")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600418B")]
			[Address(RVA = "0x840120", Offset = "0x83E720", VA = "0x180840120", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				UltimateBigChomper.UniqueUpgrade uniqueUpgrade = new UltimateBigChomper.UniqueUpgrade();
				int size2 = list._size;
				UltimateBigChomper.SuperBuff superBuff = new UltimateBigChomper.SuperBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x001574B4 File Offset: 0x001556B4
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x840080", Offset = "0x83E680", VA = "0x180840080", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x001574D8 File Offset: 0x001556D8
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateBigChomper()
		{
		}

		// Token: 0x02000C3E RID: 3134
		[Token(Token = "0x2000C3E")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000595 RID: 1429
			// (get) Token: 0x0600418E RID: 16782 RVA: 0x001574EC File Offset: 0x001556EC
			[Token(Token = "0x17000595")]
			public override string Title
			{
				[Token(Token = "0x600418E")]
				[Address(RVA = "0x846A10", Offset = "0x845010", VA = "0x180846A10", Slot = "5")]
				get
				{
					return "强化：范围";
				}
			}

			// Token: 0x17000596 RID: 1430
			// (get) Token: 0x0600418F RID: 16783 RVA: 0x00157500 File Offset: 0x00155700
			[Token(Token = "0x17000596")]
			public override string Description
			{
				[Token(Token = "0x600418F")]
				[Address(RVA = "0x8464C0", Offset = "0x844AC0", VA = "0x1808464C0", Slot = "6")]
				get
				{
					return base.PlantName + "范围+1";
				}
			}

			// Token: 0x17000597 RID: 1431
			// (get) Token: 0x06004190 RID: 16784 RVA: 0x00157520 File Offset: 0x00155720
			[Token(Token = "0x17000597")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004190")]
				[Address(RVA = "0x780C90", Offset = "0x77F290", VA = "0x180780C90", Slot = "4")]
				get
				{
					return PlantType.UltimateBigChomper;
				}
			}

			// Token: 0x06004191 RID: 16785 RVA: 0x00157534 File Offset: 0x00155734
			[Token(Token = "0x6004191")]
			[Address(RVA = "0x8458C0", Offset = "0x843EC0", VA = "0x1808458C0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x06004192 RID: 16786 RVA: 0x00157554 File Offset: 0x00155754
			[Token(Token = "0x17000598")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004192")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004193 RID: 16787 RVA: 0x00157564 File Offset: 0x00155764
			[Token(Token = "0x6004193")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C3F RID: 3135
		[Token(Token = "0x2000C3F")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x06004194 RID: 16788 RVA: 0x00157578 File Offset: 0x00155778
			[Token(Token = "0x17000599")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004194")]
				[Address(RVA = "0x780C90", Offset = "0x77F290", VA = "0x180780C90", Slot = "4")]
				get
				{
					return PlantType.UltimateBigChomper;
				}
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x06004195 RID: 16789 RVA: 0x0015758C File Offset: 0x0015578C
			[Token(Token = "0x1700059A")]
			public override string Title
			{
				[Token(Token = "0x6004195")]
				[Address(RVA = "0x83A520", Offset = "0x838B20", VA = "0x18083A520", Slot = "5")]
				get
				{
					return "质变：吞噬";
				}
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x06004196 RID: 16790 RVA: 0x001575A0 File Offset: 0x001557A0
			[Token(Token = "0x1700059B")]
			public override string Description
			{
				[Token(Token = "0x6004196")]
				[Address(RVA = "0x83A1A0", Offset = "0x8387A0", VA = "0x18083A1A0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12009];
				}
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x06004197 RID: 16791 RVA: 0x001575C4 File Offset: 0x001557C4
			[Token(Token = "0x1700059C")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004197")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x06004198 RID: 16792 RVA: 0x001575D4 File Offset: 0x001557D4
			[Token(Token = "0x1700059D")]
			public override int MaxCount
			{
				[Token(Token = "0x6004198")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x06004199 RID: 16793 RVA: 0x001575E4 File Offset: 0x001557E4
			[Token(Token = "0x1700059E")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004199")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600419A RID: 16794 RVA: 0x001575F8 File Offset: 0x001557F8
			[Token(Token = "0x600419A")]
			[Address(RVA = "0x839A90", Offset = "0x838090", VA = "0x180839A90", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12009));
			}

			// Token: 0x0600419B RID: 16795 RVA: 0x00157620 File Offset: 0x00155820
			[Token(Token = "0x600419B")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
