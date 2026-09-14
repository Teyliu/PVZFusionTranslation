using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200017C RID: 380
[Token(Token = "0x200017C")]
public class Bullet_pea_chomper : Bullet
{
	// Token: 0x060006B8 RID: 1720 RVA: 0x000232F8 File Offset: 0x000214F8
	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x7DA460", Offset = "0x7D8A60", VA = "0x1807DA460", Slot = "25")]
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

	// Token: 0x060006B9 RID: 1721 RVA: 0x00023398 File Offset: 0x00021598
	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_pea_chomper()
	{
	}
}
