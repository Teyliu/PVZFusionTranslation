using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C58 RID: 3160
	[Token(Token = "0x2000C58")]
	public class HypnoNut : BaseConfig
	{
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x001585B4 File Offset: 0x001567B4
		[Token(Token = "0x170005F9")]
		public override string Role
		{
			[Token(Token = "0x6004228")]
			[Address(RVA = "0x8328F0", Offset = "0x830EF0", VA = "0x1808328F0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06004229 RID: 16937 RVA: 0x001585C8 File Offset: 0x001567C8
		[Token(Token = "0x170005FA")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004229")]
			[Address(RVA = "0x8328E0", Offset = "0x830EE0", VA = "0x1808328E0", Slot = "4")]
			get
			{
				return PlantType.HypnoNut;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x001585DC File Offset: 0x001567DC
		[Token(Token = "0x170005FB")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600422A")]
			[Address(RVA = "0x8327C0", Offset = "0x830DC0", VA = "0x1808327C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1147L);
				upgradeBuff.targetType = (PlantType)((ulong)900L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x00158624 File Offset: 0x00156824
		[Token(Token = "0x600422B")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x00158634 File Offset: 0x00156834
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public HypnoNut()
		{
		}
	}
}
