using System;
using Cpp2IlInjected;

// Token: 0x020001E8 RID: 488
[Token(Token = "0x20001E8")]
public class MoveWay_right : BulletMovement
{
	// Token: 0x0600083D RID: 2109 RVA: 0x00029C88 File Offset: 0x00027E88
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x8FB670", Offset = "0x8F9C70", VA = "0x1808FB670", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.RightUpdate();
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00029CA8 File Offset: 0x00027EA8
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_right()
	{
		base.PositionUpdate();
	}
}
