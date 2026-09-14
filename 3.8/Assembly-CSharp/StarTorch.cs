using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000575 RID: 1397
[Token(Token = "0x2000575")]
public class StarTorch : TorchWood
{
	// Token: 0x060019D7 RID: 6615 RVA: 0x0008B36C File Offset: 0x0008956C
	[Token(Token = "0x60019D7")]
	[Address(RVA = "0x4E7AA0", Offset = "0x4E60A0", VA = "0x1804E7AA0", Slot = "69")]
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
				uint num2;
				GameAPP.PlaySound((int)num2, 0.5f, 1f);
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x0008B428 File Offset: 0x00089628
	[Token(Token = "0x60019D8")]
	[Address(RVA = "0x4E7880", Offset = "0x4E5E80", VA = "0x1804E7880")]
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
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		bullet.Die();
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x0008B4B8 File Offset: 0x000896B8
	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public StarTorch()
	{
	}
}
