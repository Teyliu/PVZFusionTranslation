using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000138 RID: 312
[Token(Token = "0x2000138")]
public class Bullet_extremeSnowPea : Bullet_snowPea
{
	// Token: 0x060005DF RID: 1503 RVA: 0x0001F9AC File Offset: 0x0001DBAC
	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x6C1B60", Offset = "0x6C0160", VA = "0x1806C1B60", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform child = base.transform.GetChild(1);
		this._sprite = child;
		throw new NullReferenceException();
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0001F9D8 File Offset: 0x0001DBD8
	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x6C1BB0", Offset = "0x6C01B0", VA = "0x1806C1BB0", Slot = "25")]
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
			Bullet_extremeSnowPea.<>c.<>9__2_1 = func2;
		}
		IOrderedEnumerable<Zombie> orderedEnumerable = Enumerable.OrderByDescending<Zombie, bool>(list, func2);
		Func<Zombie, int> func3;
		if (Bullet_extremeSnowPea.<>c.<>9__2_2 == 0)
		{
			Bullet_extremeSnowPea.<>c.<>9__2_2 = func3;
		}
		Zombie zombie2 = Enumerable.FirstOrDefault<Zombie>(Enumerable.ThenByDescending<Zombie, int>(orderedEnumerable, func3));
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

	// Token: 0x060005E1 RID: 1505 RVA: 0x0001FB74 File Offset: 0x0001DD74
	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x6C2200", Offset = "0x6C0800", VA = "0x1806C2200", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform sprite = this._sprite;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0001FBA4 File Offset: 0x0001DDA4
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_extremeSnowPea()
	{
	}

	// Token: 0x0400036D RID: 877
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400036D")]
	private Transform _sprite;
}
