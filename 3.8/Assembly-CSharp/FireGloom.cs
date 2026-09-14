using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004EE RID: 1262
[Token(Token = "0x20004EE")]
public class FireGloom : GloomShroom
{
	// Token: 0x060017AE RID: 6062 RVA: 0x000814C0 File Offset: 0x0007F6C0
	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x4C7F50", Offset = "0x4C6550", VA = "0x1804C7F50", Slot = "73")]
	protected override void AttackZombie()
	{
		GameObject center = this.center;
		int num = 0;
		Transform transform = center.transform;
		int num2 = this.zombieLayer;
		int num3 = 0;
		int num4 = 0;
		Collider2D[] array;
		if (num3 < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				List<Zombie> zombieList = this.zombieList;
			}
			num4++;
		}
		int size = this.zombieList._size;
		Zombie zombie = this.zombieList[size];
		int num5 = 0;
		if (zombie != num5)
		{
			Zombie zombie2 = this.zombieList[size];
			PlantType thePlantType = this.thePlantType;
			this.zombieList[size].SetJalaed();
		}
		List<Zombie> zombieList2 = this.zombieList;
		int size2 = zombieList2._size;
		zombieList2._size = (int)((ulong)0L);
		if (size2 > 0)
		{
		}
		if (num != 0)
		{
			uint num6;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num6), 0.5f, 1f);
		}
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x000815B0 File Offset: 0x0007F7B0
	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x4C8300", Offset = "0x4C6900", VA = "0x1804C8300", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = this.center.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x000815E0 File Offset: 0x0007F7E0
	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x4C8390", Offset = "0x4C6990", VA = "0x1804C8390")]
	public FireGloom()
	{
		this.range = 2f;
		this.maxRow = (int)((ulong)1L);
		base..ctor();
	}
}
