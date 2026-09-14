using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C8D RID: 3213
	[Token(Token = "0x2000C8D")]
	public class UltimateCactus : BaseConfig
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x0015AC74 File Offset: 0x00158E74
		[Token(Token = "0x170006AA")]
		public override string Role
		{
			[Token(Token = "0x6004351")]
			[Address(RVA = "0x841260", Offset = "0x83F860", VA = "0x180841260", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x0015AC88 File Offset: 0x00158E88
		[Token(Token = "0x170006AB")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004352")]
			[Address(RVA = "0x841250", Offset = "0x83F850", VA = "0x180841250", Slot = "4")]
			get
			{
				return PlantType.UltimateCactus;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x0015AC9C File Offset: 0x00158E9C
		[Token(Token = "0x170006AC")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004353")]
			[Address(RVA = "0x841030", Offset = "0x83F630", VA = "0x180841030", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateCactus.UniqueUpgrade uniqueUpgrade = new UltimateCactus.UniqueUpgrade();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x0015ACE4 File Offset: 0x00158EE4
		[Token(Token = "0x6004354")]
		[Address(RVA = "0x840FE0", Offset = "0x83F5E0", VA = "0x180840FE0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 3f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x0015AD18 File Offset: 0x00158F18
		[Token(Token = "0x6004355")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateCactus()
		{
		}

		// Token: 0x02000C8E RID: 3214
		[Token(Token = "0x2000C8E")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x06004356 RID: 17238 RVA: 0x0015AD2C File Offset: 0x00158F2C
			[Token(Token = "0x170006AD")]
			public override string Title
			{
				[Token(Token = "0x6004356")]
				[Address(RVA = "0x846920", Offset = "0x844F20", VA = "0x180846920", Slot = "5")]
				get
				{
					return "强化：大招";
				}
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x06004357 RID: 17239 RVA: 0x0015AD40 File Offset: 0x00158F40
			[Token(Token = "0x170006AE")]
			public override string Description
			{
				[Token(Token = "0x6004357")]
				[Address(RVA = "0x846630", Offset = "0x844C30", VA = "0x180846630", Slot = "6")]
				get
				{
					return base.PlantName + "大招所需杀敌数-20";
				}
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x06004358 RID: 17240 RVA: 0x0015AD60 File Offset: 0x00158F60
			[Token(Token = "0x170006AF")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004358")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x06004359 RID: 17241 RVA: 0x0015AD74 File Offset: 0x00158F74
			[Token(Token = "0x170006B0")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004359")]
				[Address(RVA = "0x841250", Offset = "0x83F850", VA = "0x180841250", Slot = "4")]
				get
				{
					return PlantType.UltimateCactus;
				}
			}

			// Token: 0x0600435A RID: 17242 RVA: 0x0015AD88 File Offset: 0x00158F88
			[Token(Token = "0x600435A")]
			[Address(RVA = "0x845BB0", Offset = "0x8441B0", VA = "0x180845BB0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x0600435B RID: 17243 RVA: 0x0015ADA8 File Offset: 0x00158FA8
			[Token(Token = "0x170006B1")]
			public override Quality Rarity
			{
				[Token(Token = "0x600435B")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600435C RID: 17244 RVA: 0x0015ADB8 File Offset: 0x00158FB8
			[Token(Token = "0x600435C")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
