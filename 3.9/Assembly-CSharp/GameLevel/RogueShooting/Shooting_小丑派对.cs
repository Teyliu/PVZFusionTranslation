using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C96 RID: 3222
	[Token(Token = "0x2000C96")]
	public class Shooting_小丑派对 : BaseDebuff
	{
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060042D3 RID: 17107 RVA: 0x0015CD64 File Offset: 0x0015AF64
		[Token(Token = "0x170005B3")]
		public override int Point
		{
			[Token(Token = "0x60042D3")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x0015CD78 File Offset: 0x0015AF78
		[Token(Token = "0x170005B4")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042D4")]
			[Address(RVA = "0x89EEB0", Offset = "0x89D4B0", VA = "0x18089EEB0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_小丑派对;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x0015CD8C File Offset: 0x0015AF8C
		[Token(Token = "0x170005B5")]
		public override string Description
		{
			[Token(Token = "0x60042D5")]
			[Address(RVA = "0x89EEC0", Offset = "0x89D4C0", VA = "0x18089EEC0", Slot = "13")]
			get
			{
				return "小丑派对：僵尸血量低于10%时有概率自爆（对领袖和boss无效）";
			}
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x0015CDA0 File Offset: 0x0015AFA0
		[Token(Token = "0x60042D6")]
		[Address(RVA = "0x89EDD0", Offset = "0x89D3D0", VA = "0x18089EDD0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Shooting_小丑派对.<>c__DisplayClass6_0().board = board;
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x0015CDCC File Offset: 0x0015AFCC
		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_小丑派对()
		{
		}
	}
}
