using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000480 RID: 1152
[Token(Token = "0x2000480")]
public class TwinShulk : Shulkflower
{
	// Token: 0x06001535 RID: 5429 RVA: 0x00075270 File Offset: 0x00073470
	[Token(Token = "0x6001535")]
	[Address(RVA = "0x4D2BB0", Offset = "0x4D11B0", VA = "0x1804D2BB0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		float num = global::UnityEngine.Random.Range(0.5f, 1f);
		bullet.velocity.y = num;
		bullet.velocity = (ulong)3221225472L;
		bullet.trackSpeed = 8f;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int num2 = this.attackDamage;
		num2 += num2;
		bullet.Damage = num2;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x0007531C File Offset: 0x0007351C
	[Token(Token = "0x6001536")]
	[Address(RVA = "0x4D29D0", Offset = "0x4D0FD0", VA = "0x1804D29D0", Slot = "43")]
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

	// Token: 0x06001537 RID: 5431 RVA: 0x00075380 File Offset: 0x00073580
	[Token(Token = "0x6001537")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public TwinShulk()
	{
	}
}
