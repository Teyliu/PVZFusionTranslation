using System;
using Cpp2IlInjected;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x20001E4")]
public class MoveWay_stable : BaseBulletMovement
{
	// Token: 0x06000832 RID: 2098 RVA: 0x00029FE4 File Offset: 0x000281E4
	[Token(Token = "0x6000832")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00029FFC File Offset: 0x000281FC
	[Token(Token = "0x6000833")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_stable()
	{
		base.PositionUpdate();
	}
}
