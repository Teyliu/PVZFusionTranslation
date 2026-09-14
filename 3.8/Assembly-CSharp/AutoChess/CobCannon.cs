using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A7D RID: 2685
	[Token(Token = "0x2000A7D")]
	public class CobCannon : PlantData
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x0012770C File Offset: 0x0012590C
		[Token(Token = "0x170002B9")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600372C")]
			[Address(RVA = "0x768010", Offset = "0x766610", VA = "0x180768010", Slot = "4")]
			get
			{
				return PlantType.CobCannon;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600372D RID: 14125 RVA: 0x00127720 File Offset: 0x00125920
		[Token(Token = "0x170002BA")]
		public override string Title
		{
			[Token(Token = "0x600372D")]
			[Address(RVA = "0x768190", Offset = "0x766790", VA = "0x180768190", Slot = "5")]
			get
			{
				return "火箭发射";
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x00127734 File Offset: 0x00125934
		[Token(Token = "0x170002BB")]
		public override string Description
		{
			[Token(Token = "0x600372E")]
			[Address(RVA = "0x767FE0", Offset = "0x7665E0", VA = "0x180767FE0", Slot = "6")]
			get
			{
				return "每次攻击后，提供伤害加成，敌人受到的伤害增加";
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600372F RID: 14127 RVA: 0x00127748 File Offset: 0x00125948
		[Token(Token = "0x170002BC")]
		public override int Cost
		{
			[Token(Token = "0x600372F")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x00127758 File Offset: 0x00125958
		[Token(Token = "0x170002BD")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003730")]
			[Address(RVA = "0x768020", Offset = "0x766620", VA = "0x180768020", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x0012779C File Offset: 0x0012599C
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public CobCannon()
		{
		}
	}
}
