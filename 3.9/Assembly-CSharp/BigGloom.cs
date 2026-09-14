using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E5 RID: 1253
[Token(Token = "0x20004E5")]
public class BigGloom : Shooter
{
	// Token: 0x060017AB RID: 6059 RVA: 0x00081850 File Offset: 0x0007FA50
	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x50A320", Offset = "0x508920", VA = "0x18050A320", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		int num = 0;
		CreateBullet instance = CreateBullet.Instance;
		int thePlantRow = this.thePlantRow;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		Transform transform = bullet.transform;
		int num2 = 0;
		int num3 = 0;
		transform.Rotate((float)num3, (float)num2, (float)thePlantRow);
		PlantType thePlantType = this.thePlantType;
		num += 45;
		bullet.fromType = thePlantType;
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x000818D4 File Offset: 0x0007FAD4
	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x50A4C0", Offset = "0x508AC0", VA = "0x18050A4C0", Slot = "69")]
	protected override Bullet Shoot2()
	{
		int num;
		do
		{
			num = 0;
			Transform transform = this.shoot.transform;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject;
			Transform transform2 = gameObject.transform;
			int num2 = 0;
			IEnumerator enumerator = transform2.GetEnumerator();
			if (num < num2)
			{
				num += num;
				num++;
			}
			if (num < num)
			{
				num += num;
				num++;
			}
			Vector3 vector2;
			float z2 = vector2.z;
			Transform transform3;
			transform3 += transform3;
			transform3 += transform3;
		}
		while (num != 0);
		int num3 = 0;
		int num4 = 0;
		Collider2D[] array;
		if (num3 < array.Length)
		{
			bool flag;
			if (!flag || Lawnf.InLandStatus((ZombieStatus)num))
			{
			}
			num3++;
		}
		if (num4 != 0)
		{
			uint num5;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num5), 0.5f, 1f);
		}
		throw new NullReferenceException();
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x000819A8 File Offset: 0x0007FBA8
	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x509F60", Offset = "0x508560", VA = "0x180509F60", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		int num2;
		for (;;)
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (num != num3)
				{
					int thePlantRow = this.thePlantRow;
					float vision = this.vision;
					Transform axis = this.axis;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num2 == 0)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		int num4 = 0;
		Collider2D[] array;
		bool flag2;
		if (num4 < array.Length && (!flag2 || !Lawnf.InLandStatus((ZombieStatus)num2)))
		{
			num4++;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00081A44 File Offset: 0x0007FC44
	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x5090F0", Offset = "0x5076F0", VA = "0x1805090F0")]
	public BigGloom()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
