using System;
using Cpp2IlInjected;

// Token: 0x020001DD RID: 477
[Token(Token = "0x20001DD")]
public class MoveWay_roll : BulletMovement
{
	// Token: 0x06000820 RID: 2080 RVA: 0x00029E1C File Offset: 0x0002801C
	[Token(Token = "0x6000820")]
	[Address(RVA = "0x86CAD0", Offset = "0x86B0D0", VA = "0x18086CAD0", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.RollingUpdate();
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x00029E3C File Offset: 0x0002803C
	[Token(Token = "0x6000821")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_roll()
	{
		base.PositionUpdate();
	}
}
