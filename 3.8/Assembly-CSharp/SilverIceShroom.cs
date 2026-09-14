using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041D RID: 1053
[Token(Token = "0x200041D")]
public class SilverIceShroom : IceShroom
{
	// Token: 0x0600136E RID: 4974 RVA: 0x0006D248 File Offset: 0x0006B448
	[Token(Token = "0x600136E")]
	[Address(RVA = "0x466430", Offset = "0x464A30", VA = "0x180466430", Slot = "69")]
	protected override void Explode()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		throw new NullReferenceException();
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x0006D270 File Offset: 0x0006B470
	[Token(Token = "0x600136F")]
	[Address(RVA = "0x402BD0", Offset = "0x4011D0", VA = "0x180402BD0", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x0006D288 File Offset: 0x0006B488
	[Token(Token = "0x6001370")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SilverIceShroom()
	{
	}
}
