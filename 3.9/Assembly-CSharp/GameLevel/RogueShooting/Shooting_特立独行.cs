using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C6A RID: 3178
	[Token(Token = "0x2000C6A")]
	public class Shooting_特立独行 : BaseDebuff
	{
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x0015B714 File Offset: 0x00159914
		[Token(Token = "0x17000571")]
		public override int Point
		{
			[Token(Token = "0x6004230")]
			[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "21")]
			get
			{
				return 1000;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x0015B728 File Offset: 0x00159928
		[Token(Token = "0x17000572")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004231")]
			[Address(RVA = "0x88CCC0", Offset = "0x88B2C0", VA = "0x18088CCC0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_特立独行;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x0015B73C File Offset: 0x0015993C
		[Token(Token = "0x17000573")]
		public override string Description
		{
			[Token(Token = "0x6004232")]
			[Address(RVA = "0x88CCD0", Offset = "0x88B2D0", VA = "0x18088CCD0", Slot = "13")]
			get
			{
				return "特立独行：僵尸出现时，有概率立即消失，并使随机的一个其他僵尸获得自身80%生命值（对领袖和boss无效），概率随关卡波次提高";
			}
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x0015B750 File Offset: 0x00159950
		[Token(Token = "0x6004233")]
		[Address(RVA = "0x88CBE0", Offset = "0x88B1E0", VA = "0x18088CBE0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Shooting_特立独行.<>c__DisplayClass6_0().board = board;
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)14), action, num != 0);
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x0015B77C File Offset: 0x0015997C
		[Token(Token = "0x6004234")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_特立独行()
		{
		}
	}
}
