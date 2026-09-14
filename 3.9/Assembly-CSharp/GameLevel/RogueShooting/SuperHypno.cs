using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D33 RID: 3379
	[Token(Token = "0x2000D33")]
	public class SuperHypno : BaseConfig
	{
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600463B RID: 17979 RVA: 0x00165F08 File Offset: 0x00164108
		[Token(Token = "0x17000775")]
		public override string Role
		{
			[Token(Token = "0x600463B")]
			[Address(RVA = "0x8B78B0", Offset = "0x8B5EB0", VA = "0x1808B78B0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600463C RID: 17980 RVA: 0x00165F1C File Offset: 0x0016411C
		[Token(Token = "0x17000776")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600463C")]
			[Address(RVA = "0x8B78A0", Offset = "0x8B5EA0", VA = "0x1808B78A0", Slot = "4")]
			get
			{
				return PlantType.SuperHypno;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600463D RID: 17981 RVA: 0x00165F30 File Offset: 0x00164130
		[Token(Token = "0x17000777")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600463D")]
			[Address(RVA = "0x8B7790", Offset = "0x8B5D90", VA = "0x1808B7790", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x00165F5C File Offset: 0x0016415C
		[Token(Token = "0x600463E")]
		[Address(RVA = "0x8AD470", Offset = "0x8ABA70", VA = "0x1808AD470", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00165F90 File Offset: 0x00164190
		[Token(Token = "0x600463F")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SuperHypno()
		{
		}
	}
}
