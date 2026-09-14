using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x20001E4")]
public abstract class BaseBulletMovement : BulletMovement
{
	// Token: 0x06000832 RID: 2098 RVA: 0x00029A04 File Offset: 0x00027C04
	[Token(Token = "0x6000832")]
	[Address(RVA = "0x8E0BB0", Offset = "0x8DF1B0", VA = "0x1808E0BB0")]
	protected void SetShadowBelowBullet(float offsetY = -0.7f)
	{
		Transform transform = this.bullet.transform;
		Bullet bullet = this.bullet;
		Vector3 vector;
		float z = vector.z;
		Transform shadow = bullet.shadow;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00029A44 File Offset: 0x00027C44
	[Token(Token = "0x6000833")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	protected BaseBulletMovement()
	{
		base.PositionUpdate();
	}
}
