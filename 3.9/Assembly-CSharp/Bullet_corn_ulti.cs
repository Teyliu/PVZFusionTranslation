using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000134 RID: 308
[Token(Token = "0x2000134")]
public class Bullet_corn_ulti : Bullet_garlicKernal
{
	// Token: 0x060005C5 RID: 1477 RVA: 0x0001E694 File Offset: 0x0001C894
	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x6EA6F0", Offset = "0x6E8CF0", VA = "0x1806EA6F0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		PlantType fromType = this.fromType;
		zombie.AddPoisonLevel();
		base.Die();
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x0001E6D4 File Offset: 0x0001C8D4
	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_corn_ulti()
	{
	}
}
