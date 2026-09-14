using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018F RID: 399
[Token(Token = "0x200018F")]
public class Bullet_puffLove : Bullet
{
	// Token: 0x060006F2 RID: 1778 RVA: 0x000237D4 File Offset: 0x000219D4
	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x80A220", Offset = "0x808820", VA = "0x18080A220", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int theZombieRow = zombie.theZombieRow;
		this.AttackZombie(theZombieRow);
		base.Die();
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00023814 File Offset: 0x00021A14
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x80A130", Offset = "0x808730", VA = "0x18080A130", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int theBulletRow = this.theBulletRow;
		this.AttackZombie(theBulletRow);
		base.Die();
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00023850 File Offset: 0x00021A50
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x809DF0", Offset = "0x8083F0", VA = "0x180809DF0")]
	private void AttackZombie(int row)
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		int num3 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				num -= row;
				if (AoeDamage.InLandAoeRange((ZombieStatus)num))
				{
					PlantType fromType = this.fromType;
					long num4 = num4;
					bool flag2;
					if (flag2)
					{
					}
					float shootingfloat = this.shootingfloat;
					float num5 = global::UnityEngine.Random.Range((float)num3, 1f);
					if (shootingfloat > num5)
					{
					}
				}
			}
			num++;
		}
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x000238CC File Offset: 0x00021ACC
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x80A2C0", Offset = "0x8088C0", VA = "0x18080A2C0")]
	private void TrySetMindControl(Zombie zombie)
	{
		long currentFirstHealth = zombie.CurrentFirstHealth;
		long totalFirstHealth = zombie.TotalFirstHealth;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)18)))
		{
		}
		float shootingfloat = this.shootingfloat;
		float num = global::UnityEngine.Random.Range((float)0, 1f);
		if (shootingfloat > num)
		{
			int num2 = 0;
			zombie.SetMindControl(num2);
		}
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00023928 File Offset: 0x00021B28
	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_puffLove()
	{
	}
}
