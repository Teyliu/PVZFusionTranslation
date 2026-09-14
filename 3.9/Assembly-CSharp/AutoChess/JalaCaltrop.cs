using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB6 RID: 2742
	[Token(Token = "0x2000AB6")]
	public class JalaCaltrop : PlantData
	{
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x0012C4D0 File Offset: 0x0012A6D0
		[Token(Token = "0x170002DE")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003846")]
			[Address(RVA = "0x7D2C10", Offset = "0x7D1210", VA = "0x1807D2C10", Slot = "4")]
			get
			{
				return PlantType.JalaCaltrop;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06003847 RID: 14407 RVA: 0x0012C4E4 File Offset: 0x0012A6E4
		[Token(Token = "0x170002DF")]
		public override string Title
		{
			[Token(Token = "0x6003847")]
			[Address(RVA = "0x7D2D40", Offset = "0x7D1340", VA = "0x1807D2D40", Slot = "5")]
			get
			{
				return "破甲尖刺";
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06003848 RID: 14408 RVA: 0x0012C4F8 File Offset: 0x0012A6F8
		[Token(Token = "0x170002E0")]
		public override string Description
		{
			[Token(Token = "0x6003848")]
			[Address(RVA = "0x7D2BE0", Offset = "0x7D11E0", VA = "0x1807D2BE0", Slot = "6")]
			get
			{
				return "攻击会同时削减僵尸的护甲";
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06003849 RID: 14409 RVA: 0x0012C50C File Offset: 0x0012A70C
		[Token(Token = "0x170002E1")]
		public override int Cost
		{
			[Token(Token = "0x6003849")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600384A RID: 14410 RVA: 0x0012C51C File Offset: 0x0012A71C
		[Token(Token = "0x170002E2")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600384A")]
			[Address(RVA = "0x7D2C20", Offset = "0x7D1220", VA = "0x1807D2C20", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x0012C558 File Offset: 0x0012A758
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public JalaCaltrop()
		{
		}
	}
}
