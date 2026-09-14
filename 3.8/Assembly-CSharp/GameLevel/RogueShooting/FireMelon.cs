using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA5 RID: 3237
	[Token(Token = "0x2000CA5")]
	public class FireMelon : BaseConfig
	{
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x0015BC44 File Offset: 0x00159E44
		[Token(Token = "0x17000700")]
		public override string Role
		{
			[Token(Token = "0x60043D9")]
			[Address(RVA = "0x8311D0", Offset = "0x82F7D0", VA = "0x1808311D0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060043DA RID: 17370 RVA: 0x0015BC58 File Offset: 0x00159E58
		[Token(Token = "0x17000701")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043DA")]
			[Address(RVA = "0x8311C0", Offset = "0x82F7C0", VA = "0x1808311C0", Slot = "4")]
			get
			{
				return PlantType.FireMelon;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x0015BC6C File Offset: 0x00159E6C
		[Token(Token = "0x17000702")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043DB")]
			[Address(RVA = "0x8310A0", Offset = "0x82F6A0", VA = "0x1808310A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1149L);
				upgradeBuff.targetType = (PlantType)((ulong)940L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x0015BCB4 File Offset: 0x00159EB4
		[Token(Token = "0x60043DC")]
		[Address(RVA = "0x82E940", Offset = "0x82CF40", VA = "0x18082E940", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x0015BCE8 File Offset: 0x00159EE8
		[Token(Token = "0x60043DD")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public FireMelon()
		{
		}
	}
}
