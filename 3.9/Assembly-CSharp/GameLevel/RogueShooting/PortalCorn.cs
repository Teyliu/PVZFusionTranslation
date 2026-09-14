using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D8C RID: 3468
	[Token(Token = "0x2000D8C")]
	public class PortalCorn : BaseConfig
	{
		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x00169AD4 File Offset: 0x00167CD4
		[Token(Token = "0x170008AB")]
		public override string Role
		{
			[Token(Token = "0x6004834")]
			[Address(RVA = "0x8B1340", Offset = "0x8AF940", VA = "0x1808B1340", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x00169AE8 File Offset: 0x00167CE8
		[Token(Token = "0x170008AC")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004835")]
			[Address(RVA = "0x8B1330", Offset = "0x8AF930", VA = "0x1808B1330", Slot = "4")]
			get
			{
				return PlantType.PortalCorn;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x00169AFC File Offset: 0x00167CFC
		[Token(Token = "0x170008AD")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004836")]
			[Address(RVA = "0x8B1220", Offset = "0x8AF820", VA = "0x1808B1220", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x00169B28 File Offset: 0x00167D28
		[Token(Token = "0x6004837")]
		[Address(RVA = "0x8AA970", Offset = "0x8A8F70", VA = "0x1808AA970", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x00169B5C File Offset: 0x00167D5C
		[Token(Token = "0x6004838")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public PortalCorn()
		{
		}
	}
}
