using System;
using Cpp2IlInjected;

// Token: 0x020001DE RID: 478
[Token(Token = "0x20001DE")]
public class MoveWay_free : BaseBulletMovement
{
	// Token: 0x06000822 RID: 2082 RVA: 0x00029E50 File Offset: 0x00028050
	[Token(Token = "0x6000822")]
	[Address(RVA = "0x86C920", Offset = "0x86AF20", VA = "0x18086C920", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.FreeUpdate();
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00029E70 File Offset: 0x00028070
	[Token(Token = "0x6000823")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00029E88 File Offset: 0x00028088
	[Token(Token = "0x6000824")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_free()
	{
		base.PositionUpdate();
	}
}
