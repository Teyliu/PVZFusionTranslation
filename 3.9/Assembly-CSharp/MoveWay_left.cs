using System;
using Cpp2IlInjected;

// Token: 0x020001ED RID: 493
[Token(Token = "0x20001ED")]
public class MoveWay_left : BulletMovement
{
	// Token: 0x0600084D RID: 2125 RVA: 0x00029F4C File Offset: 0x0002814C
	[Token(Token = "0x600084D")]
	[Address(RVA = "0x8FBB10", Offset = "0x8FA110", VA = "0x1808FBB10", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.LeftUpdate();
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00029F6C File Offset: 0x0002816C
	[Token(Token = "0x600084E")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_left()
	{
		base.PositionUpdate();
	}
}
