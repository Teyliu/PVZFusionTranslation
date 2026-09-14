using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C6E RID: 3182
	[Token(Token = "0x2000C6E")]
	public class Shooting_神魂不稳 : BaseDebuff
	{
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x0015B940 File Offset: 0x00159B40
		[Token(Token = "0x17000577")]
		public override int Point
		{
			[Token(Token = "0x600423D")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "21")]
			get
			{
				return 100;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x0015B950 File Offset: 0x00159B50
		[Token(Token = "0x17000578")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600423E")]
			[Address(RVA = "0x8A00B0", Offset = "0x89E6B0", VA = "0x1808A00B0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_神魂不稳;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x0015B964 File Offset: 0x00159B64
		[Token(Token = "0x17000579")]
		public override string Description
		{
			[Token(Token = "0x600423F")]
			[Address(RVA = "0x8A00C0", Offset = "0x89E6C0", VA = "0x1808A00C0", Slot = "13")]
			get
			{
				return "神魂不稳：植物复活时间延长50%";
			}
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x0015B978 File Offset: 0x00159B78
		[Token(Token = "0x6004240")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_神魂不稳()
		{
		}
	}
}
