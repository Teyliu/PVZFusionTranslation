using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A2 RID: 418
[Token(Token = "0x20001A2")]
public class Bullet_snowPea : Bullet_pea
{
	// Token: 0x06000749 RID: 1865 RVA: 0x0002594C File Offset: 0x00023B4C
	[Token(Token = "0x6000749")]
	[Address(RVA = "0x6BA0C0", Offset = "0x6B86C0", VA = "0x1806BA0C0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.tail = child;
		throw new NullReferenceException();
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x0002597C File Offset: 0x00023B7C
	[Token(Token = "0x600074A")]
	[Address(RVA = "0x7E1DF0", Offset = "0x7E03F0", VA = "0x1807E1DF0", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x000259AC File Offset: 0x00023BAC
	[Token(Token = "0x600074B")]
	[Address(RVA = "0x7E1C00", Offset = "0x7E0200", VA = "0x1807E1C00", Slot = "25")]
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

	// Token: 0x0600074C RID: 1868 RVA: 0x00025A5C File Offset: 0x00023C5C
	[Token(Token = "0x600074C")]
	[Address(RVA = "0x7E1950", Offset = "0x7DFF50", VA = "0x1807E1950", Slot = "18")]
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

	// Token: 0x0600074D RID: 1869 RVA: 0x00025AA8 File Offset: 0x00023CA8
	[Token(Token = "0x600074D")]
	[Address(RVA = "0x7E1A60", Offset = "0x7E0060", VA = "0x1807E1A60", Slot = "24")]
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
			plant.TryBeDisable(5f);
		}
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00025B1C File Offset: 0x00023D1C
	[Token(Token = "0x600074E")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_snowPea()
	{
	}

	// Token: 0x04000394 RID: 916
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000394")]
	private Transform tail;
}
