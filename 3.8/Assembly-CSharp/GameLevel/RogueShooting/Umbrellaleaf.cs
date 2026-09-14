using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CB3 RID: 3251
	[Token(Token = "0x2000CB3")]
	public class Umbrellaleaf : BaseConfig
	{
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x0015C57C File Offset: 0x0015A77C
		[Token(Token = "0x17000731")]
		public override string Role
		{
			[Token(Token = "0x6004428")]
			[Address(RVA = "0x844A70", Offset = "0x843070", VA = "0x180844A70", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x0015C590 File Offset: 0x0015A790
		[Token(Token = "0x17000732")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004429")]
			[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "4")]
			get
			{
				return PlantType.Umbrellaleaf;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x0015C5A0 File Offset: 0x0015A7A0
		[Token(Token = "0x17000733")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600442A")]
			[Address(RVA = "0x844950", Offset = "0x842F50", VA = "0x180844950", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)30L);
				upgradeBuff.targetType = (PlantType)((ulong)1185L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x0015C5E4 File Offset: 0x0015A7E4
		[Token(Token = "0x600442B")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x0015C5F4 File Offset: 0x0015A7F4
		[Token(Token = "0x600442C")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Umbrellaleaf()
		{
		}
	}
}
