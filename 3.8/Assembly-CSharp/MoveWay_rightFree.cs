using System;
using Cpp2IlInjected;

// Token: 0x020001E7 RID: 487
[Token(Token = "0x20001E7")]
public class MoveWay_rightFree : BaseBulletMovement
{
	// Token: 0x06000838 RID: 2104 RVA: 0x0002A078 File Offset: 0x00028278
	[Token(Token = "0x6000838")]
	[Address(RVA = "0x86CAB0", Offset = "0x86B0B0", VA = "0x18086CAB0", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.RightFreeUpdate();
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x0002A098 File Offset: 0x00028298
	[Token(Token = "0x6000839")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x0002A0B0 File Offset: 0x000282B0
	[Token(Token = "0x600083A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_rightFree()
	{
		base.PositionUpdate();
	}
}
