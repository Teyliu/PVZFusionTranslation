using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200059C RID: 1436
[Token(Token = "0x200059C")]
public class StarFruitIron : StarFruit
{
	// Token: 0x06001AA2 RID: 6818 RVA: 0x0008EF20 File Offset: 0x0008D120
	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x5444D0", Offset = "0x542AD0", VA = "0x1805444D0", Slot = "72")]
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

	// Token: 0x06001AA3 RID: 6819 RVA: 0x0008EF68 File Offset: 0x0008D168
	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public StarFruitIron()
	{
	}
}
