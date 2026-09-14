using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016F RID: 367
[Token(Token = "0x200016F")]
public class Bullet_melon_iron : Bullet_melon
{
	// Token: 0x0600068D RID: 1677 RVA: 0x000227D8 File Offset: 0x000209D8
	[Token(Token = "0x600068D")]
	[Address(RVA = "0x7D7C80", Offset = "0x7D6280", VA = "0x1807D7C80", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int theBulletRow = this.theBulletRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)124), num, theBulletRow, num3 != 0UL, (float)num2);
		int num4 = 0;
		int num5 = 0;
		base.AttackOtherZombie(num5, (MelonSputterType)num4);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00022848 File Offset: 0x00020A48
	[Token(Token = "0x600068E")]
	[Address(RVA = "0x7D7DA0", Offset = "0x7D63A0", VA = "0x1807D7DA0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
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
		uint num4;
		uint num5;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num4, (int)num5), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x000228C8 File Offset: 0x00020AC8
	[Token(Token = "0x600068F")]
	[Address(RVA = "0x7D7BA0", Offset = "0x7D61A0", VA = "0x1807D7BA0", Slot = "28")]
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

	// Token: 0x06000690 RID: 1680 RVA: 0x00022914 File Offset: 0x00020B14
	[Token(Token = "0x6000690")]
	[Address(RVA = "0x7D7F50", Offset = "0x7D6550", VA = "0x1807D7F50")]
	public Bullet_melon_iron()
	{
	}
}
