using System;
using Cpp2IlInjected;

// Token: 0x0200055A RID: 1370
[Token(Token = "0x200055A")]
public class LanternRepeater : LanternPea
{
	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06001981 RID: 6529 RVA: 0x0008A0F4 File Offset: 0x000882F4
	[Token(Token = "0x1700017B")]
	protected override int TargetCount
	{
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "72")]
		get
		{
			return 2;
		}
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x0008A104 File Offset: 0x00088304
	[Token(Token = "0x6001982")]
	[Address(RVA = "0x532FC0", Offset = "0x5315C0", VA = "0x180532FC0")]
	public LanternRepeater()
	{
	}
}
