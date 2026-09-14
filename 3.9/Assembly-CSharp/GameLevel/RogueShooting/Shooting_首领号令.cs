using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C9A RID: 3226
	[Token(Token = "0x2000C9A")]
	public class Shooting_首领号令 : BaseDebuff
	{
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x0015CF0C File Offset: 0x0015B10C
		[Token(Token = "0x170005B9")]
		public override int Point
		{
			[Token(Token = "0x60042E2")]
			[Address(RVA = "0x88C900", Offset = "0x88AF00", VA = "0x18088C900", Slot = "21")]
			get
			{
				return 400;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x0015CF20 File Offset: 0x0015B120
		[Token(Token = "0x170005BA")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042E3")]
			[Address(RVA = "0x8A0C20", Offset = "0x89F220", VA = "0x1808A0C20", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_首领号令;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060042E4 RID: 17124 RVA: 0x0015CF34 File Offset: 0x0015B134
		[Token(Token = "0x170005BB")]
		public override string Description
		{
			[Token(Token = "0x60042E4")]
			[Address(RVA = "0x8A0C30", Offset = "0x89F230", VA = "0x1808A0C30", Slot = "13")]
			get
			{
				return "首领号令：boss僵尸获得30%血量加成，其召唤的僵尸获得60%血量加成";
			}
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x0015CF48 File Offset: 0x0015B148
		[Token(Token = "0x60042E5")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_首领号令()
		{
		}
	}
}
