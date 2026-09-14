using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200056A RID: 1386
[Token(Token = "0x200056A")]
public class MoneyMelon : Melonpult
{
	// Token: 0x060019C2 RID: 6594 RVA: 0x0008AE7C File Offset: 0x0008907C
	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x5375C0", Offset = "0x535BC0", VA = "0x1805375C0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x0008AE94 File Offset: 0x00089094
	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x537220", Offset = "0x535820", VA = "0x180537220", Slot = "41")]
	protected override void AnimSuperShoot()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 1f, 1f);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Transform axis = this.axis;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		bullet.cannonPos = 0;
		bullet.cannonPos.y = (float)0;
		Board instance2 = Board.Instance;
		bullet.theStatus = (BulletStatus)((ulong)2L);
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bool flag;
		if (flag)
		{
			List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__1_ = MoneyMelon.<>c.<>9__1_0;
			if (<>9__1_ == 0)
			{
				MoneyMelon.<>c.<>9__1_0 = delegate(Zombie a)
				{
					bool alive = a.Alive;
					if (!alive)
					{
						return alive;
					}
					return global::Lawnf.InLandStatus(a.theStatus);
				};
			}
			Action<Zombie> action;
			global::Core.Lawnf.Foreach<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__1_), action);
		}
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x0008AF6C File Offset: 0x0008916C
	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public MoneyMelon()
	{
	}
}
