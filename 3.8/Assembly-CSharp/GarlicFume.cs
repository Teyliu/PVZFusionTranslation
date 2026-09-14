using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F7 RID: 1271
[Token(Token = "0x20004F7")]
public class GarlicFume : FumeShroom
{
	// Token: 0x060017C9 RID: 6089 RVA: 0x00081B2C File Offset: 0x0007FD2C
	[Token(Token = "0x60017C9")]
	[Address(RVA = "0x4C8D80", Offset = "0x4C7380", VA = "0x1804C8D80", Slot = "74")]
	protected override void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)1), thePlantType, num != 0UL);
		throw new NullReferenceException();
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x00081B58 File Offset: 0x0007FD58
	[Token(Token = "0x60017CA")]
	[Address(RVA = "0x4C8DF0", Offset = "0x4C73F0", VA = "0x1804C8DF0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		GameAPP.PlaySound(58, 0.5f, 1f);
		base.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x00081BB0 File Offset: 0x0007FDB0
	[Token(Token = "0x60017CB")]
	[Address(RVA = "0x4C7F30", Offset = "0x4C6530", VA = "0x1804C7F30")]
	public GarlicFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
