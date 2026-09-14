using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CC4 RID: 3268
	[Token(Token = "0x2000CC4")]
	public class UltimateMinigun : BaseConfig
	{
		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06004486 RID: 17542 RVA: 0x0015CE0C File Offset: 0x0015B00C
		[Token(Token = "0x1700076A")]
		public override string Role
		{
			[Token(Token = "0x6004486")]
			[Address(RVA = "0x843630", Offset = "0x841C30", VA = "0x180843630", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x0015CE20 File Offset: 0x0015B020
		[Token(Token = "0x1700076B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004487")]
			[Address(RVA = "0x843620", Offset = "0x841C20", VA = "0x180843620", Slot = "4")]
			get
			{
				return PlantType.UltimateMinigun;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x0015CE34 File Offset: 0x0015B034
		[Token(Token = "0x1700076C")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004488")]
			[Address(RVA = "0x843400", Offset = "0x841A00", VA = "0x180843400", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateMinigun.UniqueBuff uniqueBuff = new UltimateMinigun.UniqueBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x0015CE7C File Offset: 0x0015B07C
		[Token(Token = "0x6004489")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x0015CE8C File Offset: 0x0015B08C
		[Token(Token = "0x600448A")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateMinigun()
		{
		}

		// Token: 0x02000CC5 RID: 3269
		[Token(Token = "0x2000CC5")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x0600448B RID: 17547 RVA: 0x0015CEA0 File Offset: 0x0015B0A0
			[Token(Token = "0x1700076D")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600448B")]
				[Address(RVA = "0x843620", Offset = "0x841C20", VA = "0x180843620", Slot = "4")]
				get
				{
					return PlantType.UltimateMinigun;
				}
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x0600448C RID: 17548 RVA: 0x0015CEB4 File Offset: 0x0015B0B4
			[Token(Token = "0x1700076E")]
			public override string Title
			{
				[Token(Token = "0x600448C")]
				[Address(RVA = "0x8451E0", Offset = "0x8437E0", VA = "0x1808451E0", Slot = "5")]
				get
				{
					return "强化：愈战愈勇";
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x0600448D RID: 17549 RVA: 0x0015CEC8 File Offset: 0x0015B0C8
			[Token(Token = "0x1700076F")]
			public override string Description
			{
				[Token(Token = "0x600448D")]
				[Address(RVA = "0x845150", Offset = "0x843750", VA = "0x180845150", Slot = "6")]
				get
				{
					return "持续射击时，每过1秒，伤害增加10%，停止攻击后重置";
				}
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x0600448E RID: 17550 RVA: 0x0015CEDC File Offset: 0x0015B0DC
			[Token(Token = "0x17000770")]
			public override Quality Rarity
			{
				[Token(Token = "0x600448E")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x0600448F RID: 17551 RVA: 0x0015CEEC File Offset: 0x0015B0EC
			[Token(Token = "0x17000771")]
			public override float AppearWeight
			{
				[Token(Token = "0x600448F")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004490 RID: 17552 RVA: 0x0015CF00 File Offset: 0x0015B100
			[Token(Token = "0x6004490")]
			[Address(RVA = "0x844AA0", Offset = "0x8430A0", VA = "0x180844AA0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__10_ = UltimateMinigun.UniqueBuff.<>c.<>9__10_0;
				if (<>9__10_ == 0)
				{
					Action<Plant> action;
					UltimateMinigun.UniqueBuff.<>c.<>9__10_0 = action;
				}
				base.SafeModify(<>9__10_);
			}

			// Token: 0x06004491 RID: 17553 RVA: 0x0015CF2C File Offset: 0x0015B12C
			[Token(Token = "0x6004491")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueBuff()
			{
			}
		}
	}
}
