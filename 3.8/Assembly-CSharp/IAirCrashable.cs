using System;
using Cpp2IlInjected;

// Token: 0x020008A5 RID: 2213
[Token(Token = "0x20008A5")]
public interface IAirCrashable
{
	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06002D12 RID: 11538
	[Token(Token = "0x170001C1")]
	float CrashNeedCount
	{
		[Token(Token = "0x6002D12")]
		[Address(Slot = "0")]
		get;
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06002D13 RID: 11539
	// (set) Token: 0x06002D14 RID: 11540
	[Token(Token = "0x170001C2")]
	float CurrentCount
	{
		[Token(Token = "0x6002D13")]
		[Address(Slot = "1")]
		get;
		[Token(Token = "0x6002D14")]
		[Address(Slot = "2")]
		set;
	}

	// Token: 0x06002D15 RID: 11541
	[Token(Token = "0x6002D15")]
	[Address(Slot = "3")]
	void OnCrash(float value);
}
