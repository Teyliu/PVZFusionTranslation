using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD5 RID: 2773
	[Token(Token = "0x2000AD5")]
	public class GarlicSniper : PlantData
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x0012D80C File Offset: 0x0012BA0C
		[Token(Token = "0x17000379")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003900")]
			[Address(RVA = "0x7D1B90", Offset = "0x7D0190", VA = "0x1807D1B90", Slot = "4")]
			get
			{
				return PlantType.GarlicSniper;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x0012D820 File Offset: 0x0012BA20
		[Token(Token = "0x1700037A")]
		public override string Title
		{
			[Token(Token = "0x6003901")]
			[Address(RVA = "0x7D1CC0", Offset = "0x7D02C0", VA = "0x1807D1CC0", Slot = "5")]
			get
			{
				return "深海回响";
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06003902 RID: 14594 RVA: 0x0012D834 File Offset: 0x0012BA34
		[Token(Token = "0x1700037B")]
		public override string Description
		{
			[Token(Token = "0x6003902")]
			[Address(RVA = "0x7D1B60", Offset = "0x7D0160", VA = "0x1807D1B60", Slot = "6")]
			get
			{
				return "攻击后为目标叠加持续蒜毒，并使地方被攻击后对范围内敌人额外造成持续蒜毒";
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x0012D848 File Offset: 0x0012BA48
		[Token(Token = "0x1700037C")]
		public override int Cost
		{
			[Token(Token = "0x6003903")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x0012D858 File Offset: 0x0012BA58
		[Token(Token = "0x1700037D")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003904")]
			[Address(RVA = "0x7D1BA0", Offset = "0x7D01A0", VA = "0x1807D1BA0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0012D894 File Offset: 0x0012BA94
		[Token(Token = "0x6003905")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public GarlicSniper()
		{
		}
	}
}
