using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C98 RID: 3224
	[Token(Token = "0x2000C98")]
	public class Shooting_随从号令 : BaseDebuff
	{
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x0015CE3C File Offset: 0x0015B03C
		[Token(Token = "0x170005B6")]
		public override int Point
		{
			[Token(Token = "0x60042DA")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x0015CE50 File Offset: 0x0015B050
		[Token(Token = "0x170005B7")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042DB")]
			[Address(RVA = "0x8A0AC0", Offset = "0x89F0C0", VA = "0x1808A0AC0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_随从号令;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x0015CE64 File Offset: 0x0015B064
		[Token(Token = "0x170005B8")]
		public override string Description
		{
			[Token(Token = "0x60042DC")]
			[Address(RVA = "0x8A0AD0", Offset = "0x89F0D0", VA = "0x1808A0AD0", Slot = "13")]
			get
			{
				return "随从号令：每一波僵尸刷新时，令全场僵尸提高20%生命值和20%速度";
			}
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x0015CE78 File Offset: 0x0015B078
		[Token(Token = "0x60042DD")]
		[Address(RVA = "0x8A09A0", Offset = "0x89EFA0", VA = "0x1808A09A0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			if (Shooting_随从号令.<>c.<>9__6_0 == 0)
			{
				Action<object> action;
				Shooting_随从号令.<>c.<>9__6_0 = action;
			}
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x0015CE94 File Offset: 0x0015B094
		[Token(Token = "0x60042DE")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_随从号令()
		{
		}
	}
}
