using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018B RID: 395
[Token(Token = "0x200018B")]
public class Bullet_poisonSpark : Bullet_pierce
{
	// Token: 0x060006E3 RID: 1763 RVA: 0x00023428 File Offset: 0x00021628
	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00023440 File Offset: 0x00021640
	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x8096D0", Offset = "0x807CD0", VA = "0x1808096D0", Slot = "22")]
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

	// Token: 0x060006E5 RID: 1765 RVA: 0x000234A4 File Offset: 0x000216A4
	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x809380", Offset = "0x807980", VA = "0x180809380")]
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

	// Token: 0x060006E6 RID: 1766 RVA: 0x000234F8 File Offset: 0x000216F8
	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x8095C0", Offset = "0x807BC0", VA = "0x1808095C0", Slot = "17")]
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

	// Token: 0x060006E7 RID: 1767 RVA: 0x00023564 File Offset: 0x00021764
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_poisonSpark()
	{
	}
}
