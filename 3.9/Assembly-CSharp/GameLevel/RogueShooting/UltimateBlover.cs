using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DAC RID: 3500
	[Token(Token = "0x2000DAC")]
	public class UltimateBlover : BaseConfig
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x0016AAE0 File Offset: 0x00168CE0
		[Token(Token = "0x17000912")]
		public override string Role
		{
			[Token(Token = "0x60048E2")]
			[Address(RVA = "0x8C06B0", Offset = "0x8BECB0", VA = "0x1808C06B0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x0016AAF4 File Offset: 0x00168CF4
		[Token(Token = "0x17000913")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60048E3")]
			[Address(RVA = "0x8C06A0", Offset = "0x8BECA0", VA = "0x1808C06A0", Slot = "4")]
			get
			{
				return PlantType.UltimateBlover;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x0016AB08 File Offset: 0x00168D08
		[Token(Token = "0x17000914")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60048E4")]
			[Address(RVA = "0x8C0590", Offset = "0x8BEB90", VA = "0x1808C0590", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UltimateBlover.UniqueBuff uniqueBuff = new UltimateBlover.UniqueBuff();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x0016AB3C File Offset: 0x00168D3C
		[Token(Token = "0x60048E5")]
		[Address(RVA = "0x8C04F0", Offset = "0x8BEAF0", VA = "0x1808C04F0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'UltimateStarBlover' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(UltimateStarBlover).TypeHandle;
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x0016AB60 File Offset: 0x00168D60
		[Token(Token = "0x60048E6")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateBlover()
		{
		}

		// Token: 0x02000DAD RID: 3501
		[Token(Token = "0x2000DAD")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x060048E7 RID: 18663 RVA: 0x0016AB74 File Offset: 0x00168D74
			[Token(Token = "0x17000915")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60048E7")]
				[Address(RVA = "0x8C06A0", Offset = "0x8BECA0", VA = "0x1808C06A0", Slot = "4")]
				get
				{
					return PlantType.UltimateBlover;
				}
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x060048E8 RID: 18664 RVA: 0x0016AB88 File Offset: 0x00168D88
			[Token(Token = "0x17000916")]
			public override string Title
			{
				[Token(Token = "0x60048E8")]
				[Address(RVA = "0x8C5490", Offset = "0x8C3A90", VA = "0x1808C5490", Slot = "5")]
				get
				{
					return "强化：数量";
				}
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x060048E9 RID: 18665 RVA: 0x0016AB9C File Offset: 0x00168D9C
			[Token(Token = "0x17000917")]
			public override string Description
			{
				[Token(Token = "0x60048E9")]
				[Address(RVA = "0x8C53D0", Offset = "0x8C39D0", VA = "0x1808C53D0", Slot = "6")]
				get
				{
					return "存储子弹数量上限增加30";
				}
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x060048EA RID: 18666 RVA: 0x0016ABB0 File Offset: 0x00168DB0
			[Token(Token = "0x17000918")]
			public override Quality Rarity
			{
				[Token(Token = "0x60048EA")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060048EB RID: 18667 RVA: 0x0016ABC0 File Offset: 0x00168DC0
			[Token(Token = "0x60048EB")]
			[Address(RVA = "0x8C4DD0", Offset = "0x8C33D0", VA = "0x1808C4DD0", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__8_ = UltimateBlover.UniqueBuff.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					Action<Plant> action;
					UltimateBlover.UniqueBuff.<>c.<>9__8_0 = action;
				}
				base.SafeModify(<>9__8_);
			}

			// Token: 0x060048EC RID: 18668 RVA: 0x0016ABEC File Offset: 0x00168DEC
			[Token(Token = "0x60048EC")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueBuff()
			{
			}
		}
	}
}
