using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A5 RID: 421
[Token(Token = "0x20001A5")]
public class Bullet_smallIceSpark_sp : Bullet_iceSpark
{
	// Token: 0x06000746 RID: 1862 RVA: 0x00024D5C File Offset: 0x00022F5C
	[Token(Token = "0x6000746")]
	[Address(RVA = "0x80E150", Offset = "0x80C750", VA = "0x18080E150", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.HasBuff((EffectType)((uint)2)))
		{
			int num = 0;
			if (!zombie.HasBuff((EffectType)num))
			{
				goto IL_0046;
			}
			int num2 = 0;
			zombie.SetFreeze(4f, num2);
		}
		zombie.Unfreezing();
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num3;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num3 != 0UL);
		IL_0046:
		base.PlaySound(zombie);
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00024DBC File Offset: 0x00022FBC
	[Token(Token = "0x6000747")]
	[Address(RVA = "0x80E040", Offset = "0x80C640", VA = "0x18080E040", Slot = "17")]
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

	// Token: 0x06000748 RID: 1864 RVA: 0x00024E08 File Offset: 0x00023008
	[Token(Token = "0x6000748")]
	[Address(RVA = "0x807150", Offset = "0x805750", VA = "0x180807150", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00024E28 File Offset: 0x00023028
	[Token(Token = "0x6000749")]
	[Address(RVA = "0x80DE70", Offset = "0x80C470", VA = "0x18080DE70")]
	public Bullet_smallIceSpark_sp()
	{
	}
}
