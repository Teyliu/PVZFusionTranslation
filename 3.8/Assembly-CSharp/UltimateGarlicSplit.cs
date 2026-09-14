using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005AB RID: 1451
[Token(Token = "0x20005AB")]
public class UltimateGarlicSplit : Shooter
{
	// Token: 0x06001AF7 RID: 6903 RVA: 0x00090AC8 File Offset: 0x0008ECC8
	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x470B20", Offset = "0x46F120", VA = "0x180470B20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)1L);
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x00090AE4 File Offset: 0x0008ECE4
	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0x4FDE10", Offset = "0x4FC410", VA = "0x1804FDE10", Slot = "69")]
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

	// Token: 0x06001AF9 RID: 6905 RVA: 0x00090B70 File Offset: 0x0008ED70
	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x4FDFA0", Offset = "0x4FC5A0", VA = "0x1804FDFA0", Slot = "70")]
	protected override Bullet Shoot2()
	{
		int attributeCount = this.attributeCount;
		Transform shoot = this.shoot2;
		this.attributeCount = attributeCount;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		Rigidbody2D rb = bullet.rb;
		bullet.fromType = thePlantType;
		float num = global::UnityEngine.Random.Range(0.5f, 1f);
		bullet.trackSpeed = 8f;
		GameAPP.PlaySound(4, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x00090C04 File Offset: 0x0008EE04
	[Token(Token = "0x6001AFA")]
	[Address(RVA = "0x4FDC00", Offset = "0x4FC200", VA = "0x1804FDC00", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_shadow_poison;
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x00090C18 File Offset: 0x0008EE18
	[Token(Token = "0x6001AFB")]
	[Address(RVA = "0x4FDC10", Offset = "0x4FC210", VA = "0x1804FDC10", Slot = "44")]
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

	// Token: 0x06001AFC RID: 6908 RVA: 0x00090C84 File Offset: 0x0008EE84
	[Token(Token = "0x6001AFC")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateGarlicSplit()
	{
	}
}
