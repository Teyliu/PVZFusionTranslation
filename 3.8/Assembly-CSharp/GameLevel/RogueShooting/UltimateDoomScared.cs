using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C66 RID: 3174
	[Token(Token = "0x2000C66")]
	public class UltimateDoomScared : BaseConfig
	{
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x00158E68 File Offset: 0x00157068
		[Token(Token = "0x17000625")]
		public override string Role
		{
			[Token(Token = "0x6004272")]
			[Address(RVA = "0x841C90", Offset = "0x840290", VA = "0x180841C90", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x00158E7C File Offset: 0x0015707C
		[Token(Token = "0x17000626")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004273")]
			[Address(RVA = "0x83A3F0", Offset = "0x8389F0", VA = "0x18083A3F0", Slot = "4")]
			get
			{
				return PlantType.UltimateDoomScaredy;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06004274 RID: 17012 RVA: 0x00158E90 File Offset: 0x00157090
		[Token(Token = "0x17000627")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004274")]
			[Address(RVA = "0x841A70", Offset = "0x840070", VA = "0x180841A70", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				UltimateDoomScared.SuperBuff superBuff = new UltimateDoomScared.SuperBuff();
				int size2 = list._size;
				UltimateDoomScared.UniqueBuff uniqueBuff = new UltimateDoomScared.UniqueBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00158EDC File Offset: 0x001570DC
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x8419D0", Offset = "0x83FFD0", VA = "0x1808419D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 2.5f, num2 != 0, num);
			plant.AddSpeed(1f);
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)2));
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00158F1C File Offset: 0x0015711C
		[Token(Token = "0x6004276")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateDoomScared()
		{
		}

		// Token: 0x02000C67 RID: 3175
		[Token(Token = "0x2000C67")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x06004277 RID: 17015 RVA: 0x00158F30 File Offset: 0x00157130
			[Token(Token = "0x17000628")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004277")]
				[Address(RVA = "0x83A3F0", Offset = "0x8389F0", VA = "0x18083A3F0", Slot = "4")]
				get
				{
					return PlantType.UltimateDoomScaredy;
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06004278 RID: 17016 RVA: 0x00158F44 File Offset: 0x00157144
			[Token(Token = "0x17000629")]
			public override string Title
			{
				[Token(Token = "0x6004278")]
				[Address(RVA = "0x8452D0", Offset = "0x8438D0", VA = "0x1808452D0", Slot = "5")]
				get
				{
					return "强化：超级宇宙无敌雷霆大子弹";
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06004279 RID: 17017 RVA: 0x00158F58 File Offset: 0x00157158
			[Token(Token = "0x1700062A")]
			public override string Description
			{
				[Token(Token = "0x6004279")]
				[Address(RVA = "0x8450A0", Offset = "0x8436A0", VA = "0x1808450A0", Slot = "6")]
				get
				{
					return "大子弹所需射击数-4";
				}
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x0600427A RID: 17018 RVA: 0x00158F6C File Offset: 0x0015716C
			[Token(Token = "0x1700062B")]
			public override Quality Rarity
			{
				[Token(Token = "0x600427A")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x0600427B RID: 17019 RVA: 0x00158F7C File Offset: 0x0015717C
			[Token(Token = "0x1700062C")]
			public override int MaxCount
			{
				[Token(Token = "0x600427B")]
				[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
				get
				{
					return 4;
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x0600427C RID: 17020 RVA: 0x00158F8C File Offset: 0x0015718C
			[Token(Token = "0x1700062D")]
			public override float AppearWeight
			{
				[Token(Token = "0x600427C")]
				[Address(RVA = "0x845090", Offset = "0x843690", VA = "0x180845090", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600427D RID: 17021 RVA: 0x00158FA0 File Offset: 0x001571A0
			[Token(Token = "0x600427D")]
			[Address(RVA = "0x844CC0", Offset = "0x8432C0", VA = "0x180844CC0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__12_ = UltimateDoomScared.UniqueBuff.<>c.<>9__12_0;
				if (<>9__12_ == 0)
				{
					Action<Plant> action;
					UltimateDoomScared.UniqueBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(<>9__12_);
			}

			// Token: 0x0600427E RID: 17022 RVA: 0x00158FCC File Offset: 0x001571CC
			[Token(Token = "0x600427E")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueBuff()
			{
			}
		}

		// Token: 0x02000C69 RID: 3177
		[Token(Token = "0x2000C69")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x06004282 RID: 17026 RVA: 0x00158FE0 File Offset: 0x001571E0
			[Token(Token = "0x1700062E")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004282")]
				[Address(RVA = "0x83A3F0", Offset = "0x8389F0", VA = "0x18083A3F0", Slot = "4")]
				get
				{
					return PlantType.UltimateDoomScaredy;
				}
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x06004283 RID: 17027 RVA: 0x00158FF4 File Offset: 0x001571F4
			[Token(Token = "0x1700062F")]
			public override string Title
			{
				[Token(Token = "0x6004283")]
				[Address(RVA = "0x83A6D0", Offset = "0x838CD0", VA = "0x18083A6D0", Slot = "5")]
				get
				{
					return "质变：真毁";
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x06004284 RID: 17028 RVA: 0x00159008 File Offset: 0x00157208
			[Token(Token = "0x17000630")]
			public override string Description
			{
				[Token(Token = "0x6004284")]
				[Address(RVA = "0x83A220", Offset = "0x838820", VA = "0x18083A220", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)2000];
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x06004285 RID: 17029 RVA: 0x0015902C File Offset: 0x0015722C
			[Token(Token = "0x17000631")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004285")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x06004286 RID: 17030 RVA: 0x0015903C File Offset: 0x0015723C
			[Token(Token = "0x17000632")]
			public override int MaxCount
			{
				[Token(Token = "0x6004286")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x06004287 RID: 17031 RVA: 0x0015904C File Offset: 0x0015724C
			[Token(Token = "0x17000633")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004287")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004288 RID: 17032 RVA: 0x00159060 File Offset: 0x00157260
			[Token(Token = "0x6004288")]
			[Address(RVA = "0x839860", Offset = "0x837E60", VA = "0x180839860", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)2000));
			}

			// Token: 0x06004289 RID: 17033 RVA: 0x00159088 File Offset: 0x00157288
			[Token(Token = "0x6004289")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
