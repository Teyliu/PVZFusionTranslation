using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200059E RID: 1438
[Token(Token = "0x200059E")]
public class StarfruitMagnet : StarFruit
{
	// Token: 0x06001AA6 RID: 6822 RVA: 0x0008EFD8 File Offset: 0x0008D1D8
	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0x545A70", Offset = "0x544070", VA = "0x180545A70", Slot = "72")]
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

	// Token: 0x06001AA7 RID: 6823 RVA: 0x0008F020 File Offset: 0x0008D220
	[Token(Token = "0x6001AA7")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public StarfruitMagnet()
	{
	}
}
