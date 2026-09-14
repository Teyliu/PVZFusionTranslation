using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011D RID: 285
[Token(Token = "0x200011D")]
public class Bullet_butter_ulti2 : Bullet_butter_ulti
{
	// Token: 0x06000577 RID: 1399 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
	[Token(Token = "0x6000577")]
	[Address(RVA = "0x6E3FB0", Offset = "0x6E25B0", VA = "0x1806E3FB0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		if (!zombie.isSmall)
		{
		}
		int num2 = 0;
		zombie.Buttered(1.5f, num2 != 0);
		zombie.SetPoison(10f);
		bool flag;
		if (!flag)
		{
			int num3 = 0;
			if (!zombie.HasBuff((EffectType)num3))
			{
				goto IL_007D;
			}
			int num4 = 0;
			zombie.SetFreeze(4f, num4);
		}
		zombie.Unfreezing();
		PlantType fromType2 = this.fromType;
		IL_007D:
		base.Die();
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x0001CF40 File Offset: 0x0001B140
	[Token(Token = "0x6000578")]
	[Address(RVA = "0x6E3EB0", Offset = "0x6E24B0", VA = "0x1806E3EB0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(100, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)24), num, theBulletRow, num3 != 0UL, (float)num2);
		base.Die();
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x0001CF98 File Offset: 0x0001B198
	[Token(Token = "0x6000579")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_butter_ulti2()
	{
	}
}
