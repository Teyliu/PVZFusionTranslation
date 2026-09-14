using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000185 RID: 389
[Token(Token = "0x2000185")]
public class Bullet_portalPea : Bullet
{
	// Token: 0x060006DB RID: 1755 RVA: 0x00023C58 File Offset: 0x00021E58
	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x7DC300", Offset = "0x7DA900", VA = "0x1807DC300", Slot = "25")]
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

	// Token: 0x060006DC RID: 1756 RVA: 0x00023CAC File Offset: 0x00021EAC
	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x7DC1D0", Offset = "0x7DA7D0", VA = "0x1807DC1D0", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00023CE0 File Offset: 0x00021EE0
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x7DC0F0", Offset = "0x7DA6F0", VA = "0x1807DC0F0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00023D0C File Offset: 0x00021F0C
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_portalPea()
	{
	}
}
