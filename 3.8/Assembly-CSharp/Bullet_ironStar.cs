using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000159 RID: 345
[Token(Token = "0x2000159")]
public class Bullet_ironStar : Bullet_star
{
	// Token: 0x0600064B RID: 1611 RVA: 0x0002177C File Offset: 0x0001F97C
	[Token(Token = "0x600064B")]
	[Address(RVA = "0x6C7D30", Offset = "0x6C6330", VA = "0x1806C7D30", Slot = "25")]
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

	// Token: 0x0600064C RID: 1612 RVA: 0x000217D4 File Offset: 0x0001F9D4
	[Token(Token = "0x600064C")]
	[Address(RVA = "0x6C7C50", Offset = "0x6C6250", VA = "0x1806C7C50", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00021800 File Offset: 0x0001FA00
	[Token(Token = "0x600064D")]
	[Address(RVA = "0x6BC210", Offset = "0x6BA810", VA = "0x1806BC210")]
	public Bullet_ironStar()
	{
	}
}
