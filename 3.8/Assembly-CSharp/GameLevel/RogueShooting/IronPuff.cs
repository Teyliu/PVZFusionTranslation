using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C44 RID: 3140
	[Token(Token = "0x2000C44")]
	public class IronPuff : BaseConfig
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x001578FC File Offset: 0x00155AFC
		[Token(Token = "0x170005AD")]
		public override string Role
		{
			[Token(Token = "0x60041B2")]
			[Address(RVA = "0x8331E0", Offset = "0x8317E0", VA = "0x1808331E0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x00157910 File Offset: 0x00155B10
		[Token(Token = "0x170005AE")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041B3")]
			[Address(RVA = "0x8331D0", Offset = "0x8317D0", VA = "0x1808331D0", Slot = "4")]
			get
			{
				return PlantType.IronPuff;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x00157924 File Offset: 0x00155B24
		[Token(Token = "0x170005AF")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041B4")]
			[Address(RVA = "0x8330B0", Offset = "0x8316B0", VA = "0x1808330B0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1152L);
				upgradeBuff.targetType = (PlantType)((ulong)942L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x0015796C File Offset: 0x00155B6C
		[Token(Token = "0x60041B5")]
		[Address(RVA = "0x833060", Offset = "0x831660", VA = "0x180833060", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)2E-44f, 9f, num2 != 0, num);
			plant.AddSpeed(2E-44f);
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x001579A0 File Offset: 0x00155BA0
		[Token(Token = "0x60041B6")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public IronPuff()
		{
		}
	}
}
