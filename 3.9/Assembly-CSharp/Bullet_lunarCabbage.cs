using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016B RID: 363
[Token(Token = "0x200016B")]
public class Bullet_lunarCabbage : Bullet_cabbage
{
	// Token: 0x0600067A RID: 1658 RVA: 0x0002182C File Offset: 0x0001FA2C
	[Token(Token = "0x600067A")]
	[Address(RVA = "0x6F4B40", Offset = "0x6F3140", VA = "0x1806F4B40", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00021878 File Offset: 0x0001FA78
	[Token(Token = "0x600067B")]
	[Address(RVA = "0x6F4A60", Offset = "0x6F3060", VA = "0x1806F4A60", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x000218A4 File Offset: 0x0001FAA4
	[Token(Token = "0x600067C")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_lunarCabbage()
	{
	}
}
