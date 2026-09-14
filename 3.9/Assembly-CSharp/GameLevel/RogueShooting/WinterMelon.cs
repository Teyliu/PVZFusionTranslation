using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D88 RID: 3464
	[Token(Token = "0x2000D88")]
	public class WinterMelon : BaseConfig
	{
		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x0016986C File Offset: 0x00167A6C
		[Token(Token = "0x1700089D")]
		public override string Role
		{
			[Token(Token = "0x600481E")]
			[Address(RVA = "0x8C75F0", Offset = "0x8C5BF0", VA = "0x1808C75F0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x00169880 File Offset: 0x00167A80
		[Token(Token = "0x1700089E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600481F")]
			[Address(RVA = "0x8C75E0", Offset = "0x8C5BE0", VA = "0x1808C75E0", Slot = "4")]
			get
			{
				return PlantType.WinterMelon;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x00169894 File Offset: 0x00167A94
		[Token(Token = "0x1700089F")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004820")]
			[Address(RVA = "0x8C74D0", Offset = "0x8C5AD0", VA = "0x1808C74D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x001698C0 File Offset: 0x00167AC0
		[Token(Token = "0x6004821")]
		[Address(RVA = "0x88FD80", Offset = "0x88E380", VA = "0x18088FD80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x001698F4 File Offset: 0x00167AF4
		[Token(Token = "0x6004822")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public WinterMelon()
		{
		}
	}
}
