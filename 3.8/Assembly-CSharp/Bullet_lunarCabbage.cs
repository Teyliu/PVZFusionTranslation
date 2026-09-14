using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000165 RID: 357
[Token(Token = "0x2000165")]
public class Bullet_lunarCabbage : Bullet_cabbage
{
	// Token: 0x0600066F RID: 1647 RVA: 0x00021E84 File Offset: 0x00020084
	[Token(Token = "0x600066F")]
	[Address(RVA = "0x6C9240", Offset = "0x6C7840", VA = "0x1806C9240", Slot = "25")]
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

	// Token: 0x06000670 RID: 1648 RVA: 0x00021ED0 File Offset: 0x000200D0
	[Token(Token = "0x6000670")]
	[Address(RVA = "0x6C9160", Offset = "0x6C7760", VA = "0x1806C9160", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00021EFC File Offset: 0x000200FC
	[Token(Token = "0x6000671")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_lunarCabbage()
	{
	}
}
