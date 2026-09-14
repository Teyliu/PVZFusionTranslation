using System;
using Cpp2IlInjected;

// Token: 0x020001DB RID: 475
[Token(Token = "0x20001DB")]
public class MoveWay_jump : BulletMovement
{
	// Token: 0x0600081C RID: 2076 RVA: 0x00029DB4 File Offset: 0x00027FB4
	[Token(Token = "0x600081C")]
	[Address(RVA = "0x86C940", Offset = "0x86AF40", VA = "0x18086C940", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.JumpUpdate();
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00029DD4 File Offset: 0x00027FD4
	[Token(Token = "0x600081D")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_jump()
	{
		base.PositionUpdate();
	}
}
