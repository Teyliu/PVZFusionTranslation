using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015E RID: 350
[Token(Token = "0x200015E")]
public class Bullet_ironPea_curse : Bullet
{
	// Token: 0x06000652 RID: 1618 RVA: 0x0002104C File Offset: 0x0001F24C
	[Token(Token = "0x6000652")]
	[Address(RVA = "0x6F31E0", Offset = "0x6F17E0", VA = "0x1806F31E0", Slot = "17")]
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

	// Token: 0x06000653 RID: 1619 RVA: 0x00021098 File Offset: 0x0001F298
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x6F32F0", Offset = "0x6F18F0", VA = "0x1806F32F0", Slot = "21")]
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

	// Token: 0x06000654 RID: 1620 RVA: 0x00021104 File Offset: 0x0001F304
	[Token(Token = "0x6000654")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_ironPea_curse()
	{
	}
}
