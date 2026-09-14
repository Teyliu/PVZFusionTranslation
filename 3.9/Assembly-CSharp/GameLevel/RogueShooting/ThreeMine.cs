using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D08 RID: 3336
	[Token(Token = "0x2000D08")]
	public class ThreeMine : BaseConfig
	{
		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06004542 RID: 17730 RVA: 0x00164530 File Offset: 0x00162730
		[Token(Token = "0x170006D6")]
		public override string Role
		{
			[Token(Token = "0x6004542")]
			[Address(RVA = "0x8B8CE0", Offset = "0x8B72E0", VA = "0x1808B8CE0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x00164544 File Offset: 0x00162744
		[Token(Token = "0x170006D7")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004543")]
			[Address(RVA = "0x7E5810", Offset = "0x7E3E10", VA = "0x1807E5810", Slot = "4")]
			get
			{
				return PlantType.ThreeMine;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06004544 RID: 17732 RVA: 0x00164558 File Offset: 0x00162758
		[Token(Token = "0x170006D8")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004544")]
			[Address(RVA = "0x8B8A30", Offset = "0x8B7030", VA = "0x1808B8A30", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				ThreeMine.UniqueUpgrade uniqueUpgrade = new ThreeMine.UniqueUpgrade();
				int size3 = list._size;
				ThreeMine.ExplodeBuff explodeBuff = new ThreeMine.ExplodeBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x001645B0 File Offset: 0x001627B0
		[Token(Token = "0x6004545")]
		[Address(RVA = "0x8B89E0", Offset = "0x8B6FE0", VA = "0x1808B89E0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.attributeCountdown = 0.5f;
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x001645E4 File Offset: 0x001627E4
		[Token(Token = "0x6004546")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ThreeMine()
		{
		}

		// Token: 0x02000D09 RID: 3337
		[Token(Token = "0x2000D09")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x06004547 RID: 17735 RVA: 0x001645F8 File Offset: 0x001627F8
			[Token(Token = "0x170006D9")]
			public override string Title
			{
				[Token(Token = "0x6004547")]
				[Address(RVA = "0x8C6E70", Offset = "0x8C5470", VA = "0x1808C6E70", Slot = "5")]
				get
				{
					return "强化：持久";
				}
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x06004548 RID: 17736 RVA: 0x0016460C File Offset: 0x0016280C
			[Token(Token = "0x170006DA")]
			public override string Description
			{
				[Token(Token = "0x6004548")]
				[Address(RVA = "0x8C6810", Offset = "0x8C4E10", VA = "0x1808C6810", Slot = "6")]
				get
				{
					return base.PlantName + "大招持续时间+5秒";
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x06004549 RID: 17737 RVA: 0x0016462C File Offset: 0x0016282C
			[Token(Token = "0x170006DB")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004549")]
				[Address(RVA = "0x7E5810", Offset = "0x7E3E10", VA = "0x1807E5810", Slot = "4")]
				get
				{
					return PlantType.ThreeMine;
				}
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x0600454A RID: 17738 RVA: 0x00164640 File Offset: 0x00162840
			[Token(Token = "0x170006DC")]
			public override float AppearWeight
			{
				[Token(Token = "0x600454A")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600454B RID: 17739 RVA: 0x00164654 File Offset: 0x00162854
			[Token(Token = "0x600454B")]
			[Address(RVA = "0x8C5AB0", Offset = "0x8C40B0", VA = "0x1808C5AB0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x0600454C RID: 17740 RVA: 0x00164674 File Offset: 0x00162874
			[Token(Token = "0x170006DD")]
			public override Quality Rarity
			{
				[Token(Token = "0x600454C")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600454D RID: 17741 RVA: 0x00164684 File Offset: 0x00162884
			[Token(Token = "0x600454D")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D0A RID: 3338
		[Token(Token = "0x2000D0A")]
		private class ExplodeBuff : BaseBuff
		{
			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x0600454E RID: 17742 RVA: 0x00164698 File Offset: 0x00162898
			[Token(Token = "0x170006DE")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600454E")]
				[Address(RVA = "0x7E5810", Offset = "0x7E3E10", VA = "0x1807E5810", Slot = "4")]
				get
				{
					return PlantType.ThreeMine;
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x0600454F RID: 17743 RVA: 0x001646AC File Offset: 0x001628AC
			[Token(Token = "0x170006DF")]
			public override string Title
			{
				[Token(Token = "0x600454F")]
				[Address(RVA = "0x8ABB00", Offset = "0x8AA100", VA = "0x1808ABB00", Slot = "5")]
				get
				{
					return "质变：爆破";
				}
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x06004550 RID: 17744 RVA: 0x001646C0 File Offset: 0x001628C0
			[Token(Token = "0x170006E0")]
			public override string Description
			{
				[Token(Token = "0x6004550")]
				[Address(RVA = "0x8ABA70", Offset = "0x8AA070", VA = "0x1808ABA70", Slot = "6")]
				get
				{
					return "发射的子弹升级为爆破子弹";
				}
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x06004551 RID: 17745 RVA: 0x001646D4 File Offset: 0x001628D4
			[Token(Token = "0x170006E1")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004551")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x06004552 RID: 17746 RVA: 0x001646E4 File Offset: 0x001628E4
			[Token(Token = "0x170006E2")]
			public override int MaxCount
			{
				[Token(Token = "0x6004552")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06004553 RID: 17747 RVA: 0x001646F4 File Offset: 0x001628F4
			[Token(Token = "0x170006E3")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004553")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004554 RID: 17748 RVA: 0x00164708 File Offset: 0x00162908
			[Token(Token = "0x6004554")]
			[Address(RVA = "0x8ABA10", Offset = "0x8AA010", VA = "0x1808ABA10", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12003));
			}

			// Token: 0x06004555 RID: 17749 RVA: 0x00164730 File Offset: 0x00162930
			[Token(Token = "0x6004555")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public ExplodeBuff()
			{
			}
		}
	}
}
