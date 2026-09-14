using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CB9 RID: 3257
	[Token(Token = "0x2000CB9")]
	public class LotusBamboo : BaseConfig
	{
		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x0015C954 File Offset: 0x0015AB54
		[Token(Token = "0x17000749")]
		public override string Role
		{
			[Token(Token = "0x600444C")]
			[Address(RVA = "0x833970", Offset = "0x831F70", VA = "0x180833970", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x0015C968 File Offset: 0x0015AB68
		[Token(Token = "0x1700074A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600444D")]
			[Address(RVA = "0x833960", Offset = "0x831F60", VA = "0x180833960", Slot = "4")]
			get
			{
				return PlantType.LotusBamboo;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x0015C97C File Offset: 0x0015AB7C
		[Token(Token = "0x1700074B")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600444E")]
			[Address(RVA = "0x833840", Offset = "0x831E40", VA = "0x180833840", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1258L);
				upgradeBuff.targetType = (PlantType)((ulong)980L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x0015C9C4 File Offset: 0x0015ABC4
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x0015C9D4 File Offset: 0x0015ABD4
		[Token(Token = "0x6004450")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public LotusBamboo()
		{
		}
	}
}
