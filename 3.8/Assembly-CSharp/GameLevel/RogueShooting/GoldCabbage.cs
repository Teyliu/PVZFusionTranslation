using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C9A RID: 3226
	[Token(Token = "0x2000C9A")]
	public class GoldCabbage : BaseConfig
	{
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x0015B474 File Offset: 0x00159674
		[Token(Token = "0x170006D4")]
		public override string Role
		{
			[Token(Token = "0x6004397")]
			[Address(RVA = "0x8319C0", Offset = "0x82FFC0", VA = "0x1808319C0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x0015B488 File Offset: 0x00159688
		[Token(Token = "0x170006D5")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004398")]
			[Address(RVA = "0x76B240", Offset = "0x769840", VA = "0x18076B240", Slot = "4")]
			get
			{
				return PlantType.GoldCabbage;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x0015B49C File Offset: 0x0015969C
		[Token(Token = "0x170006D6")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004399")]
			[Address(RVA = "0x8318A0", Offset = "0x82FEA0", VA = "0x1808318A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1135L);
				upgradeBuff.targetType = (PlantType)((ulong)934L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x0015B4E4 File Offset: 0x001596E4
		[Token(Token = "0x600439A")]
		[Address(RVA = "0x831850", Offset = "0x82FE50", VA = "0x180831850", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 24f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x0015B518 File Offset: 0x00159718
		[Token(Token = "0x600439B")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public GoldCabbage()
		{
		}
	}
}
