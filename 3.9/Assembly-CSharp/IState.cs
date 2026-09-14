using System;
using Cpp2IlInjected;

// Token: 0x02000107 RID: 263
[Token(Token = "0x2000107")]
public interface IState
{
	// Token: 0x060004F7 RID: 1271
	[Token(Token = "0x60004F7")]
	[Address(Slot = "0")]
	void OnEnter();

	// Token: 0x060004F8 RID: 1272
	[Token(Token = "0x60004F8")]
	[Address(Slot = "1")]
	void OnUpdate();

	// Token: 0x060004F9 RID: 1273
	[Token(Token = "0x60004F9")]
	[Address(Slot = "2")]
	void OnExit();
}
