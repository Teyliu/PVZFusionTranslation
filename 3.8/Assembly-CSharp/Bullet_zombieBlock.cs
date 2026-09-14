using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D3 RID: 467
[Token(Token = "0x20001D3")]
public class Bullet_zombieBlock : Bullet_nut
{
	// Token: 0x060007FF RID: 2047 RVA: 0x00029378 File Offset: 0x00027578
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x8545C0", Offset = "0x852BC0", VA = "0x1808545C0", Slot = "25")]
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
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x000293C0 File Offset: 0x000275C0
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x8544E0", Offset = "0x852AE0", VA = "0x1808544E0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x000293EC File Offset: 0x000275EC
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_zombieBlock()
	{
	}
}
