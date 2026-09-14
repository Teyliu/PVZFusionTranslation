using System;
using Cpp2IlInjected;

// Token: 0x020004C0 RID: 1216
[Token(Token = "0x20004C0")]
public class Wheat : Plant
{
	// Token: 0x060016C7 RID: 5831 RVA: 0x0007D640 File Offset: 0x0007B840
	[Token(Token = "0x60016C7")]
	[Address(RVA = "0x51C7E0", Offset = "0x51ADE0", VA = "0x18051C7E0", Slot = "15")]
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

	// Token: 0x060016C8 RID: 5832 RVA: 0x0007D69C File Offset: 0x0007B89C
	[Token(Token = "0x60016C8")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Wheat()
	{
	}

	// Token: 0x04000E0B RID: 3595
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E0B")]
	public bool recover;
}
