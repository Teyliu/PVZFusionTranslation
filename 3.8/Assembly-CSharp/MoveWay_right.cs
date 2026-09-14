using System;
using Cpp2IlInjected;

// Token: 0x020001DC RID: 476
[Token(Token = "0x20001DC")]
public class MoveWay_right : BulletMovement
{
	// Token: 0x0600081E RID: 2078 RVA: 0x00029DE8 File Offset: 0x00027FE8
	[Token(Token = "0x600081E")]
	[Address(RVA = "0x86C900", Offset = "0x86AF00", VA = "0x18086C900", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.RightUpdate();
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00029E08 File Offset: 0x00028008
	[Token(Token = "0x600081F")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_right()
	{
		base.PositionUpdate();
	}
}
