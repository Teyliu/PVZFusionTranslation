using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001AC RID: 428
[Token(Token = "0x20001AC")]
public class Bullet_squashKelp : Bullet_squash
{
	// Token: 0x06000770 RID: 1904 RVA: 0x00026544 File Offset: 0x00024744
	[Token(Token = "0x6000770")]
	[Address(RVA = "0x7E3C00", Offset = "0x7E2200", VA = "0x1807E3C00", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		if (zombie.inWater)
		{
			int num3 = 0;
			zombie.SetKelped((float)damage, num3 != 0);
		}
		base.MoveWay = (BulletMoveWay)((uint)(-1));
		float num4 = this.Vy * -0.75f;
		this.Vy = num4;
		BoxCollider2D component = base.GetComponent<BoxCollider2D>();
		int num5 = 0;
		component.enabled = num5 != 0;
		base.PlaySound(zombie);
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x000265C0 File Offset: 0x000247C0
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x7E3B80", Offset = "0x7E2180", VA = "0x1807E3B80", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x000265EC File Offset: 0x000247EC
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x7E3930", Offset = "0x7E1F30", VA = "0x1807E3930", Slot = "27")]
	protected override void AttackZombie()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		int num3 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theBulletRow = this.theBulletRow;
				PlantType fromType = this.fromType;
			}
			num++;
		}
		if (num3 != 0)
		{
			uint num4;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
		}
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00026658 File Offset: 0x00024858
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_squashKelp()
	{
	}
}
