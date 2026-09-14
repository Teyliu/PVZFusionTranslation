using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200013D RID: 317
[Token(Token = "0x200013D")]
public class Bullet_extremeSnowPea : Bullet_snowPea
{
	// Token: 0x060005E6 RID: 1510 RVA: 0x0001F170 File Offset: 0x0001D370
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x6EC940", Offset = "0x6EAF40", VA = "0x1806EC940", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform child = base.transform.GetChild(1);
		this._sprite = child;
		throw new NullReferenceException();
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0001F19C File Offset: 0x0001D39C
	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x6EC990", Offset = "0x6EAF90", VA = "0x1806EC990", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = this._damage;
		int num2 = 0;
		uint num3;
		zombie.AddfreezeLevel((int)num3, num2);
		float freezeSpeed = zombie.freezeSpeed;
		if (zombie == 0)
		{
		}
		bool flag;
		if (flag)
		{
			int num4 = num.Multiply(freezeSpeed);
			num += num4;
		}
		PlantType fromType = this.fromType;
		GameObject theSecondArmor = zombie.theSecondArmor;
		int num5 = 0;
		if (!(theSecondArmor == num5))
		{
		}
		int num6 = 0;
		uint num7;
		zombie.SetCold(15f, (int)num7, num6 != 0);
		Transform transform = base.transform;
		int num8 = 0;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
		if (zombie.read > num8)
		{
		}
		BoardAction boardAction = this.board.boardAction;
		BulletType theBulletType = this.theBulletType;
		int num9 = 0;
		int num10 = 0;
		Bullet bullet = boardAction.FirePeas(this, num10, num9, theBulletType, num8 != 0);
		int attributeCount = this.attributeCount;
		bullet.attributeCount = attributeCount;
		float num11 = bullet.trackSpeed * 3f;
		int num12 = 0;
		bullet.trackSpeed = num11;
		List<Zombie> allZombies = global::Lawnf.GetAllZombies(num12 != 0);
		Func<Zombie, bool> func;
		if (Bullet_extremeSnowPea.<>c.<>9__2_0 == 0)
		{
			func = delegate(Zombie a)
			{
				bool alive = a.Alive;
				if (!alive)
				{
					return alive;
				}
				return global::Lawnf.InLandStatus(a.theStatus);
			};
			Bullet_extremeSnowPea.<>c.<>9__2_0 = func;
		}
		List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, func));
		bool flag2;
		if (!flag2)
		{
			Zombie random = ListExtensions.GetRandom<Zombie>(list);
			bullet.targetZombie = random;
		}
		Func<Zombie, bool> func2;
		if (Bullet_extremeSnowPea.<>c.<>9__2_1 == 0)
		{
			func2 = delegate(Zombie a)
			{
				int theZombieType = (int)a.theZombieType;
				bool flag5;
				return flag5;
			};
			Bullet_extremeSnowPea.<>c.<>9__2_1 = func2;
		}
		IOrderedEnumerable<Zombie> orderedEnumerable = Enumerable.OrderByDescending<Zombie, bool>(list, func2);
		Func<Zombie, long> func3;
		if (Bullet_extremeSnowPea.<>c.<>9__2_2 == 0)
		{
			Bullet_extremeSnowPea.<>c.<>9__2_2 = func3;
		}
		Zombie zombie2 = Enumerable.FirstOrDefault<Zombie>(Enumerable.ThenByDescending<Zombie, long>(orderedEnumerable, func3));
		bool flag3;
		if (flag3)
		{
		}
		bool flag4;
		if (flag4)
		{
			int damage = bullet._damage;
			int num13 = damage.Multiply(0.1f);
			bullet._damage = damage;
		}
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0001F35C File Offset: 0x0001D55C
	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x6ECFE0", Offset = "0x6EB5E0", VA = "0x1806ECFE0", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform sprite = this._sprite;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0001F38C File Offset: 0x0001D58C
	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_extremeSnowPea()
	{
	}

	// Token: 0x04000374 RID: 884
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000374")]
	private Transform _sprite;
}
