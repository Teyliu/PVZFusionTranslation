using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C6A RID: 3178
	[Token(Token = "0x2000C6A")]
	public class Squash : BaseConfig
	{
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x0015909C File Offset: 0x0015729C
		[Token(Token = "0x17000634")]
		public override string Role
		{
			[Token(Token = "0x600428A")]
			[Address(RVA = "0x8393E0", Offset = "0x8379E0", VA = "0x1808393E0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x001590B0 File Offset: 0x001572B0
		[Token(Token = "0x17000635")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600428B")]
			[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "4")]
			get
			{
				return PlantType.Squash;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x001590C0 File Offset: 0x001572C0
		[Token(Token = "0x17000636")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600428C")]
			[Address(RVA = "0x839240", Offset = "0x837840", VA = "0x180839240", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)13L);
				upgradeBuff.targetType = (PlantType)((ulong)248L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)13L);
				upgradeBuff2.targetType = (PlantType)((ulong)1344L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x00159124 File Offset: 0x00157324
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x82EE90", Offset = "0x82D490", VA = "0x18082EE90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x0015914C File Offset: 0x0015734C
		[Token(Token = "0x600428E")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Squash()
		{
		}
	}
}
