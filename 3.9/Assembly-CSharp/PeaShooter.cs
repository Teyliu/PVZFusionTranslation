using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000572 RID: 1394
[Token(Token = "0x2000572")]
public class PeaShooter : Shooter
{
	// Token: 0x060019E7 RID: 6631 RVA: 0x0008B810 File Offset: 0x00089A10
	[Token(Token = "0x60019E7")]
	[Address(RVA = "0x539020", Offset = "0x537620", VA = "0x180539020", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int bulletType = (int)base.GetBulletType();
		BulletMoveWay bulletMoveWay = base.GetBulletMoveWay();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x0008B868 File Offset: 0x00089A68
	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PeaShooter()
	{
	}
}
