using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CA4 RID: 3236
	[Token(Token = "0x2000CA4")]
	public class Shooting_猫瓜纪元 : BaseDebuff
	{
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600430A RID: 17162 RVA: 0x0015D278 File Offset: 0x0015B478
		[Token(Token = "0x170005D1")]
		public override int Point
		{
			[Token(Token = "0x600430A")]
			[Address(RVA = "0x89FDB0", Offset = "0x89E3B0", VA = "0x18089FDB0", Slot = "21")]
			get
			{
				return 500;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x0015D28C File Offset: 0x0015B48C
		[Token(Token = "0x170005D2")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600430B")]
			[Address(RVA = "0x89FD70", Offset = "0x89E370", VA = "0x18089FD70", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_猫瓜纪元;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600430C RID: 17164 RVA: 0x0015D2A0 File Offset: 0x0015B4A0
		[Token(Token = "0x170005D3")]
		public override string Description
		{
			[Token(Token = "0x600430C")]
			[Address(RVA = "0x89FD80", Offset = "0x89E380", VA = "0x18089FD80", Slot = "13")]
			get
			{
				return "猫瓜纪元：僵尸出现时，有概率立即消失，并在原地生成一个继承血量的猫瓜僵尸，概率随波次增加";
			}
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x0015D2B4 File Offset: 0x0015B4B4
		[Token(Token = "0x600430D")]
		[Address(RVA = "0x89FC90", Offset = "0x89E290", VA = "0x18089FC90", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Shooting_猫瓜纪元.<>c__DisplayClass6_0().board = board;
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)14), action, num != 0);
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x0015D2E0 File Offset: 0x0015B4E0
		[Token(Token = "0x600430E")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_猫瓜纪元()
		{
		}
	}
}
