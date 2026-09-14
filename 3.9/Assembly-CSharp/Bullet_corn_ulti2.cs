using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000135 RID: 309
[Token(Token = "0x2000135")]
public class Bullet_corn_ulti2 : Bullet_corn_ulti
{
	// Token: 0x060005C7 RID: 1479 RVA: 0x0001E6E8 File Offset: 0x0001C8E8
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x6EA5E0", Offset = "0x6E8BE0", VA = "0x1806EA5E0", Slot = "22")]
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

	// Token: 0x060005C8 RID: 1480 RVA: 0x0001E734 File Offset: 0x0001C934
	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_corn_ulti2()
	{
	}
}
