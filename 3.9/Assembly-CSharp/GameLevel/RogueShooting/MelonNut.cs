using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CF7 RID: 3319
	[Token(Token = "0x2000CF7")]
	public class MelonNut : BaseConfig
	{
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x00163AE8 File Offset: 0x00161CE8
		[Token(Token = "0x170006A6")]
		public override string Role
		{
			[Token(Token = "0x60044EB")]
			[Address(RVA = "0x8AFA60", Offset = "0x8AE060", VA = "0x1808AFA60", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x00163AFC File Offset: 0x00161CFC
		[Token(Token = "0x170006A7")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044EC")]
			[Address(RVA = "0x7D3420", Offset = "0x7D1A20", VA = "0x1807D3420", Slot = "4")]
			get
			{
				return PlantType.MelonNut;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060044ED RID: 17645 RVA: 0x00163B10 File Offset: 0x00161D10
		[Token(Token = "0x170006A8")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044ED")]
			[Address(RVA = "0x8AF7C0", Offset = "0x8ADDC0", VA = "0x1808AF7C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				MelonNut.HealthBuff healthBuff = new MelonNut.HealthBuff();
				int size2 = list._size;
				MelonNut.SaveDamageBuff saveDamageBuff = new MelonNut.SaveDamageBuff();
				int size3 = list._size;
				MelonNut.SuperBuff superBuff = new MelonNut.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00163B6C File Offset: 0x00161D6C
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x8AF750", Offset = "0x8ADD50", VA = "0x1808AF750", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			float attributeFloat = plant.attributeFloat;
			Animator anim = plant.anim;
			plant.attributeFloat = attributeFloat;
			anim.SetFloat("Speed2", 3f);
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00163BA4 File Offset: 0x00161DA4
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public MelonNut()
		{
		}

		// Token: 0x02000CF8 RID: 3320
		[Token(Token = "0x2000CF8")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x060044F0 RID: 17648 RVA: 0x00163BB8 File Offset: 0x00161DB8
			[Token(Token = "0x170006A9")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60044F0")]
				[Address(RVA = "0x7D3420", Offset = "0x7D1A20", VA = "0x1807D3420", Slot = "4")]
				get
				{
					return PlantType.MelonNut;
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x060044F1 RID: 17649 RVA: 0x00163BCC File Offset: 0x00161DCC
			[Token(Token = "0x170006AA")]
			public override string Title
			{
				[Token(Token = "0x60044F1")]
				[Address(RVA = "0x8B73F0", Offset = "0x8B59F0", VA = "0x1808B73F0", Slot = "5")]
				get
				{
					return "质变：谁劈了我的瓜？";
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x060044F2 RID: 17650 RVA: 0x00163BE0 File Offset: 0x00161DE0
			[Token(Token = "0x170006AB")]
			public override string Description
			{
				[Token(Token = "0x60044F2")]
				[Address(RVA = "0x8B6FC0", Offset = "0x8B55C0", VA = "0x1808B6FC0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12017];
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x060044F3 RID: 17651 RVA: 0x00163C04 File Offset: 0x00161E04
			[Token(Token = "0x170006AC")]
			public override Quality Rarity
			{
				[Token(Token = "0x60044F3")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x060044F4 RID: 17652 RVA: 0x00163C14 File Offset: 0x00161E14
			[Token(Token = "0x170006AD")]
			public override int MaxCount
			{
				[Token(Token = "0x60044F4")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x060044F5 RID: 17653 RVA: 0x00163C24 File Offset: 0x00161E24
			[Token(Token = "0x170006AE")]
			public override float AppearWeight
			{
				[Token(Token = "0x60044F5")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060044F6 RID: 17654 RVA: 0x00163C38 File Offset: 0x00161E38
			[Token(Token = "0x60044F6")]
			[Address(RVA = "0x8B6800", Offset = "0x8B4E00", VA = "0x1808B6800", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12017));
			}

			// Token: 0x060044F7 RID: 17655 RVA: 0x00163C60 File Offset: 0x00161E60
			[Token(Token = "0x60044F7")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}

		// Token: 0x02000CF9 RID: 3321
		[Token(Token = "0x2000CF9")]
		private class HealthBuff : BaseBuff
		{
			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x060044F8 RID: 17656 RVA: 0x00163C74 File Offset: 0x00161E74
			[Token(Token = "0x170006AF")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60044F8")]
				[Address(RVA = "0x7D3420", Offset = "0x7D1A20", VA = "0x1807D3420", Slot = "4")]
				get
				{
					return PlantType.MelonNut;
				}
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x060044F9 RID: 17657 RVA: 0x00163C88 File Offset: 0x00161E88
			[Token(Token = "0x170006B0")]
			public override string Title
			{
				[Token(Token = "0x60044F9")]
				[Address(RVA = "0x8AD220", Offset = "0x8AB820", VA = "0x1808AD220", Slot = "5")]
				get
				{
					return "强化：生命";
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x060044FA RID: 17658 RVA: 0x00163C9C File Offset: 0x00161E9C
			[Token(Token = "0x170006B1")]
			public override string Description
			{
				[Token(Token = "0x60044FA")]
				[Address(RVA = "0x8AD1F0", Offset = "0x8AB7F0", VA = "0x1808AD1F0", Slot = "6")]
				get
				{
					return "生命值上限+50%，其他植物受伤时，获得相当于5%伤害量的蓄能";
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x060044FB RID: 17659 RVA: 0x00163CB0 File Offset: 0x00161EB0
			[Token(Token = "0x170006B2")]
			public override Quality Rarity
			{
				[Token(Token = "0x60044FB")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x060044FC RID: 17660 RVA: 0x00163CC0 File Offset: 0x00161EC0
			[Token(Token = "0x170006B3")]
			public override int MaxCount
			{
				[Token(Token = "0x60044FC")]
				[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x060044FD RID: 17661 RVA: 0x00163CD0 File Offset: 0x00161ED0
			[Token(Token = "0x170006B4")]
			public override float AppearWeight
			{
				[Token(Token = "0x60044FD")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060044FE RID: 17662 RVA: 0x00163CE4 File Offset: 0x00161EE4
			[Token(Token = "0x60044FE")]
			[Address(RVA = "0x8ACFA0", Offset = "0x8AB5A0", VA = "0x1808ACFA0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__12_ = MelonNut.HealthBuff.<>c.<>9__12_0;
				if (<>9__12_ == 0)
				{
					Action<Plant> action;
					MelonNut.HealthBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(<>9__12_);
			}

			// Token: 0x060044FF RID: 17663 RVA: 0x00163D10 File Offset: 0x00161F10
			[Token(Token = "0x60044FF")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public HealthBuff()
			{
			}
		}

		// Token: 0x02000CFB RID: 3323
		[Token(Token = "0x2000CFB")]
		private class SaveDamageBuff : BaseBuff
		{
			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x06004503 RID: 17667 RVA: 0x00163D24 File Offset: 0x00161F24
			[Token(Token = "0x170006B5")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004503")]
				[Address(RVA = "0x7D3420", Offset = "0x7D1A20", VA = "0x1807D3420", Slot = "4")]
				get
				{
					return PlantType.MelonNut;
				}
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x06004504 RID: 17668 RVA: 0x00163D38 File Offset: 0x00161F38
			[Token(Token = "0x170006B6")]
			public override string Title
			{
				[Token(Token = "0x6004504")]
				[Address(RVA = "0x8B3530", Offset = "0x8B1B30", VA = "0x1808B3530", Slot = "5")]
				get
				{
					return "强化：蓄力";
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x06004505 RID: 17669 RVA: 0x00163D4C File Offset: 0x00161F4C
			[Token(Token = "0x170006B7")]
			public override string Description
			{
				[Token(Token = "0x6004505")]
				[Address(RVA = "0x8B3500", Offset = "0x8B1B00", VA = "0x1808B3500", Slot = "6")]
				get
				{
					return "蓄能获取效率增加+100%";
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x06004506 RID: 17670 RVA: 0x00163D60 File Offset: 0x00161F60
			[Token(Token = "0x170006B8")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004506")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x06004507 RID: 17671 RVA: 0x00163D70 File Offset: 0x00161F70
			[Token(Token = "0x170006B9")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004507")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004508 RID: 17672 RVA: 0x00163D84 File Offset: 0x00161F84
			[Token(Token = "0x6004508")]
			[Address(RVA = "0x8B33F0", Offset = "0x8B19F0", VA = "0x1808B33F0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = MelonNut.SaveDamageBuff.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					MelonNut.SaveDamageBuff.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x06004509 RID: 17673 RVA: 0x00163DB0 File Offset: 0x00161FB0
			[Token(Token = "0x6004509")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SaveDamageBuff()
			{
			}
		}
	}
}
