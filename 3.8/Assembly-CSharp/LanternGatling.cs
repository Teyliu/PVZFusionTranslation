using System;
using Cpp2IlInjected;

// Token: 0x02000527 RID: 1319
[Token(Token = "0x2000527")]
public class LanternGatling : LanternPea
{
	// Token: 0x1700012F RID: 303
	// (get) Token: 0x0600188B RID: 6283 RVA: 0x00085684 File Offset: 0x00083884
	[Token(Token = "0x1700012F")]
	protected override int TargetCount
	{
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "73")]
		get
		{
			return 4;
		}
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x00085694 File Offset: 0x00083894
	[Token(Token = "0x600188C")]
	[Address(RVA = "0x4D26E0", Offset = "0x4D0CE0", VA = "0x1804D26E0")]
	public LanternGatling()
	{
	}
}
