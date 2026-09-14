using System;
using Cpp2IlInjected;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000031")]
public class Debuff_信息封锁II : BaseDebuff
{
	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x000049B0 File Offset: 0x00002BB0
	[Token(Token = "0x17000031")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3A6AD0", Offset = "0x3A50D0", VA = "0x1803A6AD0", Slot = "12")]
		get
		{
			return TravelDebuff.信息封锁II;
		}
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x000049C4 File Offset: 0x00002BC4
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x3A6A80", Offset = "0x3A5080", VA = "0x1803A6A80", Slot = "13")]
	public override string GetDescription()
	{
		return "信息封锁II：永久关闭僵尸显血";
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x000049D8 File Offset: 0x00002BD8
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x3A6AB0", Offset = "0x3A50B0", VA = "0x1803A6AB0", Slot = "17")]
	public override void OnSelect(Board board)
	{
		board.ShowZombieHealth();
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x000049F4 File Offset: 0x00002BF4
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_信息封锁II()
	{
	}
}
