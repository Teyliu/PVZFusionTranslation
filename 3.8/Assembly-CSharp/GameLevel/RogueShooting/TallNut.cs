using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C2E RID: 3118
	[Token(Token = "0x2000C2E")]
	public class TallNut : BaseConfig
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x00156A28 File Offset: 0x00154C28
		[Token(Token = "0x17000557")]
		public override string Role
		{
			[Token(Token = "0x6004130")]
			[Address(RVA = "0x83B7F0", Offset = "0x839DF0", VA = "0x18083B7F0", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x00156A3C File Offset: 0x00154C3C
		[Token(Token = "0x17000558")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004131")]
			[Address(RVA = "0x83B7E0", Offset = "0x839DE0", VA = "0x18083B7E0", Slot = "4")]
			get
			{
				return PlantType.TallNut;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x00156A50 File Offset: 0x00154C50
		[Token(Token = "0x17000559")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004132")]
			[Address(RVA = "0x83B6C0", Offset = "0x839CC0", VA = "0x18083B6C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1027L);
				upgradeBuff.targetType = (PlantType)((ulong)913L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00156A98 File Offset: 0x00154C98
		[Token(Token = "0x6004133")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00156AA8 File Offset: 0x00154CA8
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public TallNut()
		{
		}
	}
}
