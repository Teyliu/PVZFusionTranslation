using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043C RID: 1084
[Token(Token = "0x200043C")]
public class SilverIceShroom : IceShroom
{
	// Token: 0x060013F8 RID: 5112 RVA: 0x0006F4F0 File Offset: 0x0006D6F0
	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x4BD420", Offset = "0x4BBA20", VA = "0x1804BD420", Slot = "68")]
	protected override void Explode()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		throw new NullReferenceException();
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x0006F518 File Offset: 0x0006D718
	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x446E20", Offset = "0x445420", VA = "0x180446E20", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x0006F530 File Offset: 0x0006D730
	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SilverIceShroom()
	{
	}
}
