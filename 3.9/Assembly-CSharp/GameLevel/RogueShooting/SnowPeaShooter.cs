using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CE7 RID: 3303
	[Token(Token = "0x2000CE7")]
	public class SnowPeaShooter : BaseConfig
	{
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x00163194 File Offset: 0x00161394
		[Token(Token = "0x1700066D")]
		public override string Role
		{
			[Token(Token = "0x600448B")]
			[Address(RVA = "0x8B57A0", Offset = "0x8B3DA0", VA = "0x1808B57A0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x001631A8 File Offset: 0x001613A8
		[Token(Token = "0x1700066E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600448C")]
			[Address(RVA = "0x7DF440", Offset = "0x7DDA40", VA = "0x1807DF440", Slot = "4")]
			get
			{
				return PlantType.SnowPeaShooter;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x001631BC File Offset: 0x001613BC
		[Token(Token = "0x1700066F")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600448D")]
			[Address(RVA = "0x8B5690", Offset = "0x8B3C90", VA = "0x1808B5690", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x001631E8 File Offset: 0x001613E8
		[Token(Token = "0x600448E")]
		[Address(RVA = "0x8B5640", Offset = "0x8B3C40", VA = "0x1808B5640", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 39f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x0016321C File Offset: 0x0016141C
		[Token(Token = "0x600448F")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SnowPeaShooter()
		{
		}
	}
}
