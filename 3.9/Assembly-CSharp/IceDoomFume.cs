using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200053C RID: 1340
[Token(Token = "0x200053C")]
public class IceDoomFume : Shooter
{
	// Token: 0x060018FB RID: 6395 RVA: 0x00086E94 File Offset: 0x00085094
	[Token(Token = "0x60018FB")]
	[Address(RVA = "0x52AE30", Offset = "0x529430", VA = "0x18052AE30", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x00086EDC File Offset: 0x000850DC
	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x52AC10", Offset = "0x529210", VA = "0x18052AC10", Slot = "43")]
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

	// Token: 0x060018FD RID: 6397 RVA: 0x00086F4C File Offset: 0x0008514C
	[Token(Token = "0x60018FD")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public IceDoomFume()
	{
	}
}
