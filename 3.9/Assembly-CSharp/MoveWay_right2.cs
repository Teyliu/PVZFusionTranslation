using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001F2 RID: 498
[Token(Token = "0x20001F2")]
public class MoveWay_right2 : BaseBulletMovement
{
	// Token: 0x0600085E RID: 2142 RVA: 0x0002A198 File Offset: 0x00028398
	[Token(Token = "0x600085E")]
	[Address(RVA = "0x8FBD00", Offset = "0x8FA300", VA = "0x1808FBD00", Slot = "4")]
	public override void PositionUpdate()
	{
		Bullet bullet = this.bullet;
		Mouse instance = Mouse.Instance;
		Transform transform = bullet.transform;
		Bullet bullet2 = this.bullet;
		Bullet bullet3 = this.bullet;
		float normalSpeed = bullet3.normalSpeed;
		Transform transform2 = bullet3.transform;
		bullet3.velocity = normalSpeed;
		float num;
		bullet3.velocity.y = num;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x0002A1FC File Offset: 0x000283FC
	[Token(Token = "0x600085F")]
	[Address(RVA = "0x8FB7F0", Offset = "0x8F9DF0", VA = "0x1808FB7F0", Slot = "5")]
	public override void ShadowUpdate()
	{
		base.SetShadowBelowBullet(-0.7f);
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0002A214 File Offset: 0x00028414
	[Token(Token = "0x6000860")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public MoveWay_right2()
	{
		base.PositionUpdate();
	}
}
