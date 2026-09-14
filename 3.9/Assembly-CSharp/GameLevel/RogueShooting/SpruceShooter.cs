using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DA0 RID: 3488
	[Token(Token = "0x2000DA0")]
	public class SpruceShooter : BaseConfig
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x0016A510 File Offset: 0x00168710
		[Token(Token = "0x170008ED")]
		public override string Role
		{
			[Token(Token = "0x60048A2")]
			[Address(RVA = "0x8B5A70", Offset = "0x8B4070", VA = "0x1808B5A70", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x0016A524 File Offset: 0x00168724
		[Token(Token = "0x170008EE")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60048A3")]
			[Address(RVA = "0x71E620", Offset = "0x71CC20", VA = "0x18071E620", Slot = "4")]
			get
			{
				return PlantType.SpruceShooter;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x0016A534 File Offset: 0x00168734
		[Token(Token = "0x170008EF")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60048A4")]
			[Address(RVA = "0x8B5960", Offset = "0x8B3F60", VA = "0x1808B5960", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x0016A560 File Offset: 0x00168760
		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x8B5920", Offset = "0x8B3F20", VA = "0x1808B5920", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 18f, num2 != 0, num);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x0016A588 File Offset: 0x00168788
		[Token(Token = "0x60048A6")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SpruceShooter()
		{
		}
	}
}
