using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D7A RID: 3450
	[Token(Token = "0x2000D7A")]
	public class SuperMelon : BaseConfig
	{
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x00168ED8 File Offset: 0x001670D8
		[Token(Token = "0x17000868")]
		public override string Role
		{
			[Token(Token = "0x60047CB")]
			[Address(RVA = "0x8B7A50", Offset = "0x8B6050", VA = "0x1808B7A50", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x00168EEC File Offset: 0x001670EC
		[Token(Token = "0x17000869")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60047CC")]
			[Address(RVA = "0x8B7A40", Offset = "0x8B6040", VA = "0x1808B7A40", Slot = "4")]
			get
			{
				return PlantType.SuperMelon;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x00168F00 File Offset: 0x00167100
		[Token(Token = "0x1700086A")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60047CD")]
			[Address(RVA = "0x8B7930", Offset = "0x8B5F30", VA = "0x1808B7930", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x00168F2C File Offset: 0x0016712C
		[Token(Token = "0x60047CE")]
		[Address(RVA = "0x8B78E0", Offset = "0x8B5EE0", VA = "0x1808B78E0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)2E-44f, 4f, num2 != 0, num);
			plant.AddSpeed(2E-44f);
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x00168F60 File Offset: 0x00167160
		[Token(Token = "0x60047CF")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SuperMelon()
		{
		}
	}
}
