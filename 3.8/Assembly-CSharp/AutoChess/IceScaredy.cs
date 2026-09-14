using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A82 RID: 2690
	[Token(Token = "0x2000A82")]
	public class IceScaredy : PlantData
	{
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x00127A28 File Offset: 0x00125C28
		[Token(Token = "0x170002D2")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600374A")]
			[Address(RVA = "0x76BAB0", Offset = "0x76A0B0", VA = "0x18076BAB0", Slot = "4")]
			get
			{
				return PlantType.IceScaredyShroom;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x00127A3C File Offset: 0x00125C3C
		[Token(Token = "0x170002D3")]
		public override string Title
		{
			[Token(Token = "0x600374B")]
			[Address(RVA = "0x76BBE0", Offset = "0x76A1E0", VA = "0x18076BBE0", Slot = "5")]
			get
			{
				return "石破天惊";
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x00127A50 File Offset: 0x00125C50
		[Token(Token = "0x170002D4")]
		public override string Description
		{
			[Token(Token = "0x600374C")]
			[Address(RVA = "0x76BA80", Offset = "0x76A080", VA = "0x18076BA80", Slot = "6")]
			get
			{
				return "攻击附带1级寒冷，敌人被冻结后受到的伤害提高";
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x00127A64 File Offset: 0x00125C64
		[Token(Token = "0x170002D5")]
		public override int Cost
		{
			[Token(Token = "0x600374D")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x00127A74 File Offset: 0x00125C74
		[Token(Token = "0x170002D6")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600374E")]
			[Address(RVA = "0x76BAC0", Offset = "0x76A0C0", VA = "0x18076BAC0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00127AB0 File Offset: 0x00125CB0
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public IceScaredy()
		{
		}
	}
}
