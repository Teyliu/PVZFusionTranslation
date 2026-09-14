using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CEF RID: 3311
	[Token(Token = "0x2000CEF")]
	public class SuperChomper : BaseConfig
	{
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060044BD RID: 17597 RVA: 0x0016363C File Offset: 0x0016183C
		[Token(Token = "0x17000688")]
		public override string Role
		{
			[Token(Token = "0x60044BD")]
			[Address(RVA = "0x8B76A0", Offset = "0x8B5CA0", VA = "0x1808B76A0", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x00163650 File Offset: 0x00161850
		[Token(Token = "0x17000689")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044BE")]
			[Address(RVA = "0x3F3540", Offset = "0x3F1B40", VA = "0x1803F3540", Slot = "4")]
			get
			{
				return PlantType.SuperChomper;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060044BF RID: 17599 RVA: 0x00163664 File Offset: 0x00161864
		[Token(Token = "0x1700068A")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044BF")]
			[Address(RVA = "0x8B7590", Offset = "0x8B5B90", VA = "0x1808B7590", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00163690 File Offset: 0x00161890
		[Token(Token = "0x60044C0")]
		[Address(RVA = "0x8B7540", Offset = "0x8B5B40", VA = "0x1808B7540", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(1f);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x001636B4 File Offset: 0x001618B4
		[Token(Token = "0x60044C1")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SuperChomper()
		{
		}
	}
}
