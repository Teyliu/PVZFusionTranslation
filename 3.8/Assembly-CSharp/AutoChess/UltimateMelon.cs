using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A9F RID: 2719
	[Token(Token = "0x2000A9F")]
	public class UltimateMelon : PlantData
	{
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060037F8 RID: 14328 RVA: 0x00128BF4 File Offset: 0x00126DF4
		[Token(Token = "0x17000363")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037F8")]
			[Address(RVA = "0x781C80", Offset = "0x780280", VA = "0x180781C80", Slot = "4")]
			get
			{
				return PlantType.UltimateMelon;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x00128C08 File Offset: 0x00126E08
		[Token(Token = "0x17000364")]
		public override string Title
		{
			[Token(Token = "0x60037F9")]
			[Address(RVA = "0x781DB0", Offset = "0x7803B0", VA = "0x180781DB0", Slot = "5")]
			get
			{
				return "窥视奥纪";
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060037FA RID: 14330 RVA: 0x00128C1C File Offset: 0x00126E1C
		[Token(Token = "0x17000365")]
		public override string Description
		{
			[Token(Token = "0x60037FA")]
			[Address(RVA = "0x781C50", Offset = "0x780250", VA = "0x180781C50", Slot = "6")]
			get
			{
				return "蒜毒叠加的层数提高";
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x00128C30 File Offset: 0x00126E30
		[Token(Token = "0x17000366")]
		public override int Cost
		{
			[Token(Token = "0x60037FB")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060037FC RID: 14332 RVA: 0x00128C40 File Offset: 0x00126E40
		[Token(Token = "0x17000367")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037FC")]
			[Address(RVA = "0x781C90", Offset = "0x780290", VA = "0x180781C90", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00128C7C File Offset: 0x00126E7C
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateMelon()
		{
		}
	}
}
