using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000120 RID: 288
[Token(Token = "0x2000120")]
public class Bullet_cabbage_ulti : Bullet_cabbage_small
{
	// Token: 0x0600058A RID: 1418 RVA: 0x0001E050 File Offset: 0x0001C250
	[Token(Token = "0x600058A")]
	[Address(RVA = "0x6BBF60", Offset = "0x6BA560", VA = "0x1806BBF60", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.isSmall)
		{
			zombie.BeSmall(0.7f);
		}
		this.smallEffect = true;
		zombie.AddPoisonLevel();
		PlantType fromType = this.fromType;
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		float num = this.Vy * -1f;
		this.Vy = num;
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x0001E0BC File Offset: 0x0001C2BC
	[Token(Token = "0x600058B")]
	[Address(RVA = "0x6BBE50", Offset = "0x6BA450", VA = "0x1806BBE50", Slot = "18")]
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
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0001E120 File Offset: 0x0001C320
	[Token(Token = "0x600058C")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cabbage_ulti()
	{
	}
}
