using System;
using Cpp2IlInjected;

// Token: 0x0200052D RID: 1325
[Token(Token = "0x200052D")]
public class LanternRepeater : LanternPea
{
	// Token: 0x17000135 RID: 309
	// (get) Token: 0x060018B1 RID: 6321 RVA: 0x00086430 File Offset: 0x00084630
	[Token(Token = "0x17000135")]
	protected override int TargetCount
	{
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "73")]
		get
		{
			return 2;
		}
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x00086440 File Offset: 0x00084640
	[Token(Token = "0x60018B2")]
	[Address(RVA = "0x4D26E0", Offset = "0x4D0CE0", VA = "0x1804D26E0")]
	public LanternRepeater()
	{
	}
}
