using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000191 RID: 401
[Token(Token = "0x2000191")]
public class Bullet_puffPea : Bullet
{
	// Token: 0x060006FB RID: 1787 RVA: 0x000239F8 File Offset: 0x00021BF8
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x80A6E0", Offset = "0x808CE0", VA = "0x18080A6E0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num != 0);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00023A48 File Offset: 0x00021C48
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x80A600", Offset = "0x808C00", VA = "0x18080A600", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00023A78 File Offset: 0x00021C78
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_puffPea()
	{
	}
}
