using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001E2 RID: 482
[Token(Token = "0x20001E2")]
public class BulletHelper : MonoBehaviour
{
	// Token: 0x06000829 RID: 2089 RVA: 0x000296DC File Offset: 0x000278DC
	[Token(Token = "0x6000829")]
	[Address(RVA = "0x8E0C90", Offset = "0x8DF290", VA = "0x1808E0C90")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num;
		do
		{
			Bullet bullet = this.bullet;
			num = 0;
			int maxHitCount = bullet.maxHitCount;
			if (bullet.hitCount >= maxHitCount)
			{
				return;
			}
			if (collision.TryGetComponent<Zombie>(num) && this.bullet.bulletMovement.CanHit(num))
			{
				goto Block_2;
			}
		}
		while (!collision.TryGetComponent<AirProjectile>(num));
		bool flag;
		while (!flag)
		{
		}
		return;
		Block_2:
		this.bullet.Hit(num);
		Bullet bullet2 = this.bullet;
		Bullet bullet3 = this.bullet;
		int maxHitCount2 = bullet3.maxHitCount;
		bullet3.Die();
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00029764 File Offset: 0x00027964
	[Token(Token = "0x600082A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BulletHelper()
	{
	}

	// Token: 0x040003D0 RID: 976
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003D0")]
	public Bullet bullet;
}
