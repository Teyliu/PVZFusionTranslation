using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200055D RID: 1373
[Token(Token = "0x200055D")]
public class SnowPeaShooter : PeaShooter
{
	// Token: 0x06001987 RID: 6535 RVA: 0x00089CB4 File Offset: 0x00087EB4
	[Token(Token = "0x6001987")]
	[Address(RVA = "0x4E27D0", Offset = "0x4E0DD0", VA = "0x1804E27D0", Slot = "69")]
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

	// Token: 0x06001988 RID: 6536 RVA: 0x00089D1C File Offset: 0x00087F1C
	[Token(Token = "0x6001988")]
	[Address(RVA = "0x4E2650", Offset = "0x4E0C50", VA = "0x1804E2650", Slot = "71")]
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

	// Token: 0x06001989 RID: 6537 RVA: 0x00089D78 File Offset: 0x00087F78
	[Token(Token = "0x6001989")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SnowPeaShooter()
	{
	}
}
