using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200053A RID: 1338
[Token(Token = "0x200053A")]
public class IceCattail : CattailPlant
{
	// Token: 0x060018F6 RID: 6390 RVA: 0x00086DDC File Offset: 0x00084FDC
	[Token(Token = "0x60018F6")]
	[Address(RVA = "0x52AA90", Offset = "0x529090", VA = "0x18052AA90", Slot = "68")]
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

	// Token: 0x060018F7 RID: 6391 RVA: 0x00086E44 File Offset: 0x00085044
	[Token(Token = "0x60018F7")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public IceCattail()
	{
	}
}
