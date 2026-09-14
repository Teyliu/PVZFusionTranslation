using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CE8 RID: 3304
	[Token(Token = "0x2000CE8")]
	public class MagicSnowPea2 : BaseConfig
	{
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x00163230 File Offset: 0x00161430
		[Token(Token = "0x17000670")]
		public override string Role
		{
			[Token(Token = "0x6004490")]
			[Address(RVA = "0x8AF290", Offset = "0x8AD890", VA = "0x1808AF290", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x00163244 File Offset: 0x00161444
		[Token(Token = "0x17000671")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004491")]
			[Address(RVA = "0x3F2DB0", Offset = "0x3F13B0", VA = "0x1803F2DB0", Slot = "4")]
			get
			{
				return PlantType.MagicSnowPea2;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x00163258 File Offset: 0x00161458
		[Token(Token = "0x17000672")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004492")]
			[Address(RVA = "0x8AEF60", Offset = "0x8AD560", VA = "0x1808AEF60", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				MagicSnowPea2.UniqueUpgrade uniqueUpgrade = new MagicSnowPea2.UniqueUpgrade();
				int size3 = list._size;
				MagicSnowPea2.SuperUpgrade superUpgrade = new MagicSnowPea2.SuperUpgrade();
				int size4 = list._size;
				MagicSnowPea2.SuperUpgrade2 superUpgrade2 = new MagicSnowPea2.SuperUpgrade2();
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x001632C0 File Offset: 0x001614C0
		[Token(Token = "0x6004493")]
		[Address(RVA = "0x8AEF10", Offset = "0x8AD510", VA = "0x1808AEF10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.thePlantAttackInterval = 0.75f;
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x001632F4 File Offset: 0x001614F4
		[Token(Token = "0x6004494")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public MagicSnowPea2()
		{
		}

		// Token: 0x02000CE9 RID: 3305
		[Token(Token = "0x2000CE9")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x06004495 RID: 17557 RVA: 0x00163308 File Offset: 0x00161508
			[Token(Token = "0x17000673")]
			public override string Title
			{
				[Token(Token = "0x6004495")]
				[Address(RVA = "0x8C6CF0", Offset = "0x8C52F0", VA = "0x1808C6CF0", Slot = "5")]
				get
				{
					return "强化：解读";
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x06004496 RID: 17558 RVA: 0x0016331C File Offset: 0x0016151C
			[Token(Token = "0x17000674")]
			public override string Description
			{
				[Token(Token = "0x6004496")]
				[Address(RVA = "0x8C6560", Offset = "0x8C4B60", VA = "0x1808C6560", Slot = "6")]
				get
				{
					return base.PlantName + "攻击僵尸时有4%概率施加一层“解读”标记。若弹射击中已标记的僵尸，则会消耗此标记，使本次弹射次数+1。多选每次提高4%概率";
				}
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x06004497 RID: 17559 RVA: 0x0016333C File Offset: 0x0016153C
			[Token(Token = "0x17000675")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004497")]
				[Address(RVA = "0x3F2DB0", Offset = "0x3F13B0", VA = "0x1803F2DB0", Slot = "4")]
				get
				{
					return PlantType.MagicSnowPea2;
				}
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x06004498 RID: 17560 RVA: 0x00163350 File Offset: 0x00161550
			[Token(Token = "0x17000676")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004498")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004499 RID: 17561 RVA: 0x00163364 File Offset: 0x00161564
			[Token(Token = "0x6004499")]
			[Address(RVA = "0x8C63D0", Offset = "0x8C49D0", VA = "0x1808C63D0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = MagicSnowPea2.UniqueUpgrade.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					MagicSnowPea2.UniqueUpgrade.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x0600449A RID: 17562 RVA: 0x00163390 File Offset: 0x00161590
			[Token(Token = "0x17000677")]
			public override Quality Rarity
			{
				[Token(Token = "0x600449A")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600449B RID: 17563 RVA: 0x001633A0 File Offset: 0x001615A0
			[Token(Token = "0x600449B")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000CEB RID: 3307
		[Token(Token = "0x2000CEB")]
		private class SuperUpgrade : BaseBuff
		{
			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x0600449F RID: 17567 RVA: 0x001633B4 File Offset: 0x001615B4
			[Token(Token = "0x17000678")]
			public override string Title
			{
				[Token(Token = "0x600449F")]
				[Address(RVA = "0x8B86B0", Offset = "0x8B6CB0", VA = "0x1808B86B0", Slot = "5")]
				get
				{
					return "质变：魔力升级";
				}
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x060044A0 RID: 17568 RVA: 0x001633C8 File Offset: 0x001615C8
			[Token(Token = "0x17000679")]
			public override string Description
			{
				[Token(Token = "0x60044A0")]
				[Address(RVA = "0x8B8620", Offset = "0x8B6C20", VA = "0x1808B8620", Slot = "6")]
				get
				{
					return "获得词条：魔力升级II\n获得词条：举世无双";
				}
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x060044A1 RID: 17569 RVA: 0x001633DC File Offset: 0x001615DC
			[Token(Token = "0x1700067A")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60044A1")]
				[Address(RVA = "0x3F2DB0", Offset = "0x3F13B0", VA = "0x1803F2DB0", Slot = "4")]
				get
				{
					return PlantType.MagicSnowPea2;
				}
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x060044A2 RID: 17570 RVA: 0x001633F0 File Offset: 0x001615F0
			[Token(Token = "0x1700067B")]
			public override float AppearWeight
			{
				[Token(Token = "0x60044A2")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x060044A3 RID: 17571 RVA: 0x00163404 File Offset: 0x00161604
			[Token(Token = "0x1700067C")]
			public override int MaxCount
			{
				[Token(Token = "0x60044A3")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x060044A4 RID: 17572 RVA: 0x00163414 File Offset: 0x00161614
			[Token(Token = "0x60044A4")]
			[Address(RVA = "0x8B8300", Offset = "0x8B6900", VA = "0x1808B8300", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1022));
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)44));
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x060044A5 RID: 17573 RVA: 0x00163448 File Offset: 0x00161648
			[Token(Token = "0x1700067D")]
			public override Quality Rarity
			{
				[Token(Token = "0x60044A5")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x060044A6 RID: 17574 RVA: 0x00163458 File Offset: 0x00161658
			[Token(Token = "0x60044A6")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperUpgrade()
			{
			}
		}

		// Token: 0x02000CEC RID: 3308
		[Token(Token = "0x2000CEC")]
		private class SuperUpgrade2 : BaseBuff
		{
			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x060044A7 RID: 17575 RVA: 0x0016346C File Offset: 0x0016166C
			[Token(Token = "0x1700067E")]
			public override string Title
			{
				[Token(Token = "0x60044A7")]
				[Address(RVA = "0x8B82D0", Offset = "0x8B68D0", VA = "0x1808B82D0", Slot = "5")]
				get
				{
					return "质变：拿来吧你";
				}
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x060044A8 RID: 17576 RVA: 0x00163480 File Offset: 0x00161680
			[Token(Token = "0x1700067F")]
			public override string Description
			{
				[Token(Token = "0x60044A8")]
				[Address(RVA = "0x8B8250", Offset = "0x8B6850", VA = "0x1808B8250", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12016];
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x060044A9 RID: 17577 RVA: 0x001634A4 File Offset: 0x001616A4
			[Token(Token = "0x17000680")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60044A9")]
				[Address(RVA = "0x3F2DB0", Offset = "0x3F13B0", VA = "0x1803F2DB0", Slot = "4")]
				get
				{
					return PlantType.MagicSnowPea2;
				}
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x060044AA RID: 17578 RVA: 0x001634B8 File Offset: 0x001616B8
			[Token(Token = "0x17000681")]
			public override float AppearWeight
			{
				[Token(Token = "0x60044AA")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x060044AB RID: 17579 RVA: 0x001634CC File Offset: 0x001616CC
			[Token(Token = "0x17000682")]
			public override int MaxCount
			{
				[Token(Token = "0x60044AB")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x060044AC RID: 17580 RVA: 0x001634DC File Offset: 0x001616DC
			[Token(Token = "0x17000683")]
			public override bool Passive
			{
				[Token(Token = "0x60044AC")]
				[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x060044AD RID: 17581 RVA: 0x001634EC File Offset: 0x001616EC
			[Token(Token = "0x60044AD")]
			[Address(RVA = "0x8B7F40", Offset = "0x8B6540", VA = "0x1808B7F40", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				if (MagicSnowPea2.SuperUpgrade2.<>c.<>9__12_0 == 0)
				{
					Action<object> action;
					MagicSnowPea2.SuperUpgrade2.<>c.<>9__12_0 = action;
				}
				if (MagicSnowPea2.SuperUpgrade2.<>c.<>9__12_1 == 0)
				{
					MagicSnowPea2.SuperUpgrade2.<>c.<>9__12_1 = delegate
					{
					};
				}
				if (MagicSnowPea2.SuperUpgrade2.<>c.<>9__12_2 == 0)
				{
					Action<object> action2;
					MagicSnowPea2.SuperUpgrade2.<>c.<>9__12_2 = action2;
				}
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x060044AE RID: 17582 RVA: 0x00163544 File Offset: 0x00161744
			[Token(Token = "0x17000684")]
			public override Quality Rarity
			{
				[Token(Token = "0x60044AE")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x060044AF RID: 17583 RVA: 0x00163554 File Offset: 0x00161754
			[Token(Token = "0x60044AF")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperUpgrade2()
			{
			}
		}
	}
}
