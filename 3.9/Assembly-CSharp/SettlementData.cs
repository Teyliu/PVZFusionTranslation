using System;
using Cpp2IlInjected;

// Token: 0x0200061B RID: 1563
[Token(Token = "0x200061B")]
public class SettlementData
{
	// Token: 0x06001D77 RID: 7543 RVA: 0x0009CE28 File Offset: 0x0009B028
	[Token(Token = "0x6001D77")]
	[Address(RVA = "0x577170", Offset = "0x575770", VA = "0x180577170")]
	public SettlementData(bool firstWin, int restMower, int duringTime)
	{
		this.firstWin = firstWin;
		this.restMower = restMower;
		this.duringTime = duringTime;
	}

	// Token: 0x04000FF7 RID: 4087
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FF7")]
	public bool firstWin;

	// Token: 0x04000FF8 RID: 4088
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000FF8")]
	public int restMower;

	// Token: 0x04000FF9 RID: 4089
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FF9")]
	public int duringTime;
}
