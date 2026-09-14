using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DA6 RID: 3494
	[Token(Token = "0x2000DA6")]
	public class UltimateSniperGatling : BaseConfig
	{
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x0016A844 File Offset: 0x00168A44
		[Token(Token = "0x17000901")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60048C3")]
			[Address(RVA = "0x8C3940", Offset = "0x8C1F40", VA = "0x1808C3940", Slot = "4")]
			get
			{
				return PlantType.UltimateSniperGatling;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060048C4 RID: 18628 RVA: 0x0016A858 File Offset: 0x00168A58
		[Token(Token = "0x17000902")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60048C4")]
			[Address(RVA = "0x8C3720", Offset = "0x8C1D20", VA = "0x1808C3720", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateSniperGatling.UniqueBuff uniqueBuff = new UltimateSniperGatling.UniqueBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060048C5 RID: 18629 RVA: 0x0016A8A0 File Offset: 0x00168AA0
		[Token(Token = "0x17000903")]
		public override string Role
		{
			[Token(Token = "0x60048C5")]
			[Address(RVA = "0x8C3950", Offset = "0x8C1F50", VA = "0x1808C3950", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x0016A8B4 File Offset: 0x00168AB4
		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x8C3400", Offset = "0x8C1A00", VA = "0x1808C3400", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), -0.75f, num2 != 0, num);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x0016A8DC File Offset: 0x00168ADC
		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateSniperGatling()
		{
		}

		// Token: 0x02000DA7 RID: 3495
		[Token(Token = "0x2000DA7")]
		private class UniqueBuff : BaseBuff
		{
			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x060048C8 RID: 18632 RVA: 0x0016A8F0 File Offset: 0x00168AF0
			[Token(Token = "0x17000904")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60048C8")]
				[Address(RVA = "0x8C3940", Offset = "0x8C1F40", VA = "0x1808C3940", Slot = "4")]
				get
				{
					return PlantType.UltimateSniperGatling;
				}
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x060048C9 RID: 18633 RVA: 0x0016A904 File Offset: 0x00168B04
			[Token(Token = "0x17000905")]
			public override string Title
			{
				[Token(Token = "0x60048C9")]
				[Address(RVA = "0x8C5460", Offset = "0x8C3A60", VA = "0x1808C5460", Slot = "5")]
				get
				{
					return "强化：爆头";
				}
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x060048CA RID: 18634 RVA: 0x0016A918 File Offset: 0x00168B18
			[Token(Token = "0x17000906")]
			public override string Description
			{
				[Token(Token = "0x60048CA")]
				[Address(RVA = "0x8C52F0", Offset = "0x8C38F0", VA = "0x1808C52F0", Slot = "6")]
				get
				{
					return base.PlantName + "爆头所需次数-1";
				}
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x060048CB RID: 18635 RVA: 0x0016A938 File Offset: 0x00168B38
			[Token(Token = "0x17000907")]
			public override Quality Rarity
			{
				[Token(Token = "0x60048CB")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x060048CC RID: 18636 RVA: 0x0016A948 File Offset: 0x00168B48
			[Token(Token = "0x17000908")]
			public override float AppearWeight
			{
				[Token(Token = "0x60048CC")]
				[Address(RVA = "0x8C52A0", Offset = "0x8C38A0", VA = "0x1808C52A0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x060048CD RID: 18637 RVA: 0x0016A95C File Offset: 0x00168B5C
			[Token(Token = "0x17000909")]
			public override int MaxCount
			{
				[Token(Token = "0x60048CD")]
				[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
				get
				{
					return 5;
				}
			}

			// Token: 0x060048CE RID: 18638 RVA: 0x0016A96C File Offset: 0x00168B6C
			[Token(Token = "0x60048CE")]
			[Address(RVA = "0x8C5100", Offset = "0x8C3700", VA = "0x1808C5100", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__12_ = UltimateSniperGatling.UniqueBuff.<>c.<>9__12_0;
				if (<>9__12_ == 0)
				{
					Action<Plant> action;
					UltimateSniperGatling.UniqueBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(<>9__12_);
			}

			// Token: 0x060048CF RID: 18639 RVA: 0x0016A998 File Offset: 0x00168B98
			[Token(Token = "0x60048CF")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueBuff()
			{
			}
		}
	}
}
