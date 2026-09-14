using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CDB RID: 3291
	[Token(Token = "0x2000CDB")]
	public class UltimateLanternSplit : BaseConfig
	{
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x00162AA0 File Offset: 0x00160CA0
		[Token(Token = "0x1700063F")]
		public override string Role
		{
			[Token(Token = "0x6004443")]
			[Address(RVA = "0x8C2E40", Offset = "0x8C1440", VA = "0x1808C2E40", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x00162AB4 File Offset: 0x00160CB4
		[Token(Token = "0x17000640")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004444")]
			[Address(RVA = "0x7E89A0", Offset = "0x7E6FA0", VA = "0x1807E89A0", Slot = "4")]
			get
			{
				return PlantType.UltimateLanternSplit;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x00162AC8 File Offset: 0x00160CC8
		[Token(Token = "0x17000641")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004445")]
			[Address(RVA = "0x8C2B90", Offset = "0x8C1190", VA = "0x1808C2B90", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateLanternSplit.UniqueUpgrade uniqueUpgrade = new UltimateLanternSplit.UniqueUpgrade();
				int size3 = list._size;
				UltimateLanternSplit.SuperBuff superBuff = new UltimateLanternSplit.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00162B20 File Offset: 0x00160D20
		[Token(Token = "0x6004446")]
		[Address(RVA = "0x8C2B30", Offset = "0x8C1130", VA = "0x1808C2B30", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			float attributeFloat = plant.attributeFloat;
			plant.attributeFloat = attributeFloat;
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00162B44 File Offset: 0x00160D44
		[Token(Token = "0x6004447")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateLanternSplit()
		{
		}

		// Token: 0x02000CDC RID: 3292
		[Token(Token = "0x2000CDC")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x06004448 RID: 17480 RVA: 0x00162B58 File Offset: 0x00160D58
			[Token(Token = "0x17000642")]
			public override string Title
			{
				[Token(Token = "0x6004448")]
				[Address(RVA = "0x8C6FC0", Offset = "0x8C55C0", VA = "0x1808C6FC0", Slot = "5")]
				get
				{
					return "强化：天网";
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x06004449 RID: 17481 RVA: 0x00162B6C File Offset: 0x00160D6C
			[Token(Token = "0x17000643")]
			public override string Description
			{
				[Token(Token = "0x6004449")]
				[Address(RVA = "0x8C6720", Offset = "0x8C4D20", VA = "0x1808C6720", Slot = "6")]
				get
				{
					return base.PlantName + "在前方生成一束天网攻击僵尸";
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x0600444A RID: 17482 RVA: 0x00162B8C File Offset: 0x00160D8C
			[Token(Token = "0x17000644")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600444A")]
				[Address(RVA = "0x7E89A0", Offset = "0x7E6FA0", VA = "0x1807E89A0", Slot = "4")]
				get
				{
					return PlantType.UltimateLanternSplit;
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x0600444B RID: 17483 RVA: 0x00162BA0 File Offset: 0x00160DA0
			[Token(Token = "0x17000645")]
			public override float AppearWeight
			{
				[Token(Token = "0x600444B")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x0600444C RID: 17484 RVA: 0x00162BB4 File Offset: 0x00160DB4
			[Token(Token = "0x17000646")]
			public override int MaxCount
			{
				[Token(Token = "0x600444C")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x0600444D RID: 17485 RVA: 0x00162BC4 File Offset: 0x00160DC4
			[Token(Token = "0x600444D")]
			[Address(RVA = "0x8C6300", Offset = "0x8C4900", VA = "0x1808C6300", Slot = "7")]
			public override void OnGet()
			{
				int num = 0;
				if (ShootingManager.Instance.TryGetPlant((PlantType)((uint)984), num))
				{
				}
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x0600444E RID: 17486 RVA: 0x00162BF0 File Offset: 0x00160DF0
			[Token(Token = "0x17000647")]
			public override Quality Rarity
			{
				[Token(Token = "0x600444E")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600444F RID: 17487 RVA: 0x00162C00 File Offset: 0x00160E00
			[Token(Token = "0x600444F")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000CDD RID: 3293
		[Token(Token = "0x2000CDD")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x06004450 RID: 17488 RVA: 0x00162C14 File Offset: 0x00160E14
			[Token(Token = "0x17000648")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004450")]
				[Address(RVA = "0x7E89A0", Offset = "0x7E6FA0", VA = "0x1807E89A0", Slot = "4")]
				get
				{
					return PlantType.UltimateLanternSplit;
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x06004451 RID: 17489 RVA: 0x00162C28 File Offset: 0x00160E28
			[Token(Token = "0x17000649")]
			public override string Title
			{
				[Token(Token = "0x6004451")]
				[Address(RVA = "0x8B7300", Offset = "0x8B5900", VA = "0x1808B7300", Slot = "5")]
				get
				{
					return "质变：湮灭之核";
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x06004452 RID: 17490 RVA: 0x00162C3C File Offset: 0x00160E3C
			[Token(Token = "0x1700064A")]
			public override string Description
			{
				[Token(Token = "0x6004452")]
				[Address(RVA = "0x8B70C0", Offset = "0x8B56C0", VA = "0x1808B70C0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12010];
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x06004453 RID: 17491 RVA: 0x00162C60 File Offset: 0x00160E60
			[Token(Token = "0x1700064B")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004453")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x06004454 RID: 17492 RVA: 0x00162C70 File Offset: 0x00160E70
			[Token(Token = "0x1700064C")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004454")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x06004455 RID: 17493 RVA: 0x00162C84 File Offset: 0x00160E84
			[Token(Token = "0x1700064D")]
			public override int MaxCount
			{
				[Token(Token = "0x6004455")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x06004456 RID: 17494 RVA: 0x00162C94 File Offset: 0x00160E94
			[Token(Token = "0x6004456")]
			[Address(RVA = "0x8B6560", Offset = "0x8B4B60", VA = "0x1808B6560", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12010));
			}

			// Token: 0x06004457 RID: 17495 RVA: 0x00162CBC File Offset: 0x00160EBC
			[Token(Token = "0x6004457")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
