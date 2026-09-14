using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004EC RID: 1260
[Token(Token = "0x20004EC")]
public class Cactus : Shooter
{
	// Token: 0x060017C4 RID: 6084 RVA: 0x00081DAC File Offset: 0x0007FFAC
	[Token(Token = "0x60017C4")]
	[Address(RVA = "0x50CCB0", Offset = "0x50B2B0", VA = "0x18050CCB0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x00081E0C File Offset: 0x0008000C
	[Token(Token = "0x60017C5")]
	[Address(RVA = "0x50CE40", Offset = "0x50B440", VA = "0x18050CE40", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform transform = base.transform.Find("Shoot2").transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060017C6 RID: 6086 RVA: 0x00081E68 File Offset: 0x00080068
	[Token(Token = "0x60017C6")]
	[Address(RVA = "0x50C610", Offset = "0x50AC10", VA = "0x18050C610", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cactus;
	}

	// Token: 0x060017C7 RID: 6087 RVA: 0x00081E78 File Offset: 0x00080078
	[Token(Token = "0x60017C7")]
	[Address(RVA = "0x50C620", Offset = "0x50AC20", VA = "0x18050C620", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		GameObject gameObject = this.SearchZombie();
		int num2 = 0;
		if (gameObject == num2)
		{
			Zombie zombie = base.SearchBoss();
			int num3 = 0;
			if (zombie != num3)
			{
				GameObject gameObject2 = zombie.gameObject;
			}
		}
		int num4 = 0;
		if (!(gameObject != num4))
		{
			Animator anim = this.anim;
			int num5 = 0;
			anim.SetBool("rise", num5 != 0);
			return;
		}
		Animator anim2 = this.anim;
		Zombie zombie2;
		if (zombie2.theStatus == ZombieStatus.Flying)
		{
			anim2.SetBool("rise", true);
			this.anim.SetTrigger("shoot2");
			return;
		}
		Animator anim3 = this.anim;
		throw new NullReferenceException();
	}

	// Token: 0x060017C8 RID: 6088 RVA: 0x00081F40 File Offset: 0x00080140
	[Token(Token = "0x60017C8")]
	[Address(RVA = "0x50C920", Offset = "0x50AF20", VA = "0x18050C920", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieList = this.zombieList;
			int size = zombieList._size;
			zombieList._size = num;
			if (size > 0)
			{
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				float vision = this.vision;
				Transform axis = this.axis;
				if (!this.SearchUniqueZombie(num))
				{
					continue;
				}
				List<Zombie> zombieList2 = this.zombieList;
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_00A7;
			}
			bool flag2;
			if (flag2)
			{
				break;
			}
			ulong num4;
			if (num4 == (ulong)0L)
			{
				goto Block_5;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_5:
		throw new NullReferenceException();
		IL_00A7:
		throw new NullReferenceException();
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x00081FFC File Offset: 0x000801FC
	[Token(Token = "0x60017C9")]
	[Address(RVA = "0x50C850", Offset = "0x50AE50", VA = "0x18050C850", Slot = "47")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		int num = 0;
		bool flag = zombie == num;
		if (!flag && zombie.isMindControlled == flag)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus > ZombieStatus.Pol_jump)
			{
				if (flag <= true)
				{
				}
				if (flag > true && theStatus != ZombieStatus.Bungi_awake)
				{
					goto IL_003E;
				}
			}
		}
		IL_0031:
		while (18446744073709551615UL == (ulong)4294967293L)
		{
		}
		goto IL_003E;
		goto IL_0031;
		IL_003E:
		throw new NullReferenceException();
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x00082050 File Offset: 0x00080250
	[Token(Token = "0x60017CA")]
	[Address(RVA = "0x5090F0", Offset = "0x5076F0", VA = "0x1805090F0")]
	public Cactus()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
