using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000502 RID: 1282
[Token(Token = "0x2000502")]
public class HelmetFume : FumeShroom
{
	// Token: 0x060017F5 RID: 6133 RVA: 0x00082738 File Offset: 0x00080938
	[Token(Token = "0x60017F5")]
	[Address(RVA = "0x4CABC0", Offset = "0x4C91C0", VA = "0x1804CABC0", Slot = "74")]
	protected override void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)6), thePlantType, num != 0UL);
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x00082768 File Offset: 0x00080968
	[Token(Token = "0x60017F6")]
	[Address(RVA = "0x4CAC20", Offset = "0x4C9220", VA = "0x1804CAC20", Slot = "69")]
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

	// Token: 0x060017F7 RID: 6135 RVA: 0x000827C0 File Offset: 0x000809C0
	[Token(Token = "0x60017F7")]
	[Address(RVA = "0x4C7F30", Offset = "0x4C6530", VA = "0x1804C7F30")]
	public HelmetFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
