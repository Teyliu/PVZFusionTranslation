using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000169 RID: 361
[Token(Token = "0x2000169")]
public class Bullet_lotusSpruce : Bullet
{
	// Token: 0x06000672 RID: 1650 RVA: 0x0002169C File Offset: 0x0001F89C
	[Token(Token = "0x6000672")]
	[Address(RVA = "0x6F48D0", Offset = "0x6F2ED0", VA = "0x1806F48D0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		this.AttackZombies();
		base.Die();
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x000216BC File Offset: 0x0001F8BC
	[Token(Token = "0x6000673")]
	[Address(RVA = "0x6F48B0", Offset = "0x6F2EB0", VA = "0x1806F48B0", Slot = "17")]
	public override void HitLand()
	{
		this.AttackZombies();
		base.Die();
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x000216D8 File Offset: 0x0001F8D8
	[Token(Token = "0x6000674")]
	[Address(RVA = "0x6F45B0", Offset = "0x6F2BB0", VA = "0x1806F45B0")]
	private void AttackZombies()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				PlantType fromType = this.fromType;
			}
			num3++;
		}
		ParticleManager instance = ParticleManager.Instance;
		Transform transform2 = base.transform;
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00021748 File Offset: 0x0001F948
	[Token(Token = "0x6000675")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_lotusSpruce()
	{
	}
}
