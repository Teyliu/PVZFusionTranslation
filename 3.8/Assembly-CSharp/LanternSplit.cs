using System;
using Cpp2IlInjected;

// Token: 0x0200052E RID: 1326
[Token(Token = "0x200052E")]
public class LanternSplit : LanternPea
{
	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060018B3 RID: 6323 RVA: 0x00086454 File Offset: 0x00084654
	[Token(Token = "0x17000136")]
	protected override int TargetCount
	{
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "73")]
		get
		{
			return 1;
		}
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00086464 File Offset: 0x00084664
	[Token(Token = "0x60018B4")]
	[Address(RVA = "0x4D26E0", Offset = "0x4D0CE0", VA = "0x1804D26E0")]
	public LanternSplit()
	{
	}
}
