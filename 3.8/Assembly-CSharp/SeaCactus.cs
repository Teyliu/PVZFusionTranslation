using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000555 RID: 1365
[Token(Token = "0x2000555")]
public class SeaCactus : Shooter
{
	// Token: 0x06001959 RID: 6489 RVA: 0x00088D84 File Offset: 0x00086F84
	[Token(Token = "0x6001959")]
	[Address(RVA = "0x4AB6E0", Offset = "0x4A9CE0", VA = "0x1804AB6E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 120f;
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x00088DA4 File Offset: 0x00086FA4
	[Token(Token = "0x600195A")]
	[Address(RVA = "0x4DF700", Offset = "0x4DDD00", VA = "0x1804DF700", Slot = "40")]
	protected override void AttributeEvent()
	{
		if (this.growLevel == 0)
		{
			this.anim.SetTrigger("grow");
			GameAPP.PlaySound(56, 0.5f, 1f);
			return;
		}
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x00088DE4 File Offset: 0x00086FE4
	[Token(Token = "0x600195B")]
	[Address(RVA = "0x4DF7A0", Offset = "0x4DDDA0", VA = "0x1804DF7A0")]
	public void Grow()
	{
		this.anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x00088E18 File Offset: 0x00087018
	[Token(Token = "0x600195C")]
	[Address(RVA = "0x4DFEB0", Offset = "0x4DE4B0", VA = "0x1804DFEB0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00088E74 File Offset: 0x00087074
	[Token(Token = "0x600195D")]
	[Address(RVA = "0x4DFFD0", Offset = "0x4DE5D0", VA = "0x1804DFFD0", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot2;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		Transform transform = bullet.transform;
		Quaternion quaternion;
		GameAPP.PlaySound((int)quaternion.x, 0.5f, 1f);
		Bullet bullet2 = base.AnimShoot();
		return bullet;
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x00088EE8 File Offset: 0x000870E8
	[Token(Token = "0x600195E")]
	[Address(RVA = "0x4DF830", Offset = "0x4DDE30", VA = "0x1804DF830", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		GameObject gameObject = this.SearchZombie();
		int num2 = 0;
		GameObject gameObject2;
		if (gameObject == num2)
		{
			Zombie zombie = base.SearchBoss();
			int num3 = 0;
			if (zombie != num3)
			{
				gameObject2 = zombie.gameObject;
			}
		}
		int num4 = 0;
		if (gameObject2 != num4)
		{
			int theZombieType = (int)gameObject2.GetComponent<Zombie>().theZombieType;
			Animator anim = this.anim;
			bool flag;
			if (!flag)
			{
				throw new NullReferenceException();
			}
			anim.SetTrigger("shoot2");
		}
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x00088F84 File Offset: 0x00087184
	[Token(Token = "0x600195F")]
	[Address(RVA = "0x4DFAF0", Offset = "0x4DE0F0", VA = "0x1804DFAF0", Slot = "44")]
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
				bool flag2;
				while (!flag2)
				{
				}
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_00AC;
			}
			bool flag3;
			if (flag3)
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
		IL_00AC:
		throw new NullReferenceException();
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x00089044 File Offset: 0x00087244
	[Token(Token = "0x6001960")]
	[Address(RVA = "0x4DFA20", Offset = "0x4DE020", VA = "0x1804DFA20", Slot = "48")]
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

	// Token: 0x06001961 RID: 6497 RVA: 0x00089098 File Offset: 0x00087298
	[Token(Token = "0x6001961")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SeaCactus()
	{
	}

	// Token: 0x04000E3E RID: 3646
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E3E")]
	private int growLevel;
}
