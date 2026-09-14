using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ABB RID: 2747
	[Token(Token = "0x2000ABB")]
	public class StarNut : PlantData
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06003864 RID: 14436 RVA: 0x0012C7F4 File Offset: 0x0012A9F4
		[Token(Token = "0x170002F7")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003864")]
			[Address(RVA = "0x7DF750", Offset = "0x7DDD50", VA = "0x1807DF750", Slot = "4")]
			get
			{
				return PlantType.StarNut;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x0012C808 File Offset: 0x0012AA08
		[Token(Token = "0x170002F8")]
		public override string Title
		{
			[Token(Token = "0x6003865")]
			[Address(RVA = "0x7DF8D0", Offset = "0x7DDED0", VA = "0x1807DF8D0", Slot = "5")]
			get
			{
				return "博弈论";
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06003866 RID: 14438 RVA: 0x0012C81C File Offset: 0x0012AA1C
		[Token(Token = "0x170002F9")]
		public override string Description
		{
			[Token(Token = "0x6003866")]
			[Address(RVA = "0x7DF720", Offset = "0x7DDD20", VA = "0x1807DF720", Slot = "6")]
			get
			{
				return "随时间提供更多护盾，我方小队伤害提高";
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x0012C830 File Offset: 0x0012AA30
		[Token(Token = "0x170002FA")]
		public override int Cost
		{
			[Token(Token = "0x6003867")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06003868 RID: 14440 RVA: 0x0012C840 File Offset: 0x0012AA40
		[Token(Token = "0x170002FB")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003868")]
			[Address(RVA = "0x7DF760", Offset = "0x7DDD60", VA = "0x1807DF760", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x0012C884 File Offset: 0x0012AA84
		[Token(Token = "0x6003869")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public StarNut()
		{
		}
	}
}
