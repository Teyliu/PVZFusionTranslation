using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D5F RID: 3423
	[Token(Token = "0x2000D5F")]
	public class Cactus : BaseConfig
	{
		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06004737 RID: 18231 RVA: 0x00167F0C File Offset: 0x0016610C
		[Token(Token = "0x1700080D")]
		public override string Role
		{
			[Token(Token = "0x6004737")]
			[Address(RVA = "0x8A93E0", Offset = "0x8A79E0", VA = "0x1808A93E0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x00167F20 File Offset: 0x00166120
		[Token(Token = "0x1700080E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004738")]
			[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "4")]
			get
			{
				return PlantType.Cactus;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x00167F30 File Offset: 0x00166130
		[Token(Token = "0x1700080F")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004739")]
			[Address(RVA = "0x8A92D0", Offset = "0x8A78D0", VA = "0x1808A92D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x00167F5C File Offset: 0x0016615C
		[Token(Token = "0x600473A")]
		[Address(RVA = "0x88FD80", Offset = "0x88E380", VA = "0x18088FD80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x00167F90 File Offset: 0x00166190
		[Token(Token = "0x600473B")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Cactus()
		{
		}
	}
}
