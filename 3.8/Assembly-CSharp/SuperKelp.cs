using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057E RID: 1406
[Token(Token = "0x200057E")]
public class SuperKelp : SquashKelp
{
	// Token: 0x060019F4 RID: 6644 RVA: 0x0008BB2C File Offset: 0x00089D2C
	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x4E9AB0", Offset = "0x4E80B0", VA = "0x1804E9AB0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x0008BB40 File Offset: 0x00089D40
	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x4E9590", Offset = "0x4E7B90", VA = "0x1804E9590", Slot = "74")]
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

	// Token: 0x060019F6 RID: 6646 RVA: 0x0008BBD4 File Offset: 0x00089DD4
	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x4E9850", Offset = "0x4E7E50", VA = "0x1804E9850", Slot = "44")]
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

	// Token: 0x060019F7 RID: 6647 RVA: 0x0008BC4C File Offset: 0x00089E4C
	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x4E9AE0", Offset = "0x4E80E0", VA = "0x1804E9AE0")]
	public SuperKelp()
	{
	}
}
