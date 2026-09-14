using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA8 RID: 3240
	[Token(Token = "0x2000CA8")]
	public class Shooting_命运无常 : BaseDebuff
	{
		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06004319 RID: 17177 RVA: 0x0015D3FC File Offset: 0x0015B5FC
		[Token(Token = "0x170005DA")]
		public override int Point
		{
			[Token(Token = "0x6004319")]
			[Address(RVA = "0x480D00", Offset = "0x47F300", VA = "0x180480D00", Slot = "21")]
			get
			{
				return 200;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x0015D410 File Offset: 0x0015B610
		[Token(Token = "0x170005DB")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600431A")]
			[Address(RVA = "0x89ED90", Offset = "0x89D390", VA = "0x18089ED90", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_命运无常;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600431B RID: 17179 RVA: 0x0015D424 File Offset: 0x0015B624
		[Token(Token = "0x170005DC")]
		public override string Description
		{
			[Token(Token = "0x600431B")]
			[Address(RVA = "0x89EDA0", Offset = "0x89D3A0", VA = "0x18089EDA0", Slot = "13")]
			get
			{
				return "命运无常：每次抽取词条时，随机获得-27~23幸运";
			}
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x0015D438 File Offset: 0x0015B638
		[Token(Token = "0x600431C")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_命运无常()
		{
		}
	}
}
