using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ACA RID: 2762
	[Token(Token = "0x2000ACA")]
	public class GoldMagnet : PlantData
	{
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x0012D140 File Offset: 0x0012B340
		[Token(Token = "0x17000342")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038BE")]
			[Address(RVA = "0x7D23F0", Offset = "0x7D09F0", VA = "0x1807D23F0", Slot = "4")]
			get
			{
				return PlantType.GoldMagnet;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x0012D154 File Offset: 0x0012B354
		[Token(Token = "0x17000343")]
		public override string Title
		{
			[Token(Token = "0x60038BF")]
			[Address(RVA = "0x7D2570", Offset = "0x7D0B70", VA = "0x1807D2570", Slot = "5")]
			get
			{
				return "护你左右";
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060038C0 RID: 14528 RVA: 0x0012D168 File Offset: 0x0012B368
		[Token(Token = "0x17000344")]
		public override string Description
		{
			[Token(Token = "0x60038C0")]
			[Address(RVA = "0x7D23C0", Offset = "0x7D09C0", VA = "0x1807D23C0", Slot = "6")]
			get
			{
				return "吸引子弹可以提高子弹伤害，并提供更多金币";
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x0012D17C File Offset: 0x0012B37C
		[Token(Token = "0x17000345")]
		public override int Cost
		{
			[Token(Token = "0x60038C1")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060038C2 RID: 14530 RVA: 0x0012D18C File Offset: 0x0012B38C
		[Token(Token = "0x17000346")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038C2")]
			[Address(RVA = "0x7D2400", Offset = "0x7D0A00", VA = "0x1807D2400", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0012D1D0 File Offset: 0x0012B3D0
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public GoldMagnet()
		{
		}
	}
}
