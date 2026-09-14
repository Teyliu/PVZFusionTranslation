using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A71 RID: 2673
	[Token(Token = "0x2000A71")]
	public class TorchWood : PlantData
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060036E4 RID: 14052 RVA: 0x00126F98 File Offset: 0x00125198
		[Token(Token = "0x1700027D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036E4")]
			[Address(RVA = "0x69BB30", Offset = "0x69A130", VA = "0x18069BB30", Slot = "4")]
			get
			{
				return PlantType.TorchWood;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060036E5 RID: 14053 RVA: 0x00126FA8 File Offset: 0x001251A8
		[Token(Token = "0x1700027E")]
		public override string Title
		{
			[Token(Token = "0x60036E5")]
			[Address(RVA = "0x77EDA0", Offset = "0x77D3A0", VA = "0x18077EDA0", Slot = "5")]
			get
			{
				return "高温灼烧";
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060036E6 RID: 14054 RVA: 0x00126FBC File Offset: 0x001251BC
		[Token(Token = "0x1700027F")]
		public override string Description
		{
			[Token(Token = "0x60036E6")]
			[Address(RVA = "0x77EC50", Offset = "0x77D250", VA = "0x18077EC50", Slot = "6")]
			get
			{
				return "点燃的豌豆升至红火状态";
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x00126FD0 File Offset: 0x001251D0
		[Token(Token = "0x17000280")]
		public override int Cost
		{
			[Token(Token = "0x60036E7")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x00126FE0 File Offset: 0x001251E0
		[Token(Token = "0x17000281")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036E8")]
			[Address(RVA = "0x77EC80", Offset = "0x77D280", VA = "0x18077EC80", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x0012701C File Offset: 0x0012521C
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public TorchWood()
		{
		}
	}
}
