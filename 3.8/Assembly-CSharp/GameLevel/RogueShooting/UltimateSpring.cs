using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA6 RID: 3238
	[Token(Token = "0x2000CA6")]
	public class UltimateSpring : BaseConfig
	{
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060043DE RID: 17374 RVA: 0x0015BCFC File Offset: 0x00159EFC
		[Token(Token = "0x17000703")]
		public override string Role
		{
			[Token(Token = "0x60043DE")]
			[Address(RVA = "0x843FF0", Offset = "0x8425F0", VA = "0x180843FF0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x0015BD10 File Offset: 0x00159F10
		[Token(Token = "0x17000704")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043DF")]
			[Address(RVA = "0x83A410", Offset = "0x838A10", VA = "0x18083A410", Slot = "4")]
			get
			{
				return PlantType.UltimateSpring;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060043E0 RID: 17376 RVA: 0x0015BD24 File Offset: 0x00159F24
		[Token(Token = "0x17000705")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043E0")]
			[Address(RVA = "0x843D40", Offset = "0x842340", VA = "0x180843D40", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateSpring.UniqueUpgrade uniqueUpgrade = new UltimateSpring.UniqueUpgrade();
				int size3 = list._size;
				UltimateSpring.SuperBuff superBuff = new UltimateSpring.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x0015BD7C File Offset: 0x00159F7C
		[Token(Token = "0x60043E1")]
		[Address(RVA = "0x843BE0", Offset = "0x8421E0", VA = "0x180843BE0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on \"在该模式中，\", offset 0xFFFFFFFFFFFFFFF8}" == typeof(Thrower).TypeHandle;
			InGameText instance = InGameText.Instance;
			int plantType = (int)this.PlantType;
			string text2;
			string text = "在该模式中，" + text2 + "会持续射击鼠标所在位置";
			int num = 0;
			instance.ShowText(text, 3f, num != 0);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x0015BDD4 File Offset: 0x00159FD4
		[Token(Token = "0x60043E2")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateSpring()
		{
		}

		// Token: 0x02000CA7 RID: 3239
		[Token(Token = "0x2000CA7")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x060043E3 RID: 17379 RVA: 0x0015BDE8 File Offset: 0x00159FE8
			[Token(Token = "0x17000706")]
			public override string Title
			{
				[Token(Token = "0x60043E3")]
				[Address(RVA = "0x8467D0", Offset = "0x844DD0", VA = "0x1808467D0", Slot = "5")]
				get
				{
					return "强化：火海";
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x060043E4 RID: 17380 RVA: 0x0015BDFC File Offset: 0x00159FFC
			[Token(Token = "0x17000707")]
			public override string Description
			{
				[Token(Token = "0x60043E4")]
				[Address(RVA = "0x846540", Offset = "0x844B40", VA = "0x180846540", Slot = "6")]
				get
				{
					return base.PlantName + "火海时间+3秒";
				}
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x060043E5 RID: 17381 RVA: 0x0015BE1C File Offset: 0x0015A01C
			[Token(Token = "0x17000708")]
			public override float AppearWeight
			{
				[Token(Token = "0x60043E5")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x060043E6 RID: 17382 RVA: 0x0015BE30 File Offset: 0x0015A030
			[Token(Token = "0x17000709")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60043E6")]
				[Address(RVA = "0x83A410", Offset = "0x838A10", VA = "0x18083A410", Slot = "4")]
				get
				{
					return PlantType.UltimateSpring;
				}
			}

			// Token: 0x060043E7 RID: 17383 RVA: 0x0015BE44 File Offset: 0x0015A044
			[Token(Token = "0x60043E7")]
			[Address(RVA = "0x845730", Offset = "0x843D30", VA = "0x180845730", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x060043E8 RID: 17384 RVA: 0x0015BE74 File Offset: 0x0015A074
			[Token(Token = "0x1700070A")]
			public override Quality Rarity
			{
				[Token(Token = "0x60043E8")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060043E9 RID: 17385 RVA: 0x0015BE84 File Offset: 0x0015A084
			[Token(Token = "0x60043E9")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000CA8 RID: 3240
		[Token(Token = "0x2000CA8")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x060043EA RID: 17386 RVA: 0x0015BE98 File Offset: 0x0015A098
			[Token(Token = "0x1700070B")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60043EA")]
				[Address(RVA = "0x83A410", Offset = "0x838A10", VA = "0x18083A410", Slot = "4")]
				get
				{
					return PlantType.UltimateSpring;
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x060043EB RID: 17387 RVA: 0x0015BEAC File Offset: 0x0015A0AC
			[Token(Token = "0x1700070C")]
			public override string Title
			{
				[Token(Token = "0x60043EB")]
				[Address(RVA = "0x83A6A0", Offset = "0x838CA0", VA = "0x18083A6A0", Slot = "5")]
				get
				{
					return "质变：火海";
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x060043EC RID: 17388 RVA: 0x0015BEC0 File Offset: 0x0015A0C0
			[Token(Token = "0x1700070D")]
			public override string Description
			{
				[Token(Token = "0x60043EC")]
				[Address(RVA = "0x83A170", Offset = "0x838770", VA = "0x18083A170", Slot = "6")]
				get
				{
					return "火神的子弹命中地面时也会生成火海，命中僵尸最多额外分裂2次";
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x060043ED RID: 17389 RVA: 0x0015BED4 File Offset: 0x0015A0D4
			[Token(Token = "0x1700070E")]
			public override Quality Rarity
			{
				[Token(Token = "0x60043ED")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x060043EE RID: 17390 RVA: 0x0015BEE4 File Offset: 0x0015A0E4
			[Token(Token = "0x1700070F")]
			public override int MaxCount
			{
				[Token(Token = "0x60043EE")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x060043EF RID: 17391 RVA: 0x0015BEF4 File Offset: 0x0015A0F4
			[Token(Token = "0x17000710")]
			public override float AppearWeight
			{
				[Token(Token = "0x60043EF")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060043F0 RID: 17392 RVA: 0x0015BF08 File Offset: 0x0015A108
			[Token(Token = "0x60043F0")]
			[Address(RVA = "0x839C10", Offset = "0x838210", VA = "0x180839C10", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12000));
			}

			// Token: 0x060043F1 RID: 17393 RVA: 0x0015BF30 File Offset: 0x0015A130
			[Token(Token = "0x60043F1")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
