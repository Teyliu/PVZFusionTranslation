using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000514 RID: 1300
[Token(Token = "0x2000514")]
public class FireCattail : CattailPlant
{
	// Token: 0x0600185F RID: 6239 RVA: 0x00084570 File Offset: 0x00082770
	[Token(Token = "0x600185F")]
	[Address(RVA = "0x522D10", Offset = "0x521310", VA = "0x180522D10", Slot = "68")]
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

	// Token: 0x06001860 RID: 6240 RVA: 0x000845C8 File Offset: 0x000827C8
	[Token(Token = "0x6001860")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public FireCattail()
	{
	}
}
