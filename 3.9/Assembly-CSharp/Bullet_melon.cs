using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000170 RID: 368
[Token(Token = "0x2000170")]
public class Bullet_melon : Bullet_cabbage
{
	// Token: 0x0600068A RID: 1674 RVA: 0x00021B90 File Offset: 0x0001FD90
	[Token(Token = "0x600068A")]
	[Address(RVA = "0x6F6270", Offset = "0x6F4870", VA = "0x1806F6270", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		int num2 = 0;
		this.AttackOtherZombie(num2, (MelonSputterType)num);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00021BE0 File Offset: 0x0001FDE0
	[Token(Token = "0x600068B")]
	[Address(RVA = "0x6F6360", Offset = "0x6F4960", VA = "0x1806F6360", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)1), fromType, num != 0UL);
		int num2 = 0;
		this.AttackOtherZombie(zombie, (MelonSputterType)num2);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00021C4C File Offset: 0x0001FE4C
	[Token(Token = "0x600068C")]
	[Address(RVA = "0x6F55D0", Offset = "0x6F3BD0", VA = "0x1806F55D0", Slot = "26")]
	protected virtual void AttackEffect(Zombie zombie, int dmg)
	{
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(dmg, this, (DamageType)((uint)1), fromType, num != 0UL);
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00021C74 File Offset: 0x0001FE74
	[Token(Token = "0x600068D")]
	[Address(RVA = "0x6F5630", Offset = "0x6F3C30", VA = "0x1806F5630")]
	public void AttackOtherZombie(Zombie targetZombie, MelonSputterType damageType)
	{
		int num = 0;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		LayerMask zombieLayer = this.zombieLayer;
		int num2;
		float num5;
		if (num2 > 0)
		{
			Collider2D[] array = Bullet_melon.sharedCols;
			Collider2D collider2D;
			bool flag;
			uint num4;
			if (collider2D.TryGetComponent<Zombie>(num) && !flag)
			{
				int num3 = 0;
				if (num3 != 3)
				{
					if (18446744073709551607UL <= (ulong)15L)
					{
					}
					if (num3 != 44)
					{
						Zombie[] array2 = Bullet_melon.zombies;
						if (num != 0)
						{
						}
						num4.m_value = (uint)num;
						num += 4;
						num++;
					}
				}
			}
			num++;
			num++;
			num4 += (uint)8;
			if (num5 > 1f)
			{
				if (damageType - MelonSputterType.Butter <= 5)
				{
					int num6 = damageType - MelonSputterType.Butter;
					Zombie[] array3 = Bullet_melon.zombies;
					PlantType fromType = this.fromType;
					Zombie[] array4 = Bullet_melon.zombies;
					num++;
					num++;
					Zombie[] array5 = Bullet_melon.zombies;
					Zombie zombie;
					int poisonLevel = zombie.poisonLevel;
					array5 += poisonLevel;
					PlantType fromType2 = this.fromType;
					Zombie[] array6 = Bullet_melon.zombies;
					Zombie zombie2;
					zombie2.AddPoisonLevel();
					num++;
					num++;
					Zombie[] array7 = Bullet_melon.zombies;
					PlantType fromType3 = this.fromType;
					Zombie[] array8 = Bullet_melon.zombies;
					Zombie zombie3;
					zombie3.SetJalaed();
					num++;
					num++;
					Zombie[] array9 = Bullet_melon.zombies;
					int num7 = 0;
					uint num8;
					array9.AddfreezeLevel((int)num8, num7);
					Zombie[] array10 = Bullet_melon.zombies;
					Zombie[] array11 = Bullet_melon.zombies;
					Zombie[] array12 = Bullet_melon.zombies;
					PlantType fromType4 = this.fromType;
					num++;
					num++;
					Zombie[] array13 = Bullet_melon.zombies;
					PlantType fromType5 = this.fromType;
					Bullet_melon.zombies.SetJalaed();
					num++;
					num++;
					Zombie[] array14 = Bullet_melon.zombies;
					PlantType fromType6 = this.fromType;
					Zombie[] array15 = Bullet_melon.zombies;
					Zombie[] array16 = Bullet_melon.zombies;
					int num9 = 0;
					long num10 = array16.TotalFirstHealth;
					num10 -= (long)num9;
					long num11;
					if (num11 < num10)
					{
						Zombie[] array17 = Bullet_melon.zombies;
						int num12 = 0;
						array17.SetMindControl(num12);
					}
					num++;
					num++;
				}
				Zombie[] array18 = Bullet_melon.zombies;
				num++;
				num++;
				throw new NullReferenceException();
			}
		}
		while (num5 != 1f)
		{
		}
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00021E58 File Offset: 0x00020058
	[Token(Token = "0x600068E")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_melon()
	{
	}

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	private static readonly Collider2D[] sharedCols = new Collider2D[50];

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x4000381")]
	private static readonly Zombie[] zombies = new Zombie[50];
}
