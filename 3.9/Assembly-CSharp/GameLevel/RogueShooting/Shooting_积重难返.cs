using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA6 RID: 3238
	[Token(Token = "0x2000CA6")]
	public class Shooting_积重难返 : BaseDebuff
	{
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06004311 RID: 17169 RVA: 0x0015D35C File Offset: 0x0015B55C
		[Token(Token = "0x170005D4")]
		public override int Point
		{
			[Token(Token = "0x6004311")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x0015D370 File Offset: 0x0015B570
		[Token(Token = "0x170005D5")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004312")]
			[Address(RVA = "0x8A00F0", Offset = "0x89E6F0", VA = "0x1808A00F0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_积重难返;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06004313 RID: 17171 RVA: 0x0015D384 File Offset: 0x0015B584
		[Token(Token = "0x170005D6")]
		public override string Description
		{
			[Token(Token = "0x6004313")]
			[Address(RVA = "0x8A0100", Offset = "0x89E700", VA = "0x1808A0100", Slot = "13")]
			get
			{
				return "积重难返：植物每次复活，下一次复活时间增加0.5秒";
			}
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x0015D398 File Offset: 0x0015B598
		[Token(Token = "0x6004314")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_积重难返()
		{
		}
	}
}
