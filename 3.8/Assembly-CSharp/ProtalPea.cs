using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054B RID: 1355
[Token(Token = "0x200054B")]
public class ProtalPea : Shooter
{
	// Token: 0x0600192E RID: 6446 RVA: 0x000880B4 File Offset: 0x000862B4
	[Token(Token = "0x600192E")]
	[Address(RVA = "0x4DCAD0", Offset = "0x4DB0D0", VA = "0x1804DCAD0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x0600192F RID: 6447 RVA: 0x000880FC File Offset: 0x000862FC
	[Token(Token = "0x600192F")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ProtalPea()
	{
	}
}
