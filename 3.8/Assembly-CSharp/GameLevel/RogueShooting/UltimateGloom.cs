using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C54 RID: 3156
	[Token(Token = "0x2000C54")]
	public class UltimateGloom : BaseConfig
	{
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x00158308 File Offset: 0x00156508
		[Token(Token = "0x170005E8")]
		public override string Role
		{
			[Token(Token = "0x600420F")]
			[Address(RVA = "0x842630", Offset = "0x840C30", VA = "0x180842630", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x0015831C File Offset: 0x0015651C
		[Token(Token = "0x170005E9")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004210")]
			[Address(RVA = "0x830290", Offset = "0x82E890", VA = "0x180830290", Slot = "4")]
			get
			{
				return PlantType.UltimateGloom;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x00158330 File Offset: 0x00156530
		[Token(Token = "0x170005EA")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004211")]
			[Address(RVA = "0x842300", Offset = "0x840900", VA = "0x180842300", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateGloom.UniqueUpgrade uniqueUpgrade = new UltimateGloom.UniqueUpgrade();
				int size3 = list._size;
				UltimateGloom.DoomBuff doomBuff = new UltimateGloom.DoomBuff();
				int size4 = list._size;
				StarUpBuff starUpBuff;
				starUpBuff.targetType = (PlantType)((ulong)910L);
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x001583A0 File Offset: 0x001565A0
		[Token(Token = "0x6004212")]
		[Address(RVA = "0x841290", Offset = "0x83F890", VA = "0x180841290", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 3f, num2 != 0, num);
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x001583C8 File Offset: 0x001565C8
		[Token(Token = "0x6004213")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateGloom()
		{
		}

		// Token: 0x02000C55 RID: 3157
		[Token(Token = "0x2000C55")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x06004214 RID: 16916 RVA: 0x001583DC File Offset: 0x001565DC
			[Token(Token = "0x170005EB")]
			public override string Title
			{
				[Token(Token = "0x6004214")]
				[Address(RVA = "0x8466B0", Offset = "0x844CB0", VA = "0x1808466B0", Slot = "5")]
				get
				{
					return "强化：半径";
				}
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x06004215 RID: 16917 RVA: 0x001583F0 File Offset: 0x001565F0
			[Token(Token = "0x170005EC")]
			public override string Description
			{
				[Token(Token = "0x6004215")]
				[Address(RVA = "0x846240", Offset = "0x844840", VA = "0x180846240", Slot = "6")]
				get
				{
					return base.PlantName + "伤害半径+0.5";
				}
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x06004216 RID: 16918 RVA: 0x00158410 File Offset: 0x00156610
			[Token(Token = "0x170005ED")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004216")]
				[Address(RVA = "0x830290", Offset = "0x82E890", VA = "0x180830290", Slot = "4")]
				get
				{
					return PlantType.UltimateGloom;
				}
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x06004217 RID: 16919 RVA: 0x00158424 File Offset: 0x00156624
			[Token(Token = "0x170005EE")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004217")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004218 RID: 16920 RVA: 0x00158438 File Offset: 0x00156638
			[Token(Token = "0x6004218")]
			[Address(RVA = "0x8459C0", Offset = "0x843FC0", VA = "0x1808459C0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x06004219 RID: 16921 RVA: 0x00158458 File Offset: 0x00156658
			[Token(Token = "0x170005EF")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004219")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600421A RID: 16922 RVA: 0x00158468 File Offset: 0x00156668
			[Token(Token = "0x600421A")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C56 RID: 3158
		[Token(Token = "0x2000C56")]
		private class DoomBuff : BaseBuff
		{
			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x0600421B RID: 16923 RVA: 0x0015847C File Offset: 0x0015667C
			[Token(Token = "0x170005F0")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600421B")]
				[Address(RVA = "0x830290", Offset = "0x82E890", VA = "0x180830290", Slot = "4")]
				get
				{
					return PlantType.UltimateGloom;
				}
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x0600421C RID: 16924 RVA: 0x00158490 File Offset: 0x00156690
			[Token(Token = "0x170005F1")]
			public override string Title
			{
				[Token(Token = "0x600421C")]
				[Address(RVA = "0x8302A0", Offset = "0x82E8A0", VA = "0x1808302A0", Slot = "5")]
				get
				{
					return "质变：湮灭";
				}
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x0600421D RID: 16925 RVA: 0x001584A4 File Offset: 0x001566A4
			[Token(Token = "0x170005F2")]
			public override string Description
			{
				[Token(Token = "0x600421D")]
				[Address(RVA = "0x830260", Offset = "0x82E860", VA = "0x180830260", Slot = "6")]
				get
				{
					return "获得词条：真-万籁俱寂";
				}
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x0600421E RID: 16926 RVA: 0x001584B8 File Offset: 0x001566B8
			[Token(Token = "0x170005F3")]
			public override Quality Rarity
			{
				[Token(Token = "0x600421E")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x0600421F RID: 16927 RVA: 0x001584C8 File Offset: 0x001566C8
			[Token(Token = "0x170005F4")]
			public override int MaxCount
			{
				[Token(Token = "0x600421F")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x06004220 RID: 16928 RVA: 0x001584D8 File Offset: 0x001566D8
			[Token(Token = "0x170005F5")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004220")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004221 RID: 16929 RVA: 0x001584EC File Offset: 0x001566EC
			[Token(Token = "0x6004221")]
			[Address(RVA = "0x830200", Offset = "0x82E800", VA = "0x180830200", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12005));
			}

			// Token: 0x06004222 RID: 16930 RVA: 0x00158514 File Offset: 0x00156714
			[Token(Token = "0x6004222")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public DoomBuff()
			{
			}
		}
	}
}
