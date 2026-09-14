using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C41 RID: 3137
	[Token(Token = "0x2000C41")]
	public class IcePuff : BaseConfig
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x00157700 File Offset: 0x00155900
		[Token(Token = "0x170005A2")]
		public override string Role
		{
			[Token(Token = "0x60041A1")]
			[Address(RVA = "0x833030", Offset = "0x831630", VA = "0x180833030", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060041A2 RID: 16802 RVA: 0x00157714 File Offset: 0x00155914
		[Token(Token = "0x170005A3")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041A2")]
			[Address(RVA = "0x833020", Offset = "0x831620", VA = "0x180833020", Slot = "4")]
			get
			{
				return PlantType.IcePuff;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x00157728 File Offset: 0x00155928
		[Token(Token = "0x170005A4")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041A3")]
			[Address(RVA = "0x832F00", Offset = "0x831500", VA = "0x180832F00", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1035L);
				upgradeBuff.targetType = (PlantType)((ulong)908L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00157770 File Offset: 0x00155970
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0x82FD50", Offset = "0x82E350", VA = "0x18082FD50", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x001577A4 File Offset: 0x001559A4
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public IcePuff()
		{
		}
	}
}
