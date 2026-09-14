using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B3 RID: 435
[Token(Token = "0x20001B3")]
public class Bullet_squashKelp : Bullet_squash
{
	// Token: 0x0600077D RID: 1917 RVA: 0x00025E58 File Offset: 0x00024058
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x811270", Offset = "0x80F870", VA = "0x180811270", Slot = "22")]
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
		base.MoveWay = (BulletMoveWay)((uint)15);
		this.velocity = (ulong)1075838976L;
		Vector2 gravity = Physics2D.gravity;
		this.acceleration.y = (float)0;
		BoxCollider2D component = base.GetComponent<BoxCollider2D>();
		int num4 = 0;
		component.enabled = num4 != 0;
		base.PlaySound(zombie);
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00025EE4 File Offset: 0x000240E4
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x8111F0", Offset = "0x80F7F0", VA = "0x1808111F0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00025F10 File Offset: 0x00024110
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x810FA0", Offset = "0x80F5A0", VA = "0x180810FA0", Slot = "25")]
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

	// Token: 0x06000780 RID: 1920 RVA: 0x00025F7C File Offset: 0x0002417C
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_squashKelp()
	{
	}
}
