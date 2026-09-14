using System;
using Cpp2IlInjected;

// Token: 0x02000958 RID: 2392
[Token(Token = "0x2000958")]
public abstract class BaseBuffData
{
	// Token: 0x06003178 RID: 12664 RVA: 0x00104AE8 File Offset: 0x00102CE8
	[Token(Token = "0x6003178")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "4")]
	public virtual void OnBoardStart(Board board)
	{
	}

	// Token: 0x06003179 RID: 12665 RVA: 0x00104AF8 File Offset: 0x00102CF8
	[Token(Token = "0x6003179")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "5")]
	public virtual void ReinforcePlant(Board board, Plant plant)
	{
	}

	// Token: 0x0600317A RID: 12666 RVA: 0x00104B08 File Offset: 0x00102D08
	[Token(Token = "0x600317A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	protected BaseBuffData()
	{
		int num = 0;
		this.OnBoardStart(num);
	}
}
