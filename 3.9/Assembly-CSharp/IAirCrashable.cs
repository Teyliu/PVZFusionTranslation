using System;
using Cpp2IlInjected;

// Token: 0x020008E1 RID: 2273
[Token(Token = "0x20008E1")]
public interface IAirCrashable
{
	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06002E45 RID: 11845
	[Token(Token = "0x17000209")]
	float CrashNeedCount
	{
		[Token(Token = "0x6002E45")]
		[Address(Slot = "0")]
		get;
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x06002E46 RID: 11846
	// (set) Token: 0x06002E47 RID: 11847
	[Token(Token = "0x1700020A")]
	float CurrentCount
	{
		[Token(Token = "0x6002E46")]
		[Address(Slot = "1")]
		get;
		[Token(Token = "0x6002E47")]
		[Address(Slot = "2")]
		set;
	}

	// Token: 0x06002E48 RID: 11848
	[Token(Token = "0x6002E48")]
	[Address(Slot = "3")]
	void OnCrash(float value);
}
