using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000560 RID: 1376
[Token(Token = "0x2000560")]
public class MagnetCactus : Cactus
{
	// Token: 0x06001999 RID: 6553 RVA: 0x0008A820 File Offset: 0x00088A20
	[Token(Token = "0x6001999")]
	[Address(RVA = "0x535F40", Offset = "0x534540", VA = "0x180535F40", Slot = "68")]
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

	// Token: 0x0600199A RID: 6554 RVA: 0x0008A878 File Offset: 0x00088A78
	[Token(Token = "0x600199A")]
	[Address(RVA = "0x5360B0", Offset = "0x5346B0", VA = "0x1805360B0", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform transform = base.transform.Find("Shoot2").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x0008A8D0 File Offset: 0x00088AD0
	[Token(Token = "0x600199B")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public MagnetCactus()
	{
	}
}
