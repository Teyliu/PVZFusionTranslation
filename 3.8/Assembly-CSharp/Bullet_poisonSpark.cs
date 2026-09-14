using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000184 RID: 388
[Token(Token = "0x2000184")]
public class Bullet_poisonSpark : Bullet_pierce
{
	// Token: 0x060006D6 RID: 1750 RVA: 0x00023B08 File Offset: 0x00021D08
	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x6BB760", Offset = "0x6B9D60", VA = "0x1806BB760", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00023B20 File Offset: 0x00021D20
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x7DBFE0", Offset = "0x7DA5E0", VA = "0x1807DBFE0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int theZombieRow = zombie.theZombieRow;
		this.AttackZombies(theZombieRow);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)143), num, theBulletRow, num3 != 0UL, (float)num2);
		GameAPP.PlaySound((SoundType)((uint)70), 0.5f, 1f);
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00023B84 File Offset: 0x00021D84
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x7DBC90", Offset = "0x7DA290", VA = "0x1807DBC90")]
	private void AttackZombies(int row)
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				num -= row;
				PlantType fromType = this.fromType;
			}
			num++;
		}
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00023BD8 File Offset: 0x00021DD8
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x7DBED0", Offset = "0x7DA4D0", VA = "0x1807DBED0", Slot = "18")]
	public override void HitLand()
	{
		int theBulletRow = this.theBulletRow;
		this.AttackZombies(theBulletRow);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow2 = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)143), num, theBulletRow2, num3 != 0UL, (float)num2);
		GameAPP.PlaySound((SoundType)((uint)70), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00023C44 File Offset: 0x00021E44
	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_poisonSpark()
	{
	}
}
