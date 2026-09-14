using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA1 RID: 3233
	[Token(Token = "0x2000CA1")]
	public class Shooting_点钻成金 : BaseDebuff
	{
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x0015D188 File Offset: 0x0015B388
		[Token(Token = "0x170005C8")]
		public override int Point
		{
			[Token(Token = "0x60042FE")]
			[Address(RVA = "0x88C900", Offset = "0x88AF00", VA = "0x18088C900", Slot = "21")]
			get
			{
				return 400;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x0015D19C File Offset: 0x0015B39C
		[Token(Token = "0x170005C9")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042FF")]
			[Address(RVA = "0x89FC50", Offset = "0x89E250", VA = "0x18089FC50", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_点钻成金;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x0015D1B0 File Offset: 0x0015B3B0
		[Token(Token = "0x170005CA")]
		public override string Description
		{
			[Token(Token = "0x6004300")]
			[Address(RVA = "0x89FC60", Offset = "0x89E260", VA = "0x18089FC60", Slot = "13")]
			get
			{
				return "点钻成金：非保底时出现钻石品质时，以对应的黄金品质词条代替";
			}
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x0015D1C4 File Offset: 0x0015B3C4
		[Token(Token = "0x6004301")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_点钻成金()
		{
		}
	}
}
