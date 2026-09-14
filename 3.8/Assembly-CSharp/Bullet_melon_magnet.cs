using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000170 RID: 368
[Token(Token = "0x2000170")]
public class Bullet_melon_magnet : Bullet_melon
{
	// Token: 0x06000691 RID: 1681 RVA: 0x00022928 File Offset: 0x00020B28
	[Token(Token = "0x6000691")]
	[Address(RVA = "0x7D81A0", Offset = "0x7D67A0", VA = "0x1807D81A0", Slot = "25")]
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

	// Token: 0x06000692 RID: 1682 RVA: 0x00022988 File Offset: 0x00020B88
	[Token(Token = "0x6000692")]
	[Address(RVA = "0x7D8080", Offset = "0x7D6680", VA = "0x1807D8080", Slot = "18")]
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

	// Token: 0x06000693 RID: 1683 RVA: 0x000229DC File Offset: 0x00020BDC
	[Token(Token = "0x6000693")]
	[Address(RVA = "0x7D7FA0", Offset = "0x7D65A0", VA = "0x1807D7FA0", Slot = "28")]
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

	// Token: 0x06000694 RID: 1684 RVA: 0x00022A28 File Offset: 0x00020C28
	[Token(Token = "0x6000694")]
	[Address(RVA = "0x7D8350", Offset = "0x7D6950", VA = "0x1807D8350")]
	public Bullet_melon_magnet()
	{
	}
}
