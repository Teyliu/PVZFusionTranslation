using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003AD RID: 941
[Token(Token = "0x20003AD")]
public class IceCannon : CobCannon
{
	// Token: 0x0600113F RID: 4415 RVA: 0x000622AC File Offset: 0x000604AC
	[Token(Token = "0x600113F")]
	[Address(RVA = "0x43E750", Offset = "0x43CD50", VA = "0x18043E750", Slot = "71")]
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

	// Token: 0x06001140 RID: 4416 RVA: 0x00062324 File Offset: 0x00060524
	[Token(Token = "0x6001140")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public IceCannon()
	{
	}
}
