using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C8D RID: 3213
	[Token(Token = "0x2000C8D")]
	public class Shooting_真实伤害 : BaseDebuff
	{
		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060042B2 RID: 17074 RVA: 0x0015C968 File Offset: 0x0015AB68
		[Token(Token = "0x170005A7")]
		public override int Point
		{
			[Token(Token = "0x60042B2")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x0015C97C File Offset: 0x0015AB7C
		[Token(Token = "0x170005A8")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042B3")]
			[Address(RVA = "0x8A0070", Offset = "0x89E670", VA = "0x1808A0070", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_真实伤害;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060042B4 RID: 17076 RVA: 0x0015C990 File Offset: 0x0015AB90
		[Token(Token = "0x170005A9")]
		public override string Description
		{
			[Token(Token = "0x60042B4")]
			[Address(RVA = "0x8A0080", Offset = "0x89E680", VA = "0x1808A0080", Slot = "13")]
			get
			{
				return "真实伤害：植物受到伤害后，额外受到30%的真实伤害";
			}
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x0015C9A4 File Offset: 0x0015ABA4
		[Token(Token = "0x60042B5")]
		[Address(RVA = "0x89FF50", Offset = "0x89E550", VA = "0x18089FF50", Slot = "17")]
		public override void OnSelect(Board board)
		{
			if (Shooting_真实伤害.<>c.<>9__6_0 == 0)
			{
				Action<object> action;
				Shooting_真实伤害.<>c.<>9__6_0 = action;
			}
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x0015C9C0 File Offset: 0x0015ABC0
		[Token(Token = "0x60042B6")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_真实伤害()
		{
		}
	}
}
