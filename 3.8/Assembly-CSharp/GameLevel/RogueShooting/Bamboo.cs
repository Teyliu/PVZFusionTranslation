using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CB8 RID: 3256
	[Token(Token = "0x2000CB8")]
	public class Bamboo : BaseConfig
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x0015C8C8 File Offset: 0x0015AAC8
		[Token(Token = "0x17000746")]
		public override string Role
		{
			[Token(Token = "0x6004447")]
			[Address(RVA = "0x82E040", Offset = "0x82C640", VA = "0x18082E040", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x0015C8DC File Offset: 0x0015AADC
		[Token(Token = "0x17000747")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004448")]
			[Address(RVA = "0x69C9D0", Offset = "0x69AFD0", VA = "0x18069C9D0", Slot = "4")]
			get
			{
				return PlantType.Bamboo;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x0015C8EC File Offset: 0x0015AAEC
		[Token(Token = "0x17000748")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004449")]
			[Address(RVA = "0x82DF20", Offset = "0x82C520", VA = "0x18082DF20", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)39L);
				upgradeBuff.targetType = (PlantType)((ulong)1258L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x0015C930 File Offset: 0x0015AB30
		[Token(Token = "0x600444A")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x0015C940 File Offset: 0x0015AB40
		[Token(Token = "0x600444B")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Bamboo()
		{
		}
	}
}
