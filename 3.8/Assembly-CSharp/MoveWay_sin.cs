using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001EA RID: 490
[Token(Token = "0x20001EA")]
public class MoveWay_sin : BaseBulletMovement
{
	// Token: 0x06000841 RID: 2113 RVA: 0x0002A168 File Offset: 0x00028368
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x86CAF0", Offset = "0x86B0F0", VA = "0x18086CAF0", Slot = "4")]
	public override void PositionUpdate()
	{
		Bullet bullet = this.bullet;
		float theExistTime = bullet.theExistTime;
		Rigidbody2D rb = bullet.rb;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x0002A194 File Offset: 0x00028394
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x0002A1AC File Offset: 0x000283AC
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_sin()
	{
		base.PositionUpdate();
	}
}
