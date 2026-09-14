using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C9F RID: 3231
	[Token(Token = "0x2000C9F")]
	public class Shooting_廉价审美 : BaseDebuff
	{
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x0015D0EC File Offset: 0x0015B2EC
		[Token(Token = "0x170005C2")]
		public override int Point
		{
			[Token(Token = "0x60042F6")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060042F7 RID: 17143 RVA: 0x0015D100 File Offset: 0x0015B300
		[Token(Token = "0x170005C3")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042F7")]
			[Address(RVA = "0x89F1C0", Offset = "0x89D7C0", VA = "0x18089F1C0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_廉价审美;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x0015D114 File Offset: 0x0015B314
		[Token(Token = "0x170005C4")]
		public override string Description
		{
			[Token(Token = "0x60042F8")]
			[Address(RVA = "0x89F1D0", Offset = "0x89D7D0", VA = "0x18089F1D0", Slot = "13")]
			get
			{
				return "廉价审美：木头、白银词条加成变为原来的110%，黄金，钻石词条加成变为原来的70%";
			}
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x0015D128 File Offset: 0x0015B328
		[Token(Token = "0x60042F9")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_廉价审美()
		{
		}
	}
}
