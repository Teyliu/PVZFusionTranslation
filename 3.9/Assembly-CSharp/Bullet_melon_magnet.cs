using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000176 RID: 374
[Token(Token = "0x2000176")]
public class Bullet_melon_magnet : Bullet_melon
{
	// Token: 0x0600069C RID: 1692 RVA: 0x00022278 File Offset: 0x00020478
	[Token(Token = "0x600069C")]
	[Address(RVA = "0x805A30", Offset = "0x804030", VA = "0x180805A30", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		GameObject theFirstArmor = zombie.theFirstArmor;
		int num = 0;
		bool flag = theFirstArmor != num;
		int num2 = this._damage;
		PlantType fromType = this.fromType;
		if (flag)
		{
			num2 += num2;
		}
		int num3 = 0;
		base.AttackOtherZombie(zombie, (MelonSputterType)num3);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		base.Die();
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x000222D8 File Offset: 0x000204D8
	[Token(Token = "0x600069D")]
	[Address(RVA = "0x805910", Offset = "0x803F10", VA = "0x180805910", Slot = "17")]
	public override void HitLand()
	{
		int num = 0;
		int num2 = 0;
		base.AttackOtherZombie(num2, (MelonSputterType)num);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num3 = 0;
		int theBulletRow = this.theBulletRow;
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle((ParticleType)((uint)123), num3, theBulletRow, num5 != 0UL, (float)num4);
		base.Die();
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x0002232C File Offset: 0x0002052C
	[Token(Token = "0x600069E")]
	[Address(RVA = "0x805830", Offset = "0x803E30", VA = "0x180805830", Slot = "26")]
	protected override void AttackEffect(Zombie zombie, int dmg)
	{
		GameObject theFirstArmor = zombie.theFirstArmor;
		int num = 0;
		bool flag = theFirstArmor != num;
		PlantType fromType = this.fromType;
		ulong num2;
		if (!flag)
		{
			zombie.TakeDamage(dmg, this, (DamageType)((uint)1), fromType, num2 != 0UL);
			return;
		}
		zombie.TakeDamage(num, this, (DamageType)((uint)1), fromType, num2 != 0UL);
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00022378 File Offset: 0x00020578
	[Token(Token = "0x600069F")]
	[Address(RVA = "0x805BE0", Offset = "0x8041E0", VA = "0x180805BE0")]
	public Bullet_melon_magnet()
	{
	}
}
