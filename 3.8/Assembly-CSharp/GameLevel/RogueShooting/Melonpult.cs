using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA0 RID: 3232
	[Token(Token = "0x2000CA0")]
	public class Melonpult : BaseConfig
	{
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x0015B870 File Offset: 0x00159A70
		[Token(Token = "0x170006EA")]
		public override string Role
		{
			[Token(Token = "0x60043B9")]
			[Address(RVA = "0x833F80", Offset = "0x832580", VA = "0x180833F80", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060043BA RID: 17338 RVA: 0x0015B884 File Offset: 0x00159A84
		[Token(Token = "0x170006EB")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043BA")]
			[Address(RVA = "0x6A3410", Offset = "0x6A1A10", VA = "0x1806A3410", Slot = "4")]
			get
			{
				return PlantType.Melonpult;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060043BB RID: 17339 RVA: 0x0015B894 File Offset: 0x00159A94
		[Token(Token = "0x170006EC")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043BB")]
			[Address(RVA = "0x833D50", Offset = "0x832350", VA = "0x180833D50", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)32L);
				upgradeBuff.targetType = (PlantType)((ulong)1126L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)32L);
				upgradeBuff2.targetType = (PlantType)((ulong)1149L);
				int size2 = list._size;
				UpgradeBuff upgradeBuff3;
				upgradeBuff3.sourceType = (PlantType)((ulong)32L);
				upgradeBuff3.targetType = (PlantType)((ulong)1116L);
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x0015B918 File Offset: 0x00159B18
		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x82E270", Offset = "0x82C870", VA = "0x18082E270", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x0015B940 File Offset: 0x00159B40
		[Token(Token = "0x60043BD")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Melonpult()
		{
		}
	}
}
