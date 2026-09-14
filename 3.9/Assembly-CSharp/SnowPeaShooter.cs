using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058D RID: 1421
[Token(Token = "0x200058D")]
public class SnowPeaShooter : PeaShooter
{
	// Token: 0x06001A67 RID: 6759 RVA: 0x0008DD3C File Offset: 0x0008BF3C
	[Token(Token = "0x6001A67")]
	[Address(RVA = "0x540C40", Offset = "0x53F240", VA = "0x180540C40", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = this.shoot.transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(68, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x0008DDA4 File Offset: 0x0008BFA4
	[Token(Token = "0x6001A68")]
	[Address(RVA = "0x540AC0", Offset = "0x53F0C0", VA = "0x180540AC0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		for (;;)
		{
			int num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
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
				return BulletType.Bullet_snowPea;
			}
		}
		return BulletType.Bullet_extremeSnowPea;
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x0008DE00 File Offset: 0x0008C000
	[Token(Token = "0x6001A69")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SnowPeaShooter()
	{
	}
}
