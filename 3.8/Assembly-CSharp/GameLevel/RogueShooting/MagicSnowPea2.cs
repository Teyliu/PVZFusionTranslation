using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C24 RID: 3108
	[Token(Token = "0x2000C24")]
	public class MagicSnowPea2 : BaseConfig
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x001563E4 File Offset: 0x001545E4
		[Token(Token = "0x17000533")]
		public override string Role
		{
			[Token(Token = "0x60040F1")]
			[Address(RVA = "0x833D20", Offset = "0x832320", VA = "0x180833D20", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060040F2 RID: 16626 RVA: 0x001563F8 File Offset: 0x001545F8
		[Token(Token = "0x17000534")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60040F2")]
			[Address(RVA = "0x3A6E50", Offset = "0x3A5450", VA = "0x1803A6E50", Slot = "4")]
			get
			{
				return PlantType.MagicSnowPea2;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x0015640C File Offset: 0x0015460C
		[Token(Token = "0x17000535")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60040F3")]
			[Address(RVA = "0x8339F0", Offset = "0x831FF0", VA = "0x1808339F0", Slot = "5")]
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

		// Token: 0x060040F4 RID: 16628 RVA: 0x00156474 File Offset: 0x00154674
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x8339A0", Offset = "0x831FA0", VA = "0x1808339A0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.thePlantAttackInterval = 0.75f;
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x001564A8 File Offset: 0x001546A8
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public MagicSnowPea2()
		{
		}

		// Token: 0x02000C25 RID: 3109
		[Token(Token = "0x2000C25")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000536 RID: 1334
			// (get) Token: 0x060040F6 RID: 16630 RVA: 0x001564BC File Offset: 0x001546BC
			[Token(Token = "0x17000536")]
			public override string Title
			{
				[Token(Token = "0x60040F6")]
				[Address(RVA = "0x846740", Offset = "0x844D40", VA = "0x180846740", Slot = "5")]
				get
				{
					return "强化：解读";
				}
			}

			// Token: 0x17000537 RID: 1335
			// (get) Token: 0x060040F7 RID: 16631 RVA: 0x001564D0 File Offset: 0x001546D0
			[Token(Token = "0x17000537")]
			public override string Description
			{
				[Token(Token = "0x60040F7")]
				[Address(RVA = "0x846030", Offset = "0x844630", VA = "0x180846030", Slot = "6")]
				get
				{
					return base.PlantName + "攻击僵尸时有几率施加一层“解读”标记。若弹射击中已标记的僵尸，则会消耗此标记，使本次弹射次数+1。多选提高概率";
				}
			}

			// Token: 0x17000538 RID: 1336
			// (get) Token: 0x060040F8 RID: 16632 RVA: 0x001564F0 File Offset: 0x001546F0
			[Token(Token = "0x17000538")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60040F8")]
				[Address(RVA = "0x3A6E50", Offset = "0x3A5450", VA = "0x1803A6E50", Slot = "4")]
				get
				{
					return PlantType.MagicSnowPea2;
				}
			}

			// Token: 0x17000539 RID: 1337
			// (get) Token: 0x060040F9 RID: 16633 RVA: 0x00156504 File Offset: 0x00154704
			[Token(Token = "0x17000539")]
			public override float AppearWeight
			{
				[Token(Token = "0x60040F9")]
				[Address(RVA = "0x845090", Offset = "0x843690", VA = "0x180845090", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060040FA RID: 16634 RVA: 0x00156518 File Offset: 0x00154718
			[Token(Token = "0x60040FA")]
			[Address(RVA = "0x845EA0", Offset = "0x8444A0", VA = "0x180845EA0", Slot = "7")]
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

			// Token: 0x1700053A RID: 1338
			// (get) Token: 0x060040FB RID: 16635 RVA: 0x00156544 File Offset: 0x00154744
			[Token(Token = "0x1700053A")]
			public override int MaxCount
			{
				[Token(Token = "0x60040FB")]
				[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
				get
				{
					return 5;
				}
			}

			// Token: 0x1700053B RID: 1339
			// (get) Token: 0x060040FC RID: 16636 RVA: 0x00156554 File Offset: 0x00154754
			[Token(Token = "0x1700053B")]
			public override Quality Rarity
			{
				[Token(Token = "0x60040FC")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060040FD RID: 16637 RVA: 0x00156564 File Offset: 0x00154764
			[Token(Token = "0x60040FD")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C27 RID: 3111
		[Token(Token = "0x2000C27")]
		private class SuperUpgrade : BaseBuff
		{
			// Token: 0x1700053C RID: 1340
			// (get) Token: 0x06004101 RID: 16641 RVA: 0x00156578 File Offset: 0x00154778
			[Token(Token = "0x1700053C")]
			public override string Title
			{
				[Token(Token = "0x6004101")]
				[Address(RVA = "0x83B500", Offset = "0x839B00", VA = "0x18083B500", Slot = "5")]
				get
				{
					return "质变：魔力升级";
				}
			}

			// Token: 0x1700053D RID: 1341
			// (get) Token: 0x06004102 RID: 16642 RVA: 0x0015658C File Offset: 0x0015478C
			[Token(Token = "0x1700053D")]
			public override string Description
			{
				[Token(Token = "0x6004102")]
				[Address(RVA = "0x83B4A0", Offset = "0x839AA0", VA = "0x18083B4A0", Slot = "6")]
				get
				{
					return "获得词条：魔力升级II\n获得词条：举世无双";
				}
			}

			// Token: 0x1700053E RID: 1342
			// (get) Token: 0x06004103 RID: 16643 RVA: 0x001565A0 File Offset: 0x001547A0
			[Token(Token = "0x1700053E")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004103")]
				[Address(RVA = "0x3A6E50", Offset = "0x3A5450", VA = "0x1803A6E50", Slot = "4")]
				get
				{
					return PlantType.MagicSnowPea2;
				}
			}

			// Token: 0x1700053F RID: 1343
			// (get) Token: 0x06004104 RID: 16644 RVA: 0x001565B4 File Offset: 0x001547B4
			[Token(Token = "0x1700053F")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004104")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000540 RID: 1344
			// (get) Token: 0x06004105 RID: 16645 RVA: 0x001565C8 File Offset: 0x001547C8
			[Token(Token = "0x17000540")]
			public override int MaxCount
			{
				[Token(Token = "0x6004105")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x06004106 RID: 16646 RVA: 0x001565D8 File Offset: 0x001547D8
			[Token(Token = "0x6004106")]
			[Address(RVA = "0x83B3C0", Offset = "0x8399C0", VA = "0x18083B3C0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1023));
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)44));
			}

			// Token: 0x17000541 RID: 1345
			// (get) Token: 0x06004107 RID: 16647 RVA: 0x0015660C File Offset: 0x0015480C
			[Token(Token = "0x17000541")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004107")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x06004108 RID: 16648 RVA: 0x0015661C File Offset: 0x0015481C
			[Token(Token = "0x6004108")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperUpgrade()
			{
			}
		}

		// Token: 0x02000C28 RID: 3112
		[Token(Token = "0x2000C28")]
		private class SuperUpgrade2 : BaseBuff
		{
			// Token: 0x17000542 RID: 1346
			// (get) Token: 0x06004109 RID: 16649 RVA: 0x00156630 File Offset: 0x00154830
			[Token(Token = "0x17000542")]
			public override string Title
			{
				[Token(Token = "0x6004109")]
				[Address(RVA = "0x83B390", Offset = "0x839990", VA = "0x18083B390", Slot = "5")]
				get
				{
					return "质变：拿来吧你";
				}
			}

			// Token: 0x17000543 RID: 1347
			// (get) Token: 0x0600410A RID: 16650 RVA: 0x00156644 File Offset: 0x00154844
			[Token(Token = "0x17000543")]
			public override string Description
			{
				[Token(Token = "0x600410A")]
				[Address(RVA = "0x83B310", Offset = "0x839910", VA = "0x18083B310", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12016];
				}
			}

			// Token: 0x17000544 RID: 1348
			// (get) Token: 0x0600410B RID: 16651 RVA: 0x00156668 File Offset: 0x00154868
			[Token(Token = "0x17000544")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600410B")]
				[Address(RVA = "0x3A6E50", Offset = "0x3A5450", VA = "0x1803A6E50", Slot = "4")]
				get
				{
					return PlantType.MagicSnowPea2;
				}
			}

			// Token: 0x17000545 RID: 1349
			// (get) Token: 0x0600410C RID: 16652 RVA: 0x0015667C File Offset: 0x0015487C
			[Token(Token = "0x17000545")]
			public override float AppearWeight
			{
				[Token(Token = "0x600410C")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000546 RID: 1350
			// (get) Token: 0x0600410D RID: 16653 RVA: 0x00156690 File Offset: 0x00154890
			[Token(Token = "0x17000546")]
			public override int MaxCount
			{
				[Token(Token = "0x600410D")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000547 RID: 1351
			// (get) Token: 0x0600410E RID: 16654 RVA: 0x001566A0 File Offset: 0x001548A0
			[Token(Token = "0x17000547")]
			public override bool Passive
			{
				[Token(Token = "0x600410E")]
				[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x0600410F RID: 16655 RVA: 0x001566B0 File Offset: 0x001548B0
			[Token(Token = "0x600410F")]
			[Address(RVA = "0x83B000", Offset = "0x839600", VA = "0x18083B000", Slot = "7")]
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

			// Token: 0x17000548 RID: 1352
			// (get) Token: 0x06004110 RID: 16656 RVA: 0x00156708 File Offset: 0x00154908
			[Token(Token = "0x17000548")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004110")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x06004111 RID: 16657 RVA: 0x00156718 File Offset: 0x00154918
			[Token(Token = "0x6004111")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperUpgrade2()
			{
			}
		}
	}
}
