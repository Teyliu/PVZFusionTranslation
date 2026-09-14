using System;
using Cpp2IlInjected;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public interface IEffect
{
	// Token: 0x0600002E RID: 46
	[Token(Token = "0x600002E")]
	[Address(Slot = "0")]
	void OnUpdate();

	// Token: 0x0600002F RID: 47
	[Token(Token = "0x600002F")]
	[Address(Slot = "1")]
	void OnFixedUpdate();

	// Token: 0x06000030 RID: 48
	[Token(Token = "0x6000030")]
	[Address(Slot = "2")]
	void Main();
}
