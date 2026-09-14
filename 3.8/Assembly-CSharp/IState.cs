using System;
using Cpp2IlInjected;

// Token: 0x02000102 RID: 258
[Token(Token = "0x2000102")]
public interface IState
{
	// Token: 0x060004DC RID: 1244
	[Token(Token = "0x60004DC")]
	[Address(Slot = "0")]
	void OnEnter();

	// Token: 0x060004DD RID: 1245
	[Token(Token = "0x60004DD")]
	[Address(Slot = "1")]
	void OnUpdate();

	// Token: 0x060004DE RID: 1246
	[Token(Token = "0x60004DE")]
	[Address(Slot = "2")]
	void OnExit();
}
