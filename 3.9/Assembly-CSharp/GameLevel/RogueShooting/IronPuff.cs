using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D18 RID: 3352
	[Token(Token = "0x2000D18")]
	public class IronPuff : BaseConfig
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x00164F84 File Offset: 0x00163184
		[Token(Token = "0x17000716")]
		public override string Role
		{
			[Token(Token = "0x60045A2")]
			[Address(RVA = "0x8AE780", Offset = "0x8ACD80", VA = "0x1808AE780", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x00164F98 File Offset: 0x00163198
		[Token(Token = "0x17000717")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60045A3")]
			[Address(RVA = "0x8AE770", Offset = "0x8ACD70", VA = "0x1808AE770", Slot = "4")]
			get
			{
				return PlantType.IronPuff;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x00164FAC File Offset: 0x001631AC
		[Token(Token = "0x17000718")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60045A4")]
			[Address(RVA = "0x8AE660", Offset = "0x8ACC60", VA = "0x1808AE660", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00164FD8 File Offset: 0x001631D8
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x8AE610", Offset = "0x8ACC10", VA = "0x1808AE610", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)2E-44f, 9f, num2 != 0, num);
			plant.AddSpeed(2E-44f);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x0016500C File Offset: 0x0016320C
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public IronPuff()
		{
		}
	}
}
