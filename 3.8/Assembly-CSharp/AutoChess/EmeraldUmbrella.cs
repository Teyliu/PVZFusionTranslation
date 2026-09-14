using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	public class EmeraldUmbrella : PlantData
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060037CE RID: 14286 RVA: 0x001287B0 File Offset: 0x001269B0
		[Token(Token = "0x17000340")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037CE")]
			[Address(RVA = "0x76A860", Offset = "0x768E60", VA = "0x18076A860", Slot = "4")]
			get
			{
				return PlantType.EmeraldUmbrella;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060037CF RID: 14287 RVA: 0x001287C4 File Offset: 0x001269C4
		[Token(Token = "0x17000341")]
		public override string Title
		{
			[Token(Token = "0x60037CF")]
			[Address(RVA = "0x76A990", Offset = "0x768F90", VA = "0x18076A990", Slot = "5")]
			get
			{
				return "欧拉！";
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x001287D8 File Offset: 0x001269D8
		[Token(Token = "0x17000342")]
		public override string Description
		{
			[Token(Token = "0x60037D0")]
			[Address(RVA = "0x76A830", Offset = "0x768E30", VA = "0x18076A830", Slot = "6")]
			get
			{
				return "斩杀失败时也能造成5000真实伤害";
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x001287EC File Offset: 0x001269EC
		[Token(Token = "0x17000343")]
		public override int Cost
		{
			[Token(Token = "0x60037D1")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060037D2 RID: 14290 RVA: 0x001287FC File Offset: 0x001269FC
		[Token(Token = "0x17000344")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037D2")]
			[Address(RVA = "0x76A870", Offset = "0x768E70", VA = "0x18076A870", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x00128838 File Offset: 0x00126A38
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public EmeraldUmbrella()
		{
		}
	}
}
