using System;
using Cpp2IlInjected;

// Token: 0x020001E2 RID: 482
[Token(Token = "0x20001E2")]
public class MoveWay_fly : BulletMovement
{
	// Token: 0x0600082E RID: 2094 RVA: 0x00029F7C File Offset: 0x0002817C
	[Token(Token = "0x600082E")]
	[Address(RVA = "0x86C900", Offset = "0x86AF00", VA = "0x18086C900", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.RightUpdate();
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00029F9C File Offset: 0x0002819C
	[Token(Token = "0x600082F")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_fly()
	{
		base.PositionUpdate();
	}
}
