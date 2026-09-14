using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004EC RID: 1260
[Token(Token = "0x20004EC")]
public class FireCattail : CattailPlant
{
	// Token: 0x060017A8 RID: 6056 RVA: 0x00081328 File Offset: 0x0007F528
	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x4C79D0", Offset = "0x4C5FD0", VA = "0x1804C79D0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x00081380 File Offset: 0x0007F580
	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public FireCattail()
	{
	}
}
