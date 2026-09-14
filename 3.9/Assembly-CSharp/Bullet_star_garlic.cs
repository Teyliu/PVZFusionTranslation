using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BC RID: 444
[Token(Token = "0x20001BC")]
public class Bullet_star_garlic : Bullet_star
{
	// Token: 0x0600079B RID: 1947 RVA: 0x0002666C File Offset: 0x0002486C
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x812E60", Offset = "0x811460", VA = "0x180812E60", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		PlantType fromType = this.fromType;
		zombie.AddPoisonLevel();
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x000266AC File Offset: 0x000248AC
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x812D50", Offset = "0x811350", VA = "0x180812D50", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)57), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x000266F8 File Offset: 0x000248F8
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x809340", Offset = "0x807940", VA = "0x180809340")]
	public Bullet_star_garlic()
	{
		this.movingToCircle = true;
		base..ctor();
	}
}
