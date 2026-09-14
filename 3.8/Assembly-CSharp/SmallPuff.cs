using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000559 RID: 1369
[Token(Token = "0x2000559")]
public class SmallPuff : Shooter
{
	// Token: 0x06001971 RID: 6513 RVA: 0x0008939C File Offset: 0x0008759C
	[Token(Token = "0x6001971")]
	[Address(RVA = "0x4E08F0", Offset = "0x4DEEF0", VA = "0x1804E08F0", Slot = "44")]
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
					Transform axis = this.axis;
					Transform axis2 = this.axis;
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

	// Token: 0x06001972 RID: 6514 RVA: 0x0008942C File Offset: 0x0008762C
	[Token(Token = "0x6001972")]
	[Address(RVA = "0x4E0BB0", Offset = "0x4DF1B0", VA = "0x1804E0BB0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x00089484 File Offset: 0x00087684
	[Token(Token = "0x6001973")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SmallPuff()
	{
	}
}
