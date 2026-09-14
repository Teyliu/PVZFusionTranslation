using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000175 RID: 373
[Token(Token = "0x2000175")]
public class Bullet_melon_iron : Bullet_melon
{
	// Token: 0x06000698 RID: 1688 RVA: 0x00022128 File Offset: 0x00020328
	[Token(Token = "0x6000698")]
	[Address(RVA = "0x805510", Offset = "0x803B10", VA = "0x180805510", Slot = "17")]
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

	// Token: 0x06000699 RID: 1689 RVA: 0x00022198 File Offset: 0x00020398
	[Token(Token = "0x6000699")]
	[Address(RVA = "0x805630", Offset = "0x803C30", VA = "0x180805630", Slot = "22")]
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

	// Token: 0x0600069A RID: 1690 RVA: 0x00022218 File Offset: 0x00020418
	[Token(Token = "0x600069A")]
	[Address(RVA = "0x805430", Offset = "0x803A30", VA = "0x180805430", Slot = "26")]
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

	// Token: 0x0600069B RID: 1691 RVA: 0x00022264 File Offset: 0x00020464
	[Token(Token = "0x600069B")]
	[Address(RVA = "0x8057E0", Offset = "0x803DE0", VA = "0x1808057E0")]
	public Bullet_melon_iron()
	{
	}
}
