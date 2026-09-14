using System;
using Cpp2IlInjected;

// Token: 0x020001E8 RID: 488
[Token(Token = "0x20001E8")]
public class MoveWay_convolute : BaseBulletMovement
{
	// Token: 0x0600083B RID: 2107 RVA: 0x0002A0C4 File Offset: 0x000282C4
	[Token(Token = "0x600083B")]
	[Address(RVA = "0x86C8D0", Offset = "0x86AED0", VA = "0x18086C8D0", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.ConvoluteUpdate();
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x0002A0E4 File Offset: 0x000282E4
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x0002A0FC File Offset: 0x000282FC
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_convolute()
	{
		base.PositionUpdate();
	}
}
