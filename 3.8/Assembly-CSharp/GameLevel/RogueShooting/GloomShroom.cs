using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C53 RID: 3155
	[Token(Token = "0x2000C53")]
	public class GloomShroom : BaseConfig
	{
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x0015825C File Offset: 0x0015645C
		[Token(Token = "0x170005E5")]
		public override string Role
		{
			[Token(Token = "0x600420A")]
			[Address(RVA = "0x831820", Offset = "0x82FE20", VA = "0x180831820", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x00158270 File Offset: 0x00156470
		[Token(Token = "0x170005E6")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600420B")]
			[Address(RVA = "0x831810", Offset = "0x82FE10", VA = "0x180831810", Slot = "4")]
			get
			{
				return PlantType.GloomShroom;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x00158284 File Offset: 0x00156484
		[Token(Token = "0x170005E7")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600420C")]
			[Address(RVA = "0x8316F0", Offset = "0x82FCF0", VA = "0x1808316F0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1070L);
				upgradeBuff.targetType = (PlantType)((ulong)910L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x001582CC File Offset: 0x001564CC
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x82E270", Offset = "0x82C870", VA = "0x18082E270", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x001582F4 File Offset: 0x001564F4
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public GloomShroom()
		{
		}
	}
}
