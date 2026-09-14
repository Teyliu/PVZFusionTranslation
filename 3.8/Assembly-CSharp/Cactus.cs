using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C7 RID: 1223
[Token(Token = "0x20004C7")]
public class Cactus : Shooter
{
	// Token: 0x06001716 RID: 5910 RVA: 0x0007EE44 File Offset: 0x0007D044
	[Token(Token = "0x6001716")]
	[Address(RVA = "0x49D2B0", Offset = "0x49B8B0", VA = "0x18049D2B0", Slot = "69")]
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

	// Token: 0x06001717 RID: 5911 RVA: 0x0007EEA4 File Offset: 0x0007D0A4
	[Token(Token = "0x6001717")]
	[Address(RVA = "0x49D440", Offset = "0x49BA40", VA = "0x18049D440", Slot = "70")]
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

	// Token: 0x06001718 RID: 5912 RVA: 0x0007EF00 File Offset: 0x0007D100
	[Token(Token = "0x6001718")]
	[Address(RVA = "0x49CC10", Offset = "0x49B210", VA = "0x18049CC10", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cactus;
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x0007EF10 File Offset: 0x0007D110
	[Token(Token = "0x6001719")]
	[Address(RVA = "0x49CC20", Offset = "0x49B220", VA = "0x18049CC20", Slot = "45")]
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

	// Token: 0x0600171A RID: 5914 RVA: 0x0007EFD8 File Offset: 0x0007D1D8
	[Token(Token = "0x600171A")]
	[Address(RVA = "0x49CF20", Offset = "0x49B520", VA = "0x18049CF20", Slot = "44")]
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

	// Token: 0x0600171B RID: 5915 RVA: 0x0007F094 File Offset: 0x0007D294
	[Token(Token = "0x600171B")]
	[Address(RVA = "0x49CE50", Offset = "0x49B450", VA = "0x18049CE50", Slot = "48")]
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

	// Token: 0x0600171C RID: 5916 RVA: 0x0007F0E8 File Offset: 0x0007D2E8
	[Token(Token = "0x600171C")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public Cactus()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
