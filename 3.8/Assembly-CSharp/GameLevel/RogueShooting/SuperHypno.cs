using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C5F RID: 3167
	[Token(Token = "0x2000C5F")]
	public class SuperHypno : BaseConfig
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x001589B0 File Offset: 0x00156BB0
		[Token(Token = "0x1700060C")]
		public override string Role
		{
			[Token(Token = "0x600424B")]
			[Address(RVA = "0x83AAA0", Offset = "0x8390A0", VA = "0x18083AAA0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600424C RID: 16972 RVA: 0x001589C4 File Offset: 0x00156BC4
		[Token(Token = "0x1700060D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600424C")]
			[Address(RVA = "0x83AA90", Offset = "0x839090", VA = "0x18083AA90", Slot = "4")]
			get
			{
				return PlantType.SuperHypno;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600424D RID: 16973 RVA: 0x001589D8 File Offset: 0x00156BD8
		[Token(Token = "0x1700060E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600424D")]
			[Address(RVA = "0x83A970", Offset = "0x838F70", VA = "0x18083A970", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1026L);
				upgradeBuff.targetType = (PlantType)((ulong)924L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x00158A20 File Offset: 0x00156C20
		[Token(Token = "0x600424E")]
		[Address(RVA = "0x831E70", Offset = "0x830470", VA = "0x180831E70", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00158A54 File Offset: 0x00156C54
		[Token(Token = "0x600424F")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SuperHypno()
		{
		}
	}
}
