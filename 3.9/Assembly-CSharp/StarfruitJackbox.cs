using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200059D RID: 1437
[Token(Token = "0x200059D")]
public class StarfruitJackbox : StarFruit
{
	// Token: 0x06001AA4 RID: 6820 RVA: 0x0008EF7C File Offset: 0x0008D17C
	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x545940", Offset = "0x543F40", VA = "0x180545940", Slot = "72")]
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

	// Token: 0x06001AA5 RID: 6821 RVA: 0x0008EFC4 File Offset: 0x0008D1C4
	[Token(Token = "0x6001AA5")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public StarfruitJackbox()
	{
	}
}
