using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000460 RID: 1120
[Token(Token = "0x2000460")]
public class TwinShulk : Shulkflower
{
	// Token: 0x060014A5 RID: 5285 RVA: 0x00072F40 File Offset: 0x00071140
	[Token(Token = "0x60014A5")]
	[Address(RVA = "0x47B390", Offset = "0x479990", VA = "0x18047B390", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		float num = global::UnityEngine.Random.Range(0.5f, 1f);
		bullet.trackSpeed = 8f;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int num2 = this.attackDamage;
		num2 += num2;
		bullet.Damage = num2;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x00072FC4 File Offset: 0x000711C4
	[Token(Token = "0x60014A6")]
	[Address(RVA = "0x47B1B0", Offset = "0x4797B0", VA = "0x18047B1B0", Slot = "44")]
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

	// Token: 0x060014A7 RID: 5287 RVA: 0x00073028 File Offset: 0x00071228
	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public TwinShulk()
	{
	}
}
