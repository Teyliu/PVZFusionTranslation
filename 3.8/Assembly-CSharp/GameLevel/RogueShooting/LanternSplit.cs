using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C1B RID: 3099
	[Token(Token = "0x2000C1B")]
	public class LanternSplit : BaseConfig
	{
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060040B9 RID: 16569 RVA: 0x00155D8C File Offset: 0x00153F8C
		[Token(Token = "0x1700050D")]
		public override string Role
		{
			[Token(Token = "0x60040B9")]
			[Address(RVA = "0x833340", Offset = "0x831940", VA = "0x180833340", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x00155DA0 File Offset: 0x00153FA0
		[Token(Token = "0x1700050E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60040BA")]
			[Address(RVA = "0x833330", Offset = "0x831930", VA = "0x180833330", Slot = "4")]
			get
			{
				return PlantType.LanternSplit;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060040BB RID: 16571 RVA: 0x00155DB4 File Offset: 0x00153FB4
		[Token(Token = "0x1700050F")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60040BB")]
			[Address(RVA = "0x833210", Offset = "0x831810", VA = "0x180833210", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1382L);
				upgradeBuff.targetType = (PlantType)((ulong)984L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00155DFC File Offset: 0x00153FFC
		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x82E940", Offset = "0x82CF40", VA = "0x18082E940", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x00155E30 File Offset: 0x00154030
		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public LanternSplit()
		{
		}
	}
}
