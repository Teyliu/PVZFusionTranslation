using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C8F RID: 3215
	[Token(Token = "0x2000C8F")]
	public class Shooting_同步治疗 : BaseDebuff
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x0015CA28 File Offset: 0x0015AC28
		[Token(Token = "0x170005AA")]
		public override int Point
		{
			[Token(Token = "0x60042BA")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060042BB RID: 17083 RVA: 0x0015CA3C File Offset: 0x0015AC3C
		[Token(Token = "0x170005AB")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042BB")]
			[Address(RVA = "0x89ED50", Offset = "0x89D350", VA = "0x18089ED50", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_同步治疗;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060042BC RID: 17084 RVA: 0x0015CA50 File Offset: 0x0015AC50
		[Token(Token = "0x170005AC")]
		public override string Description
		{
			[Token(Token = "0x60042BC")]
			[Address(RVA = "0x89ED60", Offset = "0x89D360", VA = "0x18089ED60", Slot = "13")]
			get
			{
				return "同步治疗：植物回复生命值时，使随机一个僵尸回复25%最大生命值，可过充";
			}
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x0015CA64 File Offset: 0x0015AC64
		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x89EC30", Offset = "0x89D230", VA = "0x18089EC30", Slot = "17")]
		public override void OnSelect(Board board)
		{
			if (Shooting_同步治疗.<>c.<>9__6_0 == 0)
			{
				Action<object> action;
				Shooting_同步治疗.<>c.<>9__6_0 = action;
			}
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x0015CA80 File Offset: 0x0015AC80
		[Token(Token = "0x60042BE")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_同步治疗()
		{
		}
	}
}
