using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000561 RID: 1377
[Token(Token = "0x2000561")]
public class SplitPea : PeaShooter
{
	// Token: 0x060019A3 RID: 6563 RVA: 0x0008A55C File Offset: 0x0008875C
	[Token(Token = "0x60019A3")]
	[Address(RVA = "0x4E4550", Offset = "0x4E2B50", VA = "0x1804E4550", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform child = base.transform.GetChild(1);
		int num = 0;
		Transform child2 = child.GetChild(num);
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		Transform shoot = this.shoot;
		CreateBullet instance2 = CreateBullet.Instance;
		int bulletType2 = (int)base.GetBulletType();
		BulletMoveWay bulletMoveWay = base.GetBulletMoveWay();
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		PlantType thePlantType = this.thePlantType;
		bullet2.fromType = thePlantType;
		return bullet2;
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x0008A5EC File Offset: 0x000887EC
	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x4E4810", Offset = "0x4E2E10", VA = "0x1804E4810", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform child = base.transform.GetChild(1);
		int num = 0;
		Transform child2 = child.GetChild(num);
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x0008A63C File Offset: 0x0008883C
	[Token(Token = "0x60019A5")]
	[Address(RVA = "0x4E4350", Offset = "0x4E2950", VA = "0x1804E4350", Slot = "44")]
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
					int thePlantRow = this.thePlantRow;
					float vision = this.vision;
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

	// Token: 0x060019A6 RID: 6566 RVA: 0x0008A6A8 File Offset: 0x000888A8
	[Token(Token = "0x60019A6")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SplitPea()
	{
	}
}
