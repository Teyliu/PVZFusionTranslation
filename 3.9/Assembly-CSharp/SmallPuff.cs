using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000588 RID: 1416
[Token(Token = "0x2000588")]
public class SmallPuff : Shooter
{
	// Token: 0x06001A4D RID: 6733 RVA: 0x0008D30C File Offset: 0x0008B50C
	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x53EA00", Offset = "0x53D000", VA = "0x18053EA00", Slot = "43")]
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

	// Token: 0x06001A4E RID: 6734 RVA: 0x0008D39C File Offset: 0x0008B59C
	[Token(Token = "0x6001A4E")]
	[Address(RVA = "0x53ECC0", Offset = "0x53D2C0", VA = "0x18053ECC0", Slot = "68")]
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

	// Token: 0x06001A4F RID: 6735 RVA: 0x0008D3F4 File Offset: 0x0008B5F4
	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SmallPuff()
	{
	}
}
