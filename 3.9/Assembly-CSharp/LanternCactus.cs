using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000552 RID: 1362
[Token(Token = "0x2000552")]
public class LanternCactus : Cactus
{
	// Token: 0x0600194F RID: 6479 RVA: 0x00088ECC File Offset: 0x000870CC
	[Token(Token = "0x600194F")]
	[Address(RVA = "0x5323C0", Offset = "0x5309C0", VA = "0x1805323C0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		ParticleSystem component = base.transform.Find("LanternShine").GetComponent<ParticleSystem>();
		this.lightShine = component;
		throw new NullReferenceException();
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x00088F04 File Offset: 0x00087104
	[Token(Token = "0x6001950")]
	[Address(RVA = "0x532A40", Offset = "0x531040", VA = "0x180532A40", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		ParticleSystem.MainModule main = this.lightShine.main;
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x00088F30 File Offset: 0x00087130
	[Token(Token = "0x6001951")]
	[Address(RVA = "0x532740", Offset = "0x530D40", VA = "0x180532740", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		PlantType thePlantType = this.thePlantType;
		Action action = new Action(this.AttackZombieInAir);
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.maxHitCount = (int)((ulong)3L);
		PlantType thePlantType2 = this.thePlantType;
		bullet.fromType = thePlantType2;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		CreateBullet instance2 = CreateBullet.Instance;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		PlantType thePlantType3 = this.thePlantType;
		bullet2.fromType = thePlantType3;
		GameAPP.PlaySound((int)thePlantType3, 0.5f, 1f);
		return bullet2;
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x00088FDC File Offset: 0x000871DC
	[Token(Token = "0x6001952")]
	[Address(RVA = "0x532460", Offset = "0x530A60", VA = "0x180532460", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		PlantType thePlantType = this.thePlantType;
		Action action = new Action(this.AttackZombieInLand);
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.maxHitCount = (int)((ulong)3L);
		PlantType thePlantType2 = this.thePlantType;
		bullet.fromType = thePlantType2;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		CreateBullet instance2 = CreateBullet.Instance;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		PlantType thePlantType3 = this.thePlantType;
		bullet2.fromType = thePlantType3;
		throw new NullReferenceException();
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x0008907C File Offset: 0x0008727C
	[Token(Token = "0x6001953")]
	[Address(RVA = "0x531C60", Offset = "0x530260", VA = "0x180531C60")]
	private void AttackZombieInAir()
	{
		int num2;
		do
		{
			int num = 0;
			List<Zombie> zombieList = this.zombieList;
			int size = zombieList._size;
			num2 = 0;
			zombieList._size = num2;
			if (size > 0)
			{
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				Transform axis = this.axis;
				int thePlantRow = this.thePlantRow;
				List<Zombie> zombieList2 = this.zombieList;
			}
		}
		while (num2 != 0);
		int num4 = 0;
		Zombie zombie;
		if (zombie != num4)
		{
		}
		uint num5;
		uint num6;
		GameAPP.PlaySound((int)num5, 1f, (float)num6);
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x00089128 File Offset: 0x00087328
	[Token(Token = "0x6001954")]
	[Address(RVA = "0x532010", Offset = "0x530610", VA = "0x180532010")]
	private void AttackZombieInLand()
	{
		int num2;
		do
		{
			int num = 0;
			List<Zombie> zombieList = this.zombieList;
			int size = zombieList._size;
			num2 = 0;
			zombieList._size = num2;
			if (size > 0)
			{
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				Transform axis = this.axis;
				if (!base.AttackLandZombie(num))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				List<Zombie> zombieList2 = this.zombieList;
			}
		}
		while (num2 != 0);
		bool flag2 = "{il2cpp field on {'constant41' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x124}" > (ulong)2L;
		int num4 = 0;
		Zombie zombie;
		bool flag3;
		if (zombie != num4)
		{
			flag3 = flag2 + true;
		}
		uint num5;
		GameAPP.PlaySound((int)num5, 1f, flag3);
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x000891F0 File Offset: 0x000873F0
	[Token(Token = "0x6001955")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public LanternCactus()
	{
	}

	// Token: 0x04000ECA RID: 3786
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000ECA")]
	private ParticleSystem lightShine;
}
