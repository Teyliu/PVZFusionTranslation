using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ACD RID: 2765
	[Token(Token = "0x2000ACD")]
	public class UltimateSpruce : PlantData
	{
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x0012D31C File Offset: 0x0012B51C
		[Token(Token = "0x17000351")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038D0")]
			[Address(RVA = "0x7E8CC0", Offset = "0x7E72C0", VA = "0x1807E8CC0", Slot = "4")]
			get
			{
				return PlantType.UltimateSpruce;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x0012D330 File Offset: 0x0012B530
		[Token(Token = "0x17000352")]
		public override string Title
		{
			[Token(Token = "0x60038D1")]
			[Address(RVA = "0x7E8DF0", Offset = "0x7E73F0", VA = "0x1807E8DF0", Slot = "5")]
			get
			{
				return "冰雪之志";
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060038D2 RID: 14546 RVA: 0x0012D344 File Offset: 0x0012B544
		[Token(Token = "0x17000353")]
		public override string Description
		{
			[Token(Token = "0x60038D2")]
			[Address(RVA = "0x7E8C90", Offset = "0x7E7290", VA = "0x1807E8C90", Slot = "6")]
			get
			{
				return "究极云杉会提供更多护盾，并提高拥有大量护盾目标的攻击力";
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x0012D358 File Offset: 0x0012B558
		[Token(Token = "0x17000354")]
		public override int Cost
		{
			[Token(Token = "0x60038D3")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060038D4 RID: 14548 RVA: 0x0012D368 File Offset: 0x0012B568
		[Token(Token = "0x17000355")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038D4")]
			[Address(RVA = "0x7E8CD0", Offset = "0x7E72D0", VA = "0x1807E8CD0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0012D3A4 File Offset: 0x0012B5A4
		[Token(Token = "0x60038D5")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateSpruce()
		{
		}
	}
}
