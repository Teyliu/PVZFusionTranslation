using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D9 RID: 473
[Token(Token = "0x20001D9")]
public class BulletMovement
{
	// Token: 0x06000816 RID: 2070 RVA: 0x00029CAC File Offset: 0x00027EAC
	[Token(Token = "0x6000816")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "4")]
	public virtual void PositionUpdate()
	{
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00029CBC File Offset: 0x00027EBC
	[Token(Token = "0x6000817")]
	[Address(RVA = "0x8530F0", Offset = "0x8516F0", VA = "0x1808530F0", Slot = "5")]
	public virtual void ShadowUpdate()
	{
		Bullet bullet = this.bullet;
		Mouse instance = Mouse.Instance;
		Transform transform = bullet.transform;
		Bullet bullet2 = this.bullet;
		Bullet bullet3 = this.bullet;
		Transform shadow = bullet3.shadow;
		Transform transform2 = bullet3.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00029D10 File Offset: 0x00027F10
	[Token(Token = "0x6000818")]
	[Address(RVA = "0x852EA0", Offset = "0x8514A0", VA = "0x180852EA0")]
	public static BulletMovement GetMovement(BulletMoveWay moveWay)
	{
		if (moveWay + 1 <= (BulletMoveWay)25)
		{
			int num = (int)(moveWay + 1);
		}
		BulletMovement bulletMovement;
		bulletMovement.PositionUpdate();
		return bulletMovement;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x00029D4C File Offset: 0x00027F4C
	[Token(Token = "0x6000819")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public BulletMovement()
	{
		this.PositionUpdate();
	}

	// Token: 0x040003C7 RID: 967
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003C7")]
	public Bullet bullet;
}
