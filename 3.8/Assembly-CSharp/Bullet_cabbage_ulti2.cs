using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000121 RID: 289
[Token(Token = "0x2000121")]
public class Bullet_cabbage_ulti2 : Bullet_cabbage_ulti
{
	// Token: 0x0600058D RID: 1421 RVA: 0x0001E134 File Offset: 0x0001C334
	[Token(Token = "0x600058D")]
	[Address(RVA = "0x6BBC70", Offset = "0x6BA270", VA = "0x1806BBC70", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.isSmall)
		{
			zombie.BeSmall(0.7f);
		}
		this.smallEffect = true;
		zombie.AddPoisonLevel();
		PlantType fromType = this.fromType;
		int num = 0;
		uint num2;
		zombie.AddfreezeLevel((int)num2, num);
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		float num3 = this.Vy * -1f;
		this.Vy = num3;
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x0001E1AC File Offset: 0x0001C3AC
	[Token(Token = "0x600058E")]
	[Address(RVA = "0x6BBB60", Offset = "0x6BA160", VA = "0x1806BBB60", Slot = "18")]
	public override void HitLand()
	{
		this.hit = true;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x0001E210 File Offset: 0x0001C410
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cabbage_ulti2()
	{
	}
}
