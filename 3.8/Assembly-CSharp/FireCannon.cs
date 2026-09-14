using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000389 RID: 905
[Token(Token = "0x2000389")]
public class FireCannon : CobCannon
{
	// Token: 0x060010A4 RID: 4260 RVA: 0x0005F47C File Offset: 0x0005D67C
	[Token(Token = "0x60010A4")]
	[Address(RVA = "0x4351E0", Offset = "0x4337E0", VA = "0x1804351E0", Slot = "71")]
	protected override void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Mouse instance2 = Mouse.Instance;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		bullet.cannonPos = 0;
		bullet.cannonPos.y = (float)0;
		Board instance3 = Board.Instance;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x0005F4F4 File Offset: 0x0005D6F4
	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public FireCannon()
	{
	}
}
