using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004FE RID: 1278
[Token(Token = "0x20004FE")]
public class GatlingPea : Shooter
{
	// Token: 0x060017DA RID: 6106 RVA: 0x00081E40 File Offset: 0x00080040
	[Token(Token = "0x60017DA")]
	[Address(RVA = "0x4C9410", Offset = "0x4C7A10", VA = "0x1804C9410", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("GatlingPea_head");
		int num = 0;
		Transform child = transform.GetChild(num);
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x00081EA0 File Offset: 0x000800A0
	[Token(Token = "0x60017DB")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public GatlingPea()
	{
	}
}
