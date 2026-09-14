using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000188 RID: 392
[Token(Token = "0x2000188")]
public class Bullet_puffLove : Bullet
{
	// Token: 0x060006E5 RID: 1765 RVA: 0x00023EB4 File Offset: 0x000220B4
	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x7DCB20", Offset = "0x7DB120", VA = "0x1807DCB20", Slot = "25")]
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

	// Token: 0x060006E6 RID: 1766 RVA: 0x00023EF4 File Offset: 0x000220F4
	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x7DCA30", Offset = "0x7DB030", VA = "0x1807DCA30", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int theBulletRow = this.theBulletRow;
		this.AttackZombie(theBulletRow);
		base.Die();
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00023F30 File Offset: 0x00022130
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x7DC700", Offset = "0x7DAD00", VA = "0x1807DC700")]
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
					bool flag2;
					if (flag2)
					{
					}
					float shootingfloat = this.shootingfloat;
					float num4 = global::UnityEngine.Random.Range((float)num3, 1f);
					if (shootingfloat > num4)
					{
					}
				}
			}
			num++;
		}
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00023FA8 File Offset: 0x000221A8
	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x7DCBC0", Offset = "0x7DB1C0", VA = "0x1807DCBC0")]
	private void TrySetMindControl(Zombie zombie)
	{
		int currentFirstHealth = zombie.CurrentFirstHealth;
		float totalFirstHealth = zombie.TotalFirstHealth;
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

	// Token: 0x060006E9 RID: 1769 RVA: 0x00023FFC File Offset: 0x000221FC
	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_puffLove()
	{
	}
}
