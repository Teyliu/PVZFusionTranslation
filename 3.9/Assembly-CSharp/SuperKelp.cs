using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005AF RID: 1455
[Token(Token = "0x20005AF")]
public class SuperKelp : SquashKelp
{
	// Token: 0x06001ADA RID: 6874 RVA: 0x0008FEC4 File Offset: 0x0008E0C4
	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x549920", Offset = "0x547F20", VA = "0x180549920", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x0008FED8 File Offset: 0x0008E0D8
	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0x549400", Offset = "0x547A00", VA = "0x180549400", Slot = "73")]
	protected virtual void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot");
		Vector3 vector;
		float z = vector.z;
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

	// Token: 0x06001ADC RID: 6876 RVA: 0x0008FF6C File Offset: 0x0008E16C
	[Token(Token = "0x6001ADC")]
	[Address(RVA = "0x5496C0", Offset = "0x547CC0", VA = "0x1805496C0", Slot = "43")]
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

	// Token: 0x06001ADD RID: 6877 RVA: 0x0008FFE4 File Offset: 0x0008E1E4
	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x4466F0", Offset = "0x444CF0", VA = "0x1804466F0")]
	public SuperKelp()
	{
	}
}
