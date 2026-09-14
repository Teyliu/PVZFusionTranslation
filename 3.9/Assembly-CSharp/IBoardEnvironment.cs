using System;
using Cpp2IlInjected;

// Token: 0x02000262 RID: 610
[Token(Token = "0x2000262")]
public interface IBoardEnvironment
{
	// Token: 0x06000AF7 RID: 2807
	[Token(Token = "0x6000AF7")]
	[Address(Slot = "0")]
	void OnUpdate();

	// Token: 0x06000AF8 RID: 2808
	[Token(Token = "0x6000AF8")]
	[Address(Slot = "1")]
	void OnFreeze();

	// Token: 0x06000AF9 RID: 2809
	[Token(Token = "0x6000AF9")]
	[Address(Slot = "2")]
	void OnFire(int row);
}
