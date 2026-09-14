using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200039C RID: 924
[Token(Token = "0x200039C")]
public class FireCannon : CobCannon
{
	// Token: 0x060010FE RID: 4350 RVA: 0x000609C8 File Offset: 0x0005EBC8
	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x488A80", Offset = "0x487080", VA = "0x180488A80", Slot = "70")]
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

	// Token: 0x060010FF RID: 4351 RVA: 0x00060A40 File Offset: 0x0005EC40
	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public FireCannon()
	{
	}
}
