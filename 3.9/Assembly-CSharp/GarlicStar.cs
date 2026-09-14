using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000526 RID: 1318
[Token(Token = "0x2000526")]
public class GarlicStar : StarFruit
{
	// Token: 0x0600189C RID: 6300 RVA: 0x000854C0 File Offset: 0x000836C0
	[Token(Token = "0x600189C")]
	[Address(RVA = "0x525340", Offset = "0x523940", VA = "0x180525340", Slot = "72")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x00085508 File Offset: 0x00083708
	[Token(Token = "0x600189D")]
	[Address(RVA = "0x48A3E0", Offset = "0x4889E0", VA = "0x18048A3E0", Slot = "63")]
	public override bool OnEat(Zombie zombie)
	{
		zombie.EatGarlic(this, 1f, true);
		return true;
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x0008552C File Offset: 0x0008372C
	[Token(Token = "0x600189E")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public GarlicStar()
	{
	}
}
