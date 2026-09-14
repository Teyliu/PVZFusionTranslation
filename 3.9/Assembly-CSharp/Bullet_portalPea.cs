using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018C RID: 396
[Token(Token = "0x200018C")]
public class Bullet_portalPea : Bullet
{
	// Token: 0x060006E8 RID: 1768 RVA: 0x00023578 File Offset: 0x00021778
	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x8099F0", Offset = "0x807FF0", VA = "0x1808099F0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		zombie.SetPortaled(1.5f);
		int num = 0;
		int num2 = 0;
		PlantType fromType = this.fromType;
		ulong num3;
		zombie.TakeDamage(num2, this, (DamageType)num, fromType, num3 != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x000235CC File Offset: 0x000217CC
	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x8098C0", Offset = "0x807EC0", VA = "0x1808098C0", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00023600 File Offset: 0x00021800
	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x8097E0", Offset = "0x807DE0", VA = "0x1808097E0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0002362C File Offset: 0x0002182C
	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_portalPea()
	{
	}
}
