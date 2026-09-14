using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200052D RID: 1325
[Token(Token = "0x200052D")]
public class HelmetFume : FumeShroom
{
	// Token: 0x060018BE RID: 6334 RVA: 0x00085F78 File Offset: 0x00084178
	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x526EE0", Offset = "0x5254E0", VA = "0x180526EE0", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)6), thePlantType, num != 0UL);
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x00085FA8 File Offset: 0x000841A8
	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x526F40", Offset = "0x525540", VA = "0x180526F40", Slot = "68")]
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

	// Token: 0x060018C0 RID: 6336 RVA: 0x00086000 File Offset: 0x00084200
	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x523270", Offset = "0x521870", VA = "0x180523270")]
	public HelmetFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
