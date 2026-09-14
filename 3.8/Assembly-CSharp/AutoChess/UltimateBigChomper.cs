using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A97 RID: 2711
	[Token(Token = "0x2000A97")]
	public class UltimateBigChomper : PlantData
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x00128714 File Offset: 0x00126914
		[Token(Token = "0x1700033B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037C8")]
			[Address(RVA = "0x780C90", Offset = "0x77F290", VA = "0x180780C90", Slot = "4")]
			get
			{
				return PlantType.UltimateBigChomper;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060037C9 RID: 14281 RVA: 0x00128728 File Offset: 0x00126928
		[Token(Token = "0x1700033C")]
		public override string Title
		{
			[Token(Token = "0x60037C9")]
			[Address(RVA = "0x780DC0", Offset = "0x77F3C0", VA = "0x180780DC0", Slot = "5")]
			get
			{
				return "流量为王";
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x0012873C File Offset: 0x0012693C
		[Token(Token = "0x1700033D")]
		public override string Description
		{
			[Token(Token = "0x60037CA")]
			[Address(RVA = "0x780C60", Offset = "0x77F260", VA = "0x180780C60", Slot = "6")]
			get
			{
				return "开启晶矿可以获得强化";
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060037CB RID: 14283 RVA: 0x00128750 File Offset: 0x00126950
		[Token(Token = "0x1700033E")]
		public override int Cost
		{
			[Token(Token = "0x60037CB")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060037CC RID: 14284 RVA: 0x00128760 File Offset: 0x00126960
		[Token(Token = "0x1700033F")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037CC")]
			[Address(RVA = "0x780CA0", Offset = "0x77F2A0", VA = "0x180780CA0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x0012879C File Offset: 0x0012699C
		[Token(Token = "0x60037CD")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateBigChomper()
		{
		}
	}
}
