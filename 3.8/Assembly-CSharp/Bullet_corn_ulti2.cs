using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000130 RID: 304
[Token(Token = "0x2000130")]
public class Bullet_corn_ulti2 : Bullet_corn_ulti
{
	// Token: 0x060005C0 RID: 1472 RVA: 0x0001EF18 File Offset: 0x0001D118
	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x6BF820", Offset = "0x6BDE20", VA = "0x1806BF820", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		PlantType fromType = this.fromType;
		int num3 = 0;
		uint num4;
		zombie.AddfreezeLevel((int)num4, num3);
		zombie.AddPoisonLevel();
		base.Die();
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0001EF64 File Offset: 0x0001D164
	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_corn_ulti2()
	{
	}
}
