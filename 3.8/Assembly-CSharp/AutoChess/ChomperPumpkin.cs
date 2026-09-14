using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A8C RID: 2700
	[Token(Token = "0x2000A8C")]
	public class ChomperPumpkin : PlantData
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x00128050 File Offset: 0x00126250
		[Token(Token = "0x17000304")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003786")]
			[Address(RVA = "0x767D00", Offset = "0x766300", VA = "0x180767D00", Slot = "4")]
			get
			{
				return PlantType.ChomperPumpkin;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x00128064 File Offset: 0x00126264
		[Token(Token = "0x17000305")]
		public override string Title
		{
			[Token(Token = "0x6003787")]
			[Address(RVA = "0x767E30", Offset = "0x766430", VA = "0x180767E30", Slot = "5")]
			get
			{
				return "护你左右";
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x00128078 File Offset: 0x00126278
		[Token(Token = "0x17000306")]
		public override string Description
		{
			[Token(Token = "0x6003788")]
			[Address(RVA = "0x767CD0", Offset = "0x7662D0", VA = "0x180767CD0", Slot = "6")]
			get
			{
				return "出场自带点数，点数上限增加";
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x0012808C File Offset: 0x0012628C
		[Token(Token = "0x17000307")]
		public override int Cost
		{
			[Token(Token = "0x6003789")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x0012809C File Offset: 0x0012629C
		[Token(Token = "0x17000308")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600378A")]
			[Address(RVA = "0x767D10", Offset = "0x766310", VA = "0x180767D10", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x001280D8 File Offset: 0x001262D8
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ChomperPumpkin()
		{
		}
	}
}
