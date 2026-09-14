using System;
using Cpp2IlInjected;

// Token: 0x020001DF RID: 479
[Token(Token = "0x20001DF")]
public class MoveWay_threeUp : BaseBulletMovement
{
	// Token: 0x06000825 RID: 2085 RVA: 0x00029E9C File Offset: 0x0002809C
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x86CB80", Offset = "0x86B180", VA = "0x18086CB80", Slot = "4")]
	public override void PositionUpdate()
	{
		this.bullet.ThreeUpUpdate();
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00029EBC File Offset: 0x000280BC
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00029ED4 File Offset: 0x000280D4
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_threeUp()
	{
		base.PositionUpdate();
	}
}
