using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AA0 RID: 2720
	[Token(Token = "0x2000AA0")]
	public class UltimateLanternSplit : PlantData
	{
		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060037FE RID: 14334 RVA: 0x00128C90 File Offset: 0x00126E90
		[Token(Token = "0x17000368")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037FE")]
			[Address(RVA = "0x781AF0", Offset = "0x7800F0", VA = "0x180781AF0", Slot = "4")]
			get
			{
				return PlantType.UltimateLanternSplit;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x00128CA4 File Offset: 0x00126EA4
		[Token(Token = "0x17000369")]
		public override string Title
		{
			[Token(Token = "0x60037FF")]
			[Address(RVA = "0x781C20", Offset = "0x780220", VA = "0x180781C20", Slot = "5")]
			get
			{
				return "点燃大海";
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06003800 RID: 14336 RVA: 0x00128CB8 File Offset: 0x00126EB8
		[Token(Token = "0x1700036A")]
		public override string Description
		{
			[Token(Token = "0x6003800")]
			[Address(RVA = "0x781AC0", Offset = "0x7800C0", VA = "0x180781AC0", Slot = "6")]
			get
			{
				return "出场时获得究极路灯花，超新星爆发的能量需求和伤害降低";
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x00128CCC File Offset: 0x00126ECC
		[Token(Token = "0x1700036B")]
		public override int Cost
		{
			[Token(Token = "0x6003801")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x00128CDC File Offset: 0x00126EDC
		[Token(Token = "0x1700036C")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003802")]
			[Address(RVA = "0x781B00", Offset = "0x780100", VA = "0x180781B00", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00128D18 File Offset: 0x00126F18
		[Token(Token = "0x6003803")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateLanternSplit()
		{
		}
	}
}
