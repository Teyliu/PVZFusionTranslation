using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001DA RID: 474
[Token(Token = "0x20001DA")]
public abstract class BaseBulletMovement : BulletMovement
{
	// Token: 0x0600081A RID: 2074 RVA: 0x00029D60 File Offset: 0x00027F60
	[Token(Token = "0x600081A")]
	[Address(RVA = "0x852970", Offset = "0x850F70", VA = "0x180852970")]
	protected void SetShadowBelowBullet(float offsetY = -0.7f)
	{
		Transform transform = this.bullet.transform;
		Bullet bullet = this.bullet;
		Vector3 vector;
		float z = vector.z;
		Transform shadow = bullet.shadow;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00029DA0 File Offset: 0x00027FA0
	[Token(Token = "0x600081B")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	protected BaseBulletMovement()
	{
		base.PositionUpdate();
	}
}
