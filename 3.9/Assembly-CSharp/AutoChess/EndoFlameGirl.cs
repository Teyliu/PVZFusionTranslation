using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD9 RID: 2777
	[Token(Token = "0x2000AD9")]
	public class EndoFlameGirl : PlantData
	{
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06003918 RID: 14616 RVA: 0x0012DA7C File Offset: 0x0012BC7C
		[Token(Token = "0x1700038D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003918")]
			[Address(RVA = "0x54CC50", Offset = "0x54B250", VA = "0x18054CC50", Slot = "4")]
			get
			{
				return PlantType.EndoFlameGirl;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x0012DA90 File Offset: 0x0012BC90
		[Token(Token = "0x1700038E")]
		public override string Title
		{
			[Token(Token = "0x6003919")]
			[Address(RVA = "0x7D1950", Offset = "0x7CFF50", VA = "0x1807D1950", Slot = "5")]
			get
			{
				return "全域封禁";
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600391A RID: 14618 RVA: 0x0012DAA4 File Offset: 0x0012BCA4
		[Token(Token = "0x1700038F")]
		public override string Description
		{
			[Token(Token = "0x600391A")]
			[Address(RVA = "0x7D1800", Offset = "0x7CFE00", VA = "0x1807D1800", Slot = "6")]
			get
			{
				return "攻击造成范围伤害，并削减敌人的护甲";
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600391B RID: 14619 RVA: 0x0012DAB8 File Offset: 0x0012BCB8
		[Token(Token = "0x17000390")]
		public override int Cost
		{
			[Token(Token = "0x600391B")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600391C RID: 14620 RVA: 0x0012DAC8 File Offset: 0x0012BCC8
		[Token(Token = "0x17000391")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600391C")]
			[Address(RVA = "0x7D1830", Offset = "0x7CFE30", VA = "0x1807D1830", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x0012DB04 File Offset: 0x0012BD04
		[Token(Token = "0x600391D")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public EndoFlameGirl()
		{
		}
	}
}
