using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C96 RID: 3222
	[Token(Token = "0x2000C96")]
	public class SwordStar : BaseConfig
	{
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06004381 RID: 17281 RVA: 0x0015B1A0 File Offset: 0x001593A0
		[Token(Token = "0x170006C6")]
		public override string Role
		{
			[Token(Token = "0x6004381")]
			[Address(RVA = "0x83B690", Offset = "0x839C90", VA = "0x18083B690", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x0015B1B4 File Offset: 0x001593B4
		[Token(Token = "0x170006C7")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004382")]
			[Address(RVA = "0x83B680", Offset = "0x839C80", VA = "0x18083B680", Slot = "4")]
			get
			{
				return PlantType.SwordStar;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x0015B1C8 File Offset: 0x001593C8
		[Token(Token = "0x170006C8")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004383")]
			[Address(RVA = "0x83B560", Offset = "0x839B60", VA = "0x18083B560", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)249L);
				upgradeBuff.targetType = (PlantType)((ulong)300L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x0015B210 File Offset: 0x00159410
		[Token(Token = "0x6004384")]
		[Address(RVA = "0x831E70", Offset = "0x830470", VA = "0x180831E70", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x0015B244 File Offset: 0x00159444
		[Token(Token = "0x6004385")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SwordStar()
		{
		}
	}
}
