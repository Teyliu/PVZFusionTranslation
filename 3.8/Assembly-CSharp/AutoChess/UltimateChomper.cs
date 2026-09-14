using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A9B RID: 2715
	[Token(Token = "0x2000A9B")]
	public class UltimateChomper : PlantData
	{
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060037E0 RID: 14304 RVA: 0x00128984 File Offset: 0x00126B84
		[Token(Token = "0x1700034F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037E0")]
			[Address(RVA = "0x7812D0", Offset = "0x77F8D0", VA = "0x1807812D0", Slot = "4")]
			get
			{
				return PlantType.UltimateChomper;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x00128998 File Offset: 0x00126B98
		[Token(Token = "0x17000350")]
		public override string Title
		{
			[Token(Token = "0x60037E1")]
			[Address(RVA = "0x781400", Offset = "0x77FA00", VA = "0x180781400", Slot = "5")]
			get
			{
				return "幻想崩坏";
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x001289AC File Offset: 0x00126BAC
		[Token(Token = "0x17000351")]
		public override string Description
		{
			[Token(Token = "0x60037E2")]
			[Address(RVA = "0x7812A0", Offset = "0x77F8A0", VA = "0x1807812A0", Slot = "6")]
			get
			{
				return "每第5次攻击强制触发吞噬";
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x001289C0 File Offset: 0x00126BC0
		[Token(Token = "0x17000352")]
		public override int Cost
		{
			[Token(Token = "0x60037E3")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x001289D0 File Offset: 0x00126BD0
		[Token(Token = "0x17000353")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037E4")]
			[Address(RVA = "0x7812E0", Offset = "0x77F8E0", VA = "0x1807812E0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00128A0C File Offset: 0x00126C0C
		[Token(Token = "0x60037E5")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateChomper()
		{
		}
	}
}
