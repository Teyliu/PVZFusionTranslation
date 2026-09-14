using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200056C RID: 1388
[Token(Token = "0x200056C")]
public class StarFruitIron : StarFruit
{
	// Token: 0x060019C2 RID: 6594 RVA: 0x0008AE6C File Offset: 0x0008906C
	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x4E6060", Offset = "0x4E4660", VA = "0x1804E6060", Slot = "73")]
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

	// Token: 0x060019C3 RID: 6595 RVA: 0x0008AEB4 File Offset: 0x000890B4
	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public StarFruitIron()
	{
	}
}
