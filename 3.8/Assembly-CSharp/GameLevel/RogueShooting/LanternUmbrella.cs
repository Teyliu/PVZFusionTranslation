using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CB4 RID: 3252
	[Token(Token = "0x2000CB4")]
	public class LanternUmbrella : BaseConfig
	{
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600442D RID: 17453 RVA: 0x0015C608 File Offset: 0x0015A808
		[Token(Token = "0x17000734")]
		public override string Role
		{
			[Token(Token = "0x600442D")]
			[Address(RVA = "0x833490", Offset = "0x831A90", VA = "0x180833490", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x0015C61C File Offset: 0x0015A81C
		[Token(Token = "0x17000735")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600442E")]
			[Address(RVA = "0x76C0F0", Offset = "0x76A6F0", VA = "0x18076C0F0", Slot = "4")]
			get
			{
				return PlantType.LanternUmbrella;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600442F RID: 17455 RVA: 0x0015C630 File Offset: 0x0015A830
		[Token(Token = "0x17000736")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600442F")]
			[Address(RVA = "0x833370", Offset = "0x831970", VA = "0x180833370", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1185L);
				upgradeBuff.targetType = (PlantType)((ulong)937L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x0015C678 File Offset: 0x0015A878
		[Token(Token = "0x6004430")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x0015C688 File Offset: 0x0015A888
		[Token(Token = "0x6004431")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public LanternUmbrella()
		{
		}
	}
}
