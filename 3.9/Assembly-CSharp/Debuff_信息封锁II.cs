using System;
using Cpp2IlInjected;

// Token: 0x02000035 RID: 53
[Token(Token = "0x2000035")]
public class Debuff_信息封锁II : BaseDebuff
{
	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060000E7 RID: 231 RVA: 0x00004C40 File Offset: 0x00002E40
	[Token(Token = "0x17000041")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x3F2A30", Offset = "0x3F1030", VA = "0x1803F2A30", Slot = "12")]
		get
		{
			return TravelDebuff.信息封锁II;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004C54 File Offset: 0x00002E54
	[Token(Token = "0x17000042")]
	public override string Description
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x3F2A40", Offset = "0x3F1040", VA = "0x1803F2A40", Slot = "13")]
		get
		{
			return "信息封锁II：永久关闭僵尸显血";
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00004C68 File Offset: 0x00002E68
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x3F2A10", Offset = "0x3F1010", VA = "0x1803F2A10", Slot = "17")]
	public override void OnSelect(Board board)
	{
		board.ShowZombieHealth();
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00004C84 File Offset: 0x00002E84
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_信息封锁II()
	{
	}
}
