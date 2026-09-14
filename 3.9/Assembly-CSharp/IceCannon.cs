using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C1 RID: 961
[Token(Token = "0x20003C1")]
public class IceCannon : CobCannon
{
	// Token: 0x0600119B RID: 4507 RVA: 0x000638B8 File Offset: 0x00061AB8
	[Token(Token = "0x600119B")]
	[Address(RVA = "0x4925E0", Offset = "0x490BE0", VA = "0x1804925E0", Slot = "70")]
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

	// Token: 0x0600119C RID: 4508 RVA: 0x00063930 File Offset: 0x00061B30
	[Token(Token = "0x600119C")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public IceCannon()
	{
	}
}
