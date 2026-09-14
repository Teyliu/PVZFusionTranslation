using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000584 RID: 1412
[Token(Token = "0x2000584")]
public class SeaCactus : Shooter
{
	// Token: 0x06001A35 RID: 6709 RVA: 0x0008CCF0 File Offset: 0x0008AEF0
	[Token(Token = "0x6001A35")]
	[Address(RVA = "0x517560", Offset = "0x515B60", VA = "0x180517560", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 120f;
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x0008CD10 File Offset: 0x0008AF10
	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x53D800", Offset = "0x53BE00", VA = "0x18053D800", Slot = "39")]
	protected override void AttributeEvent()
	{
		if (this.growLevel == 0)
		{
			this.anim.SetTrigger("grow");
			GameAPP.PlaySound(56, 0.5f, 1f);
			return;
		}
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x0008CD50 File Offset: 0x0008AF50
	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x53D8A0", Offset = "0x53BEA0", VA = "0x18053D8A0")]
	public void Grow()
	{
		this.anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x0008CD84 File Offset: 0x0008AF84
	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x53DFB0", Offset = "0x53C5B0", VA = "0x18053DFB0", Slot = "68")]
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

	// Token: 0x06001A39 RID: 6713 RVA: 0x0008CDE0 File Offset: 0x0008AFE0
	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x53E0D0", Offset = "0x53C6D0", VA = "0x18053E0D0", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot2;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		int size = bullet.hitFilters._size;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		Bullet bullet2 = base.AnimShoot();
		return bullet;
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x0008CE58 File Offset: 0x0008B058
	[Token(Token = "0x6001A3A")]
	[Address(RVA = "0x53D930", Offset = "0x53BF30", VA = "0x18053D930", Slot = "44")]
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
		if (gameObject != num4)
		{
			int theZombieType = (int)gameObject.GetComponent<Zombie>().theZombieType;
			Animator anim = this.anim;
			bool flag;
			if (!flag)
			{
				throw new NullReferenceException();
			}
			anim.SetTrigger("shoot2");
		}
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x0008CEF4 File Offset: 0x0008B0F4
	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0x53DBF0", Offset = "0x53C1F0", VA = "0x18053DBF0", Slot = "43")]
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

	// Token: 0x06001A3C RID: 6716 RVA: 0x0008CFB4 File Offset: 0x0008B1B4
	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0x53DB20", Offset = "0x53C120", VA = "0x18053DB20", Slot = "47")]
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

	// Token: 0x06001A3D RID: 6717 RVA: 0x0008D008 File Offset: 0x0008B208
	[Token(Token = "0x6001A3D")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SeaCactus()
	{
	}

	// Token: 0x04000EFC RID: 3836
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EFC")]
	private int growLevel;
}
