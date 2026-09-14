using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000192 RID: 402
[Token(Token = "0x2000192")]
public class Bullet_puffPotato : Bullet
{
	// Token: 0x060006FE RID: 1790 RVA: 0x00023A8C File Offset: 0x00021C8C
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x80A8A0", Offset = "0x808EA0", VA = "0x18080A8A0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00023ADC File Offset: 0x00021CDC
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x80A7C0", Offset = "0x808DC0", VA = "0x18080A7C0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00023B08 File Offset: 0x00021D08
	[Token(Token = "0x6000700")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_puffPotato()
	{
	}
}
