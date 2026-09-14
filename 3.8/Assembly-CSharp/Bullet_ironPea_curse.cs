using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000158 RID: 344
[Token(Token = "0x2000158")]
public class Bullet_ironPea_curse : Bullet
{
	// Token: 0x06000648 RID: 1608 RVA: 0x000216B0 File Offset: 0x0001F8B0
	[Token(Token = "0x6000648")]
	[Address(RVA = "0x6C79B0", Offset = "0x6C5FB0", VA = "0x1806C79B0", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)152), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x000216FC File Offset: 0x0001F8FC
	[Token(Token = "0x6000649")]
	[Address(RVA = "0x6C7AC0", Offset = "0x6C60C0", VA = "0x1806C7AC0", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		bool flag = plant.SetEffect((EffectType)((uint)103), 1f, 0.1f);
		plant.FlashOnce();
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int thePlantRow = plant.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)152), num, thePlantRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00021768 File Offset: 0x0001F968
	[Token(Token = "0x600064A")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_ironPea_curse()
	{
	}
}
