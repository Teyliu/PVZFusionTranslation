using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CFD RID: 3325
	[Token(Token = "0x2000CFD")]
	public class MagnetNut : BaseConfig
	{
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600450D RID: 17677 RVA: 0x00163DC4 File Offset: 0x00161FC4
		[Token(Token = "0x170006BA")]
		public override string Role
		{
			[Token(Token = "0x600450D")]
			[Address(RVA = "0x8AF720", Offset = "0x8ADD20", VA = "0x1808AF720", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600450E RID: 17678 RVA: 0x00163DD8 File Offset: 0x00161FD8
		[Token(Token = "0x170006BB")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600450E")]
			[Address(RVA = "0x8A8790", Offset = "0x8A6D90", VA = "0x1808A8790", Slot = "4")]
			get
			{
				return PlantType.MagnetNut;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x00163DEC File Offset: 0x00161FEC
		[Token(Token = "0x170006BC")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600450F")]
			[Address(RVA = "0x8AF370", Offset = "0x8AD970", VA = "0x1808AF370", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				MagnetNut.BaseUpgrade baseUpgrade = new MagnetNut.BaseUpgrade();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				MagnetNut.UniqueUpgrade uniqueUpgrade = new MagnetNut.UniqueUpgrade();
				int size4 = list._size;
				MagnetNut.SuperBuff superBuff = new MagnetNut.SuperBuff();
				int size5 = list._size;
				MagnetNut.BulletCurse bulletCurse = new MagnetNut.BulletCurse();
				int size6 = list._size;
				return list;
			}
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00163E64 File Offset: 0x00162064
		[Token(Token = "0x6004510")]
		[Address(RVA = "0x8AF2C0", Offset = "0x8AD8C0", VA = "0x1808AF2C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00163E84 File Offset: 0x00162084
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public MagnetNut()
		{
		}

		// Token: 0x02000CFE RID: 3326
		[Token(Token = "0x2000CFE")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x06004512 RID: 17682 RVA: 0x00163E98 File Offset: 0x00162098
			[Token(Token = "0x170006BD")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004512")]
				[Address(RVA = "0x8A8790", Offset = "0x8A6D90", VA = "0x1808A8790", Slot = "4")]
				get
				{
					return PlantType.MagnetNut;
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x06004513 RID: 17683 RVA: 0x00163EAC File Offset: 0x001620AC
			[Token(Token = "0x170006BE")]
			public override string Title
			{
				[Token(Token = "0x6004513")]
				[Address(RVA = "0x8C6F00", Offset = "0x8C5500", VA = "0x1808C6F00", Slot = "5")]
				get
				{
					return "强化：杀戮";
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x06004514 RID: 17684 RVA: 0x00163EC0 File Offset: 0x001620C0
			[Token(Token = "0x170006BF")]
			public override string Description
			{
				[Token(Token = "0x6004514")]
				[Address(RVA = "0x8C69A0", Offset = "0x8C4FA0", VA = "0x1808C69A0", Slot = "6")]
				get
				{
					return "子弹旋转半径提高12%，旋转速度提高80%";
				}
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x06004515 RID: 17685 RVA: 0x00163ED4 File Offset: 0x001620D4
			[Token(Token = "0x170006C0")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004515")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x06004516 RID: 17686 RVA: 0x00163EE4 File Offset: 0x001620E4
			[Token(Token = "0x170006C1")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004516")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004517 RID: 17687 RVA: 0x00163EF8 File Offset: 0x001620F8
			[Token(Token = "0x6004517")]
			[Address(RVA = "0x8C5CB0", Offset = "0x8C42B0", VA = "0x1808C5CB0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = MagnetNut.UniqueUpgrade.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					MagnetNut.UniqueUpgrade.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x06004518 RID: 17688 RVA: 0x00163F24 File Offset: 0x00162124
			[Token(Token = "0x6004518")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D00 RID: 3328
		[Token(Token = "0x2000D00")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x0600451C RID: 17692 RVA: 0x00163F38 File Offset: 0x00162138
			[Token(Token = "0x170006C2")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600451C")]
				[Address(RVA = "0x8A8790", Offset = "0x8A6D90", VA = "0x1808A8790", Slot = "4")]
				get
				{
					return PlantType.MagnetNut;
				}
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x0600451D RID: 17693 RVA: 0x00163F4C File Offset: 0x0016214C
			[Token(Token = "0x170006C3")]
			public override string Title
			{
				[Token(Token = "0x600451D")]
				[Address(RVA = "0x8B73C0", Offset = "0x8B59C0", VA = "0x1808B73C0", Slot = "5")]
				get
				{
					return "质变：杀戮光环";
				}
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x0600451E RID: 17694 RVA: 0x00163F60 File Offset: 0x00162160
			[Token(Token = "0x170006C4")]
			public override string Description
			{
				[Token(Token = "0x600451E")]
				[Address(RVA = "0x8B6B30", Offset = "0x8B5130", VA = "0x1808B6B30", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12022];
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x0600451F RID: 17695 RVA: 0x00163F84 File Offset: 0x00162184
			[Token(Token = "0x170006C5")]
			public override Quality Rarity
			{
				[Token(Token = "0x600451F")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x06004520 RID: 17696 RVA: 0x00163F94 File Offset: 0x00162194
			[Token(Token = "0x170006C6")]
			public override int MaxCount
			{
				[Token(Token = "0x6004520")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x06004521 RID: 17697 RVA: 0x00163FA4 File Offset: 0x001621A4
			[Token(Token = "0x170006C7")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004521")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004522 RID: 17698 RVA: 0x00163FB8 File Offset: 0x001621B8
			[Token(Token = "0x6004522")]
			[Address(RVA = "0x8B6150", Offset = "0x8B4750", VA = "0x1808B6150", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12022));
			}

			// Token: 0x06004523 RID: 17699 RVA: 0x00163FE0 File Offset: 0x001621E0
			[Token(Token = "0x6004523")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}

		// Token: 0x02000D01 RID: 3329
		[Token(Token = "0x2000D01")]
		private class BaseUpgrade : BaseBuff
		{
			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x06004524 RID: 17700 RVA: 0x00163FF4 File Offset: 0x001621F4
			[Token(Token = "0x170006C8")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004524")]
				[Address(RVA = "0x8A8790", Offset = "0x8A6D90", VA = "0x1808A8790", Slot = "4")]
				get
				{
					return PlantType.MagnetNut;
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x06004525 RID: 17701 RVA: 0x00164008 File Offset: 0x00162208
			[Token(Token = "0x170006C9")]
			public override string Title
			{
				[Token(Token = "0x6004525")]
				[Address(RVA = "0x8A87A0", Offset = "0x8A6DA0", VA = "0x1808A87A0", Slot = "5")]
				get
				{
					return "进化：究极";
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x06004526 RID: 17702 RVA: 0x0016401C File Offset: 0x0016221C
			[Token(Token = "0x170006CA")]
			public override string Description
			{
				[Token(Token = "0x6004526")]
				[Address(RVA = "0x8A8760", Offset = "0x8A6D60", VA = "0x1808A8760", Slot = "6")]
				get
				{
					return "磁力坚果的基础伤害x3";
				}
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x06004527 RID: 17703 RVA: 0x00164030 File Offset: 0x00162230
			[Token(Token = "0x170006CB")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004527")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "12")]
				get
				{
					return Quality.silver;
				}
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x06004528 RID: 17704 RVA: 0x00164040 File Offset: 0x00162240
			[Token(Token = "0x170006CC")]
			public override int MaxCount
			{
				[Token(Token = "0x6004528")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x06004529 RID: 17705 RVA: 0x00164050 File Offset: 0x00162250
			[Token(Token = "0x6004529")]
			[Address(RVA = "0x8A8650", Offset = "0x8A6C50", VA = "0x1808A8650", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = MagnetNut.BaseUpgrade.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					MagnetNut.BaseUpgrade.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x0600452A RID: 17706 RVA: 0x0016407C File Offset: 0x0016227C
			[Token(Token = "0x600452A")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public BaseUpgrade()
			{
			}
		}

		// Token: 0x02000D03 RID: 3331
		[Token(Token = "0x2000D03")]
		private class BulletCurse : CurseBuff
		{
			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x0600452E RID: 17710 RVA: 0x00164090 File Offset: 0x00162290
			[Token(Token = "0x170006CD")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600452E")]
				[Address(RVA = "0x8A8790", Offset = "0x8A6D90", VA = "0x1808A8790", Slot = "4")]
				get
				{
					return PlantType.MagnetNut;
				}
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x0600452F RID: 17711 RVA: 0x001640A4 File Offset: 0x001622A4
			[Token(Token = "0x170006CE")]
			public override string Title
			{
				[Token(Token = "0x600452F")]
				[Address(RVA = "0x8A8DE0", Offset = "0x8A73E0", VA = "0x1808A8DE0", Slot = "5")]
				get
				{
					return "诅咒：千锤百炼";
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x06004530 RID: 17712 RVA: 0x001640B8 File Offset: 0x001622B8
			[Token(Token = "0x170006CF")]
			public override string Description
			{
				[Token(Token = "0x6004530")]
				[Address(RVA = "0x8A8D60", Offset = "0x8A7360", VA = "0x1808A8D60", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)14006];
				}
			}

			// Token: 0x06004531 RID: 17713 RVA: 0x001640DC File Offset: 0x001622DC
			[Token(Token = "0x6004531")]
			[Address(RVA = "0x8A8D00", Offset = "0x8A7300", VA = "0x1808A8D00", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)14006));
			}

			// Token: 0x06004532 RID: 17714 RVA: 0x00164104 File Offset: 0x00162304
			[Token(Token = "0x6004532")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public BulletCurse()
			{
			}
		}
	}
}
