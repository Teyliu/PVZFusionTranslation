using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200053D RID: 1341
[Token(Token = "0x200053D")]
public class MoneyMelon : Melonpult
{
	// Token: 0x060018F2 RID: 6386 RVA: 0x000871D8 File Offset: 0x000853D8
	[Token(Token = "0x60018F2")]
	[Address(RVA = "0x4D6BB0", Offset = "0x4D51B0", VA = "0x1804D6BB0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060018F3 RID: 6387 RVA: 0x000871F0 File Offset: 0x000853F0
	[Token(Token = "0x60018F3")]
	[Address(RVA = "0x4D69C0", Offset = "0x4D4FC0", VA = "0x1804D69C0", Slot = "42")]
	protected override void AnimSuperShoot()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 1f, 1f);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Transform axis = this.axis;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		bullet.cannonPos = 0;
		bullet.cannonPos.y = (float)0;
		Board instance2 = Board.Instance;
		bullet.theStatus = (BulletStatus)((ulong)2L);
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x00087288 File Offset: 0x00085488
	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public MoneyMelon()
	{
	}
}
