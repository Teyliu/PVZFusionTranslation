using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000A8A")]
	public class GoldMagnet : PlantData
	{
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x00127F10 File Offset: 0x00126110
		[Token(Token = "0x170002FA")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600377A")]
			[Address(RVA = "0x76B5B0", Offset = "0x769BB0", VA = "0x18076B5B0", Slot = "4")]
			get
			{
				return PlantType.GoldMagnet;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x00127F24 File Offset: 0x00126124
		[Token(Token = "0x170002FB")]
		public override string Title
		{
			[Token(Token = "0x600377B")]
			[Address(RVA = "0x76B730", Offset = "0x769D30", VA = "0x18076B730", Slot = "5")]
			get
			{
				return "护你左右";
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x00127F38 File Offset: 0x00126138
		[Token(Token = "0x170002FC")]
		public override string Description
		{
			[Token(Token = "0x600377C")]
			[Address(RVA = "0x76B580", Offset = "0x769B80", VA = "0x18076B580", Slot = "6")]
			get
			{
				return "吸引子弹可以提高子弹伤害，并提供更多金币";
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x00127F4C File Offset: 0x0012614C
		[Token(Token = "0x170002FD")]
		public override int Cost
		{
			[Token(Token = "0x600377D")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x00127F5C File Offset: 0x0012615C
		[Token(Token = "0x170002FE")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600377E")]
			[Address(RVA = "0x76B5C0", Offset = "0x769BC0", VA = "0x18076B5C0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00127FA0 File Offset: 0x001261A0
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public GoldMagnet()
		{
		}
	}
}
