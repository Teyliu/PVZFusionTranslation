using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000125 RID: 293
[Token(Token = "0x2000125")]
public class Bullet_cabbage_three : Bullet_cabbage
{
	// Token: 0x06000598 RID: 1432 RVA: 0x0001D8AC File Offset: 0x0001BAAC
	[Token(Token = "0x6000598")]
	[Address(RVA = "0x6E65E0", Offset = "0x6E4BE0", VA = "0x1806E65E0", Slot = "22")]
	protected override void HitZombie(Zombie or)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		or.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0);
		base.PlaySound(or);
		Board board = this.board;
		Transform transform = base.transform;
		Vector3 vector;
		float z2 = vector.z;
		Func<Zombie, bool> func = delegate(Zombie z)
		{
			if (Lawnf.InLandStatus(z.theStatus) && !z.isMindControlled)
			{
				return z.theZombieRow == 1;
			}
			throw new NullReferenceException();
		};
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			CreateBullet instance = CreateBullet.Instance;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			int damage2 = this._damage;
			Bullet bullet;
			bullet.Damage = damage2;
			PlantType fromType2 = this.fromType;
			bullet.fromType = fromType2;
			int num3 = 0;
			bullet.ThrowTo(zombie, num3, num);
		}
		ParticleManager instance2 = ParticleManager.Instance;
		Transform transform4 = base.transform;
		int num4 = 0;
		int theZombieRow = or.theZombieRow;
		int num5 = 0;
		int num6 = 0;
		ulong num7;
		Particle particle = instance2.SetParticle((ParticleType)num6, num4, theZombieRow, num7 != 0UL, (float)num5);
		base.Die();
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0001D99C File Offset: 0x0001BB9C
	[Token(Token = "0x6000599")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cabbage_three()
	{
	}
}
