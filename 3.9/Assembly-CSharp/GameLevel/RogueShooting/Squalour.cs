using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D3F RID: 3391
	[Token(Token = "0x2000D3F")]
	public class Squalour : BaseConfig
	{
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x00166650 File Offset: 0x00164850
		[Token(Token = "0x170007A0")]
		public override string Role
		{
			[Token(Token = "0x600467F")]
			[Address(RVA = "0x8B5BC0", Offset = "0x8B41C0", VA = "0x1808B5BC0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x00166664 File Offset: 0x00164864
		[Token(Token = "0x170007A1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004680")]
			[Address(RVA = "0x8B5BB0", Offset = "0x8B41B0", VA = "0x1808B5BB0", Slot = "4")]
			get
			{
				return PlantType.Squalour;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x00166678 File Offset: 0x00164878
		[Token(Token = "0x170007A2")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004681")]
			[Address(RVA = "0x8B5AA0", Offset = "0x8B40A0", VA = "0x1808B5AA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x001666A4 File Offset: 0x001648A4
		[Token(Token = "0x6004682")]
		[Address(RVA = "0x8A98D0", Offset = "0x8A7ED0", VA = "0x1808A98D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x001666CC File Offset: 0x001648CC
		[Token(Token = "0x6004683")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Squalour()
		{
		}
	}
}
