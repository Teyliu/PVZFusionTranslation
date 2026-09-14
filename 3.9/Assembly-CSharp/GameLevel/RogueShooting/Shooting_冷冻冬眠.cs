using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C6D RID: 3181
	[Token(Token = "0x2000C6D")]
	public class Shooting_冷冻冬眠 : BaseDebuff
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06004239 RID: 16953 RVA: 0x0015B8F4 File Offset: 0x00159AF4
		[Token(Token = "0x17000574")]
		public override int Point
		{
			[Token(Token = "0x6004239")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "21")]
			get
			{
				return 100;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600423A RID: 16954 RVA: 0x0015B904 File Offset: 0x00159B04
		[Token(Token = "0x17000575")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600423A")]
			[Address(RVA = "0x89EAB0", Offset = "0x89D0B0", VA = "0x18089EAB0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_冷冻冬眠;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600423B RID: 16955 RVA: 0x0015B918 File Offset: 0x00159B18
		[Token(Token = "0x17000576")]
		public override string Description
		{
			[Token(Token = "0x600423B")]
			[Address(RVA = "0x89EAC0", Offset = "0x89D0C0", VA = "0x18089EAC0", Slot = "13")]
			get
			{
				return "冷冻冬眠：植物复活后被强制冻结2秒";
			}
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x0015B92C File Offset: 0x00159B2C
		[Token(Token = "0x600423C")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_冷冻冬眠()
		{
		}
	}
}
