using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ABC RID: 2748
	[Token(Token = "0x2000ABC")]
	public class EndoFlame : PlantData
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600386A RID: 14442 RVA: 0x0012C898 File Offset: 0x0012AA98
		[Token(Token = "0x170002FC")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600386A")]
			[Address(RVA = "0x7D19B0", Offset = "0x7CFFB0", VA = "0x1807D19B0", Slot = "4")]
			get
			{
				return PlantType.EndoFlame;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x0012C8AC File Offset: 0x0012AAAC
		[Token(Token = "0x170002FD")]
		public override string Title
		{
			[Token(Token = "0x600386B")]
			[Address(RVA = "0x7D1B30", Offset = "0x7D0130", VA = "0x1807D1B30", Slot = "5")]
			get
			{
				return "高效肥料";
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x0012C8C0 File Offset: 0x0012AAC0
		[Token(Token = "0x170002FE")]
		public override string Description
		{
			[Token(Token = "0x600386C")]
			[Address(RVA = "0x7D1980", Offset = "0x7CFF80", VA = "0x1807D1980", Slot = "6")]
			get
			{
				return "不再因为生成肥料而消失，但有冷却时间";
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600386D RID: 14445 RVA: 0x0012C8D4 File Offset: 0x0012AAD4
		[Token(Token = "0x170002FF")]
		public override int Cost
		{
			[Token(Token = "0x600386D")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x0012C8E4 File Offset: 0x0012AAE4
		[Token(Token = "0x17000300")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600386E")]
			[Address(RVA = "0x7D19C0", Offset = "0x7CFFC0", VA = "0x1807D19C0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x0012C928 File Offset: 0x0012AB28
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public EndoFlame()
		{
		}
	}
}
