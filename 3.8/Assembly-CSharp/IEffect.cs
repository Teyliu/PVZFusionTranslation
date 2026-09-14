using System;
using Cpp2IlInjected;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public interface IEffect
{
	// Token: 0x06000014 RID: 20
	[Token(Token = "0x6000014")]
	[Address(Slot = "0")]
	void OnUpdate();

	// Token: 0x06000015 RID: 21
	[Token(Token = "0x6000015")]
	[Address(Slot = "1")]
	void OnFixedUpdate();

	// Token: 0x06000016 RID: 22
	[Token(Token = "0x6000016")]
	[Address(Slot = "2")]
	void Main();
}
