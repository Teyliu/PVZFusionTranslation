using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C1F RID: 3103
	[Token(Token = "0x2000C1F")]
	public class SniperPea : BaseConfig
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x00156074 File Offset: 0x00154274
		[Token(Token = "0x1700051F")]
		public override string Role
		{
			[Token(Token = "0x60040D3")]
			[Address(RVA = "0x838BF0", Offset = "0x8371F0", VA = "0x180838BF0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x00156088 File Offset: 0x00154288
		[Token(Token = "0x17000520")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60040D4")]
			[Address(RVA = "0x838BE0", Offset = "0x8371E0", VA = "0x180838BE0", Slot = "4")]
			get
			{
				return PlantType.SniperPea;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x0015609C File Offset: 0x0015429C
		[Token(Token = "0x17000521")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60040D5")]
			[Address(RVA = "0x838AC0", Offset = "0x8370C0", VA = "0x180838AC0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1109L);
				upgradeBuff.targetType = (PlantType)((ulong)1272L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x001560E4 File Offset: 0x001542E4
		[Token(Token = "0x60040D6")]
		[Address(RVA = "0x838A90", Offset = "0x837090", VA = "0x180838A90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.ModifySpeed((PlantSpeedAdder)((uint)3), 3f);
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00156104 File Offset: 0x00154304
		[Token(Token = "0x60040D7")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SniperPea()
		{
		}
	}
}
