using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C0 RID: 1216
[Token(Token = "0x20004C0")]
public class BigGloom : Shooter
{
	// Token: 0x060016FD RID: 5885 RVA: 0x0007E8FC File Offset: 0x0007CAFC
	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x49AA20", Offset = "0x499020", VA = "0x18049AA20", Slot = "69")]
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

	// Token: 0x060016FE RID: 5886 RVA: 0x0007E980 File Offset: 0x0007CB80
	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x49ABC0", Offset = "0x4991C0", VA = "0x18049ABC0", Slot = "70")]
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
			IEnumerator enumerator = gameObject.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				Vector3 vector2;
				float z2 = vector2.z;
				Transform transform2;
				transform2 += transform2;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (!flag || Lawnf.InLandStatus((ZombieStatus)num))
			{
			}
			num2++;
		}
		if (num3 != 0)
		{
			uint num4;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
		}
		throw new NullReferenceException();
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x0007EA48 File Offset: 0x0007CC48
	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x49A660", Offset = "0x498C60", VA = "0x18049A660", Slot = "44")]
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

	// Token: 0x06001700 RID: 5888 RVA: 0x0007EAE4 File Offset: 0x0007CCE4
	[Token(Token = "0x6001700")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public BigGloom()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
