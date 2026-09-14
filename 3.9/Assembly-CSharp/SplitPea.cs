using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000591 RID: 1425
[Token(Token = "0x2000591")]
public class SplitPea : PeaShooter
{
	// Token: 0x06001A83 RID: 6787 RVA: 0x0008E610 File Offset: 0x0008C810
	[Token(Token = "0x6001A83")]
	[Address(RVA = "0x5429C0", Offset = "0x540FC0", VA = "0x1805429C0", Slot = "68")]
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

	// Token: 0x06001A84 RID: 6788 RVA: 0x0008E6A0 File Offset: 0x0008C8A0
	[Token(Token = "0x6001A84")]
	[Address(RVA = "0x542C80", Offset = "0x541280", VA = "0x180542C80", Slot = "69")]
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

	// Token: 0x06001A85 RID: 6789 RVA: 0x0008E6F0 File Offset: 0x0008C8F0
	[Token(Token = "0x6001A85")]
	[Address(RVA = "0x5427C0", Offset = "0x540DC0", VA = "0x1805427C0", Slot = "43")]
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

	// Token: 0x06001A86 RID: 6790 RVA: 0x0008E75C File Offset: 0x0008C95C
	[Token(Token = "0x6001A86")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SplitPea()
	{
	}
}
