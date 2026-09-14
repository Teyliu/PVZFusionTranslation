using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AAE RID: 2734
	[Token(Token = "0x2000AAE")]
	public class StarFruit : PlantData
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x0012C000 File Offset: 0x0012A200
		[Token(Token = "0x170002B6")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003816")]
			[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "4")]
			get
			{
				return PlantType.StarFruit;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x0012C010 File Offset: 0x0012A210
		[Token(Token = "0x170002B7")]
		public override string Title
		{
			[Token(Token = "0x6003817")]
			[Address(RVA = "0x7DF6F0", Offset = "0x7DDCF0", VA = "0x1807DF6F0", Slot = "5")]
			get
			{
				return "大捷！大捷！";
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06003818 RID: 14360 RVA: 0x0012C024 File Offset: 0x0012A224
		[Token(Token = "0x170002B8")]
		public override string Description
		{
			[Token(Token = "0x6003818")]
			[Address(RVA = "0x7DF5A0", Offset = "0x7DDBA0", VA = "0x1807DF5A0", Slot = "6")]
			get
			{
				return "发射的子弹附带追踪效果";
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x0012C038 File Offset: 0x0012A238
		[Token(Token = "0x170002B9")]
		public override int Cost
		{
			[Token(Token = "0x6003819")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600381A RID: 14362 RVA: 0x0012C048 File Offset: 0x0012A248
		[Token(Token = "0x170002BA")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600381A")]
			[Address(RVA = "0x7DF5D0", Offset = "0x7DDBD0", VA = "0x1807DF5D0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x0012C084 File Offset: 0x0012A284
		[Token(Token = "0x600381B")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public StarFruit()
		{
		}
	}
}
