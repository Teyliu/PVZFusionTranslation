using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A93 RID: 2707
	[Token(Token = "0x2000A93")]
	public class UltimateSunflower : PlantData
	{
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x001284A4 File Offset: 0x001266A4
		[Token(Token = "0x17000327")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037B0")]
			[Address(RVA = "0x782130", Offset = "0x780730", VA = "0x180782130", Slot = "4")]
			get
			{
				return PlantType.UltimateSunflower;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x001284B8 File Offset: 0x001266B8
		[Token(Token = "0x17000328")]
		public override string Title
		{
			[Token(Token = "0x60037B1")]
			[Address(RVA = "0x782260", Offset = "0x780860", VA = "0x180782260", Slot = "5")]
			get
			{
				return "双子奇兵";
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x001284CC File Offset: 0x001266CC
		[Token(Token = "0x17000329")]
		public override string Description
		{
			[Token(Token = "0x60037B2")]
			[Address(RVA = "0x782100", Offset = "0x780700", VA = "0x180782100", Slot = "6")]
			get
			{
				return "释放攻击后生阳光额外攻击，会基于场上向日葵的数量增加攻击段数";
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x001284E0 File Offset: 0x001266E0
		[Token(Token = "0x1700032A")]
		public override int Cost
		{
			[Token(Token = "0x60037B3")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x001284F0 File Offset: 0x001266F0
		[Token(Token = "0x1700032B")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037B4")]
			[Address(RVA = "0x782140", Offset = "0x780740", VA = "0x180782140", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x0012852C File Offset: 0x0012672C
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateSunflower()
		{
		}
	}
}
