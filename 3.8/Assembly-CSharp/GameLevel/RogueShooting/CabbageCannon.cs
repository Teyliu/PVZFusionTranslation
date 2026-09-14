using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C9D RID: 3229
	[Token(Token = "0x2000C9D")]
	public class CabbageCannon : BaseConfig
	{
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060043A8 RID: 17320 RVA: 0x0015B678 File Offset: 0x00159878
		[Token(Token = "0x170006DF")]
		public override string Role
		{
			[Token(Token = "0x60043A8")]
			[Address(RVA = "0x82E6F0", Offset = "0x82CCF0", VA = "0x18082E6F0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x0015B68C File Offset: 0x0015988C
		[Token(Token = "0x170006E0")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043A9")]
			[Address(RVA = "0x82E6E0", Offset = "0x82CCE0", VA = "0x18082E6E0", Slot = "4")]
			get
			{
				return PlantType.CabbageCannon;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060043AA RID: 17322 RVA: 0x0015B6A0 File Offset: 0x001598A0
		[Token(Token = "0x170006E1")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043AA")]
			[Address(RVA = "0x82E5C0", Offset = "0x82CBC0", VA = "0x18082E5C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1342L);
				upgradeBuff.targetType = (PlantType)((ulong)966L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x0015B6E8 File Offset: 0x001598E8
		[Token(Token = "0x60043AB")]
		[Address(RVA = "0x82E270", Offset = "0x82C870", VA = "0x18082E270", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x0015B710 File Offset: 0x00159910
		[Token(Token = "0x60043AC")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public CabbageCannon()
		{
		}
	}
}
