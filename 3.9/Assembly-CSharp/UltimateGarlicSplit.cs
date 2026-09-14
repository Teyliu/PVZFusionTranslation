using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DC RID: 1500
[Token(Token = "0x20005DC")]
public class UltimateGarlicSplit : Shooter
{
	// Token: 0x06001BDD RID: 7133 RVA: 0x00094DB8 File Offset: 0x00092FB8
	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x4C8380", Offset = "0x4C6980", VA = "0x1804C8380", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)1L);
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x00094DD4 File Offset: 0x00092FD4
	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x564660", Offset = "0x562C60", VA = "0x180564660", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(3, 0.5f, 1f);
		if (Lawnf.TravelUltimate((UltiBuff)((uint)49)))
		{
			this.attributeCount = (int)((ulong)2L);
			Bullet bullet2 = this.Shoot2();
			Bullet bullet3 = this.Shoot2();
			this.attributeCount = (int)((ulong)1L);
		}
		return bullet;
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x00094E60 File Offset: 0x00093060
	[Token(Token = "0x6001BDF")]
	[Address(RVA = "0x5647F0", Offset = "0x562DF0", VA = "0x1805647F0", Slot = "69")]
	protected override Bullet Shoot2()
	{
		int attributeCount = this.attributeCount;
		Transform shoot = this.shoot2;
		this.attributeCount = attributeCount;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		Transform transform = bullet.transform;
		int attributeCount2 = this.attributeCount;
		float num = global::UnityEngine.Random.Range(0.9f, 1.1f) * 0.017453292f;
		float num2 = global::UnityEngine.Random.Range(0.5f, 1f);
		bullet.velocity = (ulong)3225419776L;
		bullet.trackSpeed = 8f;
		bullet.velocity.y = num2;
		GameAPP.PlaySound(4, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x00094F38 File Offset: 0x00093138
	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x564450", Offset = "0x562A50", VA = "0x180564450", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_shadow_poison;
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x00094F4C File Offset: 0x0009314C
	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x564460", Offset = "0x562A60", VA = "0x180564460", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					int thePlantRow = this.thePlantRow;
					float vision = this.vision;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x00094FB8 File Offset: 0x000931B8
	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateGarlicSplit()
	{
	}
}
