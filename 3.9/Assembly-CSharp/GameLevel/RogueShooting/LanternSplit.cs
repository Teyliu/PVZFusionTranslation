using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CDA RID: 3290
	[Token(Token = "0x2000CDA")]
	public class LanternSplit : BaseConfig
	{
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x00162A04 File Offset: 0x00160C04
		[Token(Token = "0x1700063C")]
		public override string Role
		{
			[Token(Token = "0x600443E")]
			[Address(RVA = "0x8AE8D0", Offset = "0x8ACED0", VA = "0x1808AE8D0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x00162A18 File Offset: 0x00160C18
		[Token(Token = "0x1700063D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600443F")]
			[Address(RVA = "0x8AE8C0", Offset = "0x8ACEC0", VA = "0x1808AE8C0", Slot = "4")]
			get
			{
				return PlantType.LanternSplit;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x00162A2C File Offset: 0x00160C2C
		[Token(Token = "0x1700063E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004440")]
			[Address(RVA = "0x8AE7B0", Offset = "0x8ACDB0", VA = "0x1808AE7B0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00162A58 File Offset: 0x00160C58
		[Token(Token = "0x6004441")]
		[Address(RVA = "0x88FD80", Offset = "0x88E380", VA = "0x18088FD80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00162A8C File Offset: 0x00160C8C
		[Token(Token = "0x6004442")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public LanternSplit()
		{
		}
	}
}
