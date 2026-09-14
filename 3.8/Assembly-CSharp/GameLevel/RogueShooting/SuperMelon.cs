using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA1 RID: 3233
	[Token(Token = "0x2000CA1")]
	public class SuperMelon : BaseConfig
	{
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x0015B954 File Offset: 0x00159B54
		[Token(Token = "0x170006ED")]
		public override string Role
		{
			[Token(Token = "0x60043BE")]
			[Address(RVA = "0x83AC50", Offset = "0x839250", VA = "0x18083AC50", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x0015B968 File Offset: 0x00159B68
		[Token(Token = "0x170006EE")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043BF")]
			[Address(RVA = "0x83AC40", Offset = "0x839240", VA = "0x18083AC40", Slot = "4")]
			get
			{
				return PlantType.SuperMelon;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060043C0 RID: 17344 RVA: 0x0015B97C File Offset: 0x00159B7C
		[Token(Token = "0x170006EF")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043C0")]
			[Address(RVA = "0x83AB20", Offset = "0x839120", VA = "0x18083AB20", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1126L);
				upgradeBuff.targetType = (PlantType)((ulong)914L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x0015B9C4 File Offset: 0x00159BC4
		[Token(Token = "0x60043C1")]
		[Address(RVA = "0x83AAD0", Offset = "0x8390D0", VA = "0x18083AAD0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)2E-44f, 4f, num2 != 0, num);
			plant.AddSpeed(2E-44f);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x0015B9F8 File Offset: 0x00159BF8
		[Token(Token = "0x60043C2")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SuperMelon()
		{
		}
	}
}
