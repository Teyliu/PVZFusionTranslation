using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x2000CD0")]
	public class CherryGatling : BaseConfig
	{
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x0016240C File Offset: 0x0016060C
		[Token(Token = "0x17000617")]
		public override string Role
		{
			[Token(Token = "0x6004405")]
			[Address(RVA = "0x8AA030", Offset = "0x8A8630", VA = "0x1808AA030", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x00162420 File Offset: 0x00160620
		[Token(Token = "0x17000618")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004406")]
			[Address(RVA = "0x3F2B70", Offset = "0x3F1170", VA = "0x1803F2B70", Slot = "4")]
			get
			{
				return PlantType.CherryGatling;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x00162434 File Offset: 0x00160634
		[Token(Token = "0x17000619")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004407")]
			[Address(RVA = "0x8A9F20", Offset = "0x8A8520", VA = "0x1808A9F20", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x00162460 File Offset: 0x00160660
		[Token(Token = "0x6004408")]
		[Address(RVA = "0x88FD80", Offset = "0x88E380", VA = "0x18088FD80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00162494 File Offset: 0x00160694
		[Token(Token = "0x6004409")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public CherryGatling()
		{
		}
	}
}
