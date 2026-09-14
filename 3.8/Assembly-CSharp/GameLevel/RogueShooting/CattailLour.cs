using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C6C RID: 3180
	[Token(Token = "0x2000C6C")]
	public class CattailLour : BaseConfig
	{
		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x0015920C File Offset: 0x0015740C
		[Token(Token = "0x1700063A")]
		public override string Role
		{
			[Token(Token = "0x6004294")]
			[Address(RVA = "0x82F180", Offset = "0x82D780", VA = "0x18082F180", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x00159220 File Offset: 0x00157420
		[Token(Token = "0x1700063B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004295")]
			[Address(RVA = "0x767990", Offset = "0x765F90", VA = "0x180767990", Slot = "4")]
			get
			{
				return PlantType.CattailLour;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x00159234 File Offset: 0x00157434
		[Token(Token = "0x1700063C")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004296")]
			[Address(RVA = "0x82EED0", Offset = "0x82D4D0", VA = "0x18082EED0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				CattailLour.FlySupply flySupply = new CattailLour.FlySupply();
				int size3 = list._size;
				CattailLour.SuperBuff superBuff = new CattailLour.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x0015928C File Offset: 0x0015748C
		[Token(Token = "0x6004297")]
		[Address(RVA = "0x82EE90", Offset = "0x82D490", VA = "0x18082EE90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x001592B4 File Offset: 0x001574B4
		[Token(Token = "0x6004298")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public CattailLour()
		{
		}

		// Token: 0x02000C6D RID: 3181
		[Token(Token = "0x2000C6D")]
		private class FlySupply : BaseBuff
		{
			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x06004299 RID: 17049 RVA: 0x001592C8 File Offset: 0x001574C8
			[Token(Token = "0x1700063D")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004299")]
				[Address(RVA = "0x767990", Offset = "0x765F90", VA = "0x180767990", Slot = "4")]
				get
				{
					return PlantType.CattailLour;
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x0600429A RID: 17050 RVA: 0x001592DC File Offset: 0x001574DC
			[Token(Token = "0x1700063E")]
			public override string Title
			{
				[Token(Token = "0x600429A")]
				[Address(RVA = "0x8312D0", Offset = "0x82F8D0", VA = "0x1808312D0", Slot = "5")]
				get
				{
					return "强化：小队";
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x0600429B RID: 17051 RVA: 0x001592F0 File Offset: 0x001574F0
			[Token(Token = "0x1700063F")]
			public override string Description
			{
				[Token(Token = "0x600429B")]
				[Address(RVA = "0x8312A0", Offset = "0x82F8A0", VA = "0x1808312A0", Slot = "6")]
				get
				{
					return "每3秒自动生成一个僚机，攻速加成可缩短这个间隔";
				}
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x0600429C RID: 17052 RVA: 0x00159304 File Offset: 0x00157504
			[Token(Token = "0x17000640")]
			public override Quality Rarity
			{
				[Token(Token = "0x600429C")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600429D RID: 17053 RVA: 0x00159314 File Offset: 0x00157514
			[Token(Token = "0x600429D")]
			[Address(RVA = "0x831200", Offset = "0x82F800", VA = "0x180831200", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
					base.Plant.attributeCountdown = 0.5f;
				}
			}

			// Token: 0x0600429E RID: 17054 RVA: 0x00159354 File Offset: 0x00157554
			[Token(Token = "0x600429E")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public FlySupply()
			{
			}
		}

		// Token: 0x02000C6E RID: 3182
		[Token(Token = "0x2000C6E")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x0600429F RID: 17055 RVA: 0x00159368 File Offset: 0x00157568
			[Token(Token = "0x17000641")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600429F")]
				[Address(RVA = "0x767990", Offset = "0x765F90", VA = "0x180767990", Slot = "4")]
				get
				{
					return PlantType.CattailLour;
				}
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x060042A0 RID: 17056 RVA: 0x0015937C File Offset: 0x0015757C
			[Token(Token = "0x17000642")]
			public override string Title
			{
				[Token(Token = "0x60042A0")]
				[Address(RVA = "0x83A5B0", Offset = "0x838BB0", VA = "0x18083A5B0", Slot = "5")]
				get
				{
					return "质变：弹药";
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x060042A1 RID: 17057 RVA: 0x00159390 File Offset: 0x00157590
			[Token(Token = "0x17000643")]
			public override string Description
			{
				[Token(Token = "0x60042A1")]
				[Address(RVA = "0x839F30", Offset = "0x838530", VA = "0x180839F30", Slot = "6")]
				get
				{
					return "获得词条：特制弹药、一针见血";
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x060042A2 RID: 17058 RVA: 0x001593A4 File Offset: 0x001575A4
			[Token(Token = "0x17000644")]
			public override Quality Rarity
			{
				[Token(Token = "0x60042A2")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x060042A3 RID: 17059 RVA: 0x001593B4 File Offset: 0x001575B4
			[Token(Token = "0x17000645")]
			public override float AppearWeight
			{
				[Token(Token = "0x60042A3")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x060042A4 RID: 17060 RVA: 0x001593C8 File Offset: 0x001575C8
			[Token(Token = "0x17000646")]
			public override int MaxCount
			{
				[Token(Token = "0x60042A4")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x060042A5 RID: 17061 RVA: 0x001593D8 File Offset: 0x001575D8
			[Token(Token = "0x60042A5")]
			[Address(RVA = "0x839D90", Offset = "0x838390", VA = "0x180839D90", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)16));
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)17));
			}

			// Token: 0x060042A6 RID: 17062 RVA: 0x0015940C File Offset: 0x0015760C
			[Token(Token = "0x60042A6")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
