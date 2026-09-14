using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CD1 RID: 3281
	[Token(Token = "0x2000CD1")]
	public class HelmetGatling : BaseConfig
	{
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x001624A8 File Offset: 0x001606A8
		[Token(Token = "0x1700061A")]
		public override string Role
		{
			[Token(Token = "0x600440A")]
			[Address(RVA = "0x8AD5E0", Offset = "0x8ABBE0", VA = "0x1808AD5E0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x001624BC File Offset: 0x001606BC
		[Token(Token = "0x1700061B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600440B")]
			[Address(RVA = "0x8AD5D0", Offset = "0x8ABBD0", VA = "0x1808AD5D0", Slot = "4")]
			get
			{
				return PlantType.HelmetGatling;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x001624D0 File Offset: 0x001606D0
		[Token(Token = "0x1700061C")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600440C")]
			[Address(RVA = "0x8AD4C0", Offset = "0x8ABAC0", VA = "0x1808AD4C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x001624FC File Offset: 0x001606FC
		[Token(Token = "0x600440D")]
		[Address(RVA = "0x8AD470", Offset = "0x8ABA70", VA = "0x1808AD470", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00162530 File Offset: 0x00160730
		[Token(Token = "0x600440E")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public HelmetGatling()
		{
		}
	}
}
