using System;
using Cpp2IlInjected;

// Token: 0x02000554 RID: 1364
[Token(Token = "0x2000554")]
public class LanternGatling : LanternPea
{
	// Token: 0x17000175 RID: 373
	// (get) Token: 0x0600195B RID: 6491 RVA: 0x00089338 File Offset: 0x00087538
	[Token(Token = "0x17000175")]
	protected override int TargetCount
	{
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "72")]
		get
		{
			return 4;
		}
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x00089348 File Offset: 0x00087548
	[Token(Token = "0x600195C")]
	[Address(RVA = "0x532FC0", Offset = "0x5315C0", VA = "0x180532FC0")]
	public LanternGatling()
	{
	}
}
