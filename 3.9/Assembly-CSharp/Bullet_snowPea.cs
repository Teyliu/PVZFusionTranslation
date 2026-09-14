using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A9 RID: 425
[Token(Token = "0x20001A9")]
public class Bullet_snowPea : Bullet_pea
{
	// Token: 0x06000756 RID: 1878 RVA: 0x00025298 File Offset: 0x00023498
	[Token(Token = "0x6000756")]
	[Address(RVA = "0x6E4FB0", Offset = "0x6E35B0", VA = "0x1806E4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.tail = child;
		throw new NullReferenceException();
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x000252C8 File Offset: 0x000234C8
	[Token(Token = "0x6000757")]
	[Address(RVA = "0x80F560", Offset = "0x80DB60", VA = "0x18080F560", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x000252F8 File Offset: 0x000234F8
	[Token(Token = "0x6000758")]
	[Address(RVA = "0x80F370", Offset = "0x80D970", VA = "0x18080F370", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		zombie.AddfreezeLevel(10, num);
		int num2;
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)17), (MissionResult)((uint)2)))
		{
			num2 = global::UnityEngine.Random.Range(0, (int)1.7E-44f);
			if (num2 == 0)
			{
				int num3 = 0;
				zombie.SetFreeze(1.7E-44f, num3);
			}
		}
		int num4 = 0;
		if (num2 == 0)
		{
		}
		PlantType fromType = this.fromType;
		ulong num5;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num5 != 0UL);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num6 = 0;
		int theZombieRow = zombie.theZombieRow;
		ulong num7;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num6, theZombieRow, num7 != 0UL, (float)num4);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x000253A8 File Offset: 0x000235A8
	[Token(Token = "0x6000759")]
	[Address(RVA = "0x80F0B0", Offset = "0x80D6B0", VA = "0x18080F0B0", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x000253F4 File Offset: 0x000235F4
	[Token(Token = "0x600075A")]
	[Address(RVA = "0x80F1C0", Offset = "0x80D7C0", VA = "0x18080F1C0", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int thePlantRow = plant.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, thePlantRow, num3 != 0UL, (float)num2);
		base.Die();
		int num4 = 0;
		if (plant.disableCount > num4)
		{
		}
		plant.FlashOnce();
		if (global::UnityEngine.Random.Range(0, 10) == 0)
		{
			int num5 = 0;
			plant.TryBeDisable(5f, num5 != 0);
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x0002546C File Offset: 0x0002366C
	[Token(Token = "0x600075B")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_snowPea()
	{
	}

	// Token: 0x0400039D RID: 925
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400039D")]
	private Transform tail;
}
