using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016A RID: 362
[Token(Token = "0x200016A")]
public class Bullet_melon : Bullet_cabbage
{
	// Token: 0x0600067F RID: 1663 RVA: 0x000221E8 File Offset: 0x000203E8
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x6CAD40", Offset = "0x6C9340", VA = "0x1806CAD40", Slot = "18")]
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

	// Token: 0x06000680 RID: 1664 RVA: 0x00022238 File Offset: 0x00020438
	[Token(Token = "0x6000680")]
	[Address(RVA = "0x6CAE30", Offset = "0x6C9430", VA = "0x1806CAE30", Slot = "25")]
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

	// Token: 0x06000681 RID: 1665 RVA: 0x000222A4 File Offset: 0x000204A4
	[Token(Token = "0x6000681")]
	[Address(RVA = "0x6CA0A0", Offset = "0x6C86A0", VA = "0x1806CA0A0", Slot = "28")]
	protected virtual void AttackEffect(Zombie zombie, int dmg)
	{
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(dmg, this, (DamageType)((uint)1), fromType, num != 0UL);
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000222CC File Offset: 0x000204CC
	[Token(Token = "0x6000682")]
	[Address(RVA = "0x6CA100", Offset = "0x6C8700", VA = "0x1806CA100")]
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
					int num9;
					if (Bullet_melon.zombies.TotalFirstHealth > 4f && num9 == 0)
					{
						Zombie[] array16 = Bullet_melon.zombies;
						int num10 = 0;
						array16.SetMindControl(num10);
					}
					num++;
					num++;
				}
				Zombie[] array17 = Bullet_melon.zombies;
				num++;
				num++;
				throw new NullReferenceException();
			}
		}
		while (num5 != 1f)
		{
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x000224A4 File Offset: 0x000206A4
	[Token(Token = "0x6000683")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_melon()
	{
	}

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x4000377")]
	private static readonly Collider2D[] sharedCols = new Collider2D[50];

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x4000378")]
	private static readonly Zombie[] zombies = new Zombie[50];
}
