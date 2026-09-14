using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000529 RID: 1321
[Token(Token = "0x2000529")]
public class GatlingPea : Shooter
{
	// Token: 0x060018A3 RID: 6307 RVA: 0x00085680 File Offset: 0x00083880
	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x525730", Offset = "0x523D30", VA = "0x180525730", Slot = "68")]
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

	// Token: 0x060018A4 RID: 6308 RVA: 0x000856E0 File Offset: 0x000838E0
	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public GatlingPea()
	{
	}
}
