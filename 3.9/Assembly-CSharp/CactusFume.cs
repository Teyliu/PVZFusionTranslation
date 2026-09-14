using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004ED RID: 1261
[Token(Token = "0x20004ED")]
public class CactusFume : FumeShroom
{
	// Token: 0x060017CB RID: 6091 RVA: 0x00082070 File Offset: 0x00080270
	[Token(Token = "0x60017CB")]
	[Address(RVA = "0x50BC70", Offset = "0x50A270", VA = "0x18050BC70", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
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
				Transform axis2 = this.axis;
				float range = this.range;
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_00D9;
			}
			List<Zombie> zombieArray2 = this.board.zombieArray;
			bool flag2;
			ulong num5;
			if (flag2)
			{
				int num4 = 0;
				if (num != num4)
				{
					break;
				}
			}
			else if (num5 == (ulong)0L)
			{
				goto Block_5;
			}
		}
		int thePlantRow2 = this.thePlantRow;
		float vision2 = this.vision;
		Transform axis3 = this.axis;
		Transform axis4 = this.axis;
		float range2 = this.range;
		bool flag3;
		if (!flag3)
		{
		}
		GameObject gameObject;
		return gameObject;
		Block_5:
		throw new NullReferenceException();
		IL_00D9:
		throw new NullReferenceException();
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x0008217C File Offset: 0x0008037C
	[Token(Token = "0x60017CC")]
	[Address(RVA = "0x50B860", Offset = "0x509E60", VA = "0x18050B860", Slot = "72")]
	protected override void AttackZombie()
	{
		int num;
		ulong num3;
		do
		{
			num = 0;
			int num2 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(this.thePlantRow, num2 != 0);
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
				float range = this.range;
				Transform axis2 = this.axis;
				if (this.thePlantRow != 10)
				{
					bool flag2;
					while (!flag2)
					{
					}
				}
				if (this.thePlantType != PlantType.IceShroom)
				{
					continue;
				}
				PlantType thePlantType = this.thePlantType;
			}
		}
		while (num3 != (ulong)0L);
		if (num != 0)
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		}
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x00082224 File Offset: 0x00080424
	[Token(Token = "0x60017CD")]
	[Address(RVA = "0x50BB80", Offset = "0x50A180", VA = "0x18050BB80", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)1), thePlantType, num != 0UL);
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x00082254 File Offset: 0x00080454
	[Token(Token = "0x60017CE")]
	[Address(RVA = "0x50C130", Offset = "0x50A730", VA = "0x18050C130", Slot = "68")]
	protected override Bullet Shoot1()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform shoot = this.shoot;
		int num = 0;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)144), num, thePlantRow, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(58, 0.5f, 1f);
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x000822B4 File Offset: 0x000804B4
	[Token(Token = "0x60017CF")]
	[Address(RVA = "0x50BBE0", Offset = "0x50A1E0", VA = "0x18050BBE0", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)25L);
		anim.SetTrigger("rise");
		return true;
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x000822FC File Offset: 0x000804FC
	[Token(Token = "0x60017D0")]
	[Address(RVA = "0x50B0A0", Offset = "0x5096A0", VA = "0x18050B0A0")]
	public CactusFume()
	{
	}
}
