using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D70 RID: 3440
	[Token(Token = "0x2000D70")]
	public class GoldCabbage : BaseConfig
	{
		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x00168900 File Offset: 0x00166B00
		[Token(Token = "0x17000846")]
		public override string Role
		{
			[Token(Token = "0x6004794")]
			[Address(RVA = "0x8AC900", Offset = "0x8AAF00", VA = "0x1808AC900", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06004795 RID: 18325 RVA: 0x00168914 File Offset: 0x00166B14
		[Token(Token = "0x17000847")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004795")]
			[Address(RVA = "0x7D2080", Offset = "0x7D0680", VA = "0x1807D2080", Slot = "4")]
			get
			{
				return PlantType.GoldCabbage;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x00168928 File Offset: 0x00166B28
		[Token(Token = "0x17000848")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004796")]
			[Address(RVA = "0x8AC7F0", Offset = "0x8AADF0", VA = "0x1808AC7F0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x00168954 File Offset: 0x00166B54
		[Token(Token = "0x6004797")]
		[Address(RVA = "0x8AC7A0", Offset = "0x8AADA0", VA = "0x1808AC7A0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 24f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x00168988 File Offset: 0x00166B88
		[Token(Token = "0x6004798")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public GoldCabbage()
		{
		}
	}
}
