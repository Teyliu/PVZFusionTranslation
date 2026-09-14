using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D23 RID: 3363
	[Token(Token = "0x2000D23")]
	public class GarlicFume : BaseConfig
	{
		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060045E0 RID: 17888 RVA: 0x00165584 File Offset: 0x00163784
		[Token(Token = "0x1700073C")]
		public override string Role
		{
			[Token(Token = "0x60045E0")]
			[Address(RVA = "0x8AC620", Offset = "0x8AAC20", VA = "0x1808AC620", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x00165598 File Offset: 0x00163798
		[Token(Token = "0x1700073D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60045E1")]
			[Address(RVA = "0x7D1EF0", Offset = "0x7D04F0", VA = "0x1807D1EF0", Slot = "4")]
			get
			{
				return PlantType.GarlicFume;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060045E2 RID: 17890 RVA: 0x001655AC File Offset: 0x001637AC
		[Token(Token = "0x1700073E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60045E2")]
			[Address(RVA = "0x8AC510", Offset = "0x8AAB10", VA = "0x1808AC510", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x001655D8 File Offset: 0x001637D8
		[Token(Token = "0x60045E3")]
		[Address(RVA = "0x8AA970", Offset = "0x8A8F70", VA = "0x1808AA970", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x0016560C File Offset: 0x0016380C
		[Token(Token = "0x60045E4")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public GarlicFume()
		{
		}
	}
}
