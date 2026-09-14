using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A6C RID: 2668
	[Token(Token = "0x2000A6C")]
	public class Marigold : PlantData
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x00126C90 File Offset: 0x00124E90
		[Token(Token = "0x17000264")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036C6")]
			[Address(RVA = "0x6A3170", Offset = "0x6A1770", VA = "0x1806A3170", Slot = "4")]
			get
			{
				return PlantType.Marigold;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060036C7 RID: 14023 RVA: 0x00126CA0 File Offset: 0x00124EA0
		[Token(Token = "0x17000265")]
		public override string Title
		{
			[Token(Token = "0x60036C7")]
			[Address(RVA = "0x76C580", Offset = "0x76AB80", VA = "0x18076C580", Slot = "5")]
			get
			{
				return "玉石俱焚";
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x00126CB4 File Offset: 0x00124EB4
		[Token(Token = "0x17000266")]
		public override string Description
		{
			[Token(Token = "0x60036C8")]
			[Address(RVA = "0x76C3E0", Offset = "0x76A9E0", VA = "0x18076C3E0", Slot = "6")]
			get
			{
				return "可以使用金咖啡豆释放大招，为我方植物积攒能力，并使其攻击力提高";
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x00126CC8 File Offset: 0x00124EC8
		[Token(Token = "0x17000267")]
		public override int Cost
		{
			[Token(Token = "0x60036C9")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x00126CD8 File Offset: 0x00124ED8
		[Token(Token = "0x17000268")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036CA")]
			[Address(RVA = "0x76C410", Offset = "0x76AA10", VA = "0x18076C410", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00126D1C File Offset: 0x00124F1C
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Marigold()
		{
		}
	}
}
