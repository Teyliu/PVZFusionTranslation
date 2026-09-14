using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C14 RID: 3092
	[Token(Token = "0x2000C14")]
	public class HelmetGatling : BaseConfig
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x001558A4 File Offset: 0x00153AA4
		[Token(Token = "0x170004EE")]
		public override string Role
		{
			[Token(Token = "0x600408C")]
			[Address(RVA = "0x831FF0", Offset = "0x8305F0", VA = "0x180831FF0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600408D RID: 16525 RVA: 0x001558B8 File Offset: 0x00153AB8
		[Token(Token = "0x170004EF")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600408D")]
			[Address(RVA = "0x831FE0", Offset = "0x8305E0", VA = "0x180831FE0", Slot = "4")]
			get
			{
				return PlantType.HelmetGatling;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600408E RID: 16526 RVA: 0x001558CC File Offset: 0x00153ACC
		[Token(Token = "0x170004F0")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600408E")]
			[Address(RVA = "0x831EC0", Offset = "0x8304C0", VA = "0x180831EC0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1306L);
				upgradeBuff.targetType = (PlantType)((ulong)985L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00155914 File Offset: 0x00153B14
		[Token(Token = "0x600408F")]
		[Address(RVA = "0x831E70", Offset = "0x830470", VA = "0x180831E70", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00155948 File Offset: 0x00153B48
		[Token(Token = "0x6004090")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public HelmetGatling()
		{
		}
	}
}
