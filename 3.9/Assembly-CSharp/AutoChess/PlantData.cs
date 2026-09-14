using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AE4 RID: 2788
	[Token(Token = "0x2000AE4")]
	public abstract class PlantData
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06003955 RID: 14677
		[Token(Token = "0x170003BF")]
		public abstract PlantType PlantType
		{
			[Token(Token = "0x6003955")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06003956 RID: 14678
		[Token(Token = "0x170003C0")]
		public abstract string Title
		{
			[Token(Token = "0x6003956")]
			[Address(Slot = "5")]
			get;
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06003957 RID: 14679
		[Token(Token = "0x170003C1")]
		public abstract string Description
		{
			[Token(Token = "0x6003957")]
			[Address(Slot = "6")]
			get;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06003958 RID: 14680
		[Token(Token = "0x170003C2")]
		public abstract List<SynergyType> Synergy
		{
			[Token(Token = "0x6003958")]
			[Address(Slot = "7")]
			get;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x0012E0A8 File Offset: 0x0012C2A8
		// (set) Token: 0x0600395A RID: 14682 RVA: 0x0012E0BC File Offset: 0x0012C2BC
		[Token(Token = "0x170003C3")]
		public virtual int Cost
		{
			[Token(Token = "0x6003959")]
			[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430", Slot = "8")]
			get;
			[Token(Token = "0x600395A")]
			[Address(RVA = "0x5159A0", Offset = "0x513FA0", VA = "0x1805159A0", Slot = "9")]
			set;
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x0012E0D0 File Offset: 0x0012C2D0
		[Token(Token = "0x600395B")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected PlantData()
		{
		}
	}
}
