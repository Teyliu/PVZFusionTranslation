using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000171 RID: 369
[Token(Token = "0x2000171")]
public class Bullet_melon_portal : Bullet_melon
{
	// Token: 0x06000695 RID: 1685 RVA: 0x00022A3C File Offset: 0x00020C3C
	[Token(Token = "0x6000695")]
	[Address(RVA = "0x7D8900", Offset = "0x7D6F00", VA = "0x1807D8900", Slot = "18")]
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

	// Token: 0x06000696 RID: 1686 RVA: 0x00022A94 File Offset: 0x00020C94
	[Token(Token = "0x6000696")]
	[Address(RVA = "0x7D8A30", Offset = "0x7D7030", VA = "0x1807D8A30", Slot = "25")]
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

	// Token: 0x06000697 RID: 1687 RVA: 0x00022AEC File Offset: 0x00020CEC
	[Token(Token = "0x6000697")]
	[Address(RVA = "0x7D83A0", Offset = "0x7D69A0", VA = "0x1807D83A0")]
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

	// Token: 0x06000698 RID: 1688 RVA: 0x00022B90 File Offset: 0x00020D90
	[Token(Token = "0x6000698")]
	[Address(RVA = "0x7D8B70", Offset = "0x7D7170", VA = "0x1807D8B70")]
	public Bullet_melon_portal()
	{
	}
}
