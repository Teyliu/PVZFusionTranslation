using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000577 RID: 1399
[Token(Token = "0x2000577")]
public class SunGatlingPuff : Shooter
{
	// Token: 0x060019DE RID: 6622 RVA: 0x0008B510 File Offset: 0x00089710
	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x4E8250", Offset = "0x4E6850", VA = "0x1804E8250", Slot = "69")]
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

	// Token: 0x060019DF RID: 6623 RVA: 0x0008B56C File Offset: 0x0008976C
	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SunGatlingPuff()
	{
	}
}
