using System;
using Cpp2IlInjected;

// Token: 0x0200049E RID: 1182
[Token(Token = "0x200049E")]
public class Wheat : Plant
{
	// Token: 0x06001627 RID: 5671 RVA: 0x0007ABC4 File Offset: 0x00078DC4
	[Token(Token = "0x6001627")]
	[Address(RVA = "0x4AE010", Offset = "0x4AC610", VA = "0x1804AE010", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.wheatType = (int)((ulong)1L);
		if (this.board.boardGame != BoardGame.WheatProtection)
		{
			this.wheatTime = 30f;
			return;
		}
		this.wheatTime = 30f;
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x0007AC20 File Offset: 0x00078E20
	[Token(Token = "0x6001628")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Wheat()
	{
	}

	// Token: 0x04000D72 RID: 3442
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D72")]
	public bool recover;
}
