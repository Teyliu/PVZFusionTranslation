using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000183 RID: 387
[Token(Token = "0x2000183")]
public class Bullet_pea_chomper : Bullet
{
	// Token: 0x060006C7 RID: 1735 RVA: 0x00022CF0 File Offset: 0x00020EF0
	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x807E20", Offset = "0x806420", VA = "0x180807E20", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theZombieRow = zombie.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)156), num, theZombieRow, num3 != 0UL, (float)num2);
		GameAPP.PlaySound((SoundType)((uint)49), 0.5f, 1f);
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		if (!flag)
		{
			if (global::UnityEngine.Random.Range(0, 8) != 0)
			{
				int damage = this._damage;
				PlantType fromType = this.fromType;
				ulong num4;
				zombie.TakeDamage(damage, this, (DamageType)((uint)1), fromType, num4 != 0UL);
				base.Die();
				return;
			}
			zombie.Die(2);
		}
		PlantType fromType2 = this.fromType;
		throw new NullReferenceException();
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00022D90 File Offset: 0x00020F90
	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_pea_chomper()
	{
	}
}
