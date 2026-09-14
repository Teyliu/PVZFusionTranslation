using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000516 RID: 1302
[Token(Token = "0x2000516")]
public class FireGloom : GloomShroom
{
	// Token: 0x06001865 RID: 6245 RVA: 0x00084708 File Offset: 0x00082908
	[Token(Token = "0x6001865")]
	[Address(RVA = "0x523290", Offset = "0x521890", VA = "0x180523290", Slot = "72")]
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

	// Token: 0x06001866 RID: 6246 RVA: 0x000847F8 File Offset: 0x000829F8
	[Token(Token = "0x6001866")]
	[Address(RVA = "0x523640", Offset = "0x521C40", VA = "0x180523640", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = this.center.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x00084828 File Offset: 0x00082A28
	[Token(Token = "0x6001867")]
	[Address(RVA = "0x5236D0", Offset = "0x521CD0", VA = "0x1805236D0")]
	public FireGloom()
	{
		this.range = 2f;
		this.maxRow = (int)((ulong)1L);
		base..ctor();
	}
}
