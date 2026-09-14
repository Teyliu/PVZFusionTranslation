using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001EB RID: 491
[Token(Token = "0x20001EB")]
public class MoveWay_right2 : BaseBulletMovement
{
	// Token: 0x06000844 RID: 2116 RVA: 0x0002A1C0 File Offset: 0x000283C0
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x86C980", Offset = "0x86AF80", VA = "0x18086C980", Slot = "4")]
	public override void PositionUpdate()
	{
		Bullet bullet = this.bullet;
		Mouse instance = Mouse.Instance;
		Transform transform = bullet.transform;
		Bullet bullet2 = this.bullet;
		Transform transform2 = this.bullet.transform;
		Rigidbody2D rb = this.bullet.rb;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x0002A20C File Offset: 0x0002840C
	[Token(Token = "0x6000845")]
	[Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x0002A224 File Offset: 0x00028424
	[Token(Token = "0x6000846")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public MoveWay_right2()
	{
		base.PositionUpdate();
	}
}
