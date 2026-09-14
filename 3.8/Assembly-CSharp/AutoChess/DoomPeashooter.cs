using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A87 RID: 2695
	[Token(Token = "0x2000A87")]
	public class DoomPeashooter : PlantData
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06003768 RID: 14184 RVA: 0x00127D34 File Offset: 0x00125F34
		[Token(Token = "0x170002EB")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003768")]
			[Address(RVA = "0x7683C0", Offset = "0x7669C0", VA = "0x1807683C0", Slot = "4")]
			get
			{
				return PlantType.DoomPeashooter;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x00127D48 File Offset: 0x00125F48
		[Token(Token = "0x170002EC")]
		public override string Title
		{
			[Token(Token = "0x6003769")]
			[Address(RVA = "0x7684F0", Offset = "0x766AF0", VA = "0x1807684F0", Slot = "5")]
			get
			{
				return "禁忌之力";
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600376A RID: 14186 RVA: 0x00127D5C File Offset: 0x00125F5C
		[Token(Token = "0x170002ED")]
		public override string Description
		{
			[Token(Token = "0x600376A")]
			[Address(RVA = "0x768390", Offset = "0x766990", VA = "0x180768390", Slot = "6")]
			get
			{
				return "攻击附带余烬效果，并在可发射毁灭菇子弹";
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x00127D70 File Offset: 0x00125F70
		[Token(Token = "0x170002EE")]
		public override int Cost
		{
			[Token(Token = "0x600376B")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600376C RID: 14188 RVA: 0x00127D80 File Offset: 0x00125F80
		[Token(Token = "0x170002EF")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600376C")]
			[Address(RVA = "0x7683D0", Offset = "0x7669D0", VA = "0x1807683D0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00127DBC File Offset: 0x00125FBC
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public DoomPeashooter()
		{
		}
	}
}
