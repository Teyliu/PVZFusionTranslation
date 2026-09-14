using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058D RID: 1421
[Token(Token = "0x200058D")]
public class Threekelp : Tanglekelp
{
	// Token: 0x06001A42 RID: 6722 RVA: 0x0008D4D0 File Offset: 0x0008B6D0
	[Token(Token = "0x6001A42")]
	[Address(RVA = "0x4EE220", Offset = "0x4EC820", VA = "0x1804EE220", Slot = "16")]
	protected override void Update()
	{
		base.PlantShootUpdate();
		base.Update();
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x0008D4EC File Offset: 0x0008B6EC
	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x4EDCC0", Offset = "0x4EC2C0", VA = "0x1804EDCC0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Vector3 vector;
		float z = vector.z;
		Transform shoot3 = this.shoot;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		int rowNum = this.board.rowNum;
		CreateBullet instance2 = CreateBullet.Instance;
		int num = this.thePlantRow;
		num++;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		CreateBullet instance3 = CreateBullet.Instance;
		int attackDamage3 = this.attackDamage;
		Bullet bullet3;
		bullet3.Damage = attackDamage3;
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x0008D598 File Offset: 0x0008B798
	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x4EDFC0", Offset = "0x4EC5C0", VA = "0x1804EDFC0", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					float vision = this.vision;
					Transform axis = this.axis;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x0008D610 File Offset: 0x0008B810
	[Token(Token = "0x6001A45")]
	[Address(RVA = "0x4E9AE0", Offset = "0x4E80E0", VA = "0x1804E9AE0")]
	public Threekelp()
	{
	}
}
