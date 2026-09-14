using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CDE RID: 3294
	[Token(Token = "0x2000CDE")]
	public class SniperPea : BaseConfig
	{
		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x00162CD0 File Offset: 0x00160ED0
		[Token(Token = "0x1700064E")]
		public override string Role
		{
			[Token(Token = "0x6004458")]
			[Address(RVA = "0x8B5450", Offset = "0x8B3A50", VA = "0x1808B5450", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06004459 RID: 17497 RVA: 0x00162CE4 File Offset: 0x00160EE4
		[Token(Token = "0x1700064F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004459")]
			[Address(RVA = "0x8B5440", Offset = "0x8B3A40", VA = "0x1808B5440", Slot = "4")]
			get
			{
				return PlantType.SniperPea;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x00162CF8 File Offset: 0x00160EF8
		[Token(Token = "0x17000650")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600445A")]
			[Address(RVA = "0x8B52A0", Offset = "0x8B38A0", VA = "0x1808B52A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00162D2C File Offset: 0x00160F2C
		[Token(Token = "0x600445B")]
		[Address(RVA = "0x8B5270", Offset = "0x8B3870", VA = "0x1808B5270", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.ModifySpeed((PlantSpeedAdder)((uint)3), 3f);
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00162D4C File Offset: 0x00160F4C
		[Token(Token = "0x600445C")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SniperPea()
		{
		}
	}
}
