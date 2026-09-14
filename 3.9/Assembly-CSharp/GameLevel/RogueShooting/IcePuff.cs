using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D15 RID: 3349
	[Token(Token = "0x2000D15")]
	public class IcePuff : BaseConfig
	{
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x00164DA4 File Offset: 0x00162FA4
		[Token(Token = "0x1700070B")]
		public override string Role
		{
			[Token(Token = "0x6004591")]
			[Address(RVA = "0x8AE5E0", Offset = "0x8ACBE0", VA = "0x1808AE5E0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x00164DB8 File Offset: 0x00162FB8
		[Token(Token = "0x1700070C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004592")]
			[Address(RVA = "0x8AE5D0", Offset = "0x8ACBD0", VA = "0x1808AE5D0", Slot = "4")]
			get
			{
				return PlantType.IcePuff;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x00164DCC File Offset: 0x00162FCC
		[Token(Token = "0x1700070D")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004593")]
			[Address(RVA = "0x8AE4C0", Offset = "0x8ACAC0", VA = "0x1808AE4C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00164DF8 File Offset: 0x00162FF8
		[Token(Token = "0x6004594")]
		[Address(RVA = "0x8AA970", Offset = "0x8A8F70", VA = "0x1808AA970", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00164E2C File Offset: 0x0016302C
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public IcePuff()
		{
		}
	}
}
