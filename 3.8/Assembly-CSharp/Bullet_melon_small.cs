using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000173 RID: 371
[Token(Token = "0x2000173")]
public class Bullet_melon_small : Bullet
{
	// Token: 0x0600069C RID: 1692 RVA: 0x00022BEC File Offset: 0x00020DEC
	[Token(Token = "0x600069C")]
	[Address(RVA = "0x7D8C80", Offset = "0x7D7280", VA = "0x1807D8C80", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = this._damage;
		PlantType fromType = this.fromType;
		if (zombie.isSmall)
		{
			num += num;
		}
		base.PlaySound(zombie);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.Die();
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00022C3C File Offset: 0x00020E3C
	[Token(Token = "0x600069D")]
	[Address(RVA = "0x7D8BC0", Offset = "0x7D71C0", VA = "0x1807D8BC0", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)111), num, theBulletRow, num3 != 0UL, (float)num2);
		base.HitLand();
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00022C84 File Offset: 0x00020E84
	[Token(Token = "0x600069E")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_melon_small()
	{
	}
}
