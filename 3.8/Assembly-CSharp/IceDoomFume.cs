using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000511 RID: 1297
[Token(Token = "0x2000511")]
public class IceDoomFume : Shooter
{
	// Token: 0x06001832 RID: 6194 RVA: 0x00083644 File Offset: 0x00081844
	[Token(Token = "0x6001832")]
	[Address(RVA = "0x4CEA70", Offset = "0x4CD070", VA = "0x1804CEA70", Slot = "69")]
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

	// Token: 0x06001833 RID: 6195 RVA: 0x0008368C File Offset: 0x0008188C
	[Token(Token = "0x6001833")]
	[Address(RVA = "0x4CE850", Offset = "0x4CCE50", VA = "0x1804CE850", Slot = "44")]
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

	// Token: 0x06001834 RID: 6196 RVA: 0x000836FC File Offset: 0x000818FC
	[Token(Token = "0x6001834")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public IceDoomFume()
	{
	}
}
