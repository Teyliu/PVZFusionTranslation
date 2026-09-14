using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000128 RID: 296
[Token(Token = "0x2000128")]
public class Bullet_cactus : Bullet
{
	// Token: 0x060005A1 RID: 1441 RVA: 0x0001DBBC File Offset: 0x0001BDBC
	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x6E7170", Offset = "0x6E5770", VA = "0x1806E7170", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x6E70F0", Offset = "0x6E56F0", VA = "0x1806E70F0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0001DC20 File Offset: 0x0001BE20
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cactus()
	{
	}
}
