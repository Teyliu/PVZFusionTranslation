using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D82 RID: 3458
	[Token(Token = "0x2000D82")]
	public class SilverMelon : BaseConfig
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x00169480 File Offset: 0x00167680
		[Token(Token = "0x1700088C")]
		public override string Role
		{
			[Token(Token = "0x60047FF")]
			[Address(RVA = "0x8B4FA0", Offset = "0x8B35A0", VA = "0x1808B4FA0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06004800 RID: 18432 RVA: 0x00169494 File Offset: 0x00167694
		[Token(Token = "0x1700088D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004800")]
			[Address(RVA = "0x8B4F90", Offset = "0x8B3590", VA = "0x1808B4F90", Slot = "4")]
			get
			{
				return PlantType.SilverMelon;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x001694A8 File Offset: 0x001676A8
		[Token(Token = "0x1700088E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004801")]
			[Address(RVA = "0x8B4E80", Offset = "0x8B3480", VA = "0x1808B4E80", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x001694D4 File Offset: 0x001676D4
		[Token(Token = "0x6004802")]
		[Address(RVA = "0x8B4E30", Offset = "0x8B3430", VA = "0x1808B4E30", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 7f, num2 != 0, num);
			plant.thePlantAttackInterval = 1f;
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x00169508 File Offset: 0x00167708
		[Token(Token = "0x6004803")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SilverMelon()
		{
		}
	}
}
