using System;
using Cpp2IlInjected;

// Token: 0x020001E0 RID: 480
[Token(Token = "0x20001E0")]
public class MoveWay_threeDown : BaseBulletMovement
{
	// Token: 0x06000828 RID: 2088 RVA: 0x00029EE8 File Offset: 0x000280E8
	[Token(Token = "0x6000828")]
	[Address(RVA = "0x86CB60", Offset = "0x86B160", VA = "0x18086CB60", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.ThreeDownUpdate();
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x00029F08 File Offset: 0x00028108
	[Token(Token = "0x6000829")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00029F20 File Offset: 0x00028120
	[Token(Token = "0x600082A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_threeDown()
	{
		base.PositionUpdate();
	}
}
