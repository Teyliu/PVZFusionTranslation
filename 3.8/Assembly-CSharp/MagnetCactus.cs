using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000533 RID: 1331
[Token(Token = "0x2000533")]
public class MagnetCactus : Cactus
{
	// Token: 0x060018C9 RID: 6345 RVA: 0x00086B5C File Offset: 0x00084D5C
	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x4D5630", Offset = "0x4D3C30", VA = "0x1804D5630", Slot = "69")]
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

	// Token: 0x060018CA RID: 6346 RVA: 0x00086BB4 File Offset: 0x00084DB4
	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x4D57A0", Offset = "0x4D3DA0", VA = "0x1804D57A0", Slot = "70")]
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

	// Token: 0x060018CB RID: 6347 RVA: 0x00086C0C File Offset: 0x00084E0C
	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public MagnetCactus()
	{
	}
}
