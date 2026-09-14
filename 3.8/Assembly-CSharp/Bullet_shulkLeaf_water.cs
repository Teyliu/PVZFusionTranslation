using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000195 RID: 405
[Token(Token = "0x2000195")]
public class Bullet_shulkLeaf_water : Bullet_shulkLeaf
{
	// Token: 0x0600071E RID: 1822 RVA: 0x00024CC4 File Offset: 0x00022EC4
	[Token(Token = "0x600071E")]
	[Address(RVA = "0x6BA0B0", Offset = "0x6B86B0", VA = "0x1806BA0B0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2L);
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00024CDC File Offset: 0x00022EDC
	[Token(Token = "0x600071F")]
	[Address(RVA = "0x7DF180", Offset = "0x7DD780", VA = "0x1807DF180", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00024DE8 File Offset: 0x00022FE8
	[Token(Token = "0x6000720")]
	[Address(RVA = "0x7DF490", Offset = "0x7DDA90", VA = "0x1807DF490", Slot = "21")]
	public override void KeepHiting(Zombie zombie)
	{
		if (global::UnityEngine.Random.Range(0, 3) == 0)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			int num = 0;
			int theZombieRow = zombie.theZombieRow;
			int num2 = 0;
			ulong num3;
			Particle particle = instance.SetParticle((ParticleType)((uint)32), num, theZombieRow, num3 != 0UL, (float)num2);
		}
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), fromType, num4 != 0UL);
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00024E54 File Offset: 0x00023054
	[Token(Token = "0x6000721")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_shulkLeaf_water()
	{
	}
}
