using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C9B RID: 3227
	[Token(Token = "0x2000C9B")]
	public class Shooting_小鬼当家 : BaseDebuff
	{
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060042E6 RID: 17126 RVA: 0x0015CF5C File Offset: 0x0015B15C
		[Token(Token = "0x170005BC")]
		public override int Point
		{
			[Token(Token = "0x60042E6")]
			[Address(RVA = "0x89F050", Offset = "0x89D650", VA = "0x18089F050", Slot = "21")]
			get
			{
				return 600;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x0015CF70 File Offset: 0x0015B170
		[Token(Token = "0x170005BD")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042E7")]
			[Address(RVA = "0x89F010", Offset = "0x89D610", VA = "0x18089F010", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_小鬼当家;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060042E8 RID: 17128 RVA: 0x0015CF84 File Offset: 0x0015B184
		[Token(Token = "0x170005BE")]
		public override string Description
		{
			[Token(Token = "0x60042E8")]
			[Address(RVA = "0x89F020", Offset = "0x89D620", VA = "0x18089F020", Slot = "13")]
			get
			{
				return "小鬼当家：非boss僵尸的生命值和体型降低30%，但速度提高200%";
			}
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x0015CF98 File Offset: 0x0015B198
		[Token(Token = "0x60042E9")]
		[Address(RVA = "0x89EEF0", Offset = "0x89D4F0", VA = "0x18089EEF0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			if (Shooting_小鬼当家.<>c.<>9__6_0 == 0)
			{
				Action<object> action;
				Shooting_小鬼当家.<>c.<>9__6_0 = action;
			}
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x0015CFB4 File Offset: 0x0015B1B4
		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_小鬼当家()
		{
		}
	}
}
