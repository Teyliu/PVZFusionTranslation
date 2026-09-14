using System;
using Cpp2IlInjected;

// Token: 0x020001E6 RID: 486
[Token(Token = "0x20001E6")]
public class MoveWay_cannon : BulletMovement
{
	// Token: 0x06000836 RID: 2102 RVA: 0x0002A044 File Offset: 0x00028244
	[Token(Token = "0x6000836")]
	[Address(RVA = "0x86C8B0", Offset = "0x86AEB0", VA = "0x18086C8B0", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.CannonBulletUpdate();
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x0002A064 File Offset: 0x00028264
	[Token(Token = "0x6000837")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_cannon()
	{
		base.PositionUpdate();
	}
}
