using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000545 RID: 1349
[Token(Token = "0x2000545")]
public class PeaSmallPuff : Shooter
{
	// Token: 0x06001914 RID: 6420 RVA: 0x00087AD4 File Offset: 0x00085CD4
	[Token(Token = "0x6001914")]
	[Address(RVA = "0x4DBA10", Offset = "0x4DA010", VA = "0x1804DBA10", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00087B2C File Offset: 0x00085D2C
	[Token(Token = "0x6001915")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PeaSmallPuff()
	{
	}
}
