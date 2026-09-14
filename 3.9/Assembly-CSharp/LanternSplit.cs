using System;
using Cpp2IlInjected;

// Token: 0x0200055B RID: 1371
[Token(Token = "0x200055B")]
public class LanternSplit : LanternPea
{
	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06001983 RID: 6531 RVA: 0x0008A118 File Offset: 0x00088318
	[Token(Token = "0x1700017C")]
	protected override int TargetCount
	{
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "72")]
		get
		{
			return 1;
		}
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x0008A128 File Offset: 0x00088328
	[Token(Token = "0x6001984")]
	[Address(RVA = "0x532FC0", Offset = "0x5315C0", VA = "0x180532FC0")]
	public LanternSplit()
	{
	}
}
