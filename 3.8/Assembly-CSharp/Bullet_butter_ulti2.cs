using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000117 RID: 279
[Token(Token = "0x2000117")]
public class Bullet_butter_ulti2 : Bullet_butter_ulti
{
	// Token: 0x06000566 RID: 1382 RVA: 0x0001D528 File Offset: 0x0001B728
	[Token(Token = "0x6000566")]
	[Address(RVA = "0x6B90C0", Offset = "0x6B76C0", VA = "0x1806B90C0", Slot = "25")]
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

	// Token: 0x06000567 RID: 1383 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
	[Token(Token = "0x6000567")]
	[Address(RVA = "0x6B8FC0", Offset = "0x6B75C0", VA = "0x1806B8FC0", Slot = "18")]
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

	// Token: 0x06000568 RID: 1384 RVA: 0x0001D618 File Offset: 0x0001B818
	[Token(Token = "0x6000568")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_butter_ulti2()
	{
	}
}
