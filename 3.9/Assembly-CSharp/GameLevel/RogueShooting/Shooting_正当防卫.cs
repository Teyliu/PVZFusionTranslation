using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C7B RID: 3195
	[Token(Token = "0x2000C7B")]
	public class Shooting_正当防卫 : BaseDebuff
	{
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x0015BFCC File Offset: 0x0015A1CC
		[Token(Token = "0x1700058C")]
		public override int Point
		{
			[Token(Token = "0x600426F")]
			[Address(RVA = "0x89F050", Offset = "0x89D650", VA = "0x18089F050", Slot = "21")]
			get
			{
				return 600;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06004270 RID: 17008 RVA: 0x0015BFE0 File Offset: 0x0015A1E0
		[Token(Token = "0x1700058D")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004270")]
			[Address(RVA = "0x89F9D0", Offset = "0x89DFD0", VA = "0x18089F9D0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_正当防卫;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x0015BFF4 File Offset: 0x0015A1F4
		[Token(Token = "0x1700058E")]
		public override string Description
		{
			[Token(Token = "0x6004271")]
			[Address(RVA = "0x89F9E0", Offset = "0x89DFE0", VA = "0x18089F9E0", Slot = "13")]
			get
			{
				return "正当防卫：僵尸受到伤害时，原地生成一个僵尸方的豌豆子弹，伤害为自身攻击力的10%，最低20，0.02秒内最多触发10次";
			}
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x0015C008 File Offset: 0x0015A208
		[Token(Token = "0x6004272")]
		[Address(RVA = "0x89F6C0", Offset = "0x89DCC0", VA = "0x18089F6C0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			base.OnSelect(board);
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)5), action, num != 0);
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x0015C028 File Offset: 0x0015A228
		[Token(Token = "0x6004273")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_正当防卫()
		{
		}

		// Token: 0x0400328D RID: 12941
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400328D")]
		private float timer;

		// Token: 0x0400328E RID: 12942
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400328E")]
		private int count;

		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		private const float RESET_INTERVAL = 0.02f;

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		private const int MAX_TRIGGER_PER_INTERVAL = 10;
	}
}
