using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000544 RID: 1348
[Token(Token = "0x2000544")]
public class PeaShooter : Shooter
{
	// Token: 0x06001912 RID: 6418 RVA: 0x00087A68 File Offset: 0x00085C68
	[Token(Token = "0x6001912")]
	[Address(RVA = "0x4DB8A0", Offset = "0x4D9EA0", VA = "0x1804DB8A0", Slot = "69")]
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

	// Token: 0x06001913 RID: 6419 RVA: 0x00087AC0 File Offset: 0x00085CC0
	[Token(Token = "0x6001913")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PeaShooter()
	{
	}
}
