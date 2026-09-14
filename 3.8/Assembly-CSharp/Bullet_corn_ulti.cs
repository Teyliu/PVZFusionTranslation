using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012F RID: 303
[Token(Token = "0x200012F")]
public class Bullet_corn_ulti : Bullet_garlicKernal
{
	// Token: 0x060005BE RID: 1470 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x6BF930", Offset = "0x6BDF30", VA = "0x1806BF930", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		PlantType fromType = this.fromType;
		zombie.AddPoisonLevel();
		base.Die();
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x0001EF04 File Offset: 0x0001D104
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_corn_ulti()
	{
	}
}
