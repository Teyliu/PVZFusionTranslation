using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E8 RID: 1256
[Token(Token = "0x20004E8")]
public class CabbageBlover : Shooter
{
	// Token: 0x060017B6 RID: 6070 RVA: 0x00081B84 File Offset: 0x0007FD84
	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x50B0B0", Offset = "0x5096B0", VA = "0x18050B0B0", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			GameObject gameObject;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					return gameObject;
				}
			}
			num++;
			return gameObject;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00081BD4 File Offset: 0x0007FDD4
	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x50B220", Offset = "0x509820", VA = "0x18050B220", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		uint num3;
		num3 += (uint)2;
		bullet.velocity.y = 4f;
		bullet.acceleration.y = -15f;
		while (num3 <= (uint)2)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00081C6C File Offset: 0x0007FE6C
	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x473CB0", Offset = "0x4722B0", VA = "0x180473CB0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage;
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x00081C7C File Offset: 0x0007FE7C
	[Token(Token = "0x60017B9")]
	[Address(RVA = "0x5090F0", Offset = "0x5076F0", VA = "0x1805090F0")]
	public CabbageBlover()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
