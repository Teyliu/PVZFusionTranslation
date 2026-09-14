using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x2000A78")]
	public class PeaFume : PlantData
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x001273E0 File Offset: 0x001255E0
		[Token(Token = "0x170002A0")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600370E")]
			[Address(RVA = "0x76FD20", Offset = "0x76E320", VA = "0x18076FD20", Slot = "4")]
			get
			{
				return PlantType.PeaFume;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x001273F4 File Offset: 0x001255F4
		[Token(Token = "0x170002A1")]
		public override string Title
		{
			[Token(Token = "0x600370F")]
			[Address(RVA = "0x76FEA0", Offset = "0x76E4A0", VA = "0x18076FEA0", Slot = "5")]
			get
			{
				return "加速喷雾";
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x00127408 File Offset: 0x00125608
		[Token(Token = "0x170002A2")]
		public override string Description
		{
			[Token(Token = "0x6003710")]
			[Address(RVA = "0x76FCF0", Offset = "0x76E2F0", VA = "0x18076FCF0", Slot = "6")]
			get
			{
				return "加速提供更高伤害，同时治疗生命值较低的植物";
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06003711 RID: 14097 RVA: 0x0012741C File Offset: 0x0012561C
		[Token(Token = "0x170002A3")]
		public override int Cost
		{
			[Token(Token = "0x6003711")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x0012742C File Offset: 0x0012562C
		[Token(Token = "0x170002A4")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003712")]
			[Address(RVA = "0x76FD30", Offset = "0x76E330", VA = "0x18076FD30", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00127470 File Offset: 0x00125670
		[Token(Token = "0x6003713")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public PeaFume()
		{
		}
	}
}
