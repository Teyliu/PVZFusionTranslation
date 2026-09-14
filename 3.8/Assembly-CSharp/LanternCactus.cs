using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000525 RID: 1317
[Token(Token = "0x2000525")]
public class LanternCactus : Cactus
{
	// Token: 0x0600187F RID: 6271 RVA: 0x00085218 File Offset: 0x00083418
	[Token(Token = "0x600187F")]
	[Address(RVA = "0x4D1AE0", Offset = "0x4D00E0", VA = "0x1804D1AE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		ParticleSystem component = base.transform.Find("LanternShine").GetComponent<ParticleSystem>();
		this.lightShine = component;
		throw new NullReferenceException();
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x00085250 File Offset: 0x00083450
	[Token(Token = "0x6001880")]
	[Address(RVA = "0x4D2160", Offset = "0x4D0760", VA = "0x1804D2160", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		ParticleSystem.MainModule main = this.lightShine.main;
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x0008527C File Offset: 0x0008347C
	[Token(Token = "0x6001881")]
	[Address(RVA = "0x4D1E60", Offset = "0x4D0460", VA = "0x1804D1E60", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		PlantType thePlantType = this.thePlantType;
		Action action = new Action(this.AttackZombieInAir);
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.penetrationTimes = (int)((ulong)3L);
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

	// Token: 0x06001882 RID: 6274 RVA: 0x00085328 File Offset: 0x00083528
	[Token(Token = "0x6001882")]
	[Address(RVA = "0x4D1B80", Offset = "0x4D0180", VA = "0x1804D1B80", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		PlantType thePlantType = this.thePlantType;
		Action action = new Action(this.AttackZombieInLand);
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.penetrationTimes = (int)((ulong)3L);
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

	// Token: 0x06001883 RID: 6275 RVA: 0x000853C8 File Offset: 0x000835C8
	[Token(Token = "0x6001883")]
	[Address(RVA = "0x4D1380", Offset = "0x4CF980", VA = "0x1804D1380")]
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

	// Token: 0x06001884 RID: 6276 RVA: 0x00085474 File Offset: 0x00083674
	[Token(Token = "0x6001884")]
	[Address(RVA = "0x4D1730", Offset = "0x4CFD30", VA = "0x1804D1730")]
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
		bool flag2 = "{il2cpp field on {'constant41' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x120}" > (ulong)2L;
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

	// Token: 0x06001885 RID: 6277 RVA: 0x0008553C File Offset: 0x0008373C
	[Token(Token = "0x6001885")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public LanternCactus()
	{
	}

	// Token: 0x04000E0F RID: 3599
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E0F")]
	private ParticleSystem lightShine;
}
