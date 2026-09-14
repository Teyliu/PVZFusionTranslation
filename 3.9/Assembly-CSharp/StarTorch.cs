using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A5 RID: 1445
[Token(Token = "0x20005A5")]
public class StarTorch : TorchWood
{
	// Token: 0x06001AB7 RID: 6839 RVA: 0x0008F420 File Offset: 0x0008D620
	[Token(Token = "0x6001AB7")]
	[Address(RVA = "0x5471E0", Offset = "0x5457E0", VA = "0x1805471E0", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet_star>(num);
		if (flag)
		{
			bool flag2 = collision != this;
			if (flag2)
			{
				if (collision > (ulong)144L)
				{
					if (flag2 <= true)
					{
						return;
					}
					if (collision == (ulong)189L)
					{
						CreateBullet instance = CreateBullet.Instance;
					}
					if (flag2 <= true)
					{
						return;
					}
				}
				else
				{
					while (flag <= true)
					{
					}
					while (collision == (ulong)104L)
					{
					}
					while (collision == (ulong)144L)
					{
					}
				}
				CreateBullet instance2 = CreateBullet.Instance;
				Bullet bullet;
				bullet.theExistTime = instance2;
				bullet.trackSpeed = bullet;
				Transform transform = bullet.transform;
				Quaternion quaternion;
				bullet.accelerate = quaternion != null;
				Vector2 vector;
				bullet.rb.velocity = vector;
				if (bullet._moveWay == BulletMoveWay.Stable)
				{
				}
				List<BulletHitFilter> list;
				bullet.hitFilters = list;
				uint num2;
				GameAPP.PlaySound((int)num2, 0.5f, 1f);
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x06001AB8 RID: 6840 RVA: 0x0008F4E4 File Offset: 0x0008D6E4
	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x546F60", Offset = "0x545560", VA = "0x180546F60")]
	private void FireStar(Bullet bullet, BulletType targetType = BulletType.Bullet_fireStar)
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = bullet.transform;
		Transform transform2 = bullet.transform;
		BulletMoveWay moveWay = bullet._moveWay;
		float theExistTime = bullet.theExistTime;
		int num = bullet._damage;
		num += 20;
		float trackSpeed = bullet.trackSpeed;
		Transform transform3 = bullet.transform;
		bool accelerate = bullet.accelerate;
		Vector2 velocity = bullet.rb.velocity;
		Rigidbody2D rigidbody2D;
		rigidbody2D.velocity = velocity;
		List<BulletHitFilter> list = new List(bullet.hitFilters);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		bullet.Die();
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0008F580 File Offset: 0x0008D780
	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public StarTorch()
	{
	}
}
