using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D50 RID: 3408
	[Token(Token = "0x2000D50")]
	public class Caltrop : BaseConfig
	{
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x00167204 File Offset: 0x00165404
		[Token(Token = "0x170007E7")]
		public override string Role
		{
			[Token(Token = "0x60046EA")]
			[Address(RVA = "0x8A9780", Offset = "0x8A7D80", VA = "0x1808A9780", Slot = "7")]
			get
			{
				return "输出/防御/辅助";
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x00167218 File Offset: 0x00165418
		[Token(Token = "0x170007E8")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60046EB")]
			[Address(RVA = "0x715870", Offset = "0x713E70", VA = "0x180715870", Slot = "4")]
			get
			{
				return PlantType.Caltrop;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x00167228 File Offset: 0x00165428
		[Token(Token = "0x170007E9")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60046EC")]
			[Address(RVA = "0x8A95E0", Offset = "0x8A7BE0", VA = "0x1808A95E0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x0016725C File Offset: 0x0016545C
		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x8A90B0", Offset = "0x8A76B0", VA = "0x1808A90B0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x00167290 File Offset: 0x00165490
		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Caltrop()
		{
		}
	}
}
