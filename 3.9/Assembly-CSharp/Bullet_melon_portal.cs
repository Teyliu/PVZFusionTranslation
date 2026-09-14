using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000177 RID: 375
[Token(Token = "0x2000177")]
public class Bullet_melon_portal : Bullet_melon
{
	// Token: 0x060006A0 RID: 1696 RVA: 0x0002238C File Offset: 0x0002058C
	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x806190", Offset = "0x804790", VA = "0x180806190", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)125), num, theBulletRow, num3 != 0UL, (float)num2);
		int theBulletRow2 = this.theBulletRow;
		this.Attack(theBulletRow2);
		base.Die();
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x000223E4 File Offset: 0x000205E4
	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x8062C0", Offset = "0x8048C0", VA = "0x1808062C0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)125), num, theZombieRow, num3 != 0UL, (float)num2);
		int theZombieRow2 = zombie.theZombieRow;
		this.Attack(theZombieRow2);
		base.Die();
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x0002243C File Offset: 0x0002063C
	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x805C30", Offset = "0x804230", VA = "0x180805C30")]
	private void Attack(int row)
	{
		ulong num6;
		do
		{
			Transform transform = base.transform;
			int num = this.zombieLayer;
			List<Zombie> list = new List();
			int num2 = 0;
			int num3 = 0;
			Collider2D[] array;
			if (num3 < array.Length)
			{
				bool flag;
				if (flag)
				{
					ulong num4;
					num4 -= (ulong)row;
					bool flag2;
					if (flag2)
					{
					}
				}
				num2++;
			}
			Predicate<Zombie> predicate;
			if (Bullet_melon_portal.<>c.<>9__2_0 == 0)
			{
				Bullet_melon_portal.<>c.<>9__2_0 = predicate;
			}
			if (list.Find(predicate))
			{
				bool flag3;
				if (flag3)
				{
				}
				ulong num5;
				if (num5 != (ulong)0L)
				{
					goto IL_0090;
				}
			}
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num6 != (ulong)0L);
		return;
		IL_0090:
		throw new NullReferenceException();
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x000224E0 File Offset: 0x000206E0
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x806400", Offset = "0x804A00", VA = "0x180806400")]
	public Bullet_melon_portal()
	{
	}
}
