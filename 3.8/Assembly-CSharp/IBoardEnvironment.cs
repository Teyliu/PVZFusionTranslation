using System;
using Cpp2IlInjected;

// Token: 0x0200025C RID: 604
[Token(Token = "0x200025C")]
public interface IBoardEnvironment
{
	// Token: 0x06000ADB RID: 2779
	[Token(Token = "0x6000ADB")]
	[Address(Slot = "0")]
	void OnUpdate();

	// Token: 0x06000ADC RID: 2780
	[Token(Token = "0x6000ADC")]
	[Address(Slot = "1")]
	void OnFreeze();

	// Token: 0x06000ADD RID: 2781
	[Token(Token = "0x6000ADD")]
	[Address(Slot = "2")]
	void OnFire(int row);
}
