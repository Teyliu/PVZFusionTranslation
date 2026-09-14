using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C49 RID: 3145
	[Token(Token = "0x2000C49")]
	public class FumeShroom : BaseConfig
	{
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x00157BBC File Offset: 0x00155DBC
		[Token(Token = "0x170005BE")]
		public override string Role
		{
			[Token(Token = "0x60041CE")]
			[Address(RVA = "0x831570", Offset = "0x82FB70", VA = "0x180831570", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x00157BD0 File Offset: 0x00155DD0
		[Token(Token = "0x170005BF")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041CF")]
			[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "4")]
			get
			{
				return PlantType.FumeShroom;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060041D0 RID: 16848 RVA: 0x00157BE0 File Offset: 0x00155DE0
		[Token(Token = "0x170005C0")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041D0")]
			[Address(RVA = "0x831340", Offset = "0x82F940", VA = "0x180831340", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)7L);
				upgradeBuff.targetType = (PlantType)((ulong)1037L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)7L);
				upgradeBuff2.targetType = (PlantType)((ulong)1070L);
				int size2 = list._size;
				UpgradeBuff upgradeBuff3;
				upgradeBuff3.sourceType = (PlantType)((ulong)7L);
				upgradeBuff3.targetType = (PlantType)((ulong)1172L);
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00157C60 File Offset: 0x00155E60
		[Token(Token = "0x60041D1")]
		[Address(RVA = "0x831300", Offset = "0x82F900", VA = "0x180831300", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x00157C88 File Offset: 0x00155E88
		[Token(Token = "0x60041D2")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public FumeShroom()
		{
		}
	}
}
