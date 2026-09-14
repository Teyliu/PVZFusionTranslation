using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004EE RID: 1262
[Token(Token = "0x20004EE")]
public class CactusStar : StarFruit
{
	// Token: 0x060017D1 RID: 6097 RVA: 0x00082310 File Offset: 0x00080510
	[Token(Token = "0x60017D1")]
	[Address(RVA = "0x50C420", Offset = "0x50AA20", VA = "0x18050C420", Slot = "72")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		List<BulletHitFilter> hitFilters = bullet.hitFilters;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int size = hitFilters._size;
		hitFilters._size = (int)thePlantType;
		bool flag = bullet.hitFilters.Remove((uint)3);
		List<BulletHitFilter> hitFilters2 = bullet.hitFilters;
		int num = 0;
		bool flag2 = hitFilters2.Remove(num);
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x0008239C File Offset: 0x0008059C
	[Token(Token = "0x60017D2")]
	[Address(RVA = "0x50C240", Offset = "0x50A840", VA = "0x18050C240", Slot = "43")]
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
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_2;
			}
		}
		float vision = this.vision;
		GameObject gameObject;
		return gameObject;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x060017D3 RID: 6099 RVA: 0x000823F4 File Offset: 0x000805F4
	[Token(Token = "0x60017D3")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public CactusStar()
	{
	}
}
