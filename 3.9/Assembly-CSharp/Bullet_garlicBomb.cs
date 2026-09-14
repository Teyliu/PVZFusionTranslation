using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000148 RID: 328
[Token(Token = "0x2000148")]
public class Bullet_garlicBomb : Bullet
{
	// Token: 0x0600060E RID: 1550 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
	[Token(Token = "0x600060E")]
	[Address(RVA = "0x6EECF0", Offset = "0x6ED2F0", VA = "0x1806EECF0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		GameAPP.PlaySound(40, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0001FC28 File Offset: 0x0001DE28
	[Token(Token = "0x600060F")]
	[Address(RVA = "0x6EEC20", Offset = "0x6ED220", VA = "0x1806EEC20", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		GameAPP.PlaySound(40, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x0001FC68 File Offset: 0x0001DE68
	[Token(Token = "0x6000610")]
	[Address(RVA = "0x6EEA10", Offset = "0x6ED010", VA = "0x1806EEA10")]
	private void AttackZombie()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && AoeDamage.InLandAoeRange((ZombieStatus)num))
			{
				PlantType fromType = this.fromType;
			}
			num++;
		}
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0001FCB8 File Offset: 0x0001DEB8
	[Token(Token = "0x6000611")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_garlicBomb()
	{
	}
}
