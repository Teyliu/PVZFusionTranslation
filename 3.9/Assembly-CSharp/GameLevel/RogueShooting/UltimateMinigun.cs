using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DA9 RID: 3497
	[Token(Token = "0x2000DA9")]
	public class UltimateMinigun : BaseConfig
	{
		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x0016A9AC File Offset: 0x00168BAC
		[Token(Token = "0x1700090A")]
		public override string Role
		{
			[Token(Token = "0x60048D3")]
			[Address(RVA = "0x8C33D0", Offset = "0x8C19D0", VA = "0x1808C33D0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x0016A9C0 File Offset: 0x00168BC0
		[Token(Token = "0x1700090B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60048D4")]
			[Address(RVA = "0x8C33C0", Offset = "0x8C19C0", VA = "0x1808C33C0", Slot = "4")]
			get
			{
				return PlantType.UltimateMinigun;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x0016A9D4 File Offset: 0x00168BD4
		[Token(Token = "0x1700090C")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60048D5")]
			[Address(RVA = "0x8C31A0", Offset = "0x8C17A0", VA = "0x1808C31A0", Slot = "5")]
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

		// Token: 0x060048D6 RID: 18646 RVA: 0x0016AA1C File Offset: 0x00168C1C
		[Token(Token = "0x60048D6")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x0016AA2C File Offset: 0x00168C2C
		[Token(Token = "0x60048D7")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateMinigun()
		{
		}

		// Token: 0x02000DAA RID: 3498
		[Token(Token = "0x2000DAA")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x060048D8 RID: 18648 RVA: 0x0016AA40 File Offset: 0x00168C40
			[Token(Token = "0x1700090D")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60048D8")]
				[Address(RVA = "0x8C33C0", Offset = "0x8C19C0", VA = "0x1808C33C0", Slot = "4")]
				get
				{
					return PlantType.UltimateMinigun;
				}
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x060048D9 RID: 18649 RVA: 0x0016AA54 File Offset: 0x00168C54
			[Token(Token = "0x1700090E")]
			public override string Title
			{
				[Token(Token = "0x60048D9")]
				[Address(RVA = "0x8C5430", Offset = "0x8C3A30", VA = "0x1808C5430", Slot = "5")]
				get
				{
					return "强化：愈战愈勇";
				}
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x060048DA RID: 18650 RVA: 0x0016AA68 File Offset: 0x00168C68
			[Token(Token = "0x1700090F")]
			public override string Description
			{
				[Token(Token = "0x60048DA")]
				[Address(RVA = "0x8C53A0", Offset = "0x8C39A0", VA = "0x1808C53A0", Slot = "6")]
				get
				{
					return "持续射击时，每过1秒，伤害增加10%，停止攻击后重置";
				}
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x060048DB RID: 18651 RVA: 0x0016AA7C File Offset: 0x00168C7C
			[Token(Token = "0x17000910")]
			public override Quality Rarity
			{
				[Token(Token = "0x60048DB")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x060048DC RID: 18652 RVA: 0x0016AA8C File Offset: 0x00168C8C
			[Token(Token = "0x17000911")]
			public override float AppearWeight
			{
				[Token(Token = "0x60048DC")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060048DD RID: 18653 RVA: 0x0016AAA0 File Offset: 0x00168CA0
			[Token(Token = "0x60048DD")]
			[Address(RVA = "0x8C4BB0", Offset = "0x8C31B0", VA = "0x1808C4BB0", Slot = "7")]
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

			// Token: 0x060048DE RID: 18654 RVA: 0x0016AACC File Offset: 0x00168CCC
			[Token(Token = "0x60048DE")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueBuff()
			{
			}
		}
	}
}
