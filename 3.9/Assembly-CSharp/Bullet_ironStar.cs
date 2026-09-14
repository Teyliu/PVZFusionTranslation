using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015F RID: 351
[Token(Token = "0x200015F")]
public class Bullet_ironStar : Bullet_star
{
	// Token: 0x06000655 RID: 1621 RVA: 0x00021118 File Offset: 0x0001F318
	[Token(Token = "0x6000655")]
	[Address(RVA = "0x6F3560", Offset = "0x6F1B60", VA = "0x1806F3560", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		PlantType fromType = this.fromType;
		if (zombie.theSecondArmorHealth == num)
		{
		}
		int theSecondArmorHealth = zombie.theSecondArmorHealth;
		zombie.TakeDamage(theSecondArmorHealth, this, (DamageType)num, fromType, num != 0);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00021170 File Offset: 0x0001F370
	[Token(Token = "0x6000656")]
	[Address(RVA = "0x6F3480", Offset = "0x6F1A80", VA = "0x1806F3480", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x0002119C File Offset: 0x0001F39C
	[Token(Token = "0x6000657")]
	[Address(RVA = "0x6E70E0", Offset = "0x6E56E0", VA = "0x1806E70E0")]
	public Bullet_ironStar()
	{
	}
}
