using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000542 RID: 1346
[Token(Token = "0x2000542")]
public class IceStar : StarFruit
{
	// Token: 0x0600190C RID: 6412 RVA: 0x000873BC File Offset: 0x000855BC
	[Token(Token = "0x600190C")]
	[Address(RVA = "0x52C1D0", Offset = "0x52A7D0", VA = "0x18052C1D0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		int num3 = 0;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		Transform transform = bullet.transform;
		num3 += 72;
		throw new NullReferenceException();
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x0008744C File Offset: 0x0008564C
	[Token(Token = "0x600190D")]
	[Address(RVA = "0x52BF40", Offset = "0x52A540", VA = "0x18052BF40")]
	private void BulletUpdate(Bullet bullet)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600190E RID: 6414 RVA: 0x00087470 File Offset: 0x00085670
	[Token(Token = "0x600190E")]
	[Address(RVA = "0x52C020", Offset = "0x52A620", VA = "0x18052C020", Slot = "43")]
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
				if (num != num2 && Lawnf.InLandStatus((ZombieStatus)num))
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		ulong num4;
		while (num4 == (ulong)0L)
		{
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x000874CC File Offset: 0x000856CC
	[Token(Token = "0x600190F")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public IceStar()
	{
	}
}
