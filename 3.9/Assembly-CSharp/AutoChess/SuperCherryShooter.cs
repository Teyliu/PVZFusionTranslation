using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ACB RID: 2763
	[Token(Token = "0x2000ACB")]
	public class SuperCherryShooter : PlantData
	{
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060038C4 RID: 14532 RVA: 0x0012D1E4 File Offset: 0x0012B3E4
		[Token(Token = "0x17000347")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038C4")]
			[Address(RVA = "0x3FA410", Offset = "0x3F8A10", VA = "0x1803FA410", Slot = "4")]
			get
			{
				return PlantType.SuperCherryShooter;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x0012D1F8 File Offset: 0x0012B3F8
		[Token(Token = "0x17000348")]
		public override string Title
		{
			[Token(Token = "0x60038C5")]
			[Address(RVA = "0x7DFBD0", Offset = "0x7DE1D0", VA = "0x1807DFBD0", Slot = "5")]
			get
			{
				return "护你左右";
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060038C6 RID: 14534 RVA: 0x0012D20C File Offset: 0x0012B40C
		[Token(Token = "0x17000349")]
		public override string Description
		{
			[Token(Token = "0x60038C6")]
			[Address(RVA = "0x7DFA80", Offset = "0x7DE080", VA = "0x1807DFA80", Slot = "6")]
			get
			{
				return "造成更高的伤害，我方小队造成的伤害提高";
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x0012D220 File Offset: 0x0012B420
		[Token(Token = "0x1700034A")]
		public override int Cost
		{
			[Token(Token = "0x60038C7")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060038C8 RID: 14536 RVA: 0x0012D230 File Offset: 0x0012B430
		[Token(Token = "0x1700034B")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038C8")]
			[Address(RVA = "0x7DFAB0", Offset = "0x7DE0B0", VA = "0x1807DFAB0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x0012D26C File Offset: 0x0012B46C
		[Token(Token = "0x60038C9")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public SuperCherryShooter()
		{
		}
	}
}
