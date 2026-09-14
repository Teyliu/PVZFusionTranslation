using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C9 RID: 1225
[Token(Token = "0x20004C9")]
public class CactusStar : StarFruit
{
	// Token: 0x06001723 RID: 5923 RVA: 0x0007F3A8 File Offset: 0x0007D5A8
	[Token(Token = "0x6001723")]
	[Address(RVA = "0x49CAE0", Offset = "0x49B0E0", VA = "0x18049CAE0", Slot = "73")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x0007F3F0 File Offset: 0x0007D5F0
	[Token(Token = "0x6001724")]
	[Address(RVA = "0x49C900", Offset = "0x49AF00", VA = "0x18049C900", Slot = "44")]
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

	// Token: 0x06001725 RID: 5925 RVA: 0x0007F448 File Offset: 0x0007D648
	[Token(Token = "0x6001725")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public CactusStar()
	{
	}
}
