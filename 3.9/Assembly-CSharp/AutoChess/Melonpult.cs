using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AA9 RID: 2729
	[Token(Token = "0x2000AA9")]
	public class Melonpult : PlantData
	{
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060037F8 RID: 14328 RVA: 0x0012BCF0 File Offset: 0x00129EF0
		[Token(Token = "0x1700029D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037F8")]
			[Address(RVA = "0x71D570", Offset = "0x71BB70", VA = "0x18071D570", Slot = "4")]
			get
			{
				return PlantType.Melonpult;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x0012BD00 File Offset: 0x00129F00
		[Token(Token = "0x1700029E")]
		public override string Title
		{
			[Token(Token = "0x60037F9")]
			[Address(RVA = "0x7D36D0", Offset = "0x7D1CD0", VA = "0x1807D36D0", Slot = "5")]
			get
			{
				return "生瓜蛋子";
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060037FA RID: 14330 RVA: 0x0012BD14 File Offset: 0x00129F14
		[Token(Token = "0x1700029F")]
		public override string Description
		{
			[Token(Token = "0x60037FA")]
			[Address(RVA = "0x7D3580", Offset = "0x7D1B80", VA = "0x1807D3580", Slot = "6")]
			get
			{
				return "在敌人血量低于50%时额外发射子弹，并在敌人被消灭后永久提高前后台强度";
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x0012BD28 File Offset: 0x00129F28
		[Token(Token = "0x170002A0")]
		public override int Cost
		{
			[Token(Token = "0x60037FB")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060037FC RID: 14332 RVA: 0x0012BD38 File Offset: 0x00129F38
		[Token(Token = "0x170002A1")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037FC")]
			[Address(RVA = "0x7D35B0", Offset = "0x7D1BB0", VA = "0x1807D35B0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x0012BD74 File Offset: 0x00129F74
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Melonpult()
		{
		}
	}
}
