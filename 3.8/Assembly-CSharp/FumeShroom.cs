using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F4 RID: 1268
[Token(Token = "0x20004F4")]
public class FumeShroom : Shooter
{
	// Token: 0x060017BF RID: 6079 RVA: 0x00081904 File Offset: 0x0007FB04
	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x4C8960", Offset = "0x4C6F60", VA = "0x1804C8960", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num4;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					int thePlantRow = this.thePlantRow;
					float vision = this.vision;
					Transform axis = this.axis;
					Transform axis2 = this.axis;
					float num3 = this.range;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num4 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x060017C0 RID: 6080 RVA: 0x0008199C File Offset: 0x0007FB9C
	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x4C86A0", Offset = "0x4C6CA0", VA = "0x1804C86A0", Slot = "73")]
	protected virtual void AttackZombie()
	{
		int num2;
		ulong num5;
		do
		{
			int num = 0;
			num2 = 0;
			int num3 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(this.thePlantRow, num3 != 0);
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
				float num4 = this.range;
				Transform axis2 = this.axis;
				if (!base.SearchUniqueZombie(num))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				this.Attack(num);
			}
		}
		while (num5 != (ulong)0L);
		if (num2 != 0)
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		}
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x00081A3C File Offset: 0x0007FC3C
	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x49C240", Offset = "0x49A840", VA = "0x18049C240", Slot = "74")]
	protected virtual void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)1), thePlantType, num != 0UL);
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x00081A6C File Offset: 0x0007FC6C
	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x4C8C10", Offset = "0x4C7210", VA = "0x1804C8C10", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform = gameObject.transform;
		GameAPP.PlaySound(58, 0.5f, 1f);
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x00081AB4 File Offset: 0x0007FCB4
	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x4C7F30", Offset = "0x4C6530", VA = "0x1804C7F30")]
	public FumeShroom()
	{
	}

	// Token: 0x04000DCB RID: 3531
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DCB")]
	protected float range = 7f;
}
