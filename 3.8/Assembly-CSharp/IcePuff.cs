using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000515 RID: 1301
[Token(Token = "0x2000515")]
public class IcePuff : PeaSmallPuff
{
	// Token: 0x0600183E RID: 6206 RVA: 0x000839C0 File Offset: 0x00081BC0
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x4CF460", Offset = "0x4CDA60", VA = "0x1804CF460", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(68, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x0600183F RID: 6207 RVA: 0x00083A28 File Offset: 0x00081C28
	[Token(Token = "0x600183F")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public IcePuff()
	{
	}
}
