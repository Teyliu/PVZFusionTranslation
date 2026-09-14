using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA0 RID: 3232
	[Token(Token = "0x2000CA0")]
	public class Shooting_高贵审美 : BaseDebuff
	{
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x0015D13C File Offset: 0x0015B33C
		[Token(Token = "0x170005C5")]
		public override int Point
		{
			[Token(Token = "0x60042FA")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "21")]
			get
			{
				return 100;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x0015D14C File Offset: 0x0015B34C
		[Token(Token = "0x170005C6")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042FB")]
			[Address(RVA = "0x8A0C60", Offset = "0x89F260", VA = "0x1808A0C60", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_高贵审美;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x0015D160 File Offset: 0x0015B360
		[Token(Token = "0x170005C7")]
		public override string Description
		{
			[Token(Token = "0x60042FC")]
			[Address(RVA = "0x8A0C70", Offset = "0x89F270", VA = "0x1808A0C70", Slot = "13")]
			get
			{
				return "高贵审美：木头、白银词条加成变为原来的70%，黄金，钻石词条加成变为原来的110%";
			}
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x0015D174 File Offset: 0x0015B374
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_高贵审美()
		{
		}
	}
}
