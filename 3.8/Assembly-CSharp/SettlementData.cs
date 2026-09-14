using System;
using Cpp2IlInjected;

// Token: 0x020005E6 RID: 1510
[Token(Token = "0x20005E6")]
public class SettlementData
{
	// Token: 0x06001C78 RID: 7288 RVA: 0x000982C0 File Offset: 0x000964C0
	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x50A0F0", Offset = "0x5086F0", VA = "0x18050A0F0")]
	public SettlementData(bool firstWin, int restMower, int duringTime)
	{
		this.firstWin = firstWin;
		this.restMower = restMower;
		this.duringTime = duringTime;
	}

	// Token: 0x04000F2F RID: 3887
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F2F")]
	public bool firstWin;

	// Token: 0x04000F30 RID: 3888
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000F30")]
	public int restMower;

	// Token: 0x04000F31 RID: 3889
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F31")]
	public int duringTime;
}
