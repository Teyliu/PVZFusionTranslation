using System;
using Cpp2IlInjected;

// Token: 0x020001E3 RID: 483
[Token(Token = "0x20001E3")]
public class MoveWay_left : BulletMovement
{
	// Token: 0x06000830 RID: 2096 RVA: 0x00029FB0 File Offset: 0x000281B0
	[Token(Token = "0x6000830")]
	[Address(RVA = "0x86C960", Offset = "0x86AF60", VA = "0x18086C960", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.LeftUpdate();
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00029FD0 File Offset: 0x000281D0
	[Token(Token = "0x6000831")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_left()
	{
		base.PositionUpdate();
	}
}
