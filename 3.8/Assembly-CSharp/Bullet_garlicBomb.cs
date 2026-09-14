using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000143 RID: 323
[Token(Token = "0x2000143")]
public class Bullet_garlicBomb : Bullet
{
	// Token: 0x06000606 RID: 1542 RVA: 0x00020360 File Offset: 0x0001E560
	[Token(Token = "0x6000606")]
	[Address(RVA = "0x6C3B70", Offset = "0x6C2170", VA = "0x1806C3B70", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		GameAPP.PlaySound(40, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x000203A0 File Offset: 0x0001E5A0
	[Token(Token = "0x6000607")]
	[Address(RVA = "0x6C3AA0", Offset = "0x6C20A0", VA = "0x1806C3AA0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		GameAPP.PlaySound(40, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x000203E0 File Offset: 0x0001E5E0
	[Token(Token = "0x6000608")]
	[Address(RVA = "0x6C3890", Offset = "0x6C1E90", VA = "0x1806C3890")]
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

	// Token: 0x06000609 RID: 1545 RVA: 0x00020430 File Offset: 0x0001E630
	[Token(Token = "0x6000609")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_garlicBomb()
	{
	}
}
