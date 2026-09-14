using System;
using Cpp2IlInjected;

// Token: 0x020001E5 RID: 485
[Token(Token = "0x20001E5")]
public class MoveWay_throw : BulletMovement
{
	// Token: 0x06000834 RID: 2100 RVA: 0x0002A010 File Offset: 0x00028210
	[Token(Token = "0x6000834")]
	[Address(RVA = "0x86CBA0", Offset = "0x86B1A0", VA = "0x18086CBA0", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.ThrowBulletUpdate();
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x0002A030 File Offset: 0x00028230
	[Token(Token = "0x6000835")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_throw()
	{
		base.PositionUpdate();
	}
}
