using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A7 RID: 1447
[Token(Token = "0x20005A7")]
public class SunGatlingPuff : Shooter
{
	// Token: 0x06001ABE RID: 6846 RVA: 0x0008F5D8 File Offset: 0x0008D7D8
	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x547680", Offset = "0x545C80", VA = "0x180547680", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(68, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x0008F634 File Offset: 0x0008D834
	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SunGatlingPuff()
	{
	}
}
