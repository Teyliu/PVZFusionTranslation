using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000123 RID: 291
[Token(Token = "0x2000123")]
public class Bullet_cabbage_ice : Bullet_sunCabbage
{
	// Token: 0x0600058F RID: 1423 RVA: 0x0001D620 File Offset: 0x0001B820
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x6E6350", Offset = "0x6E4950", VA = "0x1806E6350", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)1L);
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x0001D638 File Offset: 0x0001B838
	[Token(Token = "0x6000590")]
	[Address(RVA = "0x6E60E0", Offset = "0x6E46E0", VA = "0x1806E60E0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		int num = 0;
		zombie.AddfreezeLevel(10, num);
		int num2 = 0;
		int damage = this._damage;
		if (zombie == 0)
		{
			Plant from = this.from;
			int num3 = 0;
			if (from != num3)
			{
				Plant from2 = this.from;
			}
		}
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num4 != 0UL);
		float num5 = this.velocity.y * -1f;
		this.velocity.y = num5;
		Vector2 velocity = this.velocity;
		float y = this.velocity.y;
		float num6 = velocity * 0.4f;
		float num7 = y * -0.5f;
		this.velocity = num6;
		this.velocity.y = num7;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num8 = 0;
		int theBulletRow = this.theBulletRow;
		ulong num9;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num8, theBulletRow, num9 != 0UL, (float)num2);
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0001D730 File Offset: 0x0001B930
	[Token(Token = "0x6000591")]
	[Address(RVA = "0x6E5FD0", Offset = "0x6E45D0", VA = "0x1806E5FD0", Slot = "17")]
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

	// Token: 0x06000592 RID: 1426 RVA: 0x0001D77C File Offset: 0x0001B97C
	[Token(Token = "0x6000592")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_cabbage_ice()
	{
	}
}
