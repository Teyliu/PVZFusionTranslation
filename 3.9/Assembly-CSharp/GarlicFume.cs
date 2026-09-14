using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000521 RID: 1313
[Token(Token = "0x2000521")]
public class GarlicFume : FumeShroom
{
	// Token: 0x0600188F RID: 6287 RVA: 0x000852EC File Offset: 0x000834EC
	[Token(Token = "0x600188F")]
	[Address(RVA = "0x524F70", Offset = "0x523570", VA = "0x180524F70", Slot = "73")]
	protected override void Attack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)1), thePlantType, num != 0UL);
		throw new NullReferenceException();
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x00085318 File Offset: 0x00083518
	[Token(Token = "0x6001890")]
	[Address(RVA = "0x524FE0", Offset = "0x5235E0", VA = "0x180524FE0", Slot = "68")]
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

	// Token: 0x06001891 RID: 6289 RVA: 0x00085370 File Offset: 0x00083570
	[Token(Token = "0x6001891")]
	[Address(RVA = "0x523270", Offset = "0x521870", VA = "0x180523270")]
	public GarlicFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
