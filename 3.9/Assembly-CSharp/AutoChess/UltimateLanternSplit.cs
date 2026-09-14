using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AE0 RID: 2784
	[Token(Token = "0x2000AE0")]
	public class UltimateLanternSplit : PlantData
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06003942 RID: 14658 RVA: 0x0012DEC0 File Offset: 0x0012C0C0
		[Token(Token = "0x170003B0")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003942")]
			[Address(RVA = "0x7E89A0", Offset = "0x7E6FA0", VA = "0x1807E89A0", Slot = "4")]
			get
			{
				return PlantType.UltimateLanternSplit;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x0012DED4 File Offset: 0x0012C0D4
		[Token(Token = "0x170003B1")]
		public override string Title
		{
			[Token(Token = "0x6003943")]
			[Address(RVA = "0x7E8AD0", Offset = "0x7E70D0", VA = "0x1807E8AD0", Slot = "5")]
			get
			{
				return "点燃大海";
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06003944 RID: 14660 RVA: 0x0012DEE8 File Offset: 0x0012C0E8
		[Token(Token = "0x170003B2")]
		public override string Description
		{
			[Token(Token = "0x6003944")]
			[Address(RVA = "0x7E8970", Offset = "0x7E6F70", VA = "0x1807E8970", Slot = "6")]
			get
			{
				return "出场时获得究极路灯花，超新星爆发的能量需求和伤害降低";
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x0012DEFC File Offset: 0x0012C0FC
		[Token(Token = "0x170003B3")]
		public override int Cost
		{
			[Token(Token = "0x6003945")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x0012DF0C File Offset: 0x0012C10C
		[Token(Token = "0x170003B4")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003946")]
			[Address(RVA = "0x7E89B0", Offset = "0x7E6FB0", VA = "0x1807E89B0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x0012DF48 File Offset: 0x0012C148
		[Token(Token = "0x6003947")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateLanternSplit()
		{
		}
	}
}
