using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DA1 RID: 3489
	[Token(Token = "0x2000DA1")]
	public class SuperSpruce : BaseConfig
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060048A7 RID: 18599 RVA: 0x0016A59C File Offset: 0x0016879C
		[Token(Token = "0x170008F0")]
		public override string Role
		{
			[Token(Token = "0x60048A7")]
			[Address(RVA = "0x8B7BA0", Offset = "0x8B61A0", VA = "0x1808B7BA0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x0016A5B0 File Offset: 0x001687B0
		[Token(Token = "0x170008F1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60048A8")]
			[Address(RVA = "0x8B7B90", Offset = "0x8B6190", VA = "0x1808B7B90", Slot = "4")]
			get
			{
				return PlantType.SuperSpruce;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x0016A5C4 File Offset: 0x001687C4
		[Token(Token = "0x170008F2")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60048A9")]
			[Address(RVA = "0x8B7A80", Offset = "0x8B6080", VA = "0x1808B7A80", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x0016A5F0 File Offset: 0x001687F0
		[Token(Token = "0x60048AA")]
		[Address(RVA = "0x8A89C0", Offset = "0x8A6FC0", VA = "0x1808A89C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x0016A618 File Offset: 0x00168818
		[Token(Token = "0x60048AB")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SuperSpruce()
		{
		}
	}
}
