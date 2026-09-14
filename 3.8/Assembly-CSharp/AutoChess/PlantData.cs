using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AA4 RID: 2724
	[Token(Token = "0x2000AA4")]
	public abstract class PlantData
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06003811 RID: 14353
		[Token(Token = "0x17000377")]
		public abstract PlantType PlantType
		{
			[Token(Token = "0x6003811")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06003812 RID: 14354
		[Token(Token = "0x17000378")]
		public abstract string Title
		{
			[Token(Token = "0x6003812")]
			[Address(Slot = "5")]
			get;
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06003813 RID: 14355
		[Token(Token = "0x17000379")]
		public abstract string Description
		{
			[Token(Token = "0x6003813")]
			[Address(Slot = "6")]
			get;
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06003814 RID: 14356
		[Token(Token = "0x1700037A")]
		public abstract List<SynergyType> Synergy
		{
			[Token(Token = "0x6003814")]
			[Address(Slot = "7")]
			get;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x00128E78 File Offset: 0x00127078
		// (set) Token: 0x06003816 RID: 14358 RVA: 0x00128E8C File Offset: 0x0012708C
		[Token(Token = "0x1700037B")]
		public virtual int Cost
		{
			[Token(Token = "0x6003815")]
			[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420", Slot = "8")]
			get;
			[Token(Token = "0x6003816")]
			[Address(RVA = "0x4A9D70", Offset = "0x4A8370", VA = "0x1804A9D70", Slot = "9")]
			set;
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00128EA0 File Offset: 0x001270A0
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		protected PlantData()
		{
		}
	}
}
