using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C9D RID: 3229
	[Token(Token = "0x2000C9D")]
	public class Shooting_膨胀危机 : BaseDebuff
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x0015D024 File Offset: 0x0015B224
		[Token(Token = "0x170005BF")]
		public override int Point
		{
			[Token(Token = "0x60042EE")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060042EF RID: 17135 RVA: 0x0015D038 File Offset: 0x0015B238
		[Token(Token = "0x170005C0")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042EF")]
			[Address(RVA = "0x8A0580", Offset = "0x89EB80", VA = "0x1808A0580", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_膨胀危机;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x0015D04C File Offset: 0x0015B24C
		[Token(Token = "0x170005C1")]
		public override string Description
		{
			[Token(Token = "0x60042F0")]
			[Address(RVA = "0x8A0590", Offset = "0x89EB90", VA = "0x1808A0590", Slot = "13")]
			get
			{
				return "膨胀危机：非boss僵尸的生命值和体型提高60%，但速度降低50%";
			}
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x0015D060 File Offset: 0x0015B260
		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x8A0460", Offset = "0x89EA60", VA = "0x1808A0460", Slot = "17")]
		public override void OnSelect(Board board)
		{
			if (Shooting_膨胀危机.<>c.<>9__6_0 == 0)
			{
				Action<object> action;
				Shooting_膨胀危机.<>c.<>9__6_0 = action;
			}
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x0015D07C File Offset: 0x0015B27C
		[Token(Token = "0x60042F2")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_膨胀危机()
		{
		}
	}
}
