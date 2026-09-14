using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C8 RID: 1224
[Token(Token = "0x20004C8")]
public class CactusFume : FumeShroom
{
	// Token: 0x0600171D RID: 5917 RVA: 0x0007F108 File Offset: 0x0007D308
	[Token(Token = "0x600171D")]
	[Address(RVA = "0x49C330", Offset = "0x49A930", VA = "0x18049C330", Slot = "44")]
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

	// Token: 0x0600171E RID: 5918 RVA: 0x0007F214 File Offset: 0x0007D414
	[Token(Token = "0x600171E")]
	[Address(RVA = "0x49BF20", Offset = "0x49A520", VA = "0x18049BF20", Slot = "73")]
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

	// Token: 0x0600171F RID: 5919 RVA: 0x0007F2BC File Offset: 0x0007D4BC
	[Token(Token = "0x600171F")]
	[Address(RVA = "0x49C240", Offset = "0x49A840", VA = "0x18049C240", Slot = "74")]
	protected override void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)1), thePlantType, num != 0UL);
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x0007F2EC File Offset: 0x0007D4EC
	[Token(Token = "0x6001720")]
	[Address(RVA = "0x49C7F0", Offset = "0x49ADF0", VA = "0x18049C7F0", Slot = "69")]
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

	// Token: 0x06001721 RID: 5921 RVA: 0x0007F34C File Offset: 0x0007D54C
	[Token(Token = "0x6001721")]
	[Address(RVA = "0x49C2A0", Offset = "0x49A8A0", VA = "0x18049C2A0", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)25L);
		anim.SetTrigger("rise");
		return true;
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x0007F394 File Offset: 0x0007D594
	[Token(Token = "0x6001722")]
	[Address(RVA = "0x49B750", Offset = "0x499D50", VA = "0x18049B750")]
	public CactusFume()
	{
	}
}
