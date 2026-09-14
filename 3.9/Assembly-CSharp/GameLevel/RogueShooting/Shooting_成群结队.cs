using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C68 RID: 3176
	[Token(Token = "0x2000C68")]
	public class Shooting_成群结队 : BaseDebuff
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06004229 RID: 16937 RVA: 0x0015B60C File Offset: 0x0015980C
		[Token(Token = "0x1700056E")]
		public override int Point
		{
			[Token(Token = "0x6004229")]
			[Address(RVA = "0x88C900", Offset = "0x88AF00", VA = "0x18088C900", Slot = "21")]
			get
			{
				return 400;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x0015B620 File Offset: 0x00159820
		[Token(Token = "0x1700056F")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600422A")]
			[Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_成群结队;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600422B RID: 16939 RVA: 0x0015B634 File Offset: 0x00159834
		[Token(Token = "0x17000570")]
		public override string Description
		{
			[Token(Token = "0x600422B")]
			[Address(RVA = "0x88CA00", Offset = "0x88B000", VA = "0x18088CA00", Slot = "13")]
			get
			{
				return "成群结队：僵尸出现时，有概率额外出现一次（领袖和boss除外），概率随关卡波次提高";
			}
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x0015B648 File Offset: 0x00159848
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x88C910", Offset = "0x88AF10", VA = "0x18088C910", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Shooting_成群结队.<>c__DisplayClass7_0().board = board;
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)14), action, num != 0);
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x0015B674 File Offset: 0x00159874
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_成群结队()
		{
		}

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		public static bool locked;
	}
}
