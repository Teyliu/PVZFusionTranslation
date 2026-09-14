using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C4F RID: 3151
	[Token(Token = "0x2000C4F")]
	public class GarlicFume : BaseConfig
	{
		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x00157F84 File Offset: 0x00156184
		[Token(Token = "0x170005D3")]
		public override string Role
		{
			[Token(Token = "0x60041F0")]
			[Address(RVA = "0x8316C0", Offset = "0x82FCC0", VA = "0x1808316C0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x00157F98 File Offset: 0x00156198
		[Token(Token = "0x170005D4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041F1")]
			[Address(RVA = "0x76B0B0", Offset = "0x7696B0", VA = "0x18076B0B0", Slot = "4")]
			get
			{
				return PlantType.GarlicFume;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x00157FAC File Offset: 0x001561AC
		[Token(Token = "0x170005D5")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041F2")]
			[Address(RVA = "0x8315A0", Offset = "0x82FBA0", VA = "0x1808315A0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1172L);
				upgradeBuff.targetType = (PlantType)((ulong)306L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x00157FF4 File Offset: 0x001561F4
		[Token(Token = "0x60041F3")]
		[Address(RVA = "0x82FD50", Offset = "0x82E350", VA = "0x18082FD50", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x00158028 File Offset: 0x00156228
		[Token(Token = "0x60041F4")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public GarlicFume()
		{
		}
	}
}
