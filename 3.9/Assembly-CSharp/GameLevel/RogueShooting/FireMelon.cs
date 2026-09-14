using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D7E RID: 3454
	[Token(Token = "0x2000D7E")]
	public class FireMelon : BaseConfig
	{
		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060047E6 RID: 18406 RVA: 0x001691AC File Offset: 0x001673AC
		[Token(Token = "0x1700087B")]
		public override string Role
		{
			[Token(Token = "0x60047E6")]
			[Address(RVA = "0x8ABDC0", Offset = "0x8AA3C0", VA = "0x1808ABDC0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x001691C0 File Offset: 0x001673C0
		[Token(Token = "0x1700087C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60047E7")]
			[Address(RVA = "0x8ABDB0", Offset = "0x8AA3B0", VA = "0x1808ABDB0", Slot = "4")]
			get
			{
				return PlantType.FireMelon;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x001691D4 File Offset: 0x001673D4
		[Token(Token = "0x1700087D")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60047E8")]
			[Address(RVA = "0x8ABCA0", Offset = "0x8AA2A0", VA = "0x1808ABCA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x00169200 File Offset: 0x00167400
		[Token(Token = "0x60047E9")]
		[Address(RVA = "0x88FD80", Offset = "0x88E380", VA = "0x18088FD80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x00169234 File Offset: 0x00167434
		[Token(Token = "0x60047EA")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public FireMelon()
		{
		}
	}
}
