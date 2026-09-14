using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D14 RID: 3348
	[Token(Token = "0x2000D14")]
	public class SmallPuff : BaseConfig
	{
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x00164D04 File Offset: 0x00162F04
		[Token(Token = "0x17000708")]
		public override string Role
		{
			[Token(Token = "0x600458C")]
			[Address(RVA = "0x8B5240", Offset = "0x8B3840", VA = "0x1808B5240", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x00164D18 File Offset: 0x00162F18
		[Token(Token = "0x17000709")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600458D")]
			[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "4")]
			get
			{
				return PlantType.SmallPuff;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x00164D28 File Offset: 0x00162F28
		[Token(Token = "0x1700070A")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600458E")]
			[Address(RVA = "0x8B50A0", Offset = "0x8B36A0", VA = "0x1808B50A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00164D5C File Offset: 0x00162F5C
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x8AA970", Offset = "0x8A8F70", VA = "0x1808AA970", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00164D90 File Offset: 0x00162F90
		[Token(Token = "0x6004590")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SmallPuff()
		{
		}
	}
}
