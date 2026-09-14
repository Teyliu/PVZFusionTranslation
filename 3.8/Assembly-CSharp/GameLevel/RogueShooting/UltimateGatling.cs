using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C15 RID: 3093
	[Token(Token = "0x2000C15")]
	public class UltimateGatling : BaseConfig
	{
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06004091 RID: 16529 RVA: 0x0015595C File Offset: 0x00153B5C
		[Token(Token = "0x170004F1")]
		public override string Role
		{
			[Token(Token = "0x6004091")]
			[Address(RVA = "0x8422D0", Offset = "0x8408D0", VA = "0x1808422D0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x00155970 File Offset: 0x00153B70
		[Token(Token = "0x170004F2")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004092")]
			[Address(RVA = "0x83A930", Offset = "0x838F30", VA = "0x18083A930", Slot = "4")]
			get
			{
				return PlantType.UltimateGatling;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06004093 RID: 16531 RVA: 0x00155984 File Offset: 0x00153B84
		[Token(Token = "0x170004F3")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004093")]
			[Address(RVA = "0x842020", Offset = "0x840620", VA = "0x180842020", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateGatling.UniqueUpgrade uniqueUpgrade = new UltimateGatling.UniqueUpgrade();
				int size3 = list._size;
				UltimateGatling.SuperForceUpgrade superForceUpgrade = new UltimateGatling.SuperForceUpgrade();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x001559DC File Offset: 0x00153BDC
		[Token(Token = "0x6004094")]
		[Address(RVA = "0x82EE90", Offset = "0x82D490", VA = "0x18082EE90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00155A04 File Offset: 0x00153C04
		[Token(Token = "0x6004095")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateGatling()
		{
		}

		// Token: 0x02000C16 RID: 3094
		[Token(Token = "0x2000C16")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170004F4 RID: 1268
			// (get) Token: 0x06004096 RID: 16534 RVA: 0x00155A18 File Offset: 0x00153C18
			[Token(Token = "0x170004F4")]
			public override string Title
			{
				[Token(Token = "0x6004096")]
				[Address(RVA = "0x8469E0", Offset = "0x844FE0", VA = "0x1808469E0", Slot = "5")]
				get
				{
					return "强化：弹道";
				}
			}

			// Token: 0x170004F5 RID: 1269
			// (get) Token: 0x06004097 RID: 16535 RVA: 0x00155A2C File Offset: 0x00153C2C
			[Token(Token = "0x170004F5")]
			public override string Description
			{
				[Token(Token = "0x6004097")]
				[Address(RVA = "0x846590", Offset = "0x844B90", VA = "0x180846590", Slot = "6")]
				get
				{
					return base.PlantName + "每次攻击多发射一发子弹";
				}
			}

			// Token: 0x170004F6 RID: 1270
			// (get) Token: 0x06004098 RID: 16536 RVA: 0x00155A4C File Offset: 0x00153C4C
			[Token(Token = "0x170004F6")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004098")]
				[Address(RVA = "0x83A930", Offset = "0x838F30", VA = "0x18083A930", Slot = "4")]
				get
				{
					return PlantType.UltimateGatling;
				}
			}

			// Token: 0x170004F7 RID: 1271
			// (get) Token: 0x06004099 RID: 16537 RVA: 0x00155A60 File Offset: 0x00153C60
			[Token(Token = "0x170004F7")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004099")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x170004F8 RID: 1272
			// (get) Token: 0x0600409A RID: 16538 RVA: 0x00155A70 File Offset: 0x00153C70
			[Token(Token = "0x170004F8")]
			public override float AppearWeight
			{
				[Token(Token = "0x600409A")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600409B RID: 16539 RVA: 0x00155A84 File Offset: 0x00153C84
			[Token(Token = "0x600409B")]
			[Address(RVA = "0x845D40", Offset = "0x844340", VA = "0x180845D40", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x0600409C RID: 16540 RVA: 0x00155AB4 File Offset: 0x00153CB4
			[Token(Token = "0x600409C")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C17 RID: 3095
		[Token(Token = "0x2000C17")]
		private class SuperForceUpgrade : BaseBuff
		{
			// Token: 0x170004F9 RID: 1273
			// (get) Token: 0x0600409D RID: 16541 RVA: 0x00155AC8 File Offset: 0x00153CC8
			[Token(Token = "0x170004F9")]
			public override string Title
			{
				[Token(Token = "0x600409D")]
				[Address(RVA = "0x83A940", Offset = "0x838F40", VA = "0x18083A940", Slot = "5")]
				get
				{
					return "质变：力量";
				}
			}

			// Token: 0x170004FA RID: 1274
			// (get) Token: 0x0600409E RID: 16542 RVA: 0x00155ADC File Offset: 0x00153CDC
			[Token(Token = "0x170004FA")]
			public override string Description
			{
				[Token(Token = "0x600409E")]
				[Address(RVA = "0x83A900", Offset = "0x838F00", VA = "0x18083A900", Slot = "6")]
				get
				{
					return "获得词条力大砖飞：植物造成的樱桃爆炸伤害x3";
				}
			}

			// Token: 0x170004FB RID: 1275
			// (get) Token: 0x0600409F RID: 16543 RVA: 0x00155AF0 File Offset: 0x00153CF0
			[Token(Token = "0x170004FB")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600409F")]
				[Address(RVA = "0x83A930", Offset = "0x838F30", VA = "0x18083A930", Slot = "4")]
				get
				{
					return PlantType.UltimateGatling;
				}
			}

			// Token: 0x170004FC RID: 1276
			// (get) Token: 0x060040A0 RID: 16544 RVA: 0x00155B04 File Offset: 0x00153D04
			[Token(Token = "0x170004FC")]
			public override Quality Rarity
			{
				[Token(Token = "0x60040A0")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170004FD RID: 1277
			// (get) Token: 0x060040A1 RID: 16545 RVA: 0x00155B14 File Offset: 0x00153D14
			[Token(Token = "0x170004FD")]
			public override float AppearWeight
			{
				[Token(Token = "0x60040A1")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170004FE RID: 1278
			// (get) Token: 0x060040A2 RID: 16546 RVA: 0x00155B28 File Offset: 0x00153D28
			[Token(Token = "0x170004FE")]
			public override int MaxCount
			{
				[Token(Token = "0x60040A2")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x060040A3 RID: 16547 RVA: 0x00155B38 File Offset: 0x00153D38
			[Token(Token = "0x60040A3")]
			[Address(RVA = "0x83A8A0", Offset = "0x838EA0", VA = "0x18083A8A0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				int num = 0;
				instance.GetUltiBuff((UltiBuff)((uint)2), num != 0);
			}

			// Token: 0x060040A4 RID: 16548 RVA: 0x00155B60 File Offset: 0x00153D60
			[Token(Token = "0x60040A4")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperForceUpgrade()
			{
			}
		}
	}
}
