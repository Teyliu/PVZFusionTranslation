using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011F RID: 287
[Token(Token = "0x200011F")]
public class Bullet_cabbage_three : Bullet_cabbage
{
	// Token: 0x06000587 RID: 1415 RVA: 0x0001DF24 File Offset: 0x0001C124
	[Token(Token = "0x6000587")]
	[Address(RVA = "0x6BB770", Offset = "0x6B9D70", VA = "0x1806BB770", Slot = "25")]
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
		float z = vector.z;
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

	// Token: 0x06000588 RID: 1416 RVA: 0x0001E004 File Offset: 0x0001C204
	[Token(Token = "0x6000588")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_cabbage_three()
	{
	}
}
