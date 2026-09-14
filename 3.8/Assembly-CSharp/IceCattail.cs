using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050F RID: 1295
[Token(Token = "0x200050F")]
public class IceCattail : CattailPlant
{
	// Token: 0x0600182D RID: 6189 RVA: 0x0008358C File Offset: 0x0008178C
	[Token(Token = "0x600182D")]
	[Address(RVA = "0x4CE6D0", Offset = "0x4CCCD0", VA = "0x1804CE6D0", Slot = "69")]
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

	// Token: 0x0600182E RID: 6190 RVA: 0x000835F4 File Offset: 0x000817F4
	[Token(Token = "0x600182E")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public IceCattail()
	{
	}
}
