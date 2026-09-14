using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001DD RID: 477
[Token(Token = "0x20001DD")]
public class Bullet_zombieBlock : Bullet_nut
{
	// Token: 0x06000815 RID: 2069 RVA: 0x00028F38 File Offset: 0x00027138
	[Token(Token = "0x6000815")]
	[Address(RVA = "0x8E32A0", Offset = "0x8E18A0", VA = "0x1808E32A0", Slot = "22")]
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

	// Token: 0x06000816 RID: 2070 RVA: 0x00028F80 File Offset: 0x00027180
	[Token(Token = "0x6000816")]
	[Address(RVA = "0x8E31C0", Offset = "0x8E17C0", VA = "0x1808E31C0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00028FAC File Offset: 0x000271AC
	[Token(Token = "0x6000817")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_zombieBlock()
	{
	}
}
