using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A91 RID: 2705
	[Token(Token = "0x2000A91")]
	public class UltimateStar : PlantData
	{
		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x0012836C File Offset: 0x0012656C
		[Token(Token = "0x1700031D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037A4")]
			[Address(RVA = "0x781FA0", Offset = "0x7805A0", VA = "0x180781FA0", Slot = "4")]
			get
			{
				return PlantType.UltimateStar;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060037A5 RID: 14245 RVA: 0x00128380 File Offset: 0x00126580
		[Token(Token = "0x1700031E")]
		public override string Title
		{
			[Token(Token = "0x60037A5")]
			[Address(RVA = "0x7820D0", Offset = "0x7806D0", VA = "0x1807820D0", Slot = "5")]
			get
			{
				return "天河本怒涛";
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x00128394 File Offset: 0x00126594
		[Token(Token = "0x1700031F")]
		public override string Description
		{
			[Token(Token = "0x60037A6")]
			[Address(RVA = "0x781F70", Offset = "0x780570", VA = "0x180781F70", Slot = "6")]
			get
			{
				return "使我方小队造成的伤害提高，释放大流星时造成额外伤害";
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060037A7 RID: 14247 RVA: 0x001283A8 File Offset: 0x001265A8
		[Token(Token = "0x17000320")]
		public override int Cost
		{
			[Token(Token = "0x60037A7")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060037A8 RID: 14248 RVA: 0x001283B8 File Offset: 0x001265B8
		[Token(Token = "0x17000321")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037A8")]
			[Address(RVA = "0x781FB0", Offset = "0x7805B0", VA = "0x180781FB0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x001283F4 File Offset: 0x001265F4
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateStar()
		{
		}
	}
}
