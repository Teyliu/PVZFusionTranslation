using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C6B RID: 3179
	[Token(Token = "0x2000C6B")]
	public class Squalour : BaseConfig
	{
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x00159160 File Offset: 0x00157360
		[Token(Token = "0x17000637")]
		public override string Role
		{
			[Token(Token = "0x600428F")]
			[Address(RVA = "0x839210", Offset = "0x837810", VA = "0x180839210", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x00159174 File Offset: 0x00157374
		[Token(Token = "0x17000638")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004290")]
			[Address(RVA = "0x839200", Offset = "0x837800", VA = "0x180839200", Slot = "4")]
			get
			{
				return PlantType.Squalour;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x00159188 File Offset: 0x00157388
		[Token(Token = "0x17000639")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004291")]
			[Address(RVA = "0x8390E0", Offset = "0x8376E0", VA = "0x1808390E0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)248L);
				upgradeBuff.targetType = (PlantType)((ulong)926L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x001591D0 File Offset: 0x001573D0
		[Token(Token = "0x6004292")]
		[Address(RVA = "0x82EE90", Offset = "0x82D490", VA = "0x18082EE90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x001591F8 File Offset: 0x001573F8
		[Token(Token = "0x6004293")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Squalour()
		{
		}
	}
}
